using System;

namespace HeThongeShopping
{
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoCMND_Passport { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public DateTime? NgayDangKy { get; set; }
    }

    public class DonHang
    {
        public string MaDonHang { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime ThoiDiemDatHang { get; set; }
        public string LoaiPhieuDatHang { get; set; }
        public string HoTenNguoiNhan { get; set; }
        public string DiaChiNhan { get; set; }
        public string DienThoaiNhan { get; set; }
        public decimal TongTriGia { get; set; }
        public decimal PhiGiaoHang { get; set; }
        public decimal TongTienThanhToan { get; set; }
        public string TrangThai { get; set; }
    }

    public class ChiTietDonHang
    {
        public string MaDonHang { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
    }

    public class ThanhToan
    {
        public string MaDonHang { get; set; }
        public string LoaiThe { get; set; }
        public string SoTheMasked { get; set; }
        public string TenChuThe { get; set; }
        public decimal LePhiGiaoDich { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string KetQuaThanhToan { get; set; }
    }

    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string NhomSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int TonKho { get; set; }
        public string MoTa { get; set; }
    }

    public class CauHinhHeThong
    {
        public decimal PhiThuong { get; set; }
        public decimal PhiCPN { get; set; }
        public decimal PhiHoaToc { get; set; }
        public decimal MienPhiThuong { get; set; }
        public decimal MienPhiCPN { get; set; }
        public decimal TiLePhiVisaMaster { get; set; }
        public decimal TiLePhiAmexDiscover { get; set; }
        public string EmailAdmin { get; set; }
    }

    public class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        private KetQuaXuLy(bool thanhCong, string thongBao)
        {
            ThanhCong = thanhCong;
            ThongBao = thongBao;
        }

        public static KetQuaXuLy Ok(string thongBao) { return new KetQuaXuLy(true, thongBao); }
        public static KetQuaXuLy Loi(string thongBao) { return new KetQuaXuLy(false, thongBao); }
    }
}
