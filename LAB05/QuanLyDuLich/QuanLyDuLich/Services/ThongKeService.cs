using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class ThongKeService
    {
        public DataTable LayTongQuanKPI(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
            SELECT 
                (SELECT COUNT(*) FROM Tour) AS TongSoTour,
                (SELECT COUNT(*) FROM NhanVienHDV) AS TongSoHDV,
                
                -- Khách đoàn
                ISNULL((SELECT COUNT(*) FROM PhieuDangKyTourDoan WHERE NgayLap >= @tu AND NgayLap <= DATEADD(DAY, 1, @den) AND TrangThai <> N'Hủy tour - Mất cọc'), 0) AS TongSoDoan,
                ISNULL((SELECT SUM(SoNguoi) FROM PhieuDangKyTourDoan WHERE NgayLap >= @tu AND NgayLap <= DATEADD(DAY, 1, @den) AND TrangThai <> N'Hủy tour - Mất cọc'), 0) AS TongKhachDoan,
                ISNULL((SELECT SUM(TongKinhPhi) FROM PhieuDangKyTourDoan WHERE NgayLap >= @tu AND NgayLap <= DATEADD(DAY, 1, @den) AND TrangThai <> N'Hủy tour - Mất cọc'), 0) AS DoanhThuDoan,
                ISNULL((SELECT SUM(TienCoc) FROM PhieuDangKyTourDoan WHERE NgayLap >= @tu AND NgayLap <= DATEADD(DAY, 1, @den)), 0) AS TongTienCocThu,

                -- Khách lẻ
                ISNULL((SELECT COUNT(*) FROM ChuyenDuLich WHERE NgayDi >= @tu AND NgayDi <= @den), 0) AS TongSoChuyen,
                ISNULL((SELECT SUM(SoLuongVe) FROM PhieuDangKyChuyen WHERE NgayDangKy >= @tu AND NgayDangKy <= DATEADD(DAY, 1, @den) AND TrangThai <> N'Đã hủy'), 0) AS TongVeLeDaBan,
                ISNULL((SELECT SUM(TongTien) FROM PhieuDangKyChuyen WHERE NgayDangKy >= @tu AND NgayDangKy <= DATEADD(DAY, 1, @den) AND TrangThai <> N'Đã hủy'), 0) AS DoanhThuKhachLe
            ";

            return Db.Query(sql,
                new SqlParameter("@tu", tuNgay.Date),
                new SqlParameter("@den", denNgay.Date));
        }

        public DataTable ThongKeDoanhThuTheoTour(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
            SELECT t.MaTour, t.TenTour, t.DonGia,
                   ISNULL(Doan.SoDoan, 0) AS SoDoan,
                   ISNULL(Doan.TongKhachDoan, 0) AS TongKhachDoan,
                   ISNULL(Doan.DoanhThuDoan, 0) AS DoanhThuDoan,
                   ISNULL(Le.TongVeLe, 0) AS TongVeLe,
                   ISNULL(Le.DoanhThuLe, 0) AS DoanhThuLe,
                   (ISNULL(Doan.DoanhThuDoan, 0) + ISNULL(Le.DoanhThuLe, 0)) AS TongDoanhThu
            FROM Tour t
            LEFT JOIN (
                SELECT MaTour, 
                       COUNT(*) AS SoDoan, 
                       SUM(SoNguoi) AS TongKhachDoan, 
                       SUM(TongKinhPhi) AS DoanhThuDoan
                FROM PhieuDangKyTourDoan
                WHERE NgayLap >= @tu AND NgayLap <= DATEADD(DAY, 1, @den) AND TrangThai <> N'Hủy tour - Mất cọc'
                GROUP BY MaTour
            ) Doan ON t.MaTour = Doan.MaTour
            LEFT JOIN (
                SELECT c.MaTour, 
                       SUM(p.SoLuongVe) AS TongVeLe, 
                       SUM(p.TongTien) AS DoanhThuLe
                FROM PhieuDangKyChuyen p
                JOIN ChuyenDuLich c ON p.MaChuyen = c.MaChuyen
                WHERE p.NgayDangKy >= @tu AND p.NgayDangKy <= DATEADD(DAY, 1, @den) AND p.TrangThai <> N'Đã hủy'
                GROUP BY c.MaTour
            ) Le ON t.MaTour = Le.MaTour
            ORDER BY TongDoanhThu DESC";

            return Db.Query(sql,
                new SqlParameter("@tu", tuNgay.Date),
                new SqlParameter("@den", denNgay.Date));
        }

        public DataTable ThongKeLuongVaThuLaoHDV(int thang, int nam)
        {
            string sql = @"
            SELECT nv.MaNV, nv.HoTen, nv.DienThoai, nv.LuongCoBan, nv.ThuLaoMoiTour,
                   ISNULL(pc.SoTour, 0) AS SoTourDan,
                   (ISNULL(pc.SoTour, 0) * nv.ThuLaoMoiTour) AS TongThuLao,
                   (nv.LuongCoBan + (ISNULL(pc.SoTour, 0) * nv.ThuLaoMoiTour)) AS TongThuNhap
            FROM NhanVienHDV nv
            LEFT JOIN (
                SELECT MaNV, COUNT(*) AS SoTour
                FROM PhanCongHDV
                WHERE MONTH(NgayBatDau) = @thang AND YEAR(NgayBatDau) = @nam
                GROUP BY MaNV
            ) pc ON nv.MaNV = pc.MaNV
            ORDER BY TongThuNhap DESC";

            return Db.Query(sql,
                new SqlParameter("@thang", thang),
                new SqlParameter("@nam", nam));
        }

        public DataTable LayChiTietGiaoDich(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
            -- Phiếu đoàn
            SELECT N'Tour Đoàn' AS LoaiPhieu,
                   p.SoPhieuDK AS SoPhieu,
                   d.TenCoQuan AS KhachHang,
                   d.DienThoaiCoQuan AS DienThoai,
                   t.TenTour,
                   p.NgayDi,
                   p.SoNguoi AS SoKhach,
                   p.TongKinhPhi AS TongTien,
                   p.TienCoc AS DaThanhToan,
                   p.TrangThai,
                   p.NgayLap AS NgayGiaoDich
            FROM PhieuDangKyTourDoan p
            JOIN Tour t ON p.MaTour = t.MaTour
            JOIN KhachDoan d ON p.MaDoan = d.MaDoan
            WHERE p.NgayLap >= @tu AND p.NgayLap <= DATEADD(DAY, 1, @den)

            UNION ALL

            -- Phiếu chuyến lẻ
            SELECT N'Vé Chuyến Lẻ' AS LoaiPhieu,
                   p.SoPhieuChuyen AS SoPhieu,
                   k.HoTen AS KhachHang,
                   k.DienThoai,
                   t.TenTour,
                   c.NgayDi,
                   p.SoLuongVe AS SoKhach,
                   p.TongTien AS TongTien,
                   p.TongTien AS DaThanhToan,
                   p.TrangThai,
                   p.NgayDangKy AS NgayGiaoDich
            FROM PhieuDangKyChuyen p
            JOIN ChuyenDuLich c ON p.MaChuyen = c.MaChuyen
            JOIN Tour t ON c.MaTour = t.MaTour
            JOIN KhachLe k ON p.MaKhachLe = k.MaKhachLe
            WHERE p.NgayDangKy >= @tu AND p.NgayDangKy <= DATEADD(DAY, 1, @den)

            ORDER BY NgayGiaoDich DESC";

            return Db.Query(sql,
                new SqlParameter("@tu", tuNgay.Date),
                new SqlParameter("@den", denNgay.Date));
        }
    }
}
