using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class HDVService
    {
        public DataTable LayDanhSachHDV(string timKiem = "")
        {
            if (string.IsNullOrWhiteSpace(timKiem))
            {
                return Db.Query("SELECT MaNV, HoTen, DienThoai, LuongCoBan, ThuLaoMoiTour FROM NhanVienHDV ORDER BY HoTen");
            }
            return Db.Query("SELECT MaNV, HoTen, DienThoai, LuongCoBan, ThuLaoMoiTour FROM NhanVienHDV WHERE MaNV LIKE @k OR HoTen LIKE @k OR DienThoai LIKE @k ORDER BY HoTen",
                new SqlParameter("@k", "%" + timKiem + "%"));
        }

        public KetQuaXuLy LuuHDV(NhanVienHDV nv, bool capNhat)
        {
            if (string.IsNullOrWhiteSpace(nv.MaNV) || string.IsNullOrWhiteSpace(nv.HoTen))
                return KetQuaXuLy.Fail("Mã nhân viên và Họ tên hướng dẫn viên không được để trống.");

            if (nv.LuongCoBan < 0 || nv.ThuLaoMoiTour < 0)
                return KetQuaXuLy.Fail("Lương căn bản và Thù lao mỗi tour không được âm.");

            try
            {
                if (capNhat)
                {
                    string sql = @"UPDATE NhanVienHDV 
                                   SET HoTen = @ten, DienThoai = @sdt, LuongCoBan = @luong, ThuLaoMoiTour = @thulao
                                   WHERE MaNV = @manv";
                    Db.Execute(sql,
                        new SqlParameter("@ten", nv.HoTen),
                        new SqlParameter("@sdt", nv.DienThoai ?? ""),
                        new SqlParameter("@luong", nv.LuongCoBan),
                        new SqlParameter("@thulao", nv.ThuLaoMoiTour),
                        new SqlParameter("@manv", nv.MaNV));
                    return KetQuaXuLy.Ok("Cập nhật thông tin hướng dẫn viên thành công.");
                }
                else
                {
                    object check = Db.Scalar("SELECT COUNT(*) FROM NhanVienHDV WHERE MaNV = @manv", new SqlParameter("@manv", nv.MaNV));
                    if (Convert.ToInt32(check) > 0)
                        return KetQuaXuLy.Fail("Mã hướng dẫn viên này đã tồn tại trong hệ thống.");

                    string sql = @"INSERT INTO NhanVienHDV (MaNV, HoTen, DienThoai, LuongCoBan, ThuLaoMoiTour)
                                   VALUES (@manv, @ten, @sdt, @luong, @thulao)";
                    Db.Execute(sql,
                        new SqlParameter("@manv", nv.MaNV),
                        new SqlParameter("@ten", nv.HoTen),
                        new SqlParameter("@sdt", nv.DienThoai ?? ""),
                        new SqlParameter("@luong", nv.LuongCoBan),
                        new SqlParameter("@thulao", nv.ThuLaoMoiTour));
                    return KetQuaXuLy.Ok("Thêm mới hướng dẫn viên thành công.");
                }
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi lưu thông tin hướng dẫn viên: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaHDV(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                return KetQuaXuLy.Fail("Vui lòng chọn hướng dẫn viên cần xóa.");

            try
            {
                object count = Db.Scalar("SELECT COUNT(*) FROM PhanCongHDV WHERE MaNV = @manv", new SqlParameter("@manv", maNV));
                if (Convert.ToInt32(count) > 0)
                {
                    return KetQuaXuLy.Fail("Không thể xóa HDV này vì đã có lịch sử phân công dẫn tour trong hệ thống.");
                }

                Db.Execute("DELETE FROM NhanVienHDV WHERE MaNV = @manv", new SqlParameter("@manv", maNV));
                return KetQuaXuLy.Ok("Đã xóa hướng dẫn viên thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi xóa hướng dẫn viên: " + ex.Message);
            }
        }

        public DataTable LayDanhSachChuyenDePhanCong()
        {
            string sql = @"SELECT c.MaChuyen, t.TenTour, c.NgayDi, c.NgayVe, c.SoVeToiDa, c.SoVeDaBan,
                                  (t.TenTour + ' [' + c.MaChuyen + '] | Từ: ' + CONVERT(VARCHAR(10), c.NgayDi, 103) + ' Đến: ' + CONVERT(VARCHAR(10), c.NgayVe, 103)) AS HienThi
                           FROM ChuyenDuLich c
                           JOIN Tour t ON c.MaTour = t.MaTour
                           WHERE c.TrangThai <> N'Đã hủy'
                           ORDER BY c.NgayDi ASC";
            return Db.Query(sql);
        }

        public DataTable LayDanhSachDoanDePhanCong()
        {
            string sql = @"SELECT p.SoPhieuDK, t.TenTour, d.TenCoQuan, p.NgayDi, t.SoNgay,
                                  DATEADD(DAY, t.SoNgay - 1, p.NgayDi) AS NgayVeDuKien,
                                  (t.TenTour + ' [Đoàn: ' + d.TenCoQuan + '] | Khởi hành: ' + CONVERT(VARCHAR(10), p.NgayDi, 103)) AS HienThi
                           FROM PhieuDangKyTourDoan p
                           JOIN Tour t ON p.MaTour = t.MaTour
                           JOIN KhachDoan d ON p.MaDoan = d.MaDoan
                           WHERE p.TrangThai <> N'Hủy tour - Mất cọc'
                           ORDER BY p.NgayDi ASC";
            return Db.Query(sql);
        }

        public DataTable LayDanhSachPhanCong(string maNV = "", string timKiem = "")
        {
            string sql = @"SELECT pc.MaPhanCong, pc.MaNV, nv.HoTen AS HoTenHDV, nv.DienThoai,
                                  CASE WHEN pc.MaChuyen IS NOT NULL THEN N'Theo Chuyến Lẻ' ELSE N'Theo Tour Đoàn' END AS LoaiPhanCong,
                                  COALESCE(pc.MaChuyen, pc.SoPhieuDK) AS MaDoiTuong,
                                  COALESCE(tChuyen.TenTour, tDoan.TenTour) AS TenTour,
                                  COALESCE(kd.TenCoQuan, N'Khách lẻ chuyến ' + pc.MaChuyen) AS TenDoiTac,
                                  pc.NgayBatDau, pc.NgayKetThuc,
                                  CASE 
                                      WHEN GETDATE() < pc.NgayBatDau THEN N'Sắp khởi hành'
                                      WHEN GETDATE() > pc.NgayKetThuc THEN N'Đã hoàn thành'
                                      ELSE N'Đang thực hiện'
                                  END AS TinhTrang
                           FROM PhanCongHDV pc
                           JOIN NhanVienHDV nv ON pc.MaNV = nv.MaNV
                           LEFT JOIN ChuyenDuLich c ON pc.MaChuyen = c.MaChuyen
                           LEFT JOIN Tour tChuyen ON c.MaTour = tChuyen.MaTour
                           LEFT JOIN PhieuDangKyTourDoan pdk ON pc.SoPhieuDK = pdk.SoPhieuDK
                           LEFT JOIN Tour tDoan ON pdk.MaTour = tDoan.MaTour
                           LEFT JOIN KhachDoan kd ON pdk.MaDoan = kd.MaDoan
                           WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(maNV))
            {
                sql += " AND pc.MaNV = @manv ";
            }

            if (!string.IsNullOrWhiteSpace(timKiem))
            {
                sql += " AND (pc.MaPhanCong LIKE @k OR nv.HoTen LIKE @k OR tChuyen.TenTour LIKE @k OR tDoan.TenTour LIKE @k OR kd.TenCoQuan LIKE @k) ";
            }

            sql += " ORDER BY pc.NgayBatDau DESC";

            return Db.Query(sql,
                new SqlParameter("@manv", (object)maNV ?? DBNull.Value),
                new SqlParameter("@k", "%" + (timKiem ?? "") + "%"));
        }

        // Kiểm tra nghiệp vụ: Không chồng chéo lịch phân công của hướng dẫn viên
        public KetQuaXuLy KiemTraTrungLich(string maNV, DateTime ngayBatDau, DateTime ngayKetThuc, string boQuaMaPhanCong = "")
        {
            string sql = @"SELECT pc.MaPhanCong, pc.NgayBatDau, pc.NgayKetThuc,
                                  COALESCE(tChuyen.TenTour, tDoan.TenTour) AS TenTour
                           FROM PhanCongHDV pc
                           LEFT JOIN ChuyenDuLich c ON pc.MaChuyen = c.MaChuyen
                           LEFT JOIN Tour tChuyen ON c.MaTour = tChuyen.MaTour
                           LEFT JOIN PhieuDangKyTourDoan pdk ON pc.SoPhieuDK = pdk.SoPhieuDK
                           LEFT JOIN Tour tDoan ON pdk.MaTour = tDoan.MaTour
                           WHERE pc.MaNV = @manv 
                             AND (pc.NgayBatDau <= @nket AND pc.NgayKetThuc >= @nbat) ";

            if (!string.IsNullOrWhiteSpace(boQuaMaPhanCong))
            {
                sql += " AND pc.MaPhanCong <> @boqua";
            }

            DataTable dt = Db.Query(sql,
                new SqlParameter("@manv", maNV),
                new SqlParameter("@nbat", ngayBatDau.Date),
                new SqlParameter("@nket", ngayKetThuc.Date),
                new SqlParameter("@boqua", boQuaMaPhanCong));

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                string thongBao = string.Format("CẢNH BÁO XUNG ĐỘT LỊCH TRÌNH:\nHướng dẫn viên đã có lịch công tác khác:\n- Tour: {0}\n- Thời gian: Từ {1:dd/MM/yyyy} đến {2:dd/MM/yyyy}\nTheo quy định, không được phân công chồng chéo lịch cho hướng dẫn viên!",
                    r["TenTour"], r["NgayBatDau"], r["NgayKetThuc"]);
                return KetQuaXuLy.Fail(thongBao);
            }

            return KetQuaXuLy.Ok("Lịch công tác hợp lệ, HDV hoàn toàn rảnh rỗi trong khoảng thời gian này.");
        }

        public KetQuaXuLy PhanCong(string maPhanCong, string maNV, bool theoChuyen, string maChuyen, string soPhieuDK, 
                                   DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (string.IsNullOrWhiteSpace(maPhanCong) || string.IsNullOrWhiteSpace(maNV))
                return KetQuaXuLy.Fail("Mã phân công và Nhân viên hướng dẫn không được để trống.");

            if (theoChuyen && string.IsNullOrWhiteSpace(maChuyen))
                return KetQuaXuLy.Fail("Vui lòng chọn Chuyến du lịch khách lẻ cần phân công.");

            if (!theoChuyen && string.IsNullOrWhiteSpace(soPhieuDK))
                return KetQuaXuLy.Fail("Vui lòng chọn Phiếu đăng ký đoàn cần phân công.");

            if (ngayKetThuc.Date < ngayBatDau.Date)
                return KetQuaXuLy.Fail("Ngày kết thúc không được trước ngày bắt đầu.");

            // Kiểm tra trùng mã phân công
            object check = Db.Scalar("SELECT COUNT(*) FROM PhanCongHDV WHERE MaPhanCong = @mpc", new SqlParameter("@mpc", maPhanCong));
            if (Convert.ToInt32(check) > 0)
                return KetQuaXuLy.Fail("Mã phân công này đã tồn tại trong hệ thống.");

            // Kiểm tra quy định: Mỗi chuyến khách lẻ phân công 1 HDV cụ thể
            if (theoChuyen)
            {
                object checkChuyen = Db.Scalar("SELECT COUNT(*) FROM PhanCongHDV WHERE MaChuyen = @mc", new SqlParameter("@mc", maChuyen));
                if (Convert.ToInt32(checkChuyen) > 0)
                {
                    return KetQuaXuLy.Fail("Chuyến du lịch khách lẻ này đã được phân công HDV phụ trách rồi (Quy định: mỗi chuyến khách lẻ phân công 1 HDV cụ thể).");
                }
            }

            // Kiểm tra chống chồng chéo lịch
            KetQuaXuLy checkLich = KiemTraTrungLich(maNV, ngayBatDau, ngayKetThuc);
            if (!checkLich.ThanhCong)
            {
                return checkLich;
            }

            try
            {
                string sql = @"INSERT INTO PhanCongHDV (MaPhanCong, MaNV, SoPhieuDK, MaChuyen, NgayBatDau, NgayKetThuc)
                               VALUES (@mpc, @manv, @sp, @mc, @nbat, @nket)";
                Db.Execute(sql,
                    new SqlParameter("@mpc", maPhanCong),
                    new SqlParameter("@manv", maNV),
                    new SqlParameter("@sp", theoChuyen ? (object)DBNull.Value : soPhieuDK),
                    new SqlParameter("@mc", theoChuyen ? (object)maChuyen : DBNull.Value),
                    new SqlParameter("@nbat", ngayBatDau.Date),
                    new SqlParameter("@nket", ngayKetThuc.Date));

                return KetQuaXuLy.Ok("Phân công hướng dẫn viên thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi lưu phân công HDV: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaPhanCong(string maPhanCong)
        {
            if (string.IsNullOrWhiteSpace(maPhanCong))
                return KetQuaXuLy.Fail("Vui lòng chọn phân công cần xóa.");

            try
            {
                Db.Execute("DELETE FROM PhanCongHDV WHERE MaPhanCong = @mpc", new SqlParameter("@mpc", maPhanCong));
                return KetQuaXuLy.Ok("Đã hủy phân công HDV thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi hủy phân công: " + ex.Message);
            }
        }
    }
}
