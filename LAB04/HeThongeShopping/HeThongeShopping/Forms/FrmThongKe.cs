using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly DonHangService _donHangService = new DonHangService();
        private readonly CultureInfo _viVn = new CultureInfo("vi-VN");

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dtTu.Value = new DateTime(now.Year, now.Month, 1);
            dtDen.Value = dtTu.Value.AddMonths(1).AddDays(-1);

            ThucHienThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            try
            {
                DateTime tu = dtTu.Value;
                DateTime den = dtDen.Value;

                // 1. Chỉ số tổng hợp
                DataTable dtTH = _donHangService.ThongKeTongHop(tu, den);
                if (dtTH.Rows.Count > 0)
                {
                    DataRow r = dtTH.Rows[0];
                    lblTongDon.Text = "Tổng số đơn hàng: " + Convert.ToString(r["TongDonHang"]);
                    decimal doanhThu = r["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(r["TongDoanhThu"]) : 0;
                    lblTongDoanhThu.Text = string.Format(_viVn, "Tổng doanh thu: {0:N0} đ", doanhThu);
                    lblDonThanhCong.Text = "Đơn xác nhận / hoàn tất: " + Convert.ToString(r["DonThanhCong"]);
                    lblDonCho.Text = "Đơn chờ xử lý: " + Convert.ToString(r["DonChoXuLy"]);
                    lblDonHuy.Text = "Đơn đã hủy: " + Convert.ToString(r["DonHuy"]);
                }

                // 2. Sản phẩm bán chạy
                DataTable dtSP = _donHangService.ThongKeSanPhamBanChay(tu, den);
                dgvSanPham.DataSource = dtSP;

                // 3. Thống kê theo loại thẻ
                DataTable dtThe = _donHangService.ThongKeLoaiThe(tu, den);
                dgvThe.DataSource = dtThe;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
