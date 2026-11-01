using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService _service = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today.AddMonths(1);

            numThang.Value = DateTime.Today.Month;
            numNam.Value = DateTime.Today.Year;

            TaiBaoCao();
            TaiBangLuongHDV();
        }

        private void TaiBaoCao()
        {
            DateTime tu = dtpTuNgay.Value;
            DateTime den = dtpDenNgay.Value;

            // 1. Tải KPI Tổng quan
            DataTable dtKpi = _service.LayTongQuanKPI(tu, den);
            if (dtKpi.Rows.Count > 0)
            {
                DataRow r = dtKpi.Rows[0];
                decimal doanhThuDoan = Convert.ToDecimal(r["DoanhThuDoan"]);
                decimal tienCocDoan = Convert.ToDecimal(r["TongTienCocThu"]);
                decimal doanhThuLe = Convert.ToDecimal(r["DoanhThuKhachLe"]);
                decimal tongDoanhThu = doanhThuDoan + doanhThuLe;

                int tongKhachDoan = Convert.ToInt32(r["TongKhachDoan"]);
                int tongVeLe = Convert.ToInt32(r["TongVeLeDaBan"]);
                int tongKhach = tongKhachDoan + tongVeLe;

                lblKpiTongDoanhThu.Text = string.Format("{0:N0} VNĐ", tongDoanhThu);
                lblKpiDoan.Text = string.Format("{0:N0} đ (Cọc: {1:N0} đ)", doanhThuDoan, tienCocDoan);
                lblKpiLe.Text = string.Format("{0:N0} VNĐ ({1} vé)", doanhThuLe, tongVeLe);
                lblKpiKhach.Text = string.Format("{0:N0} Khách ({1} đoàn, {2} vé lẻ)", tongKhach, r["TongSoDoan"], tongVeLe);
            }

            // 2. Thống kê theo Tour
            DataTable dtTour = _service.ThongKeDoanhThuTheoTour(tu, den);
            dgvTourRevenue.DataSource = dtTour;
            dgvTourRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 3. Nhật ký Giao dịch
            DataTable dtGiaoDich = _service.LayChiTietGiaoDich(tu, den);
            dgvGiaoDich.DataSource = dtGiaoDich;
            dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TaiBangLuongHDV()
        {
            int thang = (int)numThang.Value;
            int nam = (int)numNam.Value;

            DataTable dtHDV = _service.ThongKeLuongVaThuLaoHDV(thang, nam);
            dgvHDVRevenue.DataSource = dtHDV;
            dgvHDVRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            TaiBaoCao();
        }

        private void btnTinhLuongHDV_Click(object sender, EventArgs e)
        {
            TaiBangLuongHDV();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today.AddMonths(1);
            TaiBaoCao();
            TaiBangLuongHDV();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
