using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmDangKyTourDoan : Form
    {
        private readonly DangKyTourService _service = new DangKyTourService();
        private readonly BindingList<ThanhVienBaoHiemItem> _dsThanhVien = new BindingList<ThanhVienBaoHiemItem>();

        private decimal _donGiaTourHienTai = 0;

        public FrmDangKyTourDoan()
        {
            InitializeComponent();
        }

        private void FrmDangKyTourDoan_Load(object sender, EventArgs e)
        {
            // Thiết lập ràng buộc và nguồn dữ liệu
            dgvThanhVien.DataSource = _dsThanhVien;
            dgvThanhVien.AutoGenerateColumns = true;

            cboHinhThucTT.Items.AddRange(new object[] { "Chuyển khoản Vietcombank", "Thẻ tín dụng (POS)", "Tiền mặt tại quầy" });
            cboHinhThucTT.SelectedIndex = 0;

            dtpNgayDi.Value = DateTime.Today.AddDays(7);
            dtpNgaySinhTV.Value = new DateTime(1995, 1, 1);

            NapDanhSachTour();
            NapDanhSachKhachDoan();
            TaiLichSu();
            LamMoi();
        }

        private void NapDanhSachTour()
        {
            DataTable dtTour = _service.LayDanhSachTour();
            cboTour.DataSource = dtTour;
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";
        }

        private void NapDanhSachKhachDoan()
        {
            DataTable dtDoan = _service.LayDanhSachDoan();
            cboDoan.DataSource = dtDoan;
            cboDoan.DisplayMember = "TenCoQuan";
            cboDoan.ValueMember = "MaDoan";
        }

        private void TaiLichSu()
        {
            dgvLichSu.DataSource = _service.LayLichSuDangKyDoan();
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LamMoi()
        {
            txtSoPhieu.Text = "PDK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            txtDiemDon.Text = "Trụ sở cơ quan / Điểm hẹn riêng của đoàn";
            numSoNguoi.Value = 15; // Mặc định >= 12 người theo quy tắc
            chkCoBaoHiem.Checked = true;
            _dsThanhVien.Clear();

            // Mẫu thành viên bảo hiểm ban đầu để tiện thử nghiệm
            _dsThanhVien.Add(new ThanhVienBaoHiemItem { HoTen = "Trần Minh Trí (Trưởng đoàn)", NgaySinh = new DateTime(1986, 5, 10), CCCD = "079086001122" });
            _dsThanhVien.Add(new ThanhVienBaoHiemItem { HoTen = "Lê Thị Hồng Phúc", NgaySinh = new DateTime(1990, 8, 22), CCCD = "079090003344" });

            CapNhatChiPhi();
        }

        private void cboTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cboTour.SelectedItem as DataRowView;
            if (row != null)
            {
                _donGiaTourHienTai = Convert.ToDecimal(row["DonGia"]);
                int soNgay = Convert.ToInt32(row["SoNgay"]);
                int soDem = Convert.ToInt32(row["SoDem"]);
                lblThongTinTour.Text = string.Format("Thời lượng: {0} ngày {1} đêm  |  Đơn giá: {2:N0} đ/người  |  Xuất phát: {3}",
                    soNgay, soDem, _donGiaTourHienTai, row["DiemXuatPhat"]);
            }
            CapNhatChiPhi();
        }

        private void cboDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cboDoan.SelectedItem as DataRowView;
            if (row != null)
            {
                txtNguoiDaiDien.Text = Convert.ToString(row["NguoiDaiDien"]);
                txtDienThoaiDoan.Text = Convert.ToString(row["DienThoaiCoQuan"]);
                txtDiaChiDoan.Text = Convert.ToString(row["DiaChiCoQuan"]);
            }
        }

        private void numSoNguoi_ValueChanged(object sender, EventArgs e)
        {
            CapNhatChiPhi();
        }

        private void CapNhatChiPhi()
        {
            int soNguoi = (int)numSoNguoi.Value;
            decimal tongKinhPhi = soNguoi * _donGiaTourHienTai;
            decimal tienCoc = tongKinhPhi * 0.30m; // Bắt buộc 30%

            lblTongKinhPhi.Text = string.Format("{0:N0} VNĐ", tongKinhPhi);
            lblTienCoc.Text = string.Format("{0:N0} VNĐ", tienCoc);

            if (soNguoi < 12)
            {
                lblCanhBaoSoNguoi.Text = "Cảnh báo: Dưới 12 người không đủ chuẩn đoàn! Phải mua vé theo chuyến lẻ.";
                lblCanhBaoSoNguoi.ForeColor = Color.Red;
            }
            else
            {
                lblCanhBaoSoNguoi.Text = "Hợp lệ: Đủ điều kiện đăng ký theo đoàn (>= 12 người).";
                lblCanhBaoSoNguoi.ForeColor = Color.Green;
            }
        }

        private void chkCoBaoHiem_CheckedChanged(object sender, EventArgs e)
        {
            pnlBaoHiem.Enabled = chkCoBaoHiem.Checked;
        }

        private void btnThemTV_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTenTV.Text.Trim();
            string cccd = txtCCCDTV.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(cccd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và CCCD của thành viên mua bảo hiểm.", 
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dsThanhVien.Add(new ThanhVienBaoHiemItem
            {
                HoTen = hoTen,
                NgaySinh = dtpNgaySinhTV.Value,
                CCCD = cccd
            });

            txtHoTenTV.Clear();
            txtCCCDTV.Clear();
            txtHoTenTV.Focus();
        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            if (dgvThanhVien.CurrentRow != null && dgvThanhVien.CurrentRow.Index >= 0 && dgvThanhVien.CurrentRow.Index < _dsThanhVien.Count)
            {
                _dsThanhVien.RemoveAt(dgvThanhVien.CurrentRow.Index);
            }
        }

        private void btnXacNhanLapPhieu_Click(object sender, EventArgs e)
        {
            string soPhieu = txtSoPhieu.Text.Trim();
            string maTour = cboTour.SelectedValue == null ? "" : cboTour.SelectedValue.ToString();
            string maDoan = cboDoan.SelectedValue == null ? "" : cboDoan.SelectedValue.ToString();
            DateTime ngayDi = dtpNgayDi.Value;
            string diemDon = txtDiemDon.Text.Trim();
            int soNguoi = (int)numSoNguoi.Value;
            bool coBaoHiem = chkCoBaoHiem.Checked;
            string hinhThucTT = cboHinhThucTT.SelectedItem == null ? "Chuyển khoản" : cboHinhThucTT.SelectedItem.ToString();

            // Gọi Service xử lý theo kiến trúc 3 lớp
            List<ThanhVienBaoHiemItem> dsTV = new List<ThanhVienBaoHiemItem>(_dsThanhVien);
            KetQuaXuLy kq = _service.DangKyTourDoan(soPhieu, maTour, maDoan, ngayDi, diemDon, soNguoi, coBaoHiem, dsTV, hinhThucTT);

            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Lập phiếu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiLichSu();
                LamMoi();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Không thể lập phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemDoanMoi_Click(object sender, EventArgs e)
        {
            string maDoan = "DOAN" + DateTime.Now.ToString("yyMMddHHmm");
            string tenDoan = txtTenDoanMoi.Text.Trim();
            string diaChi = txtDiaChiMoi.Text.Trim();
            string sdt = txtSDTMoi.Text.Trim();
            string nguoiDD = txtNguoiDDMoi.Text.Trim();
            string email = txtEmailMoi.Text.Trim();

            KetQuaXuLy kq = _service.ThemKhachDoan(maDoan, tenDoan, diaChi, sdt, nguoiDD, email);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NapDanhSachKhachDoan();
                cboDoan.SelectedValue = maDoan;

                txtTenDoanMoi.Clear();
                txtDiaChiMoi.Clear();
                txtSDTMoi.Clear();
                txtNguoiDDMoi.Clear();
                txtEmailMoi.Clear();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi thêm đoàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLichSu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLichSu.CurrentRow != null)
            {
                string soPhieu = Convert.ToString(dgvLichSu.CurrentRow.Cells["SoPhieuDK"].Value);
                if (!string.IsNullOrEmpty(soPhieu))
                {
                    DataTable dtTV = _service.LayThanhVienBaoHiem(soPhieu);
                    lblSoThanhVienDaLuu.Text = string.Format("Phiếu [{0}] có {1} thành viên bảo hiểm kèm theo.", soPhieu, dtTV.Rows.Count);
                }
            }
        }

        private void btnLamMoiForm_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
