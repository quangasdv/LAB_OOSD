using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmPhanCongHDV : Form
    {
        private readonly HDVService _service = new HDVService();

        public FrmPhanCongHDV()
        {
            InitializeComponent();
        }

        private void FrmPhanCongHDV_Load(object sender, EventArgs e)
        {
            NapDanhSachHDV();
            NapDoiTuongPhanCong();
            TaiDanhSachPhanCong();
            LamMoiPhanCong();
            LamMoiNV();
        }

        private void NapDanhSachHDV()
        {
            DataTable dt = _service.LayDanhSachHDV();
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Nạp combo HDV phân công
            DataTable dtCombo = dt.Copy();
            dtCombo.Columns.Add("HienThi", typeof(string));
            foreach (DataRow r in dtCombo.Rows)
            {
                r["HienThi"] = string.Format("{0} - {1} (SĐT: {2})", r["MaNV"], r["HoTen"], r["DienThoai"]);
            }

            cboHDV.DataSource = dtCombo;
            cboHDV.DisplayMember = "HienThi";
            cboHDV.ValueMember = "MaNV";

            // Nạp combo lọc
            DataTable dtLoc = dt.Copy();
            DataRow allRow = dtLoc.NewRow();
            allRow["MaNV"] = "";
            allRow["HoTen"] = "-- Tất cả Hướng dẫn viên --";
            allRow["DienThoai"] = "";
            allRow["LuongCoBan"] = 0;
            allRow["ThuLaoMoiTour"] = 0;
            dtLoc.Rows.InsertAt(allRow, 0);

            cboLocHDV.DataSource = dtLoc;
            cboLocHDV.DisplayMember = "HoTen";
            cboLocHDV.ValueMember = "MaNV";
        }

        private void NapDoiTuongPhanCong()
        {
            if (rdoChuyen.Checked)
            {
                lblDoiTuong.Text = "Chọn Chuyến lẻ:";
                DataTable dtChuyen = _service.LayDanhSachChuyenDePhanCong();
                cboDoiTuong.DataSource = dtChuyen;
                cboDoiTuong.DisplayMember = "HienThi";
                cboDoiTuong.ValueMember = "MaChuyen";
            }
            else
            {
                lblDoiTuong.Text = "Chọn Tour Đoàn:";
                DataTable dtDoan = _service.LayDanhSachDoanDePhanCong();
                cboDoiTuong.DataSource = dtDoan;
                cboDoiTuong.DisplayMember = "HienThi";
                cboDoiTuong.ValueMember = "SoPhieuDK";
            }
        }

        private void TaiDanhSachPhanCong()
        {
            string maNV = cboLocHDV.SelectedValue == null ? "" : cboLocHDV.SelectedValue.ToString();
            dgvPhanCong.DataSource = _service.LayDanhSachPhanCong(maNV);
            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LamMoiPhanCong()
        {
            txtMaPhanCong.Text = "PC" + DateTime.Now.ToString("yyyyMMddHHmmss");
            lblKetQuaKiemTra.Text = "Sẵn sàng kiểm tra xung đột lịch trình...";
            lblKetQuaKiemTra.ForeColor = Color.ForestGreen;
            NapDoiTuongPhanCong();
        }

        private void rdoLoai_CheckedChanged(object sender, EventArgs e)
        {
            NapDoiTuongPhanCong();
        }

        private void cboDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cboDoiTuong.SelectedItem as DataRowView;
            if (row != null)
            {
                if (rdoChuyen.Checked)
                {
                    DateTime ngayDi = Convert.ToDateTime(row["NgayDi"]);
                    DateTime ngayVe = Convert.ToDateTime(row["NgayVe"]);
                    dtpNgayBatDau.Value = ngayDi;
                    dtpNgayKetThuc.Value = ngayVe;
                    lblChiTietDoiTuong.Text = string.Format("Chuyến lẻ: {0} ({1}) | Quy mô: {2}/{3} vé đã bán | Khởi hành: {4:dd/MM/yyyy} - Về: {5:dd/MM/yyyy}",
                        row["MaChuyen"], row["TenTour"], row["SoVeDaBan"], row["SoVeToiDa"], ngayDi, ngayVe);
                }
                else
                {
                    DateTime ngayDi = Convert.ToDateTime(row["NgayDi"]);
                    DateTime ngayVe = Convert.ToDateTime(row["NgayVeDuKien"]);
                    dtpNgayBatDau.Value = ngayDi;
                    dtpNgayKetThuc.Value = ngayVe;
                    lblChiTietDoiTuong.Text = string.Format("Tour Đoàn: {0} | Cơ quan: {1} | Số phiếu: {2} | Dự kiến từ: {3:dd/MM/yyyy} đến: {4:dd/MM/yyyy}",
                        row["TenTour"], row["TenCoQuan"], row["SoPhieuDK"], ngayDi, ngayVe);
                }
            }
            KiemTraLichHienTai();
        }

        private void cboHDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiemTraLichHienTai();
        }

        private void KiemTraLichHienTai()
        {
            string maNV = cboHDV.SelectedValue == null ? "" : cboHDV.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maNV)) return;

            KetQuaXuLy kq = _service.KiemTraTrungLich(maNV, dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
            if (kq.ThanhCong)
            {
                lblKetQuaKiemTra.Text = "✓ HDV rảnh rỗi, không bị trùng lịch công tác.";
                lblKetQuaKiemTra.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblKetQuaKiemTra.Text = "✗ CẢNH BÁO: HDV ĐANG BỊ TRÙNG LỊCH CÔNG TÁC!";
                lblKetQuaKiemTra.ForeColor = Color.Red;
            }
        }

        private void btnKiemTraLich_Click(object sender, EventArgs e)
        {
            string maNV = cboHDV.SelectedValue == null ? "" : cboHDV.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn hướng dẫn viên cần kiểm tra lịch.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KetQuaXuLy kq = _service.KiemTraTrungLich(maNV, dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
            if (kq.ThanhCong)
            {
                MessageBox.Show("Lịch công tác hợp lệ!\nHướng dẫn viên hoàn toàn rảnh rỗi trong khoảng thời gian này.", 
                    "Kiểm tra lịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Xung đột lịch trình", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuuPhanCong_Click(object sender, EventArgs e)
        {
            string maPC = txtMaPhanCong.Text.Trim();
            string maNV = cboHDV.SelectedValue == null ? "" : cboHDV.SelectedValue.ToString();
            bool theoChuyen = rdoChuyen.Checked;
            string maChuyen = theoChuyen && cboDoiTuong.SelectedValue != null ? cboDoiTuong.SelectedValue.ToString() : null;
            string soPhieuDK = !theoChuyen && cboDoiTuong.SelectedValue != null ? cboDoiTuong.SelectedValue.ToString() : null;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;

            KetQuaXuLy kq = _service.PhanCong(maPC, maNV, theoChuyen, maChuyen, soPhieuDK, ngayBatDau, ngayKetThuc);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachPhanCong();
                LamMoiPhanCong();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Không thể phân công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyPhanCong_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch phân công cần hủy trong bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPC = Convert.ToString(dgvPhanCong.CurrentRow.Cells["MaPhanCong"].Value);
            string tenHDV = Convert.ToString(dgvPhanCong.CurrentRow.Cells["HoTenHDV"].Value);
            string tenTour = Convert.ToString(dgvPhanCong.CurrentRow.Cells["TenTour"].Value);

            if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn hủy phân công [{0}] của HDV [{1}] cho tour [{2}]?", maPC, tenHDV, tenTour),
                "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetQuaXuLy kq = _service.XoaPhanCong(maPC);
                if (kq.ThanhCong)
                {
                    MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachPhanCong();
                }
                else
                {
                    MessageBox.Show(kq.ThongBao, "Lỗi khi hủy phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboLocHDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDanhSachPhanCong();
        }

        private void btnLamMoiPhanCong_Click(object sender, EventArgs e)
        {
            LamMoiPhanCong();
        }

        // ==========================================
        // QUẢN LÝ NHÂN VIÊN HDV (TAB 2)
        // ==========================================
        private void LamMoiNV()
        {
            txtMaNV.Clear();
            txtHoTenNV.Clear();
            txtDienThoaiNV.Clear();
            numLuongCoBan.Value = 8000000;
            numThuLaoTour.Value = 1500000;
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhanVien.CurrentRow != null)
            {
                DataRowView row = dgvNhanVien.CurrentRow.DataBoundItem as DataRowView;
                if (row != null)
                {
                    txtMaNV.Text = Convert.ToString(row["MaNV"]);
                    txtHoTenNV.Text = Convert.ToString(row["HoTen"]);
                    txtDienThoaiNV.Text = Convert.ToString(row["DienThoai"]);
                    numLuongCoBan.Value = Convert.ToDecimal(row["LuongCoBan"]);
                    numThuLaoTour.Value = Convert.ToDecimal(row["ThuLaoMoiTour"]);
                    txtMaNV.Enabled = false; // Khóa mã khi xem chi tiết
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVienHDV nv = new NhanVienHDV
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTenNV.Text.Trim(),
                DienThoai = txtDienThoaiNV.Text.Trim(),
                LuongCoBan = numLuongCoBan.Value,
                ThuLaoMoiTour = numThuLaoTour.Value
            };

            KetQuaXuLy kq = _service.LuuHDV(nv, false);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NapDanhSachHDV();
                LamMoiNV();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi thêm HDV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            NhanVienHDV nv = new NhanVienHDV
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTenNV.Text.Trim(),
                DienThoai = txtDienThoaiNV.Text.Trim(),
                LuongCoBan = numLuongCoBan.Value,
                ThuLaoMoiTour = numThuLaoTour.Value
            };

            KetQuaXuLy kq = _service.LuuHDV(nv, true);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NapDanhSachHDV();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi cập nhật HDV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn hướng dẫn viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa hướng dẫn viên [{0}] - {1}?", maNV, txtHoTenNV.Text),
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetQuaXuLy kq = _service.XoaHDV(maNV);
                if (kq.ThanhCong)
                {
                    MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NapDanhSachHDV();
                    LamMoiNV();
                }
                else
                {
                    MessageBox.Show(kq.ThongBao, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            LamMoiNV();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
