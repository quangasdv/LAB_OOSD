using System;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblStatusTime.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            KiemTraKetNoi();
        }

        public void KiemTraKetNoi()
        {
            string err;
            if (Db.TestConnection(out err))
            {
                lblStatusDb.Text = "CSDL: Sẵn sàng (QuanLyNhanSuDB)";
            }
            else
            {
                lblStatusDb.Text = "CSDL chưa kết nối: " + err;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            using (FrmNhanVien f = new FrmNhanVien())
            {
                f.ShowDialog(this);
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            using (FrmChamCongPhuTroi f = new FrmChamCongPhuTroi())
            {
                f.ShowDialog(this);
            }
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            using (FrmBangLuong f = new FrmBangLuong())
            {
                f.ShowDialog(this);
            }
        }

        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            using (FrmKhenThuongKyLuat f = new FrmKhenThuongKyLuat())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
