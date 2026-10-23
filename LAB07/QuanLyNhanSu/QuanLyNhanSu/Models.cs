using System;

namespace QuanLyNhanSu
{
    public class PhongBanModel
    {
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string LoaiDonVi { get; set; }
        public string DiaDiem { get; set; }
        public string SoDienThoai { get; set; }
        public string MaTruongPhong { get; set; }
        public bool CoMoiTruongDocHai { get; set; }
    }

    public class ChucVuModel
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public decimal PhuCapChucVuDinhMuc { get; set; }
        public string MoTaNhiemVu { get; set; }
    }

    public class NhanVienModel
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoCCCD { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MaPhongBan { get; set; }
        public string MaChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string TrangThai { get; set; }
    }

    public class BangLuongThangModel
    {
        public string MaBangLuong { get; set; }
        public string MaNhanVien { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal LuongNgayCong { get; set; }
        public decimal TienPhuCapChucVu { get; set; }
        public decimal TienPhuCapDocHai { get; set; }
        public decimal TienPhuCapLuong { get; set; }
        public decimal TienLuongPhuTroi { get; set; }
        public decimal TienKhenThuong { get; set; }
        public decimal TienTrichBHXH_BHYT { get; set; }
        public decimal TienPhatKyLuat { get; set; }
        public decimal ThueTNCN { get; set; }
        public decimal ThucLinh { get; set; }
        public string TrangThaiLuong { get; set; }
    }
}
