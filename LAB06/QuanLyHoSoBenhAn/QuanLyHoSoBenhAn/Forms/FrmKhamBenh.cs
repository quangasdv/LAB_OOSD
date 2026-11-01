using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKhamBenh : Form
    {
        private string _preselectedMaPhieuKham = null;

        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        public FrmKhamBenh(string maPhieuKham) : this()
        {
            _preselectedMaPhieuKham = maPhieuKham;
        }

        private void FrmKhamBenh_Load(object sender, EventArgs e)
        {
            LoadBacSi();
            LoadHoSo();
            cboHuongXuLy.SelectedIndex = 0;
            LamMoi();

            if (!string.IsNullOrEmpty(_preselectedMaPhieuKham))
            {
                ChonPhieuKhamTheoMa(_preselectedMaPhieuKham);
            }
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
                MessageBox.Show("Lỗi tải danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHoSo()
        {
            try
            {
                string sql = "SELECT hs.MaHoSo, bn.HoTen, bn.MaBenhNhan, hs.DiUngThuoc_PhanUngPhu, " +
                             "hs.MaHoSo + ' - ' + bn.HoTen AS TenHienThi " +
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
                MessageBox.Show("Lỗi tải danh sách hồ sơ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboHoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHoSo.SelectedValue == null) return;
            DataRowView row = cboHoSo.SelectedItem as DataRowView;
            if (row != null)
            {
                string hoTen = row["HoTen"].ToString();
                string diUng = row["DiUngThuoc_PhanUngPhu"].ToString();
                string thongTin = "Bệnh nhân: " + hoTen;
                if (!string.IsNullOrWhiteSpace(diUng) && diUng != "Không" && diUng != "Không có")
                {
                    thongTin += " | [!] DỊ ỨNG: " + diUng;
                    lblThongTinBenhNhan.ForeColor = Color.Red;
                }
                else
                {
                    lblThongTinBenhNhan.ForeColor = Color.Navy;
                }
                lblThongTinBenhNhan.Text = thongTin;

                LoadDotDieuTri(row["MaHoSo"].ToString());
            }
        }

        private void LoadDotDieuTri(string maHoSo)
        {
            try
            {
                string sql = "SELECT MaDotDieuTri, MaDotDieuTri + ' (' + LoaiDieuTri + ' - ' + TrangThai + ')' AS TenHienThi " +
                             "FROM DotDieuTri WHERE MaHoSo = @MaHoSo ORDER BY NgayBatDau DESC";
                DataTable dt = Db.Query(sql, new SqlParameter("@MaHoSo", maHoSo));
                cboDotDieuTri.DataSource = dt;
                cboDotDieuTri.DisplayMember = "TenHienThi";
                cboDotDieuTri.ValueMember = "MaDotDieuTri";

                if (dt.Rows.Count == 0)
                {
                    cboDotDieuTri.DataSource = null;
                    dgvLichSuKham.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải đợt điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDotDieuTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDotDieuTri.SelectedValue == null) return;
            string maDot = cboDotDieuTri.SelectedValue.ToString();
            LoadDanhSachPhieuKham(maDot);
        }

        private void LoadDanhSachPhieuKham(string maDot)
        {
            try
            {
                string sql = "SELECT pk.MaPhieuKham, pk.LanKham, pk.NgayGioKham, bs.HoTen AS BacSiKham, " +
                             "pk.NhietDo, pk.HuyetAp, pk.Mach, pk.NhipTho, pk.ChanDoanSoBo, pk.ChanDoanXacDinh, pk.MaBenhICD10, pk.HuongXuLy " +
                             "FROM PhieuKhamBenh pk " +
                             "JOIN BacSi bs ON pk.MaBacSiKham = bs.MaBacSi " +
                             "WHERE pk.MaDotDieuTri = @MaDot " +
                             "ORDER BY pk.LanKham DESC, pk.NgayGioKham DESC";
                DataTable dt = Db.Query(sql, new SqlParameter("@MaDot", maDot));
                dgvLichSuKham.DataSource = dt;
                FormatGrid();

                numLanKham.Value = dt.Rows.Count + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvLichSuKham.Columns.Count == 0) return;
            if (dgvLichSuKham.Columns["MaPhieuKham"] != null) dgvLichSuKham.Columns["MaPhieuKham"].HeaderText = "Mã PK";
            if (dgvLichSuKham.Columns["LanKham"] != null) dgvLichSuKham.Columns["LanKham"].HeaderText = "Lần";
            if (dgvLichSuKham.Columns["NgayGioKham"] != null)
            {
                dgvLichSuKham.Columns["NgayGioKham"].HeaderText = "Ngày giờ khám";
                dgvLichSuKham.Columns["NgayGioKham"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvLichSuKham.Columns["BacSiKham"] != null) dgvLichSuKham.Columns["BacSiKham"].HeaderText = "Bác sĩ khám";
            if (dgvLichSuKham.Columns["NhietDo"] != null) dgvLichSuKham.Columns["NhietDo"].HeaderText = "T° (C)";
            if (dgvLichSuKham.Columns["HuyetAp"] != null) dgvLichSuKham.Columns["HuyetAp"].HeaderText = "Huyết áp";
            if (dgvLichSuKham.Columns["Mach"] != null) dgvLichSuKham.Columns["Mach"].HeaderText = "Mạch";
            if (dgvLichSuKham.Columns["NhipTho"] != null) dgvLichSuKham.Columns["NhipTho"].HeaderText = "Nhịp thở";
            if (dgvLichSuKham.Columns["ChanDoanSoBo"] != null) dgvLichSuKham.Columns["ChanDoanSoBo"].HeaderText = "Chẩn đoán sơ bộ";
            if (dgvLichSuKham.Columns["ChanDoanXacDinh"] != null) dgvLichSuKham.Columns["ChanDoanXacDinh"].HeaderText = "CĐ xác định";
            if (dgvLichSuKham.Columns["MaBenhICD10"] != null) dgvLichSuKham.Columns["MaBenhICD10"].HeaderText = "ICD10";
            if (dgvLichSuKham.Columns["HuongXuLy"] != null) dgvLichSuKham.Columns["HuongXuLy"].HeaderText = "Hướng xử lý";
        }

        private void TinhBMI(object sender, EventArgs e)
        {
            decimal canNang, chieuCao;
            if (decimal.TryParse(txtCanNang.Text.Trim(), out canNang) &&
                decimal.TryParse(txtChieuCao.Text.Trim(), out chieuCao) &&
                chieuCao > 0 && canNang > 0)
            {
                decimal m = chieuCao / 100m;
                decimal bmi = canNang / (m * m);
                lblBMI.Text = string.Format("BMI: {0:N1}", bmi);
                if (bmi < 18.5m)
                {
                    lblBMI.ForeColor = Color.OrangeRed;
                    lblBMI.Text += " (Gầy)";
                }
                else if (bmi <= 24.9m)
                {
                    lblBMI.ForeColor = Color.DarkGreen;
                    lblBMI.Text += " (Bình thường)";
                }
                else if (bmi <= 29.9m)
                {
                    lblBMI.ForeColor = Color.OrangeRed;
                    lblBMI.Text += " (Thừa cân)";
                }
                else
                {
                    lblBMI.ForeColor = Color.Red;
                    lblBMI.Text += " (Béo phì)";
                }
            }
            else
            {
                lblBMI.Text = "BMI: --.-";
                lblBMI.ForeColor = Color.Gray;
            }
        }

        private void LamMoi()
        {
            string maPK = "PK" + DateTime.Now.ToString("yyMMdd") + new Random().Next(1000, 9999).ToString();
            txtMaPhieuKham.Text = maPK;
            dtpNgayKham.Value = DateTime.Now;
            txtNhietDo.Text = "37.0";
            txtHuyetAp.Text = "120/80";
            txtMach.Text = "78";
            txtNhipTho.Text = "18";
            txtCanNang.Text = "60";
            txtChieuCao.Text = "165";
            txtTrieuChung.Clear();
            txtChanDoanSoBo.Clear();
            txtChanDoanXacDinh.Clear();
            txtMaICD10.Clear();
            cboHuongXuLy.SelectedIndex = 0;
            TinhBMI(null, null);

            if (cboDotDieuTri.SelectedValue != null)
            {
                LoadDanhSachPhieuKham(cboDotDieuTri.SelectedValue.ToString());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTaoDotMoi_Click(object sender, EventArgs e)
        {
            if (cboHoSo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ bệnh án trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHoSo = cboHoSo.SelectedValue.ToString();
            string maDot = "DDT" + DateTime.Now.ToString("yyMMdd") + new Random().Next(100, 999).ToString();
            string bsDefault = (cboBacSi.SelectedValue != null) ? cboBacSi.SelectedValue.ToString() : "BS01";

            try
            {
                // Lấy khoa của bác sĩ
                object maKhoa = Db.Scalar("SELECT TOP 1 MaKhoa FROM BacSi WHERE MaBacSi = @BS", new SqlParameter("@BS", bsDefault));
                if (maKhoa == null) maKhoa = "K01";

                string sql = "INSERT INTO DotDieuTri (MaDotDieuTri, MaHoSo, MaBacSiPhuTrach, MaKhoa, NgayBatDau, LoaiDieuTri, LyDoDieuTri, TrangThai) " +
                             "VALUES (@MaDot, @MaHoSo, @BS, @Khoa, GETDATE(), N'Ngoại trú', N'Khám bệnh ngoại trú theo yêu cầu', N'Đang điều trị')";
                Db.Execute(sql,
                    new SqlParameter("@MaDot", maDot),
                    new SqlParameter("@MaHoSo", maHoSo),
                    new SqlParameter("@BS", bsDefault),
                    new SqlParameter("@Khoa", maKhoa));

                MessageBox.Show("Đã tạo mới đợt điều trị: " + maDot, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDotDieuTri(maHoSo);
                cboDotDieuTri.SelectedValue = maDot;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo đợt điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDotDieuTri.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc tạo đợt điều trị trước khi lưu phiếu khám!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ khám!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTrieuChung.Text))
            {
                MessageBox.Show("Vui lòng nhập triệu chứng lâm sàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrieuChung.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtChanDoanSoBo.Text))
            {
                MessageBox.Show("Vui lòng nhập chẩn đoán sơ bộ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChanDoanSoBo.Focus();
                return;
            }

            decimal nhietDo, canNang = 0, chieuCao = 0;
            int mach, nhipTho = 18;

            if (!decimal.TryParse(txtNhietDo.Text.Trim(), out nhietDo) || nhietDo < 34m || nhietDo > 43m)
            {
                MessageBox.Show("Nhiệt độ không hợp lệ (từ 34.0 đến 43.0 °C)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhietDo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHuyetAp.Text))
            {
                MessageBox.Show("Vui lòng nhập huyết áp (vd: 120/80)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHuyetAp.Focus();
                return;
            }
            if (!int.TryParse(txtMach.Text.Trim(), out mach) || mach < 30 || mach > 220)
            {
                MessageBox.Show("Mạch không hợp lệ (từ 30 đến 220 lần/phút)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMach.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtNhipTho.Text) && (!int.TryParse(txtNhipTho.Text.Trim(), out nhipTho) || nhipTho < 10 || nhipTho > 60))
            {
                MessageBox.Show("Nhịp thở không hợp lệ (từ 10 đến 60 lần/phút)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhipTho.Focus();
                return;
            }

            decimal.TryParse(txtCanNang.Text.Trim(), out canNang);
            decimal.TryParse(txtChieuCao.Text.Trim(), out chieuCao);

            string maPK = txtMaPhieuKham.Text.Trim();
            string maDot = cboDotDieuTri.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue.ToString();
            DateTime ngayKham = dtpNgayKham.Value;
            int lanKham = (int)numLanKham.Value;
            string huyetAp = txtHuyetAp.Text.Trim();
            string trieuChung = txtTrieuChung.Text.Trim();
            string cdSoBo = txtChanDoanSoBo.Text.Trim();
            string cdXacDinh = txtChanDoanXacDinh.Text.Trim();
            string icd10 = txtMaICD10.Text.Trim();
            string huongXuLy = (cboHuongXuLy.SelectedItem != null) ? cboHuongXuLy.SelectedItem.ToString() : cboHuongXuLy.Text;

            try
            {
                // Kiểm tra xem đã tồn tại chưa
                object exists = Db.Scalar("SELECT COUNT(*) FROM PhieuKhamBenh WHERE MaPhieuKham = @PK", new SqlParameter("@PK", maPK));
                bool isExist = (exists != null && Convert.ToInt32(exists) > 0);

                if (isExist)
                {
                    string updateSql = "UPDATE PhieuKhamBenh SET " +
                                       "MaBacSiKham = @BS, NgayGioKham = @NgayKham, LanKham = @LanKham, " +
                                       "NhietDo = @NhietDo, HuyetAp = @HuyetAp, Mach = @Mach, NhipTho = @NhipTho, " +
                                       "CanNang = @CanNang, ChieuCao = @ChieuCao, TrieuChungLamsang = @TrieuChung, " +
                                       "ChanDoanSoBo = @CDSoBo, ChanDoanXacDinh = @CDXacDinh, MaBenhICD10 = @ICD10, HuongXuLy = @HuongXuLy " +
                                       "WHERE MaPhieuKham = @PK";
                    Db.Execute(updateSql,
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayKham", ngayKham),
                        new SqlParameter("@LanKham", lanKham),
                        new SqlParameter("@NhietDo", nhietDo),
                        new SqlParameter("@HuyetAp", huyetAp),
                        new SqlParameter("@Mach", mach),
                        new SqlParameter("@NhipTho", (object)nhipTho ?? DBNull.Value),
                        new SqlParameter("@CanNang", (canNang > 0) ? (object)canNang : DBNull.Value),
                        new SqlParameter("@ChieuCao", (chieuCao > 0) ? (object)chieuCao : DBNull.Value),
                        new SqlParameter("@TrieuChung", trieuChung),
                        new SqlParameter("@CDSoBo", cdSoBo),
                        new SqlParameter("@CDXacDinh", cdXacDinh),
                        new SqlParameter("@ICD10", icd10),
                        new SqlParameter("@HuongXuLy", huongXuLy),
                        new SqlParameter("@PK", maPK));

                    MessageBox.Show("Cập nhật phiếu khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertSql = "INSERT INTO PhieuKhamBenh (MaPhieuKham, MaDotDieuTri, MaBacSiKham, NgayGioKham, LanKham, " +
                                       "NhietDo, HuyetAp, Mach, NhipTho, CanNang, ChieuCao, TrieuChungLamsang, ChanDoanSoBo, ChanDoanXacDinh, MaBenhICD10, HuongXuLy) " +
                                       "VALUES (@PK, @MaDot, @BS, @NgayKham, @LanKham, @NhietDo, @HuyetAp, @Mach, @NhipTho, @CanNang, @ChieuCao, @TrieuChung, @CDSoBo, @CDXacDinh, @ICD10, @HuongXuLy)";
                    Db.Execute(insertSql,
                        new SqlParameter("@PK", maPK),
                        new SqlParameter("@MaDot", maDot),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayKham", ngayKham),
                        new SqlParameter("@LanKham", lanKham),
                        new SqlParameter("@NhietDo", nhietDo),
                        new SqlParameter("@HuyetAp", huyetAp),
                        new SqlParameter("@Mach", mach),
                        new SqlParameter("@NhipTho", (object)nhipTho ?? DBNull.Value),
                        new SqlParameter("@CanNang", (canNang > 0) ? (object)canNang : DBNull.Value),
                        new SqlParameter("@ChieuCao", (chieuCao > 0) ? (object)chieuCao : DBNull.Value),
                        new SqlParameter("@TrieuChung", trieuChung),
                        new SqlParameter("@CDSoBo", cdSoBo),
                        new SqlParameter("@CDXacDinh", cdXacDinh),
                        new SqlParameter("@ICD10", icd10),
                        new SqlParameter("@HuongXuLy", huongXuLy));

                    MessageBox.Show("Lưu phiếu khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadDanhSachPhieuKham(maDot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPhieuKham.Text.Trim();
            if (string.IsNullOrEmpty(maPK)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu khám " + maPK + " này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM PhieuKhamBenh WHERE MaPhieuKham = @PK", new SqlParameter("@PK", maPK));
                    MessageBox.Show("Đã xóa phiếu khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa phiếu khám (có thể đã có toa thuốc hoặc chỉ định xét nghiệm liên quan): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLichSuKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvLichSuKham.Rows[e.RowIndex];
            string maPK = row.Cells["MaPhieuKham"].Value.ToString();
            ChonPhieuKhamTheoMa(maPK);
        }

        private void ChonPhieuKhamTheoMa(string maPK)
        {
            try
            {
                string sql = "SELECT * FROM PhieuKhamBenh WHERE MaPhieuKham = @PK";
                DataTable dt = Db.Query(sql, new SqlParameter("@PK", maPK));
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaPhieuKham.Text = r["MaPhieuKham"].ToString();
                    if (r["NgayGioKham"] != DBNull.Value) dtpNgayKham.Value = Convert.ToDateTime(r["NgayGioKham"]);
                    if (r["LanKham"] != DBNull.Value) numLanKham.Value = Convert.ToDecimal(r["LanKham"]);
                    if (r["MaBacSiKham"] != DBNull.Value) cboBacSi.SelectedValue = r["MaBacSiKham"].ToString();

                    txtNhietDo.Text = r["NhietDo"].ToString();
                    txtHuyetAp.Text = r["HuyetAp"].ToString();
                    txtMach.Text = r["Mach"].ToString();
                    txtNhipTho.Text = (r["NhipTho"] != DBNull.Value) ? r["NhipTho"].ToString() : "";
                    txtCanNang.Text = (r["CanNang"] != DBNull.Value) ? r["CanNang"].ToString() : "";
                    txtChieuCao.Text = (r["ChieuCao"] != DBNull.Value) ? r["ChieuCao"].ToString() : "";

                    txtTrieuChung.Text = r["TrieuChungLamsang"].ToString();
                    txtChanDoanSoBo.Text = r["ChanDoanSoBo"].ToString();
                    txtChanDoanXacDinh.Text = (r["ChanDoanXacDinh"] != DBNull.Value) ? r["ChanDoanXacDinh"].ToString() : "";
                    txtMaICD10.Text = (r["MaBenhICD10"] != DBNull.Value) ? r["MaBenhICD10"].ToString() : "";
                    cboHuongXuLy.Text = (r["HuongXuLy"] != DBNull.Value) ? r["HuongXuLy"].ToString() : "";

                    TinhBMI(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn phiếu khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiDinhXN_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPhieuKham.Text.Trim();
            if (string.IsNullOrEmpty(maPK))
            {
                MessageBox.Show("Vui lòng lưu phiếu khám bệnh trước khi chỉ định xét nghiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (FrmChiDinhXN f = new FrmChiDinhXN(maPK))
            {
                f.ShowDialog(this);
            }
        }

        private void btnKeToaThuoc_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPhieuKham.Text.Trim();
            if (string.IsNullOrEmpty(maPK))
            {
                MessageBox.Show("Vui lòng lưu phiếu khám bệnh trước khi kê toa thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (FrmKeToaThuoc f = new FrmKeToaThuoc(maPK))
            {
                f.ShowDialog(this);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
