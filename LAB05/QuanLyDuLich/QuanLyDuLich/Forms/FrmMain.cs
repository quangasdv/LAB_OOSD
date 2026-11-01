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
            // Mở form Đăng ký tour theo đoàn (>= 12 người)
            using (FrmDangKyTourDoan f = new FrmDangKyTourDoan())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDangKyChuyen_Click(object sender, EventArgs e)
        {
            // Mở form Đăng ký tour theo chuyến (Khách lẻ < 12 người)
            using (FrmDangKyTourChuyen f = new FrmDangKyTourChuyen())
            {
                f.ShowDialog(this);
            }
        }

        private void btnQuanLyTour_Click(object sender, EventArgs e)
        {
            // Mở form Quản lý danh mục tour & lộ trình
            using (FrmTour f = new FrmTour())
            {
                f.ShowDialog(this);
            }
        }

        private void btnPhanCongHDV_Click(object sender, EventArgs e)
        {
            // Mở form Quản lý & Phân công Hướng dẫn viên
            using (FrmPhanCongHDV f = new FrmPhanCongHDV())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Mở form Báo cáo & Thống kê doanh thu, lương HDV
            using (FrmThongKe f = new FrmThongKe())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            string thongTin = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM - CHÍNH SÁCH TOUR\n\n" +
                              "1. Quy định Đăng ký Tour theo đoàn (>= 12 người):\n" +
                              "   - Số lượng khách: Tối thiểu từ 12 người trở lên.\n" +
                              "   - Quyền lợi: Được chọn ngày khởi hành tùy ý, có xe đến đón tại điểm riêng của đoàn.\n" +
                              "   - Đặt cọc: Bắt buộc đặt cọc trước 30% tổng kinh phí (khách hủy tour sẽ mất cọc).\n" +
                              "   - Bảo hiểm: Đoàn mua bảo hiểm phải cung cấp danh sách thành viên cùng đi.\n\n" +
                              "2. Quy định Khách lẻ (dưới 12 người):\n" +
                              "   - Phải đăng ký mua vé theo các chuyến định sẵn của công ty.\n" +
                              "   - Điểm đón: Theo các địa điểm quy định của công ty.\n" +
                              "   - Thanh toán: Phải thanh toán 100% tiền vé ngay khi đăng ký.\n\n" +
                              "3. Quy định Hướng dẫn viên (HDV):\n" +
                              "   - Phân công đúng 1 HDV cho mỗi chuyến khách lẻ, nhiều HDV cho đoàn đông.\n" +
                              "   - Tuyệt đối không để xảy ra chồng chéo lịch trình công tác của HDV.\n" +
                              "   - Thu nhập tháng = Lương cơ bản + (Số tour dẫn * Thù lao mỗi tour).";
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
