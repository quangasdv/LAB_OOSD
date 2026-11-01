using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class ChuyenService
    {
        public DataTable LayDanhSachTour()
        {
            return Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia, DiemXuatPhat FROM Tour ORDER BY TenTour");
        }

        public DataTable LayDanhSachChuyen(string timKiem = "", bool chiChuyenConVe = false)
        {
            string sql = @"SELECT c.MaChuyen, c.MaTour, t.TenTour, c.NgayDi, c.NgayVe, 
                                  t.DonGia, c.SoVeToiDa, c.SoVeDaBan, 
                                  (c.SoVeToiDa - c.SoVeDaBan) AS SoVeConLai, 
                                  c.TrangThai
                           FROM ChuyenDuLich c
                           JOIN Tour t ON c.MaTour = t.MaTour
                           WHERE 1=1 ";

            if (chiChuyenConVe)
            {
                sql += " AND (c.SoVeToiDa - c.SoVeDaBan) > 0 AND c.TrangThai = N'Đang mở bán' ";
            }

            if (!string.IsNullOrWhiteSpace(timKiem))
            {
                sql += " AND (c.MaChuyen LIKE @k OR t.TenTour LIKE @k) ";
                sql += " ORDER BY c.NgayDi ASC";
                return Db.Query(sql, new SqlParameter("@k", "%" + timKiem + "%"));
            }

            sql += " ORDER BY c.NgayDi ASC";
            return Db.Query(sql);
        }

        public DataTable LayLichSuDangKyChuyen(string timKiem = "")
        {
            string sql = @"SELECT p.SoPhieuChuyen, p.MaChuyen, t.TenTour, c.NgayDi, c.NgayVe,
                                  k.HoTen AS HoTenKhach, k.SoCMND, k.DienThoai, k.DiaChi,
                                  p.SoLuongVe, p.DiemDonQuyDinh, p.TongTien, p.TrangThai, p.NgayDangKy
                           FROM PhieuDangKyChuyen p
                           JOIN ChuyenDuLich c ON p.MaChuyen = c.MaChuyen
                           JOIN Tour t ON c.MaTour = t.MaTour
                           JOIN KhachLe k ON p.MaKhachLe = k.MaKhachLe ";

            if (!string.IsNullOrWhiteSpace(timKiem))
            {
                sql += " WHERE p.SoPhieuChuyen LIKE @k OR k.HoTen LIKE @k OR k.SoCMND LIKE @k OR t.TenTour LIKE @k ";
                sql += " ORDER BY p.NgayDangKy DESC";
                return Db.Query(sql, new SqlParameter("@k", "%" + timKiem + "%"));
            }

            sql += " ORDER BY p.NgayDangKy DESC";
            return Db.Query(sql);
        }

        public KetQuaXuLy TaoChuyenMoi(string maChuyen, string maTour, DateTime ngayDi, DateTime ngayVe, int soVeToiDa)
        {
            if (string.IsNullOrWhiteSpace(maChuyen) || string.IsNullOrWhiteSpace(maTour))
                return KetQuaXuLy.Fail("Mã chuyến và Mã tour không được để trống.");

            if (soVeToiDa <= 0)
                return KetQuaXuLy.Fail("Số vé tối đa của chuyến phải lớn hơn 0.");

            if (ngayVe.Date < ngayDi.Date)
                return KetQuaXuLy.Fail("Ngày về không được trước ngày khởi hành.");

            try
            {
                object check = Db.Scalar("SELECT COUNT(*) FROM ChuyenDuLich WHERE MaChuyen = @mc", new SqlParameter("@mc", maChuyen));
                if (Convert.ToInt32(check) > 0)
                    return KetQuaXuLy.Fail("Mã chuyến này đã tồn tại trong hệ thống.");

                string sql = @"INSERT INTO ChuyenDuLich (MaChuyen, MaTour, NgayDi, NgayVe, SoVeToiDa, SoVeDaBan, TrangThai)
                               VALUES (@mc, @mt, @ndi, @nve, @sove, 0, N'Đang mở bán')";
                Db.Execute(sql,
                    new SqlParameter("@mc", maChuyen),
                    new SqlParameter("@mt", maTour),
                    new SqlParameter("@ndi", ngayDi.Date),
                    new SqlParameter("@nve", ngayVe.Date),
                    new SqlParameter("@sove", soVeToiDa));

                return KetQuaXuLy.Ok("Tạo chuyến du lịch mới thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi tạo chuyến du lịch: " + ex.Message);
            }
        }

        public KetQuaXuLy DangKyChuyen(string soPhieu, string maChuyen, string hoTen, string cmnd, string sdt, string diaChi, 
                                       int soLuongVe, string diemDon, string hinhThucTT)
        {
            // 1. Kiểm tra ràng buộc cơ bản
            if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(maChuyen) ||
                string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(cmnd) || 
                string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diemDon))
            {
                return KetQuaXuLy.Fail("Vui lòng nhập đầy đủ thông tin: Mã phiếu, Chuyến đi, Họ tên khách, CMND/CCCD, SĐT và Điểm đón quy định.");
            }

            // 2. Nghiệp vụ: Khách lẻ đăng ký dưới 12 người
            if (soLuongVe <= 0)
            {
                return KetQuaXuLy.Fail("Số lượng vé đặt phải lớn hơn 0.");
            }

            if (soLuongVe >= 12)
            {
                return KetQuaXuLy.Fail(string.Format("Số lượng vé ({0} vé) thuộc diện Khách đoàn (>= 12 người).\nTheo quy định, đoàn từ 12 người trở lên vui lòng sử dụng chức năng 'Đăng ký Tour theo Đoàn' để được bố trí lịch trình riêng và ưu đãi đoàn.", soLuongVe));
            }

            // 3. Kiểm tra số chỗ còn trống của chuyến
            DataTable dtChuyen = Db.Query(@"SELECT c.MaChuyen, c.SoVeToiDa, c.SoVeDaBan, c.TrangThai, t.DonGia, t.TenTour
                                            FROM ChuyenDuLich c
                                            JOIN Tour t ON c.MaTour = t.MaTour
                                            WHERE c.MaChuyen = @mc", new SqlParameter("@mc", maChuyen));
            if (dtChuyen.Rows.Count == 0)
            {
                return KetQuaXuLy.Fail("Không tìm thấy thông tin chuyến du lịch được chọn.");
            }

            DataRow rChuyen = dtChuyen.Rows[0];
            string trangThaiChuyen = Convert.ToString(rChuyen["TrangThai"]);
            if (trangThaiChuyen == "Đã hủy" || trangThaiChuyen == "Đã kết thúc")
            {
                return KetQuaXuLy.Fail(string.Format("Chuyến du lịch này hiện có trạng thái '{0}', không thể nhận thêm khách.", trangThaiChuyen));
            }

            int soVeToiDa = Convert.ToInt32(rChuyen["SoVeToiDa"]);
            int soVeDaBan = Convert.ToInt32(rChuyen["SoVeDaBan"]);
            int soVeConLai = soVeToiDa - soVeDaBan;

            if (soLuongVe > soVeConLai)
            {
                return KetQuaXuLy.Fail(string.Format("Chuyến này chỉ còn lại {0} vé trống, không đủ để đặt {1} vé. Vui lòng chọn chuyến khác hoặc giảm số lượng vé.", soVeConLai, soLuongVe));
            }

            decimal donGia = Convert.ToDecimal(rChuyen["DonGia"]);
            decimal tongTien = soLuongVe * donGia; // Khách lẻ thanh toán 100% tiền vé

            // 4. Thực thi giao dịch SqlTransaction (Khách lẻ + Phiếu đăng ký + Cập nhật chuyến)
            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    // a. Kiểm tra khách lẻ theo CMND, nếu chưa có thì thêm mới
                    string maKhachLe = "";
                    string sqlCheckKhach = "SELECT MaKhachLe FROM KhachLe WHERE SoCMND = @cmnd";
                    using (SqlCommand cmdCheckK = new SqlCommand(sqlCheckKhach, cn, tx))
                    {
                        cmdCheckK.Parameters.AddWithValue("@cmnd", cmnd);
                        object objK = cmdCheckK.ExecuteScalar();
                        if (objK != null && objK != DBNull.Value)
                        {
                            maKhachLe = Convert.ToString(objK);
                            // Cập nhật SĐT, địa chỉ mới nếu có
                            string sqlUpK = "UPDATE KhachLe SET HoTen = @ten, DienThoai = @sdt, DiaChi = @dc WHERE MaKhachLe = @mkl";
                            using (SqlCommand cmdUpK = new SqlCommand(sqlUpK, cn, tx))
                            {
                                cmdUpK.Parameters.AddWithValue("@ten", hoTen);
                                cmdUpK.Parameters.AddWithValue("@sdt", sdt);
                                cmdUpK.Parameters.AddWithValue("@dc", (object)diaChi ?? DBNull.Value);
                                cmdUpK.Parameters.AddWithValue("@mkl", maKhachLe);
                                cmdUpK.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            maKhachLe = "KL" + DateTime.Now.ToString("yyMMddHHmmss");
                            string sqlInK = "INSERT INTO KhachLe (MaKhachLe, HoTen, SoCMND, DienThoai, DiaChi) VALUES (@mkl, @ten, @cmnd, @sdt, @dc)";
                            using (SqlCommand cmdInK = new SqlCommand(sqlInK, cn, tx))
                            {
                                cmdInK.Parameters.AddWithValue("@mkl", maKhachLe);
                                cmdInK.Parameters.AddWithValue("@ten", hoTen);
                                cmdInK.Parameters.AddWithValue("@cmnd", cmnd);
                                cmdInK.Parameters.AddWithValue("@sdt", sdt);
                                cmdInK.Parameters.AddWithValue("@dc", (object)diaChi ?? DBNull.Value);
                                cmdInK.ExecuteNonQuery();
                            }
                        }
                    }

                    // b. Thêm Phiếu đăng ký theo chuyến
                    string sqlPhieu = @"INSERT INTO PhieuDangKyChuyen 
                                        (SoPhieuChuyen, MaChuyen, MaKhachLe, NgayDangKy, SoLuongVe, DiemDonQuyDinh, TongTien, TrangThai)
                                        VALUES (@sp, @mc, @mkl, GETDATE(), @sl, @don, @tong, N'Đã thanh toán')";
                    using (SqlCommand cmdP = new SqlCommand(sqlPhieu, cn, tx))
                    {
                        cmdP.Parameters.AddWithValue("@sp", soPhieu);
                        cmdP.Parameters.AddWithValue("@mc", maChuyen);
                        cmdP.Parameters.AddWithValue("@mkl", maKhachLe);
                        cmdP.Parameters.AddWithValue("@sl", soLuongVe);
                        cmdP.Parameters.AddWithValue("@don", diemDon);
                        cmdP.Parameters.AddWithValue("@tong", tongTien);
                        cmdP.ExecuteNonQuery();
                    }

                    // c. Cập nhật số vé đã bán và trạng thái chuyến
                    int tongVeDaBanMoi = soVeDaBan + soLuongVe;
                    string trangThaiMoi = (tongVeDaBanMoi >= soVeToiDa) ? "Đã hết vé" : "Đang mở bán";
                    string sqlUpChuyen = "UPDATE ChuyenDuLich SET SoVeDaBan = @slBan, TrangThai = @tt WHERE MaChuyen = @mc";
                    using (SqlCommand cmdC = new SqlCommand(sqlUpChuyen, cn, tx))
                    {
                        cmdC.Parameters.AddWithValue("@slBan", tongVeDaBanMoi);
                        cmdC.Parameters.AddWithValue("@tt", trangThaiMoi);
                        cmdC.Parameters.AddWithValue("@mc", maChuyen);
                        cmdC.ExecuteNonQuery();
                    }

                    tx.Commit();
                    string thongBao = string.Format("Đăng ký vé tour theo chuyến thành công!\n- Số phiếu: {0}\n- Chuyến: {1} ({2})\n- Khách hàng: {3} (CMND: {4})\n- Số lượng vé: {5} vé\n- Tổng tiền (Thanh toán 100%): {6:N0} VNĐ\n- Hình thức TT: {7}\n- Điểm đón: {8}",
                        soPhieu, maChuyen, rChuyen["TenTour"], hoTen, cmnd, soLuongVe, tongTien, hinhThucTT, diemDon);
                    return KetQuaXuLy.Ok(thongBao);
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi khi lưu phiếu đăng ký chuyến: " + ex.Message);
                }
            }
        }

        public KetQuaXuLy HuyPhieuChuyen(string soPhieu)
        {
            if (string.IsNullOrWhiteSpace(soPhieu))
                return KetQuaXuLy.Fail("Vui lòng chọn phiếu đăng ký chuyến cần hủy.");

            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    DataTable dtP = new DataTable();
                    string sqlSel = "SELECT MaChuyen, SoLuongVe, TrangThai FROM PhieuDangKyChuyen WHERE SoPhieuChuyen = @sp";
                    using (SqlCommand cmdSel = new SqlCommand(sqlSel, cn, tx))
                    {
                        cmdSel.Parameters.AddWithValue("@sp", soPhieu);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmdSel))
                        {
                            da.Fill(dtP);
                        }
                    }

                    if (dtP.Rows.Count == 0)
                        return KetQuaXuLy.Fail("Không tìm thấy thông tin phiếu đăng ký này.");

                    DataRow row = dtP.Rows[0];
                    string trangThai = Convert.ToString(row["TrangThai"]);
                    if (trangThai == "Đã hủy")
                        return KetQuaXuLy.Fail("Phiếu này đã được hủy trước đó.");

                    string maChuyen = Convert.ToString(row["MaChuyen"]);
                    int soLuongVe = Convert.ToInt32(row["SoLuongVe"]);

                    // Đổi trạng thái phiếu
                    string sqlUpP = "UPDATE PhieuDangKyChuyen SET TrangThai = N'Đã hủy' WHERE SoPhieuChuyen = @sp";
                    using (SqlCommand cmdUpP = new SqlCommand(sqlUpP, cn, tx))
                    {
                        cmdUpP.Parameters.AddWithValue("@sp", soPhieu);
                        cmdUpP.ExecuteNonQuery();
                    }

                    // Hoàn trả lại số vé cho ChuyenDuLich
                    string sqlUpC = @"UPDATE ChuyenDuLich 
                                      SET SoVeDaBan = CASE WHEN SoVeDaBan - @sl < 0 THEN 0 ELSE SoVeDaBan - @sl END,
                                          TrangThai = N'Đang mở bán'
                                      WHERE MaChuyen = @mc";
                    using (SqlCommand cmdUpC = new SqlCommand(sqlUpC, cn, tx))
                    {
                        cmdUpC.Parameters.AddWithValue("@sl", soLuongVe);
                        cmdUpC.Parameters.AddWithValue("@mc", maChuyen);
                        cmdUpC.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok(string.Format("Đã hủy phiếu {0} thành công và hoàn trả {1} chỗ vé vào chuyến {2}.", soPhieu, soLuongVe, maChuyen));
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi khi hủy phiếu: " + ex.Message);
                }
            }
        }
    }
}
