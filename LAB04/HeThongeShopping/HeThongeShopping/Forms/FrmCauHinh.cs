using System;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            HienThiGiaTri();
        }

        private void HienThiGiaTri()
        {
            numPhiThuong.Value = CauHinhService.Current.PhiThuong;
            numPhiCPN.Value = CauHinhService.Current.PhiCPN;
            numPhiHoaToc.Value = CauHinhService.Current.PhiHoaToc;

            numMienPhiThuong.Value = CauHinhService.Current.MienPhiThuong;
            numMienPhiCPN.Value = CauHinhService.Current.MienPhiCPN;

            numPhiVisaMaster.Value = CauHinhService.Current.TiLePhiVisaMaster;
            numPhiAmexDiscover.Value = CauHinhService.Current.TiLePhiAmexDiscover;

            txtEmailAdmin.Text = CauHinhService.Current.EmailAdmin;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinhService.Current.PhiThuong = numPhiThuong.Value;
            CauHinhService.Current.PhiCPN = numPhiCPN.Value;
            CauHinhService.Current.PhiHoaToc = numPhiHoaToc.Value;

            CauHinhService.Current.MienPhiThuong = numMienPhiThuong.Value;
            CauHinhService.Current.MienPhiCPN = numMienPhiCPN.Value;

            CauHinhService.Current.TiLePhiVisaMaster = numPhiVisaMaster.Value;
            CauHinhService.Current.TiLePhiAmexDiscover = numPhiAmexDiscover.Value;

            CauHinhService.Current.EmailAdmin = txtEmailAdmin.Text.Trim();

            MessageBox.Show("Cập nhật và áp dụng cấu hình hệ thống thành công!\nBiểu phí vận chuyển và lệ phí thẻ mới đã sẵn sàng phục vụ khách hàng.",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khôi phục toàn bộ cấu hình về giá trị mặc định của cửa hàng ABC?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CauHinhService.Current = new CauHinhHeThong
                {
                    PhiThuong = 30000m,
                    PhiCPN = 50000m,
                    PhiHoaToc = 80000m,
                    MienPhiThuong = 1000000m,
                    MienPhiCPN = 5000000m,
                    TiLePhiVisaMaster = 1.0m,
                    TiLePhiAmexDiscover = 1.5m,
                    EmailAdmin = "admin.eshopping@abcstore.com"
                };
                HienThiGiaTri();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
