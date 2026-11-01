using System;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            using (FrmTiepNhanBenhNhan f = new FrmTiepNhanBenhNhan())
            {
                f.ShowDialog(this);
            }
        }

        private void btnLePhiNam_Click(object sender, EventArgs e)
        {
            using (FrmLePhiNam f = new FrmLePhiNam())
            {
                f.ShowDialog(this);
            }
        }

        private void btnHoSoBenhAn_Click(object sender, EventArgs e)
        {
            using (FrmHoSoBenhAn f = new FrmHoSoBenhAn())
            {
                f.ShowDialog(this);
            }
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            using (FrmKhamBenh f = new FrmKhamBenh())
            {
                f.ShowDialog(this);
            }
        }

        private void btnChiDinhXN_Click(object sender, EventArgs e)
        {
            using (FrmChiDinhXN f = new FrmChiDinhXN())
            {
                f.ShowDialog(this);
            }
        }

        private void btnKeToaThuoc_Click(object sender, EventArgs e)
        {
            using (FrmKeToaThuoc f = new FrmKeToaThuoc())
            {
                f.ShowDialog(this);
            }
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            using (FrmLichHen f = new FrmLichHen())
            {
                f.ShowDialog(this);
            }
        }

        private void btnHoanTatDieuTri_Click(object sender, EventArgs e)
        {
            using (FrmHoanTatDieuTri f = new FrmHoanTatDieuTri())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (FrmDanhMuc f = new FrmDanhMuc())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
