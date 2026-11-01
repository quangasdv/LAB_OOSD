using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();
        readonly CultureInfo viVn = new CultureInfo("vi-VN");

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

        private void btnTK_Click(object a, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThucHienThongKe();
        }

        void ThucHienThongKe()
        {
            try
            {
                DataTable dtTH = s.TongHop(dtTu.Value, dtDen.Value);
                if (dtTH != null && dtTH.Rows.Count > 0)
                {
                    DataRow r = dtTH.Rows[0];
                    lblPhieuDat.Text = "Phiếu đặt: " + Convert.ToString(r["SoPhieuDat"]);
                    lblDangO.Text = "Đang ở: " + Convert.ToString(r["DangO"]);
                    lblHoaDon.Text = "Hóa đơn: " + Convert.ToString(r["SoHoaDon"]);

                    decimal doanhThu = 0;
                    if (r["DoanhThuHoaDon"] != DBNull.Value)
                        decimal.TryParse(r["DoanhThuHoaDon"].ToString(), out doanhThu);
                    lblDoanhThu.Text = string.Format(viVn, "Doanh thu HĐ: {0:N0} đ", doanhThu);

                    decimal denBu = 0;
                    if (r["TongDenBu"] != DBNull.Value)
                        decimal.TryParse(r["TongDenBu"].ToString(), out denBu);
                    lblDenBu.Text = string.Format(viVn, "Tổng đền bù: {0:N0} đ", denBu);

                    dgvTongHop.DataSource = dtTH;
                }

                DataTable dtDV = s.DichVu(dtTu.Value, dtDen.Value);
                dgvDV.DataSource = dtDV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object a, EventArgs e)
        {
            Close();
        }
    }
}
