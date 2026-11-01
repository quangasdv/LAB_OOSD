using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HeThongeShopping.Data;

namespace HeThongeShopping.Services
{
    public class DonHangService
    {
        public KetQuaXuLy XuLyDatHang(DonHang dh, List<ChiTietDonHang> dsChiTiet, ThanhToan tt)
        {
            if (dsChiTiet == null || dsChiTiet.Count == 0)
                return KetQuaXuLy.Loi("Giỏ hàng trống, không thể đặt hàng.");

            decimal tongTriGia = 0;
            foreach (var ct in dsChiTiet)
            {
                tongTriGia += (ct.DonGia * ct.SoLuong);
            }
            dh.TongTriGia = tongTriGia;
            
            // Áp dụng biểu phí linh hoạt từ cấu hình
            dh.PhiGiaoHang = CauHinhService.TinhPhiGiaoHang(dh.LoaiPhieuDatHang, dh.TongTriGia);
            dh.TongTienThanhToan = dh.TongTriGia + dh.PhiGiaoHang;

            // Tính lệ phí thẻ tín dụng
            tt.LePhiGiaoDich = CauHinhService.TinhLePhiThe(tt.LoaiThe, dh.TongTienThanhToan);

            // Thanh toán giả lập qua Adapter
            bool thanhCong = ThanhToanAdapter(tt.SoTheMasked, dh.TongTienThanhToan);
            if (!thanhCong)
                return KetQuaXuLy.Loi("Thanh toán thẻ thất bại, vui lòng kiểm tra lại thông tin thẻ.");
            
            tt.KetQuaThanhToan = "Thành công";

            // Lưu đơn hàng dùng Transaction
            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    dh.MaDonHang = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    string sqlDH = @"INSERT INTO DonHang (MaDonHang, MaKhachHang, LoaiPhieuDatHang, HoTenNguoiNhan, DiaChiNhan, DienThoaiNhan, TongTriGia, PhiGiaoHang, TongTienThanhToan, TrangThai, ThoiDiemDatHang)
                                     VALUES (@Ma, @MaKH, @LoaiPhieu, @Ten, @DiaChi, @SDT, @TriGia, @Phi, @Tong, N'Đã xác nhận', GETDATE())";
                    using (SqlCommand cmdDH = new SqlCommand(sqlDH, cn, tx))
                    {
                        cmdDH.Parameters.AddWithValue("@Ma", dh.MaDonHang);
                        cmdDH.Parameters.AddWithValue("@MaKH", dh.MaKhachHang);
                        cmdDH.Parameters.AddWithValue("@LoaiPhieu", dh.LoaiPhieuDatHang);
                        cmdDH.Parameters.AddWithValue("@Ten", dh.HoTenNguoiNhan);
                        cmdDH.Parameters.AddWithValue("@DiaChi", dh.DiaChiNhan);
                        cmdDH.Parameters.AddWithValue("@SDT", dh.DienThoaiNhan);
                        cmdDH.Parameters.AddWithValue("@TriGia", dh.TongTriGia);
                        cmdDH.Parameters.AddWithValue("@Phi", dh.PhiGiaoHang);
                        cmdDH.Parameters.AddWithValue("@Tong", dh.TongTienThanhToan);
                        cmdDH.ExecuteNonQuery();
                    }

                    string sqlCT = @"INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, TenSanPham, DonGia, SoLuong, ThanhTien)
                                     VALUES (@MaDH, @MaSP, @TenSP, @DonGia, @SoLuong, @ThanhTien)";
                    foreach (var ct in dsChiTiet)
                    {
                        using (SqlCommand cmdCT = new SqlCommand(sqlCT, cn, tx))
                        {
                            cmdCT.Parameters.AddWithValue("@MaDH", dh.MaDonHang);
                            cmdCT.Parameters.AddWithValue("@MaSP", ct.MaSanPham);
                            cmdCT.Parameters.AddWithValue("@TenSP", ct.TenSanPham);
                            cmdCT.Parameters.AddWithValue("@DonGia", ct.DonGia);
                            cmdCT.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdCT.Parameters.AddWithValue("@ThanhTien", ct.DonGia * ct.SoLuong);
                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    string sqlTT = @"INSERT INTO ThanhToan (MaDonHang, LoaiThe, SoTheMasked, TenChuThe, LePhiGiaoDich, KetQuaThanhToan, NgayThanhToan)
                                     VALUES (@MaDH, @LoaiThe, @SoThe, @TenChuThe, @LePhi, @KQ, GETDATE())";
                    using (SqlCommand cmdTT = new SqlCommand(sqlTT, cn, tx))
                    {
                        cmdTT.Parameters.AddWithValue("@MaDH", dh.MaDonHang);
                        cmdTT.Parameters.AddWithValue("@LoaiThe", tt.LoaiThe);
                        cmdTT.Parameters.AddWithValue("@SoThe", tt.SoTheMasked);
                        cmdTT.Parameters.AddWithValue("@TenChuThe", tt.TenChuThe);
                        cmdTT.Parameters.AddWithValue("@LePhi", tt.LePhiGiaoDich);
                        cmdTT.Parameters.AddWithValue("@KQ", tt.KetQuaThanhToan);
                        cmdTT.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Loi("Lỗi lưu cơ sở dữ liệu: " + ex.Message);
                }
            }

            EmailAdapter_GuiEmailXacNhan(dh.MaDonHang);
            return KetQuaXuLy.Ok(dh.MaDonHang);
        }

        public DataTable LayDanhSachDonHang(string tuKhoa = "", string trangThai = "Tất cả")
        {
            string sql = @"SELECT d.MaDonHang, d.ThoiDiemDatHang, d.HoTenNguoiNhan, d.DienThoaiNhan, 
                                  d.DiaChiNhan, d.LoaiPhieuDatHang, d.TongTriGia, d.PhiGiaoHang, 
                                  d.TongTienThanhToan, d.TrangThai, k.TenDangNhap
                           FROM DonHang d
                           LEFT JOIN KhachHang k ON d.MaKhachHang = k.MaKhachHang
                           WHERE 1=1 ";
            List<SqlParameter> ps = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
            {
                sql += " AND d.TrangThai = @tt ";
                ps.Add(new SqlParameter("@tt", trangThai));
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                sql += " AND (d.MaDonHang LIKE @k OR d.HoTenNguoiNhan LIKE @k OR d.DienThoaiNhan LIKE @k) ";
                ps.Add(new SqlParameter("@k", "%" + tuKhoa.Trim() + "%"));
            }

            sql += " ORDER BY d.ThoiDiemDatHang DESC";
            return Db.Query(sql, ps.ToArray());
        }

        public DataTable LayChiTietDonHang(string maDonHang)
        {
            string sql = "SELECT MaSanPham, TenSanPham, DonGia, SoLuong, ThanhTien FROM ChiTietDonHang WHERE MaDonHang = @id";
            return Db.Query(sql, new SqlParameter("@id", maDonHang));
        }

        public DataTable LayThanhToanTheoDon(string maDonHang)
        {
            string sql = "SELECT LoaiThe, SoTheMasked, TenChuThe, LePhiGiaoDich, NgayThanhToan, KetQuaThanhToan FROM ThanhToan WHERE MaDonHang = @id";
            return Db.Query(sql, new SqlParameter("@id", maDonHang));
        }

        public KetQuaXuLy CapNhatTrangThai(string maDonHang, string trangThaiMoi)
        {
            try
            {
                string sql = "UPDATE DonHang SET TrangThai = @tt WHERE MaDonHang = @id";
                Db.Execute(sql, new SqlParameter("@tt", trangThaiMoi), new SqlParameter("@id", maDonHang));
                return KetQuaXuLy.Ok("Cập nhật trạng thái đơn hàng thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi("Lỗi cập nhật: " + ex.Message);
            }
        }

        public DataTable ThongKeTongHop(DateTime tu, DateTime den)
        {
            string sql = @"SELECT 
                (SELECT COUNT(*) FROM DonHang WHERE CAST(ThoiDiemDatHang AS date) BETWEEN @tu AND @den) AS TongDonHang,
                (SELECT ISNULL(SUM(TongTienThanhToan), 0) FROM DonHang WHERE CAST(ThoiDiemDatHang AS date) BETWEEN @tu AND @den AND TrangThai <> N'Đã hủy') AS TongDoanhThu,
                (SELECT COUNT(*) FROM DonHang WHERE CAST(ThoiDiemDatHang AS date) BETWEEN @tu AND @den AND (TrangThai = N'Đã giao hàng' OR TrangThai = N'Hoàn tất' OR TrangThai = N'Đã thanh toán' OR TrangThai = N'Đã xác nhận')) AS DonThanhCong,
                (SELECT COUNT(*) FROM DonHang WHERE CAST(ThoiDiemDatHang AS date) BETWEEN @tu AND @den AND TrangThai = N'Chờ xử lý') AS DonChoXuLy,
                (SELECT COUNT(*) FROM DonHang WHERE CAST(ThoiDiemDatHang AS date) BETWEEN @tu AND @den AND TrangThai = N'Đã hủy') AS DonHuy";
            return Db.Query(sql, new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }

        public DataTable ThongKeSanPhamBanChay(DateTime tu, DateTime den)
        {
            string sql = @"SELECT c.MaSanPham, c.TenSanPham, 
                                  SUM(c.SoLuong) AS TongSoLuong, 
                                  SUM(c.ThanhTien) AS TongDoanhThu
                           FROM ChiTietDonHang c
                           JOIN DonHang d ON c.MaDonHang = d.MaDonHang
                           WHERE CAST(d.ThoiDiemDatHang AS date) BETWEEN @tu AND @den AND d.TrangThai <> N'Đã hủy'
                           GROUP BY c.MaSanPham, c.TenSanPham
                           ORDER BY TongDoanhThu DESC";
            return Db.Query(sql, new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }

        public DataTable ThongKeLoaiThe(DateTime tu, DateTime den)
        {
            string sql = @"SELECT t.LoaiThe, 
                                  COUNT(*) AS SoGiaoDich, 
                                  SUM(d.TongTienThanhToan) AS TongGiaTri, 
                                  SUM(t.LePhiGiaoDich) AS TongLePhi
                           FROM ThanhToan t
                           JOIN DonHang d ON t.MaDonHang = d.MaDonHang
                           WHERE CAST(t.NgayThanhToan AS date) BETWEEN @tu AND @den
                           GROUP BY t.LoaiThe
                           ORDER BY SoGiaoDich DESC";
            return Db.Query(sql, new SqlParameter("@tu", tu.Date), new SqlParameter("@den", den.Date));
        }

        private bool ThanhToanAdapter(string soThe, decimal tongTien)
        {
            return true;
        }

        private void EmailAdapter_GuiEmailXacNhan(string maDonHang)
        {
            Console.WriteLine("Đã gửi email xác nhận cho đơn hàng: " + maDonHang);
        }
    }
}
