using System;
using System.Data;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmQuanLyTaiKhoan : Form
    {
        private readonly TaiKhoanService _taiKhoanService = new TaiKhoanService();

        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                DataTable dt = _taiKhoanService.LayTatCaKhachHang();
                dgvTaiKhoan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            txtMaKH.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colMaKH"].Value);
            txtTenDangNhap.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colUser"].Value);
            txtHoTen.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colHoTen"].Value);
            txtCMND.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colCMND"].Value);
            txtDienThoai.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colSDT"].Value);
            txtEmail.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colEmail"].Value);
            txtDiaChi.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["colDiaChi"].Value);

            object ns = dgvTaiKhoan.CurrentRow.Cells["colNgaySinh"].Value;
            if (ns != DBNull.Value && ns != null)
            {
                DateTime d;
                if (DateTime.TryParse(ns.ToString(), out d))
                    dtpNgaySinh.Value = d;
            }

            txtMatKhau.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            string hoten = txtHoTen.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập, Mật khẩu và Họ tên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang
            {
                TenDangNhap = user,
                HoTen = hoten,
                NgaySinh = dtpNgaySinh.Value,
                SoCMND_Passport = txtCMND.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            KetQuaXuLy kq = _taiKhoanService.DangKy(kh, pass);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSach();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(txtMaKH.Text);
            KhachHang kh = new KhachHang
            {
                MaKhachHang = id,
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                SoCMND_Passport = txtCMND.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            KetQuaXuLy kq = _taiKhoanService.CapNhatKhachHang(kh, txtMatKhau.Text.Trim());
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSach();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(txtMaKH.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetQuaXuLy kq = _taiKhoanService.XoaKhachHang(id);
                if (kq.ThanhCong)
                {
                    MessageBox.Show(kq.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSach();
                }
                else
                {
                    MessageBox.Show(kq.ThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now.AddYears(-20);
            txtTenDangNhap.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
