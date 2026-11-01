using System;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmDangNhap : Form
    {
        private readonly TaiKhoanService _taiKhoanService = new TaiKhoanService();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            cboVaiTro.SelectedIndex = 0;
            txtTenDangNhap.Text = "nguyenvana";
            txtMatKhau.Text = "123456";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            string role = cboVaiTro.SelectedItem != null ? cboVaiTro.SelectedItem.ToString() : "Khách hàng";

            KetQuaXuLy kq = _taiKhoanService.DangNhap(user, pass, role);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao + "\nChào mừng: " + TaiKhoanService.CurrentUser.HoTen, 
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string user = txtRegUser.Text.Trim();
            string pass = txtRegPass.Text.Trim();
            string pass2 = txtRegPass2.Text.Trim();
            string hoten = txtRegHoTen.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập, Mật khẩu và Họ tên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != pass2)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang
            {
                TenDangNhap = user,
                HoTen = hoten,
                NgaySinh = dtpRegNgaySinh.Value,
                SoCMND_Passport = txtRegCMND.Text.Trim(),
                DienThoai = txtRegSDT.Text.Trim(),
                Email = txtRegEmail.Text.Trim(),
                DiaChi = txtRegDiaChi.Text.Trim()
            };

            KetQuaXuLy kq = _taiKhoanService.DangKy(kh, pass);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabAuth.SelectedTab = tabDangNhap;
                txtTenDangNhap.Text = user;
                txtMatKhau.Text = pass;
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
