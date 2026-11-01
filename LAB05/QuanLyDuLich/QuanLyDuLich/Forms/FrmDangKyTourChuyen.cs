using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmDangKyTourChuyen : Form
    {
        private readonly ChuyenService _service = new ChuyenService();
        private decimal _donGiaHienTai = 0;
        private int _soVeConLai = 0;

        public FrmDangKyTourChuyen()
        {
            InitializeComponent();
        }

        private void FrmDangKyTourChuyen_Load(object sender, EventArgs e)
        {
            // Thiết lập các điểm đón cố định theo quy định của công ty
            cboDiemDon.Items.Clear();
            cboDiemDon.Items.Add("Điểm 1: Trụ sở Công ty Du lịch Văn Hóa Việt (123 Lê Lợi, Q.1)");
            cboDiemDon.Items.Add("Điểm 2: Bưu điện Thành phố / Nhà thờ Đức Bà (Q.1)");
            cboDiemDon.Items.Add("Điểm 3: Vòng xoay Hàng Xanh (Bình Thạnh)");
            cboDiemDon.Items.Add("Điểm 4: Bến xe Miền Đông mới (TP. Thủ Đức)");
            cboDiemDon.Items.Add("Điểm 5: Sân bay Quốc tế Tân Sơn Nhất (Cột 12 Ga quốc nội)");
            cboDiemDon.SelectedIndex = 0;

            // Hình thức thanh toán
            cboHinhThucTT.Items.Clear();
            cboHinhThucTT.Items.Add("Chuyển khoản Vietcombank");
            cboHinhThucTT.Items.Add("Thẻ tín dụng (POS)");
            cboHinhThucTT.Items.Add("Tiền mặt tại quầy vé");
            cboHinhThucTT.SelectedIndex = 0;

            // Ngày mặc định tạo chuyến mới
            dtpNgayDi.Value = DateTime.Today.AddDays(5);
            dtpNgayVe.Value = DateTime.Today.AddDays(8);

            NapDanhSachTour();
            NapDanhSachChuyen();
            TaiLichSuDangKy();
            LamMoi();
        }

        private void NapDanhSachTour()
        {
            DataTable dt = _service.LayDanhSachTour();
            cboTour.DataSource = dt;
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";
        }

        private void NapDanhSachChuyen()
        {
            DataTable dt = _service.LayDanhSachChuyen();
            dgvChuyen.DataSource = dt;
            dgvChuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Nạp combo chuyến cho khách lẻ chọn mua
            DataTable dtCombo = _service.LayDanhSachChuyen("", false);
            DataTable dtDisplay = dtCombo.Clone();
            dtDisplay.Columns.Add("HienThi", typeof(string));

            foreach (DataRow r in dtCombo.Rows)
            {
                DataRow nr = dtDisplay.NewRow();
                nr.ItemArray = r.ItemArray;
                string maChuyen = Convert.ToString(r["MaChuyen"]);
                string tenTour = Convert.ToString(r["TenTour"]);
                DateTime ngayDi = Convert.ToDateTime(r["NgayDi"]);
                int veCon = Convert.ToInt32(r["SoVeConLai"]);
                string tt = Convert.ToString(r["TrangThai"]);

                nr["HienThi"] = string.Format("{0} - {1} (Khởi hành: {2:dd/MM/yyyy} - Còn {3} chỗ - {4})",
                    maChuyen, tenTour, ngayDi, veCon, tt);
                dtDisplay.Rows.Add(nr);
            }

            cboChuyen.DataSource = dtDisplay;
            cboChuyen.DisplayMember = "HienThi";
            cboChuyen.ValueMember = "MaChuyen";
        }

        private void TaiLichSuDangKy(string timKiem = "")
        {
            dgvLichSu.DataSource = _service.LayLichSuDangKyChuyen(timKiem);
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LamMoi()
        {
            txtSoPhieu.Text = "PDC" + DateTime.Now.ToString("yyyyMMddHHmmss");
            txtHoTen.Clear();
            txtCMND.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            numSoLuongVe.Value = 2; // Mặc định < 12 vé theo chuẩn khách lẻ
            txtMaChuyenMoi.Text = "CHY" + DateTime.Now.ToString("yyMMddHHmm");

            CapNhatChiPhi();
            txtHoTen.Focus();
        }

        private void cboChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cboChuyen.SelectedItem as DataRowView;
            if (row != null)
            {
                _donGiaHienTai = Convert.ToDecimal(row["DonGia"]);
                DateTime ngayDi = Convert.ToDateTime(row["NgayDi"]);
                DateTime ngayVe = Convert.ToDateTime(row["NgayVe"]);
                int soVeToiDa = Convert.ToInt32(row["SoVeToiDa"]);
                int soVeDaBan = Convert.ToInt32(row["SoVeDaBan"]);
                _soVeConLai = Convert.ToInt32(row["SoVeConLai"]);
                string trangThai = Convert.ToString(row["TrangThai"]);

                lblThongTinChuyen.Text = string.Format("Tour: {0}\nThời gian: Từ {1:dd/MM/yyyy} đến {2:dd/MM/yyyy}  |  Giá vé: {3:N0} đ/khách",
                    row["TenTour"], ngayDi, ngayVe, _donGiaHienTai);

                lblSoChoTrong.Text = string.Format("Quy mô: {0} vé  |  Đã bán: {1} vé  |  CÒN TRỐNG: {2} VÉ ({3})",
                    soVeToiDa, soVeDaBan, _soVeConLai, trangThai);

                if (_soVeConLai <= 0 || trangThai == "Đã hết vé")
                {
                    lblSoChoTrong.ForeColor = Color.Red;
                }
                else
                {
                    lblSoChoTrong.ForeColor = Color.DarkGreen;
                }
            }
            CapNhatChiPhi();
        }

        private void numSoLuongVe_ValueChanged(object sender, EventArgs e)
        {
            CapNhatChiPhi();
        }

        private void CapNhatChiPhi()
        {
            int soVe = (int)numSoLuongVe.Value;
            decimal tongTien = soVe * _donGiaHienTai;

            lblTongTien.Text = string.Format("Tổng tiền vé (Thanh toán 100%): {0:N0} VNĐ", tongTien);

            // Kiểm tra quy tắc nghiệp vụ: Khách lẻ < 12 vé
            if (soVe >= 12)
            {
                lblCanhBaoSoVe.Text = "Cảnh báo: >= 12 vé là Khách đoàn (Nên đăng ký tour đoàn để hưởng ưu đãi!)";
                lblCanhBaoSoVe.ForeColor = Color.Red;
            }
            else
            {
                lblCanhBaoSoVe.Text = "Hợp lệ: Khách lẻ dưới 12 người (< 12 vé).";
                lblCanhBaoSoVe.ForeColor = Color.ForestGreen;
            }
        }

        private void btnXacNhanDatVe_Click(object sender, EventArgs e)
        {
            string soPhieu = txtSoPhieu.Text.Trim();
            string maChuyen = cboChuyen.SelectedValue == null ? "" : cboChuyen.SelectedValue.ToString();
            string hoTen = txtHoTen.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            int soLuongVe = (int)numSoLuongVe.Value;
            string diemDon = cboDiemDon.SelectedItem == null ? "" : cboDiemDon.SelectedItem.ToString();
            string hinhThucTT = cboHinhThucTT.SelectedItem == null ? "Tiền mặt" : cboHinhThucTT.SelectedItem.ToString();

            // Gọi ChuyenService xử lý giao dịch
            KetQuaXuLy kq = _service.DangKyChuyen(soPhieu, maChuyen, hoTen, cmnd, sdt, diaChi, soLuongVe, diemDon, hinhThucTT);

            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NapDanhSachChuyen();
                TaiLichSuDangKy();
                LamMoi();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Không thể đăng ký vé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoChuyen_Click(object sender, EventArgs e)
        {
            string maChuyen = txtMaChuyenMoi.Text.Trim();
            string maTour = cboTour.SelectedValue == null ? "" : cboTour.SelectedValue.ToString();
            DateTime ngayDi = dtpNgayDi.Value;
            DateTime ngayVe = dtpNgayVe.Value;
            int soVeToiDa = (int)numSoVeToiDa.Value;

            KetQuaXuLy kq = _service.TaoChuyenMoi(maChuyen, maTour, ngayDi, ngayVe, soVeToiDa);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NapDanhSachChuyen();
                txtMaChuyenMoi.Text = "CHY" + DateTime.Now.ToString("yyMMddHHmm");
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi tạo chuyến", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu đăng ký vé lẻ cần hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhieu = Convert.ToString(dgvLichSu.CurrentRow.Cells["SoPhieuChuyen"].Value);
            string tenKhach = Convert.ToString(dgvLichSu.CurrentRow.Cells["HoTenKhach"].Value);

            if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn hủy phiếu vé [{0}] của khách [{1}]?\nSố chỗ sẽ được tự động hoàn lại cho chuyến đi.", soPhieu, tenKhach),
                "Xác nhận hủy vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetQuaXuLy kq = _service.HuyPhieuChuyen(soPhieu);
                if (kq.ThanhCong)
                {
                    MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NapDanhSachChuyen();
                    TaiLichSuDangKy();
                }
                else
                {
                    MessageBox.Show(kq.ThongBao, "Lỗi khi hủy vé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiLichSuDangKy(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
