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
            MessageBox.Show("Chức năng QUẢN LÝ LỆ PHÍ HẰNG NĂM:\n\n" +
                            "- Theo dõi tình trạng nộp lệ phí năm của bệnh nhân\n" +
                            "- Thu tiền gia hạn lệ phí năm (cố định trong 1 năm)\n" +
                            "- Xuất phiếu biên nhận thu lệ phí.",
                            "Lệ phí năm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHoSoBenhAn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng QUẢN LÝ HỒ SƠ BỆNH ÁN:\n\n" +
                            "- Tra cứu lý lịch bệnh án theo Mã HS hoặc SĐT / Họ tên\n" +
                            "- Xem thông tin bìa hồ sơ: Ảnh 3x4, ngày cấp, hạn lệ phí năm\n" +
                            "- Quản lý tiền sử bệnh tật bản thân và gia đình\n" +
                            "- Cảnh báo tiền sử dị ứng thuốc và phản ứng phụ trong các lần khám.",
                            "Hồ sơ bệnh án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng KHÁM BỆNH & GHI NHẬN TRIỆU CHỨNG:\n\n" +
                            "- Thăm khám lâm sàng, đo các chỉ số sinh hiệu (nhiệt độ, huyết áp, mạch)\n" +
                            "- Tạo Phiếu khám bệnh mới cho đợt khám hiện tại\n" +
                            "- Ghi nhận triệu chứng lâm sàng (sốt, nhức đầu...)\n" +
                            "- Đưa ra kết luận chẩn đoán sơ bộ.",
                            "Khám bệnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChiDinhXN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng CHỈ ĐỊNH XÉT NGHIỆM:\n\n" +
                            "- Bác sĩ lập Phiếu chỉ định các xét nghiệm cần thiết\n" +
                            "- KTV tiếp nhận mẫu, thực hiện kỹ thuật cận lâm sàng\n" +
                            "- Cập nhật kết quả xét nghiệm gửi về cho bác sĩ điều trị.",
                            "Xét nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKeToaThuoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng KÊ TOA THUỐC:\n\n" +
                            "- Kê toa thuốc điều trị tương ứng với triệu chứng và chẩn đoán bệnh\n" +
                            "- Tự động kiểm tra tương tác thuốc và tiền sử dị ứng thuốc cũ\n" +
                            "- Bác sĩ điều chỉnh thuốc an toàn trước khi lưu toa\n" +
                            "- Dặn dò liều dùng và bàn giao toa thuốc cho bệnh nhân.",
                            "Toa thuốc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng LỊCH KHÁM ĐỊNH KỲ:\n\n" +
                            "- Đặt lịch hẹn tái khám định kỳ theo dõi bệnh nhân mạn tính\n" +
                            "- Ghi nhận ngày hẹn, nội dung khám và lời dặn dò chuẩn bị.",
                            "Lịch hẹn khám", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHoanTatDieuTri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng HOÀN TẤT ĐỢT ĐIỀU TRỊ:\n\n" +
                            "- Đánh giá kết quả điều trị (Khỏi bệnh, Thuyên giảm, Nặng hơn...)\n" +
                            "- Ghi nhận tình trạng sức khỏe xuất viện và lời dặn sau điều trị\n" +
                            "- Quyết toán viện phí và cập nhật thông tin bệnh án lâu dài.",
                            "Hoàn tất điều trị", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng QUẢN LÝ DANH MỤC:\n\n" +
                            "- Danh mục thuốc và chống chỉ định\n" +
                            "- Danh mục xét nghiệm và đơn giá\n" +
                            "- Danh mục khoa phòng và bác sĩ điều trị.",
                            "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
