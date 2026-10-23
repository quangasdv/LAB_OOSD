using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmBangLuong : Form
    {
        public FrmBangLuong()
        {
            InitializeComponent();
        }

        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            cboThang.Text = "10";
            numNam.Value = 2026;
            TaiDuLieuBangLuong();
        }

        private void TaiDuLieuBangLuong()
        {
            try
            {
                int thang = int.Parse(cboThang.Text);
                int nam = (int)numNam.Value;

                string sql = "SELECT * FROM vw_BangLuongChiTietToanCongTy WHERE Thang = @Thang AND Nam = @Nam ORDER BY MaBangLuong";
                DataTable dt = Db.Query(sql, new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));
                dgvBangLuong.DataSource = dt;

                // Format tiêu đề và định dạng số tiền
                FormatBangLuongGrid();
                TinhTongFooter(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bảng lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatBangLuongGrid()
        {
            if (dgvBangLuong.Columns["MaBangLuong"] != null)
            {
                dgvBangLuong.Columns["MaBangLuong"].HeaderText = "Mã BL";
                dgvBangLuong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvBangLuong.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvBangLuong.Columns["TenPhongBan"].HeaderText = "Phòng ban";
                dgvBangLuong.Columns["TenChucVu"].HeaderText = "Chức vụ";
                dgvBangLuong.Columns["TongThuNhap"].HeaderText = "Tổng Thu Nhập";
                dgvBangLuong.Columns["LuongNgayCong"].HeaderText = "Lương Công";
                dgvBangLuong.Columns["TienPhuCapChucVu"].HeaderText = "PC Chức Vụ";
                dgvBangLuong.Columns["TienPhuCapDocHai"].HeaderText = "PC Độc Hại";
                dgvBangLuong.Columns["TienLuongPhuTroi"].HeaderText = "Lương OT (1.5x)";
                dgvBangLuong.Columns["TienKhenThuong"].HeaderText = "Thưởng";
                dgvBangLuong.Columns["TongKhauTru"].HeaderText = "Tổng Khấu Trừ";
                dgvBangLuong.Columns["TienTrichBHXH_BHYT"].HeaderText = "Trích BH (10.5%)";
                dgvBangLuong.Columns["TienPhatKyLuat"].HeaderText = "Phạt Kỷ Luật";
                dgvBangLuong.Columns["ThueTNCN"].HeaderText = "Thuế TNCN";
                dgvBangLuong.Columns["ThucLinh"].HeaderText = "THỰC LĨNH";
                dgvBangLuong.Columns["TrangThaiLuong"].HeaderText = "Trạng thái";

                string[] moneyCols = { "TongThuNhap", "LuongNgayCong", "TienPhuCapChucVu", "TienPhuCapDocHai",
                                       "TienLuongPhuTroi", "TienKhenThuong", "TongKhauTru", "TienTrichBHXH_BHYT",
                                       "TienPhatKyLuat", "ThueTNCN", "ThucLinh" };
                foreach (string col in moneyCols)
                {
                    if (dgvBangLuong.Columns[col] != null)
                    {
                        dgvBangLuong.Columns[col].DefaultCellStyle.Format = "#,##0";
                        dgvBangLuong.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }

                if (dgvBangLuong.Columns["ThucLinh"] != null)
                {
                    dgvBangLuong.Columns["ThucLinh"].DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                    dgvBangLuong.Columns["ThucLinh"].DefaultCellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                }
            }
        }

        private void TinhTongFooter(DataTable dt)
        {
            decimal tongDocHai = 0;
            decimal tongBH = 0;
            decimal tongThucLinh = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["TienPhuCapDocHai"] != DBNull.Value)
                    tongDocHai += Convert.ToDecimal(row["TienPhuCapDocHai"]);

                if (row["TienTrichBHXH_BHYT"] != DBNull.Value)
                    tongBH += Convert.ToDecimal(row["TienTrichBHXH_BHYT"]);

                if (row["ThucLinh"] != DBNull.Value)
                    tongThucLinh += Convert.ToDecimal(row["ThucLinh"]);
            }

            lblTongDocHai.Text = "Tổng PC Độc Hại Xưởng Sơn: " + tongDocHai.ToString("#,##0") + " đ";
            lblTongBH.Text = "Tổng trích BH (10.5%): " + tongBH.ToString("#,##0") + " đ";
            lblTongThucLinh.Text = "TỔNG THỰC LĨNH TOÀN CÔNG TY: " + tongThucLinh.ToString("#,##0") + " VNĐ";
        }

        private void btnTaiBangLuong_Click(object sender, EventArgs e)
        {
            TaiDuLieuBangLuong();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cboThang.Text);
            int nam = (int)numNam.Value;

            if (MessageBox.Show("Bạn có muốn thực hiện tính toán tiền lương tự động cho TOÀN BỘ NHÂN VIÊN trong Tháng " + thang + "/" + nam + "?\n\n" +
                                "- Tự động đối soát ngày công thực tế\n" +
                                "- Tự động tính tiền OT theo hệ số 1.5x / 2.0x / 3.0x từ phiếu đã duyệt\n" +
                                "- Tự động cộng phụ cấp độc hại cho nhân sự xưởng sơn\n" +
                                "- Tự động trích trừ BHXH/BHYT 10.5% cho HĐ dài hạn\n" +
                                "- Tự động tính thưởng lễ/tết và trừ phạt kỷ luật",
                                "Xác nhận tính lương tự động", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("EXEC sp_TinhLuongToanCongTy @Thang = @Thang, @Nam = @Nam, @NguoiThucHien = N'Ban Giám Đốc'",
                               new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));

                    MessageBox.Show("Đã hoàn tất tính lương tự động cho Tháng " + thang + "/" + nam + "!",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieuBangLuong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tính lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatPaySlip_Click(object sender, EventArgs e)
        {
            if (dgvBangLuong.CurrentRow != null)
            {
                var r = dgvBangLuong.CurrentRow;
                string maNV = r.Cells["MaNhanVien"].Value != null ? r.Cells["MaNhanVien"].Value.ToString() : "";
                string hoTen = r.Cells["HoTen"].Value != null ? r.Cells["HoTen"].Value.ToString() : "";
                string phongBan = r.Cells["TenPhongBan"].Value != null ? r.Cells["TenPhongBan"].Value.ToString() : "";
                string chucVu = r.Cells["TenChucVu"].Value != null ? r.Cells["TenChucVu"].Value.ToString() : "";
                string thang = cboThang.Text;
                string nam = numNam.Value.ToString();

                decimal luongCong = r.Cells["LuongNgayCong"].Value != null && r.Cells["LuongNgayCong"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["LuongNgayCong"].Value) : 0;
                decimal pcCV = r.Cells["TienPhuCapChucVu"].Value != null && r.Cells["TienPhuCapChucVu"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TienPhuCapChucVu"].Value) : 0;
                decimal pcDocHai = r.Cells["TienPhuCapDocHai"].Value != null && r.Cells["TienPhuCapDocHai"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TienPhuCapDocHai"].Value) : 0;
                decimal luongOT = r.Cells["TienLuongPhuTroi"].Value != null && r.Cells["TienLuongPhuTroi"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TienLuongPhuTroi"].Value) : 0;
                decimal tienThuong = r.Cells["TienKhenThuong"].Value != null && r.Cells["TienKhenThuong"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TienKhenThuong"].Value) : 0;
                decimal tongThuNhap = r.Cells["TongThuNhap"].Value != null && r.Cells["TongThuNhap"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TongThuNhap"].Value) : 0;

                decimal trichBH = r.Cells["TienTrichBHXH_BHYT"].Value != null && r.Cells["TienTrichBHXH_BHYT"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TienTrichBHXH_BHYT"].Value) : 0;
                decimal tienPhat = r.Cells["TienPhatKyLuat"].Value != null && r.Cells["TienPhatKyLuat"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TienPhatKyLuat"].Value) : 0;
                decimal thueTNCN = r.Cells["ThueTNCN"].Value != null && r.Cells["ThueTNCN"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["ThueTNCN"].Value) : 0;
                decimal tongKhauTru = r.Cells["TongKhauTru"].Value != null && r.Cells["TongKhauTru"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["TongKhauTru"].Value) : 0;
                decimal thucLinh = r.Cells["ThucLinh"].Value != null && r.Cells["ThucLinh"].Value != DBNull.Value ? Convert.ToDecimal(r.Cells["ThucLinh"].Value) : 0;

                string paySlip = string.Format(
                    "===========================================================\n" +
                    "           PHIẾU LƯƠNG CÁ NHÂN (PAY SLIP) - THÁNG {4}/{5}\n" +
                    "                   CÔNG TY SƠN ĐÔNG Á\n" +
                    "===========================================================\n" +
                    "Nhân viên: {1} ({0})\n" +
                    "Bộ phận:   {2} | Chức danh: {3}\n" +
                    "-----------------------------------------------------------\n" +
                    "I. CÁC KHOẢN THU NHẬP:\n" +
                    "  + Lương theo ngày công:       {6,15:N0} đ\n" +
                    "  + Phụ cấp chức vụ:            {7,15:N0} đ\n" +
                    "  + Phụ cấp độc hại xưởng sơn:  {8,15:N0} đ\n" +
                    "  + Lương giờ phụ trội (OT):    {9,15:N0} đ\n" +
                    "  + Tiền khen thưởng:           {10,15:N0} đ\n" +
                    "  ---------------------------------------------------------\n" +
                    "  => TỔNG THU NHẬP:             {11,15:N0} đ\n\n" +
                    "II. CÁC KHOẢN KHẤU TRỪ:\n" +
                    "  - Trích BHXH/BHYT (10.5%):    {12,15:N0} đ\n" +
                    "  - Phạt vi phạm kỷ luật:       {13,15:N0} đ\n" +
                    "  - Tạm tính Thuế TNCN:         {14,15:N0} đ\n" +
                    "  ---------------------------------------------------------\n" +
                    "  => TỔNG KHẤU TRỪ:             {15,15:N0} đ\n\n" +
                    "===========================================================\n" +
                    "  ===> THỰC LĨNH CHUYỂN KHOẢN:  {16,15:N0} VNĐ\n" +
                    "===========================================================\n",
                    maNV, hoTen, phongBan, chucVu, thang, nam,
                    luongCong, pcCV, pcDocHai, luongOT, tienThuong, tongThuNhap,
                    trichBH, tienPhat, thueTNCN, tongKhauTru, thucLinh
                );

                MessageBox.Show(paySlip, "Phiếu Lương Cá Nhân (Pay Slip)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên trên bảng lương để xem phiếu lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKhoaSo_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cboThang.Text);
            int nam = (int)numNam.Value;

            if (MessageBox.Show("Bạn có chắc chắn muốn DUYỆT & KHÓA SỔ LƯƠNG Tháng " + thang + "/" + nam + "?\n(Trạng thái sẽ chuyển thành 'Đã duyệt')",
                                "Khóa sổ lương", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("UPDATE BangLuongThang SET TrangThaiLuong = N'Đã duyệt' WHERE Thang = @Thang AND Nam = @Nam",
                               new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));
                    MessageBox.Show("Đã khóa sổ bảng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieuBangLuong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
