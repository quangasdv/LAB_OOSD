using System;

namespace QuanLyDuLich
{
    // Đối tượng đóng gói kết quả nghiệp vụ theo chuẩn kiến trúc Service-Result
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        private KetQuaXuLy(bool thanhCong, string thongBao)
        {
            ThanhCong = thanhCong;
            ThongBao = thongBao;
        }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy(true, thongBao);
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy(false, thongBao);
        }
    }

    public class Tour
    {
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public int SoNgay { get; set; }
        public int SoDem { get; set; }
        public decimal DonGia { get; set; }
        public string DiemXuatPhat { get; set; }
    }

    public class KhachDoan
    {
        public string MaDoan { get; set; }
        public string TenCoQuan { get; set; }
        public string DiaChiCoQuan { get; set; }
        public string DienThoaiCoQuan { get; set; }
        public string NguoiDaiDien { get; set; }
        public string Email { get; set; }
    }

    public class ThanhVienBaoHiemItem
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CCCD { get; set; }
    }

    public class PhieuDangKyDoanModel
    {
        public string SoPhieuDK { get; set; }
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public string MaDoan { get; set; }
        public string TenCoQuan { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayDi { get; set; }
        public string DiemDon { get; set; }
        public int SoNguoi { get; set; }
        public decimal TongKinhPhi { get; set; }
        public decimal TienCoc { get; set; }
        public bool CoMuaBaoHiem { get; set; }
        public string TrangThai { get; set; }
    }

    // Entity cho chuyến du lịch cố định của công ty
    public class ChuyenDuLich
    {
        public string MaChuyen { get; set; }
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayVe { get; set; }
        public int SoVeToiDa { get; set; }
        public int SoVeDaBan { get; set; }
        public int SoVeConLai { get; set; }
        public decimal DonGia { get; set; }
        public string TrangThai { get; set; }
    }

    // Entity cho khách hàng lẻ
    public class KhachLe
    {
        public string MaKhachLe { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
    }

    // Entity cho phiếu đăng ký theo chuyến của khách lẻ (< 12 vé)
    public class PhieuDangKyChuyenModel
    {
        public string SoPhieuChuyen { get; set; }
        public string MaChuyen { get; set; }
        public string TenTour { get; set; }
        public string MaKhachLe { get; set; }
        public string HoTenKhach { get; set; }
        public string SoCMND { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayDangKy { get; set; }
        public int SoLuongVe { get; set; }
        public string DiemDonQuyDinh { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }

    // Entity cho nhân viên hướng dẫn viên
    public class NhanVienHDV
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal ThuLaoMoiTour { get; set; }
    }

    // Entity phân công hướng dẫn viên
    public class PhanCongHDVModel
    {
        public string MaPhanCong { get; set; }
        public string MaNV { get; set; }
        public string HoTenNV { get; set; }
        public string DienThoaiNV { get; set; }
        public string LoaiPhanCong { get; set; } // "Theo Chuyến lẻ" hoặc "Theo Đoàn"
        public string MaMucTieu { get; set; }
        public string TenMucTieu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
