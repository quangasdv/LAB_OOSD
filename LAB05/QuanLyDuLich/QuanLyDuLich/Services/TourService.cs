using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class TourService
    {
        public DataTable LayDanhSachTour(string timKiem = "")
        {
            if (string.IsNullOrWhiteSpace(timKiem))
            {
                return Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia, DiemXuatPhat FROM Tour ORDER BY MaTour");
            }
            return Db.Query("SELECT MaTour, TenTour, SoNgay, SoDem, DonGia, DiemXuatPhat FROM Tour WHERE MaTour LIKE @k OR TenTour LIKE @k ORDER BY MaTour",
                new SqlParameter("@k", "%" + timKiem + "%"));
        }

        public KetQuaXuLy LuuTour(Tour tour, bool capNhat)
        {
            if (string.IsNullOrWhiteSpace(tour.MaTour) || string.IsNullOrWhiteSpace(tour.TenTour))
                return KetQuaXuLy.Fail("Mã tour và Tên tour không được để trống.");
            if (tour.SoNgay <= 0 || tour.DonGia < 0)
                return KetQuaXuLy.Fail("Số ngày phải lớn hơn 0 và Đơn giá không được âm.");

            try
            {
                if (capNhat)
                {
                    string sql = @"UPDATE Tour 
                                   SET TenTour = @t, SoNgay = @ngay, SoDem = @dem, DonGia = @gia, DiemXuatPhat = @xp 
                                   WHERE MaTour = @m";
                    Db.Execute(sql,
                        new SqlParameter("@m", tour.MaTour),
                        new SqlParameter("@t", tour.TenTour),
                        new SqlParameter("@ngay", tour.SoNgay),
                        new SqlParameter("@dem", tour.SoDem),
                        new SqlParameter("@gia", tour.DonGia),
                        new SqlParameter("@xp", string.IsNullOrWhiteSpace(tour.DiemXuatPhat) ? "TP.HCM" : tour.DiemXuatPhat));

                    return KetQuaXuLy.Ok("Cập nhật thông tin tour du lịch thành công.");
                }
                else
                {
                    object check = Db.Scalar("SELECT COUNT(*) FROM Tour WHERE MaTour = @m", new SqlParameter("@m", tour.MaTour));
                    if (Convert.ToInt32(check) > 0)
                        return KetQuaXuLy.Fail("Mã tour này đã tồn tại trong hệ thống.");

                    string sql = @"INSERT INTO Tour (MaTour, TenTour, SoNgay, SoDem, DonGia, DiemXuatPhat) 
                                   VALUES (@m, @t, @ngay, @dem, @gia, @xp)";
                    Db.Execute(sql,
                        new SqlParameter("@m", tour.MaTour),
                        new SqlParameter("@t", tour.TenTour),
                        new SqlParameter("@ngay", tour.SoNgay),
                        new SqlParameter("@dem", tour.SoDem),
                        new SqlParameter("@gia", tour.DonGia),
                        new SqlParameter("@xp", string.IsNullOrWhiteSpace(tour.DiemXuatPhat) ? "TP.HCM" : tour.DiemXuatPhat));

                    return KetQuaXuLy.Ok("Thêm mới tour du lịch thành công.");
                }
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi khi lưu thông tin tour: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaTour(string maTour)
        {
            if (string.IsNullOrWhiteSpace(maTour))
                return KetQuaXuLy.Fail("Vui lòng chọn tour cần xóa.");

            try
            {
                Db.Execute("DELETE FROM Tour WHERE MaTour = @m", new SqlParameter("@m", maTour));
                return KetQuaXuLy.Ok("Đã xóa tour du lịch thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Không thể xóa tour (tour này có thể đã được liên kết trong các phiếu đăng ký): " + ex.Message);
            }
        }
    }
}
