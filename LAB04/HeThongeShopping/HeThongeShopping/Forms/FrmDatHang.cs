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

        public FrmDatHang(List<ChiTietDonHang> gioHang) : this()
        {
            _gioHang = gioHang;
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            cboLoaiPhieu.SelectedIndex = 0;
            cboLoaiThe.SelectedIndex = 0;

            // Nếu chưa có giỏ hàng truyền sang, dùng giỏ hàng mẫu
            if (_gioHang == null || _gioHang.Count == 0)
            {
                _gioHang = new List<ChiTietDonHang>
                {
                    new ChiTietDonHang { MaSanPham = "SP001", TenSanPham = "Cây thông Noel mini", DonGia = 300000, SoLuong = 2, ThanhTien = 600000 },
                    new ChiTietDonHang { MaSanPham = "SP002", TenSanPham = "Hộp quà Giáng Sinh", DonGia = 450000, SoLuong = 1, ThanhTien = 450000 }
                };
            }

            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _gioHang;
            
            decimal tongTien = 0;
            foreach (var item in _gioHang) tongTien += item.ThanhTien;
            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " đ";

            // Nếu người dùng đã đăng nhập, tự điền thông tin
            if (TaiKhoanService.CurrentUser != null)
            {
                txtHoTenNhan.Text = TaiKhoanService.CurrentUser.HoTen;
                txtDienThoaiNhan.Text = TaiKhoanService.CurrentUser.DienThoai;
                txtDiaChiNhan.Text = TaiKhoanService.CurrentUser.DiaChi;
                txtChuThe.Text = TaiKhoanService.CurrentUser.HoTen.ToUpper();
            }
        }

        private void btnXacNhanDatHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTenNhan.Text.Trim()) || string.IsNullOrEmpty(txtDiaChiNhan.Text.Trim()) || string.IsNullOrEmpty(txtDienThoaiNhan.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin giao hàng (Người nhận, Địa chỉ, SĐT).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maKH = TaiKhoanService.CurrentUser != null && TaiKhoanService.CurrentUser.MaKhachHang > 0 ? TaiKhoanService.CurrentUser.MaKhachHang : 1;

            DonHang dh = new DonHang
            {
                MaKhachHang = maKH,
                HoTenNguoiNhan = txtHoTenNhan.Text.Trim(),
                DiaChiNhan = txtDiaChiNhan.Text.Trim(),
                DienThoaiNhan = txtDienThoaiNhan.Text.Trim(),
                LoaiPhieuDatHang = cboLoaiPhieu.SelectedItem != null ? cboLoaiPhieu.SelectedItem.ToString() : "Thường"
            };

            ThanhToan tt = new ThanhToan
            {
                LoaiThe = cboLoaiThe.SelectedItem != null ? cboLoaiThe.SelectedItem.ToString() : "VISA",
                SoTheMasked = "XXXX-XXXX-XXXX-" + (txtSoThe.Text.Trim().Length >= 4 ? txtSoThe.Text.Trim().Substring(txtSoThe.Text.Trim().Length - 4) : "1234"),
                TenChuThe = txtChuThe.Text.Trim()
            };

            KetQuaXuLy kq = _donHangService.XuLyDatHang(dh, _gioHang, tt);

            if (kq.ThanhCong)
            {
                MessageBox.Show("Đặt hàng và thanh toán thành công!\nMã đơn hàng của bạn là: " + kq.ThongBao, 
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
