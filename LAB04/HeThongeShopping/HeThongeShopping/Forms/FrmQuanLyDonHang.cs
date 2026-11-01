using System;
using System.Data;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmQuanLyDonHang : Form
    {
        private readonly DonHangService _donHangService = new DonHangService();
        private string _selectedMaDH = "";

        public FrmQuanLyDonHang()
        {
            InitializeComponent();
        }

        private void FrmQuanLyDonHang_Load(object sender, EventArgs e)
        {
            cboTrangThai.SelectedIndex = 0;
            cboTrangThaiMoi.SelectedIndex = 0;
            TaiDanhSachDonHang();
        }

        private void TaiDanhSachDonHang()
        {
            string kw = txtTimKiem.Text.Trim();
            string tt = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Tất cả";
            try
            {
                DataTable dt = _donHangService.LayDanhSachDonHang(kw, tt);
                dgvDonHang.DataSource = dt;

                if (dgvDonHang.Rows.Count > 0)
                {
                    dgvDonHang.Rows[0].Selected = true;
                    HienThiChiTietDon(Convert.ToString(dgvDonHang.Rows[0].Cells["colMaDH"].Value));
                }
                else
                {
                    _selectedMaDH = "";
                    lblDonDangChon.Text = "Đơn hàng: [Không có]";
                    dgvChiTiet.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiChiTietDon(string maDH)
        {
            _selectedMaDH = maDH;
            lblDonDangChon.Text = "Đơn hàng: " + _selectedMaDH;
            try
            {
                DataTable dtCT = _donHangService.LayChiTietDonHang(maDH);
                dgvChiTiet.DataSource = dtCT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDonHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null) return;
            string ma = Convert.ToString(dgvDonHang.CurrentRow.Cells["colMaDH"].Value);
            string tt = Convert.ToString(dgvDonHang.CurrentRow.Cells["colTrangThai"].Value);

            HienThiChiTietDon(ma);

            if (!string.IsNullOrEmpty(tt))
            {
                for (int i = 0; i < cboTrangThaiMoi.Items.Count; i++)
                {
                    if (cboTrangThaiMoi.Items[i].ToString() == tt)
                    {
                        cboTrangThaiMoi.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSachDonHang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cboTrangThai.SelectedIndex = 0;
            TaiDanhSachDonHang();
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDanhSachDonHang();
        }

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedMaDH))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ttMoi = cboTrangThaiMoi.SelectedItem != null ? cboTrangThaiMoi.SelectedItem.ToString() : "";
            KetQuaXuLy kq = _donHangService.CapNhatTrangThai(_selectedMaDH, ttMoi);

            if (kq.ThanhCong)
            {
                MessageBox.Show("Cập nhật đơn hàng [" + _selectedMaDH + "] sang trạng thái [" + ttMoi + "] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachDonHang();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedMaDH))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dtTT = _donHangService.LayThanhToanTheoDon(_selectedMaDH);
                if (dtTT.Rows.Count > 0)
                {
                    DataRow r = dtTT.Rows[0];
                    string msg = "THÔNG TIN THANH TOÁN THẺ CHO ĐƠN: " + _selectedMaDH + "\n\n"
                               + "- Loại thẻ: " + r["LoaiThe"] + "\n"
                               + "- Số thẻ: " + r["SoTheMasked"] + "\n"
                               + "- Chủ thẻ: " + r["TenChuThe"] + "\n"
                               + "- Lệ phí giao dịch: " + Convert.ToDecimal(r["LePhiGiaoDich"]).ToString("N0") + " đ\n"
                               + "- Ngày thanh toán: " + Convert.ToDateTime(r["NgayThanhToan"]).ToString("dd/MM/yyyy HH:mm:ss") + "\n"
                               + "- Kết quả: " + r["KetQuaThanhToan"];
                    MessageBox.Show(msg, "Chi tiết thanh toán thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đơn hàng này chưa có giao dịch thanh toán trực tuyến qua thẻ.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
