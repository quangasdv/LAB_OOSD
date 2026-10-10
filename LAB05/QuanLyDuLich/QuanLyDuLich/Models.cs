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
}
