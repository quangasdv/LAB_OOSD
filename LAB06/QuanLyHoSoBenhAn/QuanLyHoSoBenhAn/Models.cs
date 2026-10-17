using System;

namespace QuanLyHoSoBenhAn
{
    public class BenhNhanModel
    {
        public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string SoCCCD_BHYT { get; set; }
        public string HinhAnh3x4 { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string NguoiLienHeKhan { get; set; }
        public string SDTNguoiLienHe { get; set; }
    }

    public class HoSoBenhAnModel
    {
        public string MaHoSo { get; set; }
        public string MaBenhNhan { get; set; }
        public DateTime NgayCap { get; set; }
        public string NhomMau { get; set; }
        public string TienSuBenh { get; set; }
        public string BenhManTinh { get; set; }
        public string ThuocDaTungDung { get; set; }
        public string DiUngThuoc_PhanUngPhu { get; set; }
        public string TinhTrangHoSo { get; set; }
    }

    public class PhieuKhamBenhModel
    {
        public string MaPhieuKham { get; set; }
        public string MaDotDieuTri { get; set; }
        public string MaBacSiKham { get; set; }
        public DateTime NgayGioKham { get; set; }
        public int LanKham { get; set; }
        public decimal NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public int Mach { get; set; }
        public int? NhipTho { get; set; }
        public decimal? CanNang { get; set; }
        public decimal? ChieuCao { get; set; }
        public string TrieuChungLamsang { get; set; }
        public string ChanDoanSoBo { get; set; }
        public string ChanDoanXacDinh { get; set; }
        public string MaBenhICD10 { get; set; }
        public string HuongXuLy { get; set; }
    }

    public class ToaThuocModel
    {
        public string MaToaThuoc { get; set; }
        public string MaPhieuKham { get; set; }
        public string MaBacSiKeToa { get; set; }
        public DateTime NgayKeToa { get; set; }
        public int SoNgayDungThuoc { get; set; }
        public string LoiDanBacSi { get; set; }
        public string LuuYPhanUngPhu { get; set; }
        public string TrangThai { get; set; }
    }
}
