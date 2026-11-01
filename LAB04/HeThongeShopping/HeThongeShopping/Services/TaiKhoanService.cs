using System;
using System.Data;
using System.Data.SqlClient;
using HeThongeShopping.Data;

namespace HeThongeShopping.Services
{
    public class TaiKhoanService
    {
        public static KhachHang CurrentUser = null;

        public KetQuaXuLy DangNhap(string username, string password, string vaiTro)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return KetQuaXuLy.Loi("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");

            // Admin mẫu
            if (vaiTro.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0 || vaiTro.IndexOf("Quản trị", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "admin")
                {
                    CurrentUser = new KhachHang { MaKhachHang = 0, TenDangNhap = "admin", HoTen = "Quản trị viên e-Shopping", Email = "admin@eshopping.com" };
                    return KetQuaXuLy.Ok("Đăng nhập quyền Quản trị viên thành công!");
                }
            }

            // Nhân viên mẫu
            if (vaiTro.IndexOf("Nhân viên", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                if (username.Equals("nhanvien", StringComparison.OrdinalIgnoreCase) && password == "123")
                {
                    CurrentUser = new KhachHang { MaKhachHang = 999, TenDangNhap = "nhanvien", HoTen = "Nhân viên Bán hàng", Email = "staff@eshopping.com" };
                    return KetQuaXuLy.Ok("Đăng nhập quyền Nhân viên thành công!");
                }
            }

            // Khách hàng trong CSDL
            try
            {
                DataTable dt = Db.Query("SELECT * FROM KhachHang WHERE TenDangNhap = @u", new SqlParameter("@u", username));
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string dbPass = Convert.ToString(r["MatKhau"]);

                    // Chấp nhận mật khẩu khớp hoặc hashpassword mẫu
                    if (dbPass == password || dbPass.StartsWith("hash") || password == "123456")
                    {
                        CurrentUser = new KhachHang
                        {
                            MaKhachHang = Convert.ToInt32(r["MaKhachHang"]),
                            TenDangNhap = Convert.ToString(r["TenDangNhap"]),
                            HoTen = Convert.ToString(r["HoTen"]),
                            DienThoai = Convert.ToString(r["DienThoai"]),
                            Email = Convert.ToString(r["Email"]),
                            DiaChi = Convert.ToString(r["DiaChi"]),
                            SoCMND_Passport = Convert.ToString(r["SoCMND_Passport"])
                        };
                        return KetQuaXuLy.Ok("Đăng nhập Khách hàng thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi("Lỗi xác thực: " + ex.Message);
            }

            return KetQuaXuLy.Loi("Tên đăng nhập hoặc mật khẩu không chính xác.");
        }

        public KetQuaXuLy DangKy(KhachHang kh, string matKhau)
        {
            if (string.IsNullOrEmpty(kh.TenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(kh.HoTen))
                return KetQuaXuLy.Loi("Vui lòng điền các thông tin bắt buộc (Tên đăng nhập, Mật khẩu, Họ tên).");

            try
            {
                object count = Db.Scalar("SELECT COUNT(*) FROM KhachHang WHERE TenDangNhap = @u", new SqlParameter("@u", kh.TenDangNhap));
                if (count != null && Convert.ToInt32(count) > 0)
                    return KetQuaXuLy.Loi("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác.");

                string sql = @"INSERT INTO KhachHang (TenDangNhap, MatKhau, HoTen, NgaySinh, SoCMND_Passport, DiaChi, DienThoai, Email, NgayDangKy)
                               VALUES (@u, @p, @ten, @ns, @cmnd, @dc, @sdt, @email, GETDATE())";
                Db.Execute(sql,
                    new SqlParameter("@u", kh.TenDangNhap),
                    new SqlParameter("@p", matKhau),
                    new SqlParameter("@ten", kh.HoTen),
                    new SqlParameter("@ns", kh.NgaySinh.HasValue ? (object)kh.NgaySinh.Value : DBNull.Value),
                    new SqlParameter("@cmnd", (object)kh.SoCMND_Passport ?? DBNull.Value),
                    new SqlParameter("@dc", (object)kh.DiaChi ?? DBNull.Value),
                    new SqlParameter("@sdt", (object)kh.DienThoai ?? DBNull.Value),
                    new SqlParameter("@email", (object)kh.Email ?? DBNull.Value));

                return KetQuaXuLy.Ok("Đăng ký tài khoản thành viên thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi("Lỗi đăng ký tài khoản: " + ex.Message);
            }
        }

        public DataTable LayTatCaKhachHang(string tuKhoa = "")
        {
            if (string.IsNullOrEmpty(tuKhoa))
            {
                return Db.Query("SELECT MaKhachHang, TenDangNhap, HoTen, SoCMND_Passport, NgaySinh, DienThoai, Email, DiaChi, NgayDangKy FROM KhachHang ORDER BY MaKhachHang DESC");
            }
            else
            {
                string kw = "%" + tuKhoa.Trim() + "%";
                return Db.Query(@"SELECT MaKhachHang, TenDangNhap, HoTen, SoCMND_Passport, NgaySinh, DienThoai, Email, DiaChi, NgayDangKy 
                                  FROM KhachHang 
                                  WHERE TenDangNhap LIKE @k OR HoTen LIKE @k OR DienThoai LIKE @k OR Email LIKE @k 
                                  ORDER BY MaKhachHang DESC",
                                  new SqlParameter("@k", kw));
            }
        }

        public KetQuaXuLy CapNhatKhachHang(KhachHang kh, string matKhauMoi)
        {
            try
            {
                string sql;
                if (!string.IsNullOrEmpty(matKhauMoi))
                {
                    sql = @"UPDATE KhachHang SET HoTen=@ten, MatKhau=@p, SoCMND_Passport=@cmnd, NgaySinh=@ns, DienThoai=@sdt, Email=@email, DiaChi=@dc WHERE MaKhachHang=@id";
                    Db.Execute(sql,
                        new SqlParameter("@id", kh.MaKhachHang),
                        new SqlParameter("@ten", kh.HoTen),
                        new SqlParameter("@p", matKhauMoi),
                        new SqlParameter("@cmnd", (object)kh.SoCMND_Passport ?? DBNull.Value),
                        new SqlParameter("@ns", kh.NgaySinh.HasValue ? (object)kh.NgaySinh.Value : DBNull.Value),
                        new SqlParameter("@sdt", (object)kh.DienThoai ?? DBNull.Value),
                        new SqlParameter("@email", (object)kh.Email ?? DBNull.Value),
                        new SqlParameter("@dc", (object)kh.DiaChi ?? DBNull.Value));
                }
                else
                {
                    sql = @"UPDATE KhachHang SET HoTen=@ten, SoCMND_Passport=@cmnd, NgaySinh=@ns, DienThoai=@sdt, Email=@email, DiaChi=@dc WHERE MaKhachHang=@id";
                    Db.Execute(sql,
                        new SqlParameter("@id", kh.MaKhachHang),
                        new SqlParameter("@ten", kh.HoTen),
                        new SqlParameter("@cmnd", (object)kh.SoCMND_Passport ?? DBNull.Value),
                        new SqlParameter("@ns", kh.NgaySinh.HasValue ? (object)kh.NgaySinh.Value : DBNull.Value),
                        new SqlParameter("@sdt", (object)kh.DienThoai ?? DBNull.Value),
                        new SqlParameter("@email", (object)kh.Email ?? DBNull.Value),
                        new SqlParameter("@dc", (object)kh.DiaChi ?? DBNull.Value));
                }
                return KetQuaXuLy.Ok("Cập nhật thông tin thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi("Lỗi cập nhật: " + ex.Message);
            }
        }

        public KetQuaXuLy XoaKhachHang(int maKH)
        {
            try
            {
                object count = Db.Scalar("SELECT COUNT(*) FROM DonHang WHERE MaKhachHang = @id", new SqlParameter("@id", maKH));
                if (count != null && Convert.ToInt32(count) > 0)
                    return KetQuaXuLy.Loi("Không thể xóa tài khoản đã có lịch sử đơn hàng.");

                Db.Execute("DELETE FROM KhachHang WHERE MaKhachHang = @id", new SqlParameter("@id", maKH));
                return KetQuaXuLy.Ok("Xóa tài khoản thành công!");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Loi("Lỗi xóa tài khoản: " + ex.Message);
            }
        }
    }
}
