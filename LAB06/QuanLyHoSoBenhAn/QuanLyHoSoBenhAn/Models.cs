using System;

namespace QuanLyHoSoBenhAn
{
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

    public class KhoaDieuTriModel
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string ViTri { get; set; }
        public string DienThoaiKhoa { get; set; }
        public string TruongKhoa { get; set; }
    }

    public class BacSiModel
    {
        public string MaBacSi { get; set; }
        public string MaKhoa { get; set; }
        public string HoTen { get; set; }
        public string HocHamHocVi { get; set; }
        public string ChuyenKhoa { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
    }

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

    public class LePhiNamModel
    {
        public string MaLePhi { get; set; }
        public string MaBenhNhan { get; set; }
        public int NamThu { get; set; }
        public decimal SoTien { get; set; }
        public DateTime NgayThu { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string NguoiThu { get; set; }
        public string TrangThai { get; set; }
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

    public class DotDieuTriModel
    {
        public string MaDotDieuTri { get; set; }
        public string MaHoSo { get; set; }
        public string MaBacSiPhuTrach { get; set; }
        public string MaKhoa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string LoaiDieuTri { get; set; }
        public string LyDoDieuTri { get; set; }
        public string TrangThai { get; set; }
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

    public class DanhMucXetNghiemModel
    {
        public string MaXetNghiem { get; set; }
        public string TenXetNghiem { get; set; }
        public string LoaiXetNghiem { get; set; }
        public decimal DonGia { get; set; }
        public string ChiSoBinhThuong { get; set; }
        public string DonViDo { get; set; }
        public string ThoiGianTraKetQua { get; set; }
    }

    public class PhieuChiDinhXNModel
    {
        public string MaChiDinh { get; set; }
        public string MaPhieuKham { get; set; }
        public string MaBacSiChiDinh { get; set; }
        public DateTime NgayChiDinh { get; set; }
        public string LyDoChiDinh { get; set; }
        public string TrangThai { get; set; }
    }

    public class ChiTietXetNghiemModel
    {
        public string MaChiDinh { get; set; }
        public string MaXetNghiem { get; set; }
        public string TenXetNghiem { get; set; }
        public decimal DonGia { get; set; }
        public string ChiSoBinhThuong { get; set; }
        public string DonViDo { get; set; }
        public string KetQua { get; set; }
        public string DanhGiaKetQua { get; set; }
        public DateTime? NgayGioTraKQ { get; set; }
        public string KTVThucHien { get; set; }
        public string GhiChu { get; set; }
    }

    public class ThuocModel
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string HoatChatChinh { get; set; }
        public string DonViTinh { get; set; }
        public string HamLuong { get; set; }
        public string DuongDung { get; set; }
        public decimal DonGia { get; set; }
        public string ChongChiDinh { get; set; }
        public string TuongTacThuoc { get; set; }
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

    public class ChiTietToaThuocModel
    {
        public string MaToaThuoc { get; set; }
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public decimal Sang { get; set; }
        public decimal Trua { get; set; }
        public decimal Chieu { get; set; }
        public decimal Toi { get; set; }
        public string CachDung { get; set; }
        public decimal DonGiaLucKe { get; set; }
        public decimal ThanhTien { get { return SoLuong * DonGiaLucKe; } }
    }

    public class LichHenModel
    {
        public string MaLichHen { get; set; }
        public string MaHoSo { get; set; }
        public string MaBacSiHen { get; set; }
        public DateTime NgayHenKham { get; set; }
        public TimeSpan? GioHenKham { get; set; }
        public string NoiDungKham { get; set; }
        public string DanDoChuanBi { get; set; }
        public string TrangThaiHen { get; set; }
    }

    public class HoanTatDieuTriModel
    {
        public string MaHoanTat { get; set; }
        public string MaDotDieuTri { get; set; }
        public DateTime NgayHoanTat { get; set; }
        public string MaBacSiXacNhan { get; set; }
        public string KetQuaDieuTri { get; set; }
        public string TinhTrangXuatVien { get; set; }
        public string DanDoSauXuatVien { get; set; }
        public decimal TongTienVienPhi { get; set; }
        public decimal BHYTChiTra { get; set; }
        public decimal BenhNhanThanhToan { get; set; }
    }
}
