using System;
using System.Windows.Forms;

namespace HeThongeShopping.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (FrmDangNhap f = new FrmDangNhap())
            {
                f.ShowDialog(this);
            }
        }

        private void btnMuaSam_Click(object sender, EventArgs e)
        {
            using (FrmMuaSam f = new FrmMuaSam())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            using (FrmDatHang f = new FrmDatHang())
            {
                f.ShowDialog(this);
            }
        }

        private void btnQuanLyDonHang_Click(object sender, EventArgs e)
        {
            using (FrmQuanLyDonHang f = new FrmQuanLyDonHang())
            {
                f.ShowDialog(this);
            }
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            using (FrmQuanLyTaiKhoan f = new FrmQuanLyTaiKhoan())
            {
                f.ShowDialog(this);
            }
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            using (FrmCauHinh f = new FrmCauHinh())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (FrmThongKe f = new FrmThongKe())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
