using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HeThongeShopping.Data;

namespace HeThongeShopping.Services
{
    public class DonHangService
    {
        public KetQuaXuLy XuLyDatHang(DonHang dh, List<ChiTietDonHang> dsChiTiet, ThanhToan tt)
        {
            // 1. Kiểm tra đầu vào cơ bản
            if (dsChiTiet == null || dsChiTiet.Count == 0)
                return KetQuaXuLy.Loi("Giỏ hàng trống, không thể đặt hàng.");

            // 2. Tính phí và tổng tiền (tinhPhiVaTongTien)
            decimal tongTriGia = 0;
            foreach (var ct in dsChiTiet)
            {
                tongTriGia += (ct.DonGia * ct.SoLuong);
            }
            dh.TongTriGia = tongTriGia;
            
            // Xử lý phí giao hàng (Ví dụ: Miễn phí nếu trên 1tr)
            if (dh.TongTriGia >= 1000000)
                dh.PhiGiaoHang = 0;
            else
                dh.PhiGiaoHang = 30000; // Phí mặc định
                
            dh.TongTienThanhToan = dh.TongTriGia + dh.PhiGiaoHang;

            // Lệ phí thanh toán (Giả sử thẻ VISA phí 1%)
            tt.LePhiGiaoDich = dh.TongTienThanhToan * 0.01m;

            // 3. Thanh toán thẻ (thanhToanThe) - Gọi Adapter thanh toán (giả lập)
            bool thanhCong = ThanhToanAdapter(tt.SoTheMasked, dh.TongTienThanhToan);
            if (!thanhCong)
                return KetQuaXuLy.Loi("Thanh toán thẻ thất bại, vui lòng kiểm tra lại thông tin thẻ.");
            
            tt.KetQuaThanhToan = "Thành công";

            // 4. Lưu đơn hàng (luuDonHang) dùng Transaction
            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    // Mã đơn hàng tự sinh (DH + yyyyMMddHHmmss)
                    dh.MaDonHang = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    // Insert DonHang
                    string sqlDH = @"INSERT INTO DonHang (MaDonHang, MaKhachHang, LoaiPhieuDatHang, HoTenNguoiNhan, DiaChiNhan, DienThoaiNhan, TongTriGia, PhiGiaoHang, TongTienThanhToan, TrangThai)
                                     VALUES (@Ma, @MaKH, @LoaiPhieu, @Ten, @DiaChi, @SDT, @TriGia, @Phi, @Tong, N'Đã thanh toán')";
                    using (SqlCommand cmdDH = new SqlCommand(sqlDH, cn, tx))
                    {
                        cmdDH.Parameters.AddWithValue("@Ma", dh.MaDonHang);
                        cmdDH.Parameters.AddWithValue("@MaKH", dh.MaKhachHang);
                        cmdDH.Parameters.AddWithValue("@LoaiPhieu", dh.LoaiPhieuDatHang);
                        cmdDH.Parameters.AddWithValue("@Ten", dh.HoTenNguoiNhan);
                        cmdDH.Parameters.AddWithValue("@DiaChi", dh.DiaChiNhan);
                        cmdDH.Parameters.AddWithValue("@SDT", dh.DienThoaiNhan);
                        cmdDH.Parameters.AddWithValue("@TriGia", dh.TongTriGia);
                        cmdDH.Parameters.AddWithValue("@Phi", dh.PhiGiaoHang);
                        cmdDH.Parameters.AddWithValue("@Tong", dh.TongTienThanhToan);
                        cmdDH.ExecuteNonQuery();
                    }

                    // Insert ChiTietDonHang
                    string sqlCT = @"INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, TenSanPham, DonGia, SoLuong, ThanhTien)
                                     VALUES (@MaDH, @MaSP, @TenSP, @DonGia, @SoLuong, @ThanhTien)";
                    foreach (var ct in dsChiTiet)
                    {
                        using (SqlCommand cmdCT = new SqlCommand(sqlCT, cn, tx))
                        {
                            cmdCT.Parameters.AddWithValue("@MaDH", dh.MaDonHang);
                            cmdCT.Parameters.AddWithValue("@MaSP", ct.MaSanPham);
                            cmdCT.Parameters.AddWithValue("@TenSP", ct.TenSanPham);
                            cmdCT.Parameters.AddWithValue("@DonGia", ct.DonGia);
                            cmdCT.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdCT.Parameters.AddWithValue("@ThanhTien", ct.DonGia * ct.SoLuong);
                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    // Insert ThanhToan
                    string sqlTT = @"INSERT INTO ThanhToan (MaDonHang, LoaiThe, SoTheMasked, TenChuThe, LePhiGiaoDich, KetQuaThanhToan)
                                     VALUES (@MaDH, @LoaiThe, @SoThe, @TenChuThe, @LePhi, @KQ)";
                    using (SqlCommand cmdTT = new SqlCommand(sqlTT, cn, tx))
                    {
                        cmdTT.Parameters.AddWithValue("@MaDH", dh.MaDonHang);
                        cmdTT.Parameters.AddWithValue("@LoaiThe", tt.LoaiThe);
                        cmdTT.Parameters.AddWithValue("@SoThe", tt.SoTheMasked);
                        cmdTT.Parameters.AddWithValue("@TenChuThe", tt.TenChuThe);
                        cmdTT.Parameters.AddWithValue("@LePhi", tt.LePhiGiaoDich);
                        cmdTT.Parameters.AddWithValue("@KQ", tt.KetQuaThanhToan);
                        cmdTT.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Loi("Lỗi lưu cơ sở dữ liệu: " + ex.Message);
                }
            }

            // 5. Gửi email xác nhận (guiEmailXacNhan)
            EmailAdapter_GuiEmailXacNhan(dh.MaDonHang);

            return KetQuaXuLy.Ok(dh.MaDonHang); // Trả về mã đơn hàng để UI hiển thị
        }

        // --- Các hàm Adapter kết nối hệ thống ngoài (Giả lập) ---
        private bool ThanhToanAdapter(string soThe, decimal tongTien)
        {
            // Trong thực tế sẽ gọi API cổng thanh toán. Ở đây giả lập luôn thành công.
            return true;
        }

        private void EmailAdapter_GuiEmailXacNhan(string maDonHang)
        {
            // Trong thực tế sẽ gọi SMTP gửi email.
            Console.WriteLine("Đã gửi email xác nhận cho đơn hàng: " + maDonHang);
        }
    }
}
