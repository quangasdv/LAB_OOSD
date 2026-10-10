using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class DangKyTourService
    {
        public DataTable LayDanhSachTour()
        {
            return Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia, DiemXuatPhat FROM Tour ORDER BY MaTour");
        }

        public DataTable LayDanhSachDoan()
        {
            return Db.Query("SELECT MaDoan, TenCoQuan, DiaChiCoQuan, DienThoaiCoQuan, NguoiDaiDien, Email FROM KhachDoan ORDER BY TenCoQuan");
        }

        public DataTable LayLichSuDangKyDoan()
        {
            string sql = @"SELECT p.SoPhieuDK, t.TenTour, d.TenCoQuan, d.NguoiDaiDien, d.DienThoaiCoQuan,
                                  p.NgayDi, p.DiemDon, p.SoNguoi, p.TongKinhPhi, p.TienCoc, 
                                  p.CoMuaBaoHiem, p.TrangThai, p.NgayLap
                           FROM PhieuDangKyTourDoan p
                           JOIN Tour t ON p.MaTour = t.MaTour
                           JOIN KhachDoan d ON p.MaDoan = d.MaDoan
                           ORDER BY p.NgayLap DESC";
            return Db.Query(sql);
        }

        public DataTable LayThanhVienBaoHiem(string soPhieuDK)
        {
            return Db.Query("SELECT MaThanhVien, SoPhieuDK, HoTen, NgaySinh, CCCD FROM ThanhVienBaoHiem WHERE SoPhieuDK = @s",
                new SqlParameter("@s", soPhieuDK));
        }

        public KetQuaXuLy ThemKhachDoan(string maDoan, string tenCoQuan, string diaChi, string sdt, string nguoiDD, string email)
        {
            if (string.IsNullOrWhiteSpace(maDoan) || string.IsNullOrWhiteSpace(tenCoQuan) || 
                string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(nguoiDD))
            {
                return KetQuaXuLy.Fail("Thông tin đoàn chưa đầy đủ (Mã đoàn, Tên cơ quan, Địa chỉ, SĐT, Người đại diện là bắt buộc).");
            }

            try
            {
                string sql = "INSERT INTO KhachDoan (MaDoan, TenCoQuan, DiaChiCoQuan, DienThoaiCoQuan, NguoiDaiDien, Email) VALUES (@m, @t, @d, @s, @n, @e)";
                Db.Execute(sql,
                    new SqlParameter("@m", maDoan),
                    new SqlParameter("@t", tenCoQuan),
                    new SqlParameter("@d", diaChi),
                    new SqlParameter("@s", sdt),
                    new SqlParameter("@n", nguoiDD),
                    new SqlParameter("@e", (object)email ?? DBNull.Value));

                return KetQuaXuLy.Ok("Đã lưu thông tin đoàn khách mới thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi thêm đoàn: " + ex.Message);
            }
        }

        public KetQuaXuLy DangKyTourDoan(string soPhieu, string maTour, string maDoan, 
                                         DateTime ngayDi, string diemDon, int soNguoi, 
                                         bool coBaoHiem, List<ThanhVienBaoHiemItem> dsThanhVien, 
                                         string hinhThucThanhToan)
        {
            // 1. Kiểm tra đầu vào cơ bản
            if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(maTour) || 
                string.IsNullOrWhiteSpace(maDoan) || string.IsNullOrWhiteSpace(diemDon))
            {
                return KetQuaXuLy.Fail("Vui lòng điền đầy đủ thông tin phiếu đăng ký (Số phiếu, Tour, Cơ quan đoàn, Điểm đón riêng).");
            }

            // 2. Quy tắc nghiệp vụ: Đoàn phải từ 12 người trở lên
            if (soNguoi < 12)
            {
                return KetQuaXuLy.Fail(string.Format("Số lượng người ({0} người) không đủ điều kiện lập đoàn. Theo quy định công ty, khách đăng ký dưới 12 người phải đăng ký mua vé theo chuyến lẻ.", soNguoi));
            }

            if (ngayDi.Date < DateTime.Today)
            {
                return KetQuaXuLy.Fail("Ngày khởi hành không được ở trong quá khứ.");
            }

            // 3. Nếu mua bảo hiểm thì bắt buộc phải kèm danh sách thành viên
            if (coBaoHiem && (dsThanhVien == null || dsThanhVien.Count == 0))
            {
                return KetQuaXuLy.Fail("Đoàn có đăng ký bảo hiểm du lịch thì phải cung cấp danh sách thành viên cùng đi (Họ tên, Ngày sinh, CCCD).");
            }

            // 4. Lấy đơn giá tour và tính toán kinh phí & tiền cọc 30%
            decimal donGia = 0;
            object objGia = Db.Scalar("SELECT DonGia FROM Tour WHERE MaTour = @t", new SqlParameter("@t", maTour));
            if (objGia == null)
            {
                return KetQuaXuLy.Fail("Không tìm thấy thông tin tour được chọn.");
            }
            donGia = Convert.ToDecimal(objGia);
            decimal tongKinhPhi = soNguoi * donGia;
            decimal tienCoc = tongKinhPhi * 0.30m; // Bắt buộc đặt cọc 30%

            // 5. Thực hiện Transaction lưu dữ liệu
            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    // Insert PhieuDangKyTourDoan
                    string sqlPhieu = @"INSERT INTO PhieuDangKyTourDoan 
                                        (SoPhieuDK, MaTour, MaDoan, NgayLap, NgayDi, DiemDon, SoNguoi, TongKinhPhi, TienCoc, CoMuaBaoHiem, TrangThai)
                                        VALUES (@s, @t, @d, GETDATE(), @ngay, @don, @sl, @tong, @coc, @bh, N'Đã đặt cọc')";
                    using (SqlCommand cmdP = new SqlCommand(sqlPhieu, cn, tx))
                    {
                        cmdP.Parameters.AddWithValue("@s", soPhieu);
                        cmdP.Parameters.AddWithValue("@t", maTour);
                        cmdP.Parameters.AddWithValue("@d", maDoan);
                        cmdP.Parameters.AddWithValue("@ngay", ngayDi.Date);
                        cmdP.Parameters.AddWithValue("@don", diemDon);
                        cmdP.Parameters.AddWithValue("@sl", soNguoi);
                        cmdP.Parameters.AddWithValue("@tong", tongKinhPhi);
                        cmdP.Parameters.AddWithValue("@coc", tienCoc);
                        cmdP.Parameters.AddWithValue("@bh", coBaoHiem);
                        cmdP.ExecuteNonQuery();
                    }

                    // Insert danh sách thành viên bảo hiểm (nếu có)
                    if (coBaoHiem && dsThanhVien != null)
                    {
                        string sqlTV = "INSERT INTO ThanhVienBaoHiem (SoPhieuDK, HoTen, NgaySinh, CCCD) VALUES (@s, @ten, @ns, @c)";
                        foreach (var tv in dsThanhVien)
                        {
                            using (SqlCommand cmdTV = new SqlCommand(sqlTV, cn, tx))
                            {
                                cmdTV.Parameters.AddWithValue("@s", soPhieu);
                                cmdTV.Parameters.AddWithValue("@ten", tv.HoTen);
                                cmdTV.Parameters.AddWithValue("@ns", tv.NgaySinh.Date);
                                cmdTV.Parameters.AddWithValue("@c", tv.CCCD);
                                cmdTV.ExecuteNonQuery();
                            }
                        }
                    }

                    // Insert Biên nhận thu tiền cọc (Cam kết mất cọc nếu hủy)
                    string maBienNhan = "BN" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string sqlBienNhan = @"INSERT INTO BienNhanThuCoc (MaBienNhan, SoPhieuDK, NgayThu, SoTienCoc, HinhThuc, CamKetMatCoc)
                                          VALUES (@bn, @s, GETDATE(), @coc, @ht, 1)";
                    using (SqlCommand cmdBN = new SqlCommand(sqlBienNhan, cn, tx))
                    {
                        cmdBN.Parameters.AddWithValue("@bn", maBienNhan);
                        cmdBN.Parameters.AddWithValue("@s", soPhieu);
                        cmdBN.Parameters.AddWithValue("@coc", tienCoc);
                        cmdBN.Parameters.AddWithValue("@ht", string.IsNullOrWhiteSpace(hinhThucThanhToan) ? "Chuyển khoản" : hinhThucThanhToan);
                        cmdBN.ExecuteNonQuery();
                    }

                    tx.Commit();
                    string thongBao = string.Format("Đăng ký tour theo đoàn thành công!\n- Số phiếu: {0}\n- Tổng kinh phí dự kiến: {1:N0} đ\n- Tiền cọc đã thu (30%): {2:N0} đ (Cam kết mất cọc nếu hủy)\n- Mã biên nhận cọc: {3}", 
                        soPhieu, tongKinhPhi, tienCoc, maBienNhan);
                    return KetQuaXuLy.Ok(thongBao);
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi hệ thống khi lưu phiếu đăng ký đoàn: " + ex.Message);
                }
            }
        }
    }
}
