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

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            // Mở form Đặt Hàng theo chế độ Modal Dialog
            using (FrmDatHang f = new FrmDatHang())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi thoát
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
