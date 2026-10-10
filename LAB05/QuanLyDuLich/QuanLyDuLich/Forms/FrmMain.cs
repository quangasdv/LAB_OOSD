using System;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDangKyDoan_Click(object sender, EventArgs e)
        {
            // Mở form Đăng ký tour theo đoàn
            using (FrmDangKyTourDoan f = new FrmDangKyTourDoan())
            {
                f.ShowDialog(this);
            }
        }

        private void btnQuanLyTour_Click(object sender, EventArgs e)
        {
            // Mở form Quản lý danh mục tour
            using (FrmTour f = new FrmTour())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            string thongTin = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM - CHÍNH SÁCH TOUR\n\n" +
                              "1. Quy định Đăng ký Tour theo đoàn:\n" +
                              "   - Số lượng khách đoàn: Tối thiểu từ 12 người trở lên.\n" +
                              "   - Quyền lợi đoàn: Được chọn ngày khởi hành tùy ý, có xe đưa đón tại điểm riêng của đoàn.\n" +
                              "   - Đặt cọc: Bắt buộc đặt cọc trước 30% tổng kinh phí (khách đoàn hủy tour sẽ mất cọc).\n" +
                              "   - Bảo hiểm: Đoàn mua bảo hiểm phải cung cấp danh sách thành viên cùng đi.\n\n" +
                              "2. Quy định Khách lẻ (dưới 12 người):\n" +
                              "   - Phải đăng ký mua vé theo các chuyến định sẵn của công ty và thanh toán 100% tiền vé.";
            MessageBox.Show(thongTin, "Chính sách & Quy định Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
