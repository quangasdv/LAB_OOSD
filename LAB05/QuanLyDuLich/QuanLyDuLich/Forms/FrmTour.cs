using System;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmTour : Form
    {
        private readonly TourService _service = new TourService();

        public FrmTour()
        {
            InitializeComponent();
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            LamMoi();
        }

        private void TaiDuLieu()
        {
            dgvTour.DataSource = _service.LayDanhSachTour(txtTimKiem.Text.Trim());
            dgvTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private Tour LayDuLieuForm()
        {
            return new Tour
            {
                MaTour = txtMaTour.Text.Trim(),
                TenTour = txtTenTour.Text.Trim(),
                SoNgay = (int)numSoNgay.Value,
                SoDem = (int)numSoDem.Value,
                DonGia = numDonGia.Value,
                DiemXuatPhat = txtDiemXuatPhat.Text.Trim()
            };
        }

        private void HienKetQua(KetQuaXuLy kq)
        {
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiDuLieu();
                LamMoi();
            }
        }

        private void LamMoi()
        {
            txtMaTour.Clear();
            txtTenTour.Clear();
            numSoNgay.Value = 3;
            numSoDem.Value = 2;
            numDonGia.Value = 2500000;
            txtDiemXuatPhat.Text = "TP.HCM";
            txtMaTour.ReadOnly = false;
            txtMaTour.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HienKetQua(_service.LuuTour(LayDuLieuForm(), false));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienKetQua(_service.LuuTour(LayDuLieuForm(), true));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTour.Text))
            {
                MessageBox.Show("Vui lòng chọn tour cần xóa từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tour [" + txtMaTour.Text.Trim() + "]?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HienKetQua(_service.XoaTour(txtMaTour.Text.Trim()));
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.CurrentRow != null)
            {
                var row = dgvTour.CurrentRow;
                txtMaTour.Text = Convert.ToString(row.Cells["MaTour"].Value);
                txtTenTour.Text = Convert.ToString(row.Cells["TenTour"].Value);
                numSoNgay.Value = Convert.ToDecimal(row.Cells["SoNgay"].Value);
                numSoDem.Value = Convert.ToDecimal(row.Cells["SoDem"].Value);
                numDonGia.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
                txtDiemXuatPhat.Text = Convert.ToString(row.Cells["DiemXuatPhat"].Value);
                txtMaTour.ReadOnly = true; // Khóa mã tour khi đang chỉnh sửa
            }
        }
    }
}
