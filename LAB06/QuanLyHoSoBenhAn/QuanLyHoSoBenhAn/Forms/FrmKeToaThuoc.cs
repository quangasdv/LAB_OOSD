using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKeToaThuoc : Form
    {
        private string _maPhieuKhamParam = null;
        private DataTable _dtChiTiet = new DataTable();
        private string _patientAllergyHistory = "";

        public FrmKeToaThuoc()
        {
            InitializeComponent();
            InitChiTietTable();
        }

        public FrmKeToaThuoc(string maPhieuKham) : this()
        {
            _maPhieuKhamParam = maPhieuKham;
        }

        private void InitChiTietTable()
        {
            _dtChiTiet.Columns.Add("MaThuoc", typeof(string));
            _dtChiTiet.Columns.Add("TenThuoc", typeof(string));
            _dtChiTiet.Columns.Add("HoatChatChinh", typeof(string));
            _dtChiTiet.Columns.Add("HamLuong", typeof(string));
            _dtChiTiet.Columns.Add("DonViTinh", typeof(string));
            _dtChiTiet.Columns.Add("Sang", typeof(decimal));
            _dtChiTiet.Columns.Add("Trua", typeof(decimal));
            _dtChiTiet.Columns.Add("Chieu", typeof(decimal));
            _dtChiTiet.Columns.Add("Toi", typeof(decimal));
            _dtChiTiet.Columns.Add("SoLuong", typeof(int));
            _dtChiTiet.Columns.Add("DonGiaLucKe", typeof(decimal));
            _dtChiTiet.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGiaLucKe");
            _dtChiTiet.Columns.Add("CachDung", typeof(string));
        }

        private void FrmKeToaThuoc_Load(object sender, EventArgs e)
        {
            LoadBacSi();
            LoadPhieuKham();
            LoadThuoc();
            cboTrangThai.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(_maPhieuKhamParam))
            {
                cboPhieuKham.SelectedValue = _maPhieuKhamParam;
            }
            else
            {
                LamMoi();
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
                MessageBox.Show("Lỗi tải bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPhieuKham()
        {
            try
            {
                string sql = "SELECT pk.MaPhieuKham, pk.MaPhieuKham + ' - ' + bn.HoTen + ' (' + pk.ChanDoanSoBo + ')' AS TenHienThi, " +
                             "hs.DiUngThuoc_PhanUngPhu, bn.HoTen " +
                             "FROM PhieuKhamBenh pk " +
                             "JOIN DotDieuTri ddt ON pk.MaDotDieuTri = ddt.MaDotDieuTri " +
                             "JOIN HoSoBenhAn hs ON ddt.MaHoSo = hs.MaHoSo " +
                             "JOIN BenhNhan bn ON hs.MaBenhNhan = bn.MaBenhNhan " +
                             "ORDER BY pk.NgayGioKham DESC";
                DataTable dt = Db.Query(sql);
                cboPhieuKham.DataSource = dt;
                cboPhieuKham.DisplayMember = "TenHienThi";
                cboPhieuKham.ValueMember = "MaPhieuKham";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThuoc()
        {
            try
            {
                string sql = "SELECT MaThuoc, TenThuoc + ' (' + HamLuong + ' - ' + DonViTinh + ')' AS TenHienThi, " +
                             "TenThuoc, HoatChatChinh, DonViTinh, HamLuong, DuongDung, DonGia, ChongChiDinh, TuongTacThuoc " +
                             "FROM Thuoc ORDER BY TenThuoc";
                DataTable dt = Db.Query(sql);
                cboThuoc.DataSource = dt;
                cboThuoc.DisplayMember = "TenHienThi";
                cboThuoc.ValueMember = "MaThuoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPhieuKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhieuKham.SelectedValue == null) return;
            DataRowView row = cboPhieuKham.SelectedItem as DataRowView;
            if (row != null)
            {
                string diUng = row["DiUngThuoc_PhanUngPhu"] != DBNull.Value ? row["DiUngThuoc_PhanUngPhu"].ToString() : "";
                string hoTen = row["HoTen"].ToString();
                _patientAllergyHistory = diUng;

                if (!string.IsNullOrWhiteSpace(diUng) && diUng != "Không" && diUng != "Không có")
                {
                    lblCanhBaoDiUng.Text = string.Format("[!] CẢNH BÁO TIỀN SỬ DỊ ỨNG ({0}): {1}", hoTen, diUng);
                    pnlCanhBaoDiUng.BackColor = Color.FromArgb(255, 220, 220);
                    lblCanhBaoDiUng.ForeColor = Color.Red;
                }
                else
                {
                    lblCanhBaoDiUng.Text = string.Format("Bệnh nhân: {0} | Tiền sử dị ứng: Không ghi nhận", hoTen);
                    pnlCanhBaoDiUng.BackColor = Color.FromArgb(240, 248, 255);
                    lblCanhBaoDiUng.ForeColor = Color.DarkGreen;
                }

                LoadToaThuocCuaPK(cboPhieuKham.SelectedValue.ToString());
            }
        }

        private void LoadToaThuocCuaPK(string maPK)
        {
            try
            {
                string sql = "SELECT TOP 1 * FROM ToaThuoc WHERE MaPhieuKham = @PK ORDER BY NgayKeToa DESC";
                DataTable dt = Db.Query(sql, new SqlParameter("@PK", maPK));
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaToa.Text = r["MaToaThuoc"].ToString();
                    cboBacSi.SelectedValue = r["MaBacSiKeToa"].ToString();
                    if (r["NgayKeToa"] != DBNull.Value) dtpNgayKe.Value = Convert.ToDateTime(r["NgayKeToa"]);
                    if (r["SoNgayDungThuoc"] != DBNull.Value) numSoNgay.Value = Convert.ToDecimal(r["SoNgayDungThuoc"]);
                    txtLoiDan.Text = r["LoiDanBacSi"] != DBNull.Value ? r["LoiDanBacSi"].ToString() : "";
                    txtLuuY.Text = r["LuuYPhanUngPhu"] != DBNull.Value ? r["LuuYPhanUngPhu"].ToString() : "";
                    cboTrangThai.Text = r["TrangThai"].ToString();

                    LoadChiTietToa(r["MaToaThuoc"].ToString());
                }
                else
                {
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải toa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChiTietToa(string maToa)
        {
            try
            {
                string sql = "SELECT cttt.MaThuoc, t.TenThuoc, t.HoatChatChinh, t.HamLuong, t.DonViTinh, " +
                             "cttt.Sang, cttt.Trua, cttt.Chieu, cttt.Toi, cttt.SoLuong, cttt.DonGiaLucKe, " +
                             "cttt.CachDung " +
                             "FROM ChiTietToaThuoc cttt " +
                             "JOIN Thuoc t ON cttt.MaThuoc = t.MaThuoc " +
                             "WHERE cttt.MaToaThuoc = @Toa";
                DataTable dt = Db.Query(sql, new SqlParameter("@Toa", maToa));

                _dtChiTiet.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    DataRow newRow = _dtChiTiet.NewRow();
                    foreach (DataColumn c in _dtChiTiet.Columns)
                    {
                        if (dt.Columns.Contains(c.ColumnName))
                            newRow[c.ColumnName] = r[c.ColumnName];
                    }
                    _dtChiTiet.Rows.Add(newRow);
                }

                dgvChiTietToa.DataSource = _dtChiTiet;
                FormatGrid();
                CapNhatTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết toa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvChiTietToa.Columns.Count == 0) return;
            if (dgvChiTietToa.Columns["MaThuoc"] != null) dgvChiTietToa.Columns["MaThuoc"].HeaderText = "Mã";
            if (dgvChiTietToa.Columns["TenThuoc"] != null) dgvChiTietToa.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            if (dgvChiTietToa.Columns["HoatChatChinh"] != null) dgvChiTietToa.Columns["HoatChatChinh"].HeaderText = "Hoạt chất";
            if (dgvChiTietToa.Columns["HamLuong"] != null) dgvChiTietToa.Columns["HamLuong"].HeaderText = "Hàm lượng";
            if (dgvChiTietToa.Columns["DonViTinh"] != null) dgvChiTietToa.Columns["DonViTinh"].HeaderText = "ĐVT";
            if (dgvChiTietToa.Columns["Sang"] != null) dgvChiTietToa.Columns["Sang"].HeaderText = "Sáng";
            if (dgvChiTietToa.Columns["Trua"] != null) dgvChiTietToa.Columns["Trua"].HeaderText = "Trưa";
            if (dgvChiTietToa.Columns["Chieu"] != null) dgvChiTietToa.Columns["Chieu"].HeaderText = "Chiều";
            if (dgvChiTietToa.Columns["Toi"] != null) dgvChiTietToa.Columns["Toi"].HeaderText = "Tối";
            if (dgvChiTietToa.Columns["SoLuong"] != null) dgvChiTietToa.Columns["SoLuong"].HeaderText = "SL";
            if (dgvChiTietToa.Columns["DonGiaLucKe"] != null)
            {
                dgvChiTietToa.Columns["DonGiaLucKe"].HeaderText = "Đơn giá (đ)";
                dgvChiTietToa.Columns["DonGiaLucKe"].DefaultCellStyle.Format = "N0";
            }
            if (dgvChiTietToa.Columns["ThanhTien"] != null)
            {
                dgvChiTietToa.Columns["ThanhTien"].HeaderText = "Thành tiền (đ)";
                dgvChiTietToa.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
            if (dgvChiTietToa.Columns["CachDung"] != null) dgvChiTietToa.Columns["CachDung"].HeaderText = "Cách dùng";
        }

        private void CapNhatTongTien()
        {
            decimal total = 0;
            foreach (DataRow r in _dtChiTiet.Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["ThanhTien"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(r["ThanhTien"]);
                }
            }
            lblTongTien.Text = string.Format("TỔNG TIỀN THUỐC: {0:N0} VNĐ", total);
        }

        private void cboThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThuoc.SelectedItem == null) return;
            DataRowView row = cboThuoc.SelectedItem as DataRowView;
            if (row != null)
            {
                string tenThuoc = row["TenThuoc"].ToString();
                string hoatChat = row["HoatChatChinh"].ToString();
                string duongDung = row["DuongDung"].ToString();
                decimal gia = row["DonGia"] != DBNull.Value ? Convert.ToDecimal(row["DonGia"]) : 0;
                string chongChiDinh = row["ChongChiDinh"] != DBNull.Value ? row["ChongChiDinh"].ToString() : "";
                string tuongTac = row["TuongTacThuoc"] != DBNull.Value ? row["TuongTacThuoc"].ToString() : "";

                string thongTin = string.Format("Hoạt chất: {0} | Đường dùng: {1} | Giá: {2:N0} đ", hoatChat, duongDung, gia);
                if (!string.IsNullOrEmpty(chongChiDinh)) thongTin += " | Chống CĐ: " + chongChiDinh;
                if (!string.IsNullOrEmpty(tuongTac)) thongTin += " | Tương tác: " + tuongTac;

                lblThongTinThuoc.Text = thongTin;

                // KIỂM TRA DỊ ỨNG THUỐC
                KiemTraDiUngThuoc(tenThuoc, hoatChat);
                TinhTongSoLuongThuoc(null, null);
            }
        }

        private void KiemTraDiUngThuoc(string tenThuoc, string hoatChat)
        {
            if (string.IsNullOrWhiteSpace(_patientAllergyHistory)) return;

            string lichSu = _patientAllergyHistory.ToLower();
            string ten = tenThuoc.ToLower();
            string hc = hoatChat.ToLower();

            bool isAllergic = false;
            if (lichSu.Contains(ten) || lichSu.Contains(hc))
            {
                isAllergic = true;
            }
            else
            {
                // Tách từng từ khoá dị ứng
                string[] allergicKeywords = new string[] { "penicillin", "amoxicillin", "ampicillin", "cephalosporin", "paracetamol", "aspirin", "ibuprofen", "nsaid", "sulfonamid" };
                foreach (string kw in allergicKeywords)
                {
                    if (lichSu.Contains(kw) && (ten.Contains(kw) || hc.Contains(kw)))
                    {
                        isAllergic = true;
                        break;
                    }
                }
            }

            if (isAllergic)
            {
                MessageBox.Show(
                    string.Format("CẢNH BÁO NGUY CƠ DỊ ỨNG THUỐC NGHIÊM TRỌNG:\n\n" +
                                  "- Thuốc chọn: {0} (Hoạt chất: {1})\n" +
                                  "- Tiền sử dị ứng ghi nhận: {2}\n\n" +
                                  "Bác sĩ hãy kiểm tra kỹ chống chỉ định trước khi kê toa thuốc này!",
                                  tenThuoc, hoatChat, _patientAllergyHistory),
                    "CẢNH BÁO AN TOÀN SỬ DỤNG THUỐC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void TinhTongSoLuongThuoc(object sender, EventArgs e)
        {
            decimal tongMoiNgay = numSang.Value + numTrua.Value + numChieu.Value + numToi.Value;
            decimal soNgay = numSoNgay.Value;
            decimal tong = Math.Ceiling(tongMoiNgay * soNgay);
            if (tong < 1) tong = 1;
            numSoLuong.Value = tong;
        }

        private void numSoNgay_ValueChanged(object sender, EventArgs e)
        {
            TinhTongSoLuongThuoc(null, null);
        }

        private void LamMoi()
        {
            txtMaToa.Text = "TOA" + DateTime.Now.ToString("yyMMdd") + new Random().Next(1000, 9999).ToString();
            dtpNgayKe.Value = DateTime.Now;
            numSoNgay.Value = 5;
            txtLoiDan.Text = "Uống thuốc đúng giờ, tái khám khi hết thuốc hoặc có dấu hiệu bất thường.";
            txtLuuY.Text = "Nếu có triệu chứng dị ứng, nổi mề đay cần ngưng thuốc ngay và quay lại bệnh viện.";
            cboTrangThai.SelectedIndex = 0;
            _dtChiTiet.Clear();
            dgvChiTietToa.DataSource = _dtChiTiet;
            FormatGrid();
            CapNhatTongTien();

            numSang.Value = 1;
            numTrua.Value = 0;
            numChieu.Value = 1;
            numToi.Value = 0;
            TinhTongSoLuongThuoc(null, null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cboThuoc.SelectedItem == null) return;
            DataRowView row = cboThuoc.SelectedItem as DataRowView;
            if (row == null) return;

            string maThuoc = row["MaThuoc"].ToString();

            // Kiểm tra trùng
            foreach (DataRow r in _dtChiTiet.Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["MaThuoc"].ToString() == maThuoc)
                {
                    MessageBox.Show("Thuốc này đã có trong toa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            DataRow newRow = _dtChiTiet.NewRow();
            newRow["MaThuoc"] = maThuoc;
            newRow["TenThuoc"] = row["TenThuoc"];
            newRow["HoatChatChinh"] = row["HoatChatChinh"];
            newRow["HamLuong"] = row["HamLuong"];
            newRow["DonViTinh"] = row["DonViTinh"];
            newRow["Sang"] = numSang.Value;
            newRow["Trua"] = numTrua.Value;
            newRow["Chieu"] = numChieu.Value;
            newRow["Toi"] = numToi.Value;
            newRow["SoLuong"] = (int)numSoLuong.Value;
            newRow["DonGiaLucKe"] = row["DonGia"] != DBNull.Value ? Convert.ToDecimal(row["DonGia"]) : 0;
            newRow["CachDung"] = txtCachDung.Text.Trim();
            _dtChiTiet.Rows.Add(newRow);

            CapNhatTongTien();
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvChiTietToa.CurrentRow != null && dgvChiTietToa.CurrentRow.Index >= 0)
            {
                string maThuoc = dgvChiTietToa.CurrentRow.Cells["MaThuoc"].Value.ToString();
                for (int i = 0; i < _dtChiTiet.Rows.Count; i++)
                {
                    if (_dtChiTiet.Rows[i]["MaThuoc"].ToString() == maThuoc)
                    {
                        _dtChiTiet.Rows[i].Delete();
                        break;
                    }
                }
                CapNhatTongTien();
            }
        }

        private void btnLuuToa_Click(object sender, EventArgs e)
        {
            if (cboPhieuKham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu khám bệnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ kê toa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một thuốc vào toa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maToa = txtMaToa.Text.Trim();
            string maPK = cboPhieuKham.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue.ToString();
            DateTime ngayKe = dtpNgayKe.Value;
            int soNgay = (int)numSoNgay.Value;
            string loiDan = txtLoiDan.Text.Trim();
            string luuY = txtLuuY.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : cboTrangThai.Text;

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM ToaThuoc WHERE MaToaThuoc = @Toa", new SqlParameter("@Toa", maToa));
                bool isExist = (exists != null && Convert.ToInt32(exists) > 0);

                if (isExist)
                {
                    string updateSql = "UPDATE ToaThuoc SET " +
                                       "MaPhieuKham = @PK, MaBacSiKeToa = @BS, NgayKeToa = @NgayKe, " +
                                       "SoNgayDungThuoc = @SoNgay, LoiDanBacSi = @LoiDan, LuuYPhanUngPhu = @LuuY, TrangThai = @TT " +
                                       "WHERE MaToaThuoc = @Toa";
                    Db.Execute(updateSql,
                        new SqlParameter("@PK", maPK),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayKe", ngayKe),
                        new SqlParameter("@SoNgay", soNgay),
                        new SqlParameter("@LoiDan", loiDan),
                        new SqlParameter("@LuuY", luuY),
                        new SqlParameter("@TT", trangThai),
                        new SqlParameter("@Toa", maToa));
                }
                else
                {
                    string insertSql = "INSERT INTO ToaThuoc (MaToaThuoc, MaPhieuKham, MaBacSiKeToa, NgayKeToa, SoNgayDungThuoc, LoiDanBacSi, LuuYPhanUngPhu, TrangThai) " +
                                       "VALUES (@Toa, @PK, @BS, @NgayKe, @SoNgay, @LoiDan, @LuuY, @TT)";
                    Db.Execute(insertSql,
                        new SqlParameter("@Toa", maToa),
                        new SqlParameter("@PK", maPK),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayKe", ngayKe),
                        new SqlParameter("@SoNgay", soNgay),
                        new SqlParameter("@LoiDan", loiDan),
                        new SqlParameter("@LuuY", luuY),
                        new SqlParameter("@TT", trangThai));
                }

                // Lưu chi tiết
                Db.Execute("DELETE FROM ChiTietToaThuoc WHERE MaToaThuoc = @Toa", new SqlParameter("@Toa", maToa));
                foreach (DataRow r in _dtChiTiet.Rows)
                {
                    if (r.RowState == DataRowState.Deleted) continue;
                    string maThuoc = r["MaThuoc"].ToString();
                    int soLuong = Convert.ToInt32(r["SoLuong"]);
                    decimal sang = Convert.ToDecimal(r["Sang"]);
                    decimal trua = Convert.ToDecimal(r["Trua"]);
                    decimal chieu = Convert.ToDecimal(r["Chieu"]);
                    decimal toi = Convert.ToDecimal(r["Toi"]);
                    string cachDung = r["CachDung"].ToString();
                    decimal donGia = Convert.ToDecimal(r["DonGiaLucKe"]);

                    string insCT = "INSERT INTO ChiTietToaThuoc (MaToaThuoc, MaThuoc, SoLuong, Sang, Trua, Chieu, Toi, CachDung, DonGiaLucKe) " +
                                   "VALUES (@Toa, @Thuoc, @SL, @Sang, @Trua, @Chieu, @Toi, @CachDung, @DonGia)";
                    Db.Execute(insCT,
                        new SqlParameter("@Toa", maToa),
                        new SqlParameter("@Thuoc", maThuoc),
                        new SqlParameter("@SL", soLuong),
                        new SqlParameter("@Sang", sang),
                        new SqlParameter("@Trua", trua),
                        new SqlParameter("@Chieu", chieu),
                        new SqlParameter("@Toi", toi),
                        new SqlParameter("@CachDung", cachDung),
                        new SqlParameter("@DonGia", donGia));
                }

                MessageBox.Show("Lưu toa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChiTietToa(maToa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu toa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaToa_Click(object sender, EventArgs e)
        {
            string maToa = txtMaToa.Text.Trim();
            if (string.IsNullOrEmpty(maToa)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa toa thuốc " + maToa + " này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM ChiTietToaThuoc WHERE MaToaThuoc = @Toa", new SqlParameter("@Toa", maToa));
                    Db.Execute("DELETE FROM ToaThuoc WHERE MaToaThuoc = @Toa", new SqlParameter("@Toa", maToa));
                    MessageBox.Show("Đã xóa toa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa toa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInToa_Click(object sender, EventArgs e)
        {
            string maToa = txtMaToa.Text.Trim();
            if (string.IsNullOrEmpty(maToa) || _dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Không có nội dung toa thuốc để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string info = string.Format("=== TOA THUỐC ĐIỀU TRỊ ===\n" +
                                        "Mã toa: {0}\n" +
                                        "Bác sĩ kê toa: {1}\n" +
                                        "Ngày kê toa: {2:dd/MM/yyyy}\n" +
                                        "Thời gian điều trị: {3} ngày\n\n" +
                                        "DANH MỤC THUỐC:\n",
                                        maToa, cboBacSi.Text, dtpNgayKe.Value, numSoNgay.Value);

            int stt = 1;
            foreach (DataRow r in _dtChiTiet.Rows)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                info += string.Format("{0}. {1} ({2}) - SL: {3} {4}\n" +
                                      "   Liều dùng: Sáng {5}, Trưa {6}, Chiều {7}, Tối {8} | {9}\n",
                                      stt++, r["TenThuoc"], r["HamLuong"], r["SoLuong"], r["DonViTinh"],
                                      r["Sang"], r["Trua"], r["Chieu"], r["Toi"], r["CachDung"]);
            }

            info += string.Format("\n{0}\nLời dặn: {1}\nLưu ý phản ứng phụ: {2}",
                                  lblTongTien.Text, txtLoiDan.Text, txtLuuY.Text);

            MessageBox.Show(info, "In phiếu toa thuốc bệnh nhân", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
