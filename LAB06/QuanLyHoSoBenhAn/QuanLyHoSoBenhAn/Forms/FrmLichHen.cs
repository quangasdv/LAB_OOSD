using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmLichHen : Form
    {
        public FrmLichHen()
        {
            InitializeComponent();
        }

        private void FrmLichHen_Load(object sender, EventArgs e)
        {
            LoadBacSi();
            LoadHoSo();
            cboLocTrangThai.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            LamMoi();
            LoadDanhSachLichHen();
        }

        private void LoadBacSi()
        {
            try
            {
                string sql = "SELECT MaBacSi, HoTen + ' (' + ChuyenKhoa + ')' AS TenHienThi FROM BacSi ORDER BY HoTen";
                DataTable dt = Db.Query(sql);
                cboBacSi.DataSource = dt;
                cboBacSi.DisplayMember = "TenHienThi";
                cboBacSi.ValueMember = "MaBacSi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHoSo()
        {
            try
            {
                string sql = "SELECT hs.MaHoSo, hs.MaHoSo + ' - ' + bn.HoTen + ' (' + bn.SoDienThoai + ')' AS TenHienThi " +
                             "FROM HoSoBenhAn hs " +
                             "JOIN BenhNhan bn ON hs.MaBenhNhan = bn.MaBenhNhan " +
                             "ORDER BY hs.MaHoSo";
                DataTable dt = Db.Query(sql);
                cboHoSo.DataSource = dt;
                cboHoSo.DisplayMember = "TenHienThi";
                cboHoSo.ValueMember = "MaHoSo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hồ sơ bệnh án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachLichHen()
        {
            try
            {
                string sql = "SELECT lh.MaLichHen, lh.MaHoSo, bn.HoTen AS TenBenhNhan, bn.SoDienThoai, " +
                             "bs.HoTen AS BacSiHen, lh.NgayHenKham, lh.GioHenKham, " +
                             "lh.NoiDungKham, lh.DanDoChuanBi, lh.TrangThaiHen " +
                             "FROM LichHenTaiKham lh " +
                             "JOIN HoSoBenhAn hs ON lh.MaHoSo = hs.MaHoSo " +
                             "JOIN BenhNhan bn ON hs.MaBenhNhan = bn.MaBenhNhan " +
                             "JOIN BacSi bs ON lh.MaBacSiHen = bs.MaBacSi " +
                             "WHERE 1=1 ";

                string locTT = cboLocTrangThai.SelectedItem != null ? cboLocTrangThai.SelectedItem.ToString() : "Tất cả";
                if (locTT != "Tất cả")
                {
                    sql += "AND lh.TrangThaiHen = N'" + locTT.Replace("'", "''") + "' ";
                }

                sql += "ORDER BY lh.NgayHenKham DESC, lh.GioHenKham ASC";

                DataTable dt = Db.Query(sql);
                dgvLichHen.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lịch hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvLichHen.Columns.Count == 0) return;
            if (dgvLichHen.Columns["MaLichHen"] != null) dgvLichHen.Columns["MaLichHen"].HeaderText = "Mã LH";
            if (dgvLichHen.Columns["MaHoSo"] != null) dgvLichHen.Columns["MaHoSo"].HeaderText = "Mã HS";
            if (dgvLichHen.Columns["TenBenhNhan"] != null) dgvLichHen.Columns["TenBenhNhan"].HeaderText = "Họ tên bệnh nhân";
            if (dgvLichHen.Columns["SoDienThoai"] != null) dgvLichHen.Columns["SoDienThoai"].HeaderText = "SĐT liên hệ";
            if (dgvLichHen.Columns["BacSiHen"] != null) dgvLichHen.Columns["BacSiHen"].HeaderText = "Bác sĩ hẹn";
            if (dgvLichHen.Columns["NgayHenKham"] != null)
            {
                dgvLichHen.Columns["NgayHenKham"].HeaderText = "Ngày hẹn";
                dgvLichHen.Columns["NgayHenKham"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvLichHen.Columns["GioHenKham"] != null) dgvLichHen.Columns["GioHenKham"].HeaderText = "Giờ hẹn";
            if (dgvLichHen.Columns["NoiDungKham"] != null) dgvLichHen.Columns["NoiDungKham"].HeaderText = "Nội dung khám";
            if (dgvLichHen.Columns["DanDoChuanBi"] != null) dgvLichHen.Columns["DanDoChuanBi"].HeaderText = "Dặn dò chuẩn bị";
            if (dgvLichHen.Columns["TrangThaiHen"] != null) dgvLichHen.Columns["TrangThaiHen"].HeaderText = "Trạng thái";
        }

        private void LamMoi()
        {
            txtMaLichHen.Text = "LH" + DateTime.Now.ToString("yyMMdd") + new Random().Next(1000, 9999).ToString();
            dtpNgayHen.Value = DateTime.Now.AddDays(7);
            cboGioHen.Text = "08:30";
            txtNoiDung.Text = "Tái khám định kỳ theo dõi sức khỏe & kiểm tra theo gói hội viên";
            txtDanDo.Text = "Nhịn ăn sáng trước khi đến để lấy máu xét nghiệm đường huyết & chức năng gan thận.";
            cboTrangThai.Text = "Chưa đến hẹn";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboHoSo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ hẹn khám!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung khám hẹn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }

            string maLH = txtMaLichHen.Text.Trim();
            string maHoSo = cboHoSo.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue.ToString();
            DateTime ngayHen = dtpNgayHen.Value.Date;
            TimeSpan gioHen;
            if (!TimeSpan.TryParse(cboGioHen.Text.Trim(), out gioHen))
            {
                gioHen = new TimeSpan(8, 30, 0);
            }
            string noiDung = txtNoiDung.Text.Trim();
            string danDo = txtDanDo.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : cboTrangThai.Text;

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM LichHenTaiKham WHERE MaLichHen = @LH", new SqlParameter("@LH", maLH));
                bool isExist = (exists != null && Convert.ToInt32(exists) > 0);

                if (isExist)
                {
                    string updateSql = "UPDATE LichHenTaiKham SET " +
                                       "MaHoSo = @HS, MaBacSiHen = @BS, NgayHenKham = @NgayHen, GioHenKham = @GioHen, " +
                                       "NoiDungKham = @NoiDung, DanDoChuanBi = @DanDo, TrangThaiHen = @TT " +
                                       "WHERE MaLichHen = @LH";
                    Db.Execute(updateSql,
                        new SqlParameter("@HS", maHoSo),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayHen", ngayHen),
                        new SqlParameter("@GioHen", gioHen),
                        new SqlParameter("@NoiDung", noiDung),
                        new SqlParameter("@DanDo", danDo),
                        new SqlParameter("@TT", trangThai),
                        new SqlParameter("@LH", maLH));
                }
                else
                {
                    string insertSql = "INSERT INTO LichHenTaiKham (MaLichHen, MaHoSo, MaBacSiHen, NgayHenKham, GioHenKham, NoiDungKham, DanDoChuanBi, TrangThaiHen) " +
                                       "VALUES (@LH, @HS, @BS, @NgayHen, @GioHen, @NoiDung, @DanDo, @TT)";
                    Db.Execute(insertSql,
                        new SqlParameter("@LH", maLH),
                        new SqlParameter("@HS", maHoSo),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayHen", ngayHen),
                        new SqlParameter("@GioHen", gioHen),
                        new SqlParameter("@NoiDung", noiDung),
                        new SqlParameter("@DanDo", danDo),
                        new SqlParameter("@TT", trangThai));
                }

                MessageBox.Show("Lưu lịch hẹn tái khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachLichHen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu lịch hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhanDenKham_Click(object sender, EventArgs e)
        {
            string maLH = txtMaLichHen.Text.Trim();
            if (string.IsNullOrEmpty(maLH)) return;

            try
            {
                Db.Execute("UPDATE LichHenTaiKham SET TrangThaiHen = N'Đã đến khám' WHERE MaLichHen = @LH", new SqlParameter("@LH", maLH));
                cboTrangThai.Text = "Đã đến khám";
                MessageBox.Show("Đã xác nhận bệnh nhân đến khám theo lịch hẹn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachLichHen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLH = txtMaLichHen.Text.Trim();
            if (string.IsNullOrEmpty(maLH)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn " + maLH + " này?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("UPDATE LichHenTaiKham SET TrangThaiHen = N'Quá hạn/Hủy' WHERE MaLichHen = @LH", new SqlParameter("@LH", maLH));
                    MessageBox.Show("Đã chuyển trạng thái lịch hẹn sang Hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLichHen();
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hủy lịch hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvLichHen.Rows[e.RowIndex];
            string maLH = row.Cells["MaLichHen"].Value.ToString();

            try
            {
                string sql = "SELECT * FROM LichHenTaiKham WHERE MaLichHen = @LH";
                DataTable dt = Db.Query(sql, new SqlParameter("@LH", maLH));
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaLichHen.Text = r["MaLichHen"].ToString();
                    cboHoSo.SelectedValue = r["MaHoSo"].ToString();
                    cboBacSi.SelectedValue = r["MaBacSiHen"].ToString();
                    if (r["NgayHenKham"] != DBNull.Value) dtpNgayHen.Value = Convert.ToDateTime(r["NgayHenKham"]);
                    if (r["GioHenKham"] != DBNull.Value)
                    {
                        TimeSpan ts = (TimeSpan)r["GioHenKham"];
                        cboGioHen.Text = string.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes);
                    }
                    txtNoiDung.Text = r["NoiDungKham"] != DBNull.Value ? r["NoiDungKham"].ToString() : "";
                    txtDanDo.Text = r["DanDoChuanBi"] != DBNull.Value ? r["DanDoChuanBi"].ToString() : "";
                    cboTrangThai.Text = r["TrangThaiHen"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn lịch hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachLichHen();
        }

        private void btnLamMoiBoLoc_Click(object sender, EventArgs e)
        {
            cboLocTrangThai.SelectedIndex = 0;
            LoadDanhSachLichHen();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
