using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmLePhiNam : Form
    {
        public FrmLePhiNam()
        {
            InitializeComponent();
        }

        private void FrmLePhiNam_Load(object sender, EventArgs e)
        {
            cboHinhThucTT.SelectedIndex = 0;
            dtpNgayThu.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now.AddYears(1);
            numNamThu.Value = DateTime.Now.Year;

            NapDanhSachBenhNhan();
            TaiDanhSachLePhi();
            SinhMaTuDong();
        }

        private void NapDanhSachBenhNhan()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaBenhNhan, (MaBenhNhan + ' - ' + HoTen) AS HienThi FROM BenhNhan ORDER BY MaBenhNhan");
                cboBenhNhan.DataSource = dt;
                cboBenhNhan.DisplayMember = "HienThi";
                cboBenhNhan.ValueMember = "MaBenhNhan";
            }
            catch { }
        }

        private void SinhMaTuDong()
        {
            string nam = DateTime.Now.Year.ToString();
            long count = 1;
            try
            {
                object result = Db.Scalar("SELECT COUNT(*) FROM LePhiNam");
                if (result != null && result != DBNull.Value)
                    count = Convert.ToInt64(result) + 1;
            }
            catch
            {
                count = new Random().Next(10, 99);
            }
            txtMaLePhi.Text = string.Format("LP{0}_{1:D3}", nam, count);
        }

        private void TaiDanhSachLePhi(string timKiem = "")
        {
            try
            {
                string sql = @"SELECT l.MaLePhi AS [Mã Lệ Phí], l.MaBenhNhan AS [Mã BN], b.HoTen AS [Họ tên BN],
                                      l.NamThu AS [Năm thu], l.SoTien AS [Số tiền (VNĐ)], l.NgayThu AS [Ngày thu], 
                                      l.NgayHetHan AS [Ngày hết hạn 1 năm],
                                      CASE 
                                          WHEN l.NgayHetHan < GETDATE() THEN N'Hết hạn'
                                          WHEN DATEDIFF(DAY, GETDATE(), l.NgayHetHan) <= 30 THEN N'Sắp hết hạn'
                                          ELSE N'Còn hạn hội viên'
                                      END AS [Tình trạng hạn],
                                      l.HinhThucThanhToan AS [Hình thức TT], l.NguoiThu AS [Người thu]
                               FROM LePhiNam l
                               JOIN BenhNhan b ON l.MaBenhNhan = b.MaBenhNhan ";

                if (!string.IsNullOrWhiteSpace(timKiem))
                {
                    sql += " WHERE l.MaBenhNhan LIKE @k OR b.HoTen LIKE @k OR l.MaLePhi LIKE @k ";
                    sql += " ORDER BY l.NgayThu DESC";
                    dgvLePhi.DataSource = Db.Query(sql, new SqlParameter("@k", "%" + timKiem + "%"));
                }
                else
                {
                    sql += " ORDER BY l.NgayThu DESC";
                    dgvLePhi.DataSource = Db.Query(sql);
                }

                dgvLePhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }

        private void dtpNgayThu_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayHetHan.Value = dtpNgayThu.Value.AddYears(1);
        }

        private void cboBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBenhNhan.SelectedValue != null)
            {
                string maBN = cboBenhNhan.SelectedValue.ToString();
                try
                {
                    object maxHetHan = Db.Scalar("SELECT MAX(NgayHetHan) FROM LePhiNam WHERE MaBenhNhan = @bn", new SqlParameter("@bn", maBN));
                    if (maxHetHan != null && maxHetHan != DBNull.Value)
                    {
                        DateTime d = Convert.ToDateTime(maxHetHan);
                        if (d > DateTime.Today)
                        {
                            dtpNgayThu.Value = d;
                            dtpNgayHetHan.Value = d.AddYears(1);
                        }
                    }
                }
                catch { }
            }
        }

        private void btnThuPhi_Click(object sender, EventArgs e)
        {
            if (cboBenhNhan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần thu lệ phí / gia hạn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLePhi = txtMaLePhi.Text.Trim();
            string maBN = cboBenhNhan.SelectedValue.ToString();
            int namThu = (int)numNamThu.Value;
            decimal soTien = 200000;
            DateTime ngayThu = dtpNgayThu.Value;
            DateTime ngayHetHan = dtpNgayHetHan.Value;
            string hinhThuc = cboHinhThucTT.SelectedItem == null ? "Tiền mặt" : cboHinhThucTT.SelectedItem.ToString();
            string nguoiThu = txtNguoiThu.Text.Trim();

            try
            {
                string sql = @"INSERT INTO LePhiNam (MaLePhi, MaBenhNhan, NamThu, SoTien, NgayThu, NgayHetHan, HinhThucThanhToan, NguoiThu, TrangThai)
                               VALUES (@mlp, @mbn, @nam, @tien, @nthu, @nhan, @ht, @nguoi, N'Đã thanh toán')";
                Db.Execute(sql,
                    new SqlParameter("@mlp", maLePhi),
                    new SqlParameter("@mbn", maBN),
                    new SqlParameter("@nam", namThu),
                    new SqlParameter("@tien", soTien),
                    new SqlParameter("@nthu", ngayThu),
                    new SqlParameter("@nhan", ngayHetHan.Date),
                    new SqlParameter("@ht", hinhThuc),
                    new SqlParameter("@nguoi", string.IsNullOrWhiteSpace(nguoiThu) ? "Thu ngân" : nguoiThu));

                MessageBox.Show(string.Format("Đã thu lệ phí năm và gia hạn thẻ hội viên thành công!\n- Mã biên lai: {0}\n- Bệnh nhân: {1}\n- Hạn dùng mới (1 năm): {2:dd/MM/yyyy}\n- Số tiền: {3:N0} VNĐ", 
                    maLePhi, maBN, ngayHetHan, soTien), "Thu phí thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDanhSachLePhi();
                SinhMaTuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu lệ phí: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSachLePhi(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDanhSachLePhi();
            SinhMaTuDong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
