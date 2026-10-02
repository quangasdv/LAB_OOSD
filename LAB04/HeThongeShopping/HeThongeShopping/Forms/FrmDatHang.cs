using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmDatHang : Form
    {
        private readonly DonHangService _donHangService = new DonHangService();
        private List<ChiTietDonHang> _gioHang;

        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            cboLoaiPhieu.SelectedIndex = 0;
            cboLoaiThe.SelectedIndex = 0;

            // Giả lập giỏ hàng hiện tại của khách hàng
            _gioHang = new List<ChiTietDonHang>
            {
                new ChiTietDonHang { MaSanPham = "SP001", TenSanPham = "Cây thông Noel mini", DonGia = 300000, SoLuong = 2, ThanhTien = 600000 },
                new ChiTietDonHang { MaSanPham = "SP002", TenSanPham = "Hộp quà Giáng Sinh", DonGia = 450000, SoLuong = 1, ThanhTien = 450000 }
            };

            dgvGioHang.DataSource = _gioHang;
            
            decimal tongTien = 0;
            foreach(var item in _gioHang) tongTien += item.ThanhTien;
            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " đ";
        }

        private void btnXacNhanDatHang_Click(object sender, EventArgs e)
        {
            // Lấy thông tin giao hàng
            DonHang dh = new DonHang
            {
                MaKhachHang = 1, // Giả định khách hàng ID = 1 đã đăng nhập
                HoTenNguoiNhan = txtHoTenNhan.Text.Trim(),
                DiaChiNhan = txtDiaChiNhan.Text.Trim(),
                DienThoaiNhan = txtDienThoaiNhan.Text.Trim(),
                LoaiPhieuDatHang = cboLoaiPhieu.SelectedItem.ToString()
            };

            // Lấy thông tin thanh toán
            ThanhToan tt = new ThanhToan
            {
                LoaiThe = cboLoaiThe.SelectedItem.ToString(),
                SoTheMasked = "XXXX-XXXX-XXXX-" + (txtSoThe.Text.Trim().Length >= 4 ? txtSoThe.Text.Trim().Substring(txtSoThe.Text.Trim().Length - 4) : "0000"),
                TenChuThe = txtChuThe.Text.Trim()
            };

            // Gọi Service xử lý
            KetQuaXuLy kq = _donHangService.XuLyDatHang(dh, _gioHang, tt);

            if (kq.ThanhCong)
            {
                MessageBox.Show("Đặt hàng và thanh toán thành công!\nMã đơn hàng của bạn là: " + kq.ThongBao, 
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Làm rỗng giỏ hàng sau khi thành công
                _gioHang.Clear();
                dgvGioHang.DataSource = null;
                this.Close();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
