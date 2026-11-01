using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmChiDinhXN : Form
    {
        private string _maPhieuKhamParam = null;
        private DataTable _dtChiTiet = new DataTable();
        private string _currentSelectedMaXN = null;

        public FrmChiDinhXN()
        {
            InitializeComponent();
            InitChiTietTable();
        }

        public FrmChiDinhXN(string maPhieuKham) : this()
        {
            _maPhieuKhamParam = maPhieuKham;
        }

        private void InitChiTietTable()
        {
            _dtChiTiet.Columns.Add("MaXetNghiem", typeof(string));
            _dtChiTiet.Columns.Add("TenXetNghiem", typeof(string));
            _dtChiTiet.Columns.Add("LoaiXetNghiem", typeof(string));
            _dtChiTiet.Columns.Add("DonGia", typeof(decimal));
            _dtChiTiet.Columns.Add("ChiSoBinhThuong", typeof(string));
            _dtChiTiet.Columns.Add("DonViDo", typeof(string));
            _dtChiTiet.Columns.Add("KetQua", typeof(string));
            _dtChiTiet.Columns.Add("DanhGiaKetQua", typeof(string));
            _dtChiTiet.Columns.Add("KTVThucHien", typeof(string));
            _dtChiTiet.Columns.Add("GhiChu", typeof(string));
            _dtChiTiet.Columns.Add("NgayGioTraKQ", typeof(DateTime));
        }

        private void FrmChiDinhXN_Load(object sender, EventArgs e)
        {
            LoadBacSi();
            LoadPhieuKham();
            LoadDanhMucXN();
            cboTrangThai.SelectedIndex = 0;
            cboDanhGia.SelectedIndex = 0;

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
                MessageBox.Show("Lỗi tải danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPhieuKham()
        {
            try
            {
                string sql = "SELECT pk.MaPhieuKham, pk.MaPhieuKham + ' - ' + bn.HoTen + ' (' + pk.ChanDoanSoBo + ')' AS TenHienThi " +
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
                MessageBox.Show("Lỗi tải danh sách phiếu khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhMucXN()
        {
            try
            {
                string sql = "SELECT MaXetNghiem, TenXetNghiem + ' [' + LoaiXetNghiem + ' - ' + FORMAT(DonGia, 'N0') + ' đ]' AS TenHienThi, " +
                             "LoaiXetNghiem, DonGia, ChiSoBinhThuong, DonViDo " +
                             "FROM DanhMucXetNghiem ORDER BY LoaiXetNghiem, TenXetNghiem";
                DataTable dt = Db.Query(sql);
                cboDanhMucXN.DataSource = dt;
                cboDanhMucXN.DisplayMember = "TenHienThi";
                cboDanhMucXN.ValueMember = "MaXetNghiem";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục xét nghiệm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDanhMucXN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMucXN.SelectedItem == null) return;
            DataRowView row = cboDanhMucXN.SelectedItem as DataRowView;
            if (row != null)
            {
                string chuan = row["ChiSoBinhThuong"] != DBNull.Value ? row["ChiSoBinhThuong"].ToString() : "N/A";
                string dvi = row["DonViDo"] != DBNull.Value ? row["DonViDo"].ToString() : "";
                decimal gia = row["DonGia"] != DBNull.Value ? Convert.ToDecimal(row["DonGia"]) : 0;

                lblChiSoBinhThuong.Text = string.Format("Chỉ số chuẩn: {0} {1}", chuan, dvi);
                lblGiaXN.Text = string.Format("Đơn giá: {0:N0} đ", gia);
            }
        }

        private void cboPhieuKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhieuKham.SelectedValue == null) return;
            string maPK = cboPhieuKham.SelectedValue.ToString();
            LoadPhieuChiDinhCuaPK(maPK);
        }

        private void LoadPhieuChiDinhCuaPK(string maPK)
        {
            try
            {
                string sql = "SELECT TOP 1 * FROM PhieuChiDinhXetNghiem WHERE MaPhieuKham = @PK ORDER BY NgayChiDinh DESC";
                DataTable dt = Db.Query(sql, new SqlParameter("@PK", maPK));
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaChiDinh.Text = r["MaChiDinh"].ToString();
                    cboBacSi.SelectedValue = r["MaBacSiChiDinh"].ToString();
                    if (r["NgayChiDinh"] != DBNull.Value) dtpNgayChiDinh.Value = Convert.ToDateTime(r["NgayChiDinh"]);
                    txtLyDo.Text = r["LyDoChiDinh"] != DBNull.Value ? r["LyDoChiDinh"].ToString() : "";
                    cboTrangThai.Text = r["TrangThai"].ToString();

                    LoadChiTietXN(r["MaChiDinh"].ToString());
                }
                else
                {
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu chỉ định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChiTietXN(string maChiDinh)
        {
            try
            {
                string sql = "SELECT ctxn.MaXetNghiem, dmxn.TenXetNghiem, dmxn.LoaiXetNghiem, dmxn.DonGia, " +
                             "dmxn.ChiSoBinhThuong, dmxn.DonViDo, ctxn.KetQua, ctxn.DanhGiaKetQua, " +
                             "ctxn.KTVThucHien, ctxn.GhiChu, ctxn.NgayGioTraKQ " +
                             "FROM ChiTietXetNghiem ctxn " +
                             "JOIN DanhMucXetNghiem dmxn ON ctxn.MaXetNghiem = dmxn.MaXetNghiem " +
                             "WHERE ctxn.MaChiDinh = @CD";
                DataTable dt = Db.Query(sql, new SqlParameter("@CD", maChiDinh));

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

                dgvChiTietXN.DataSource = _dtChiTiet;
                FormatGrid();
                CapNhatTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết xét nghiệm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvChiTietXN.Columns.Count == 0) return;
            if (dgvChiTietXN.Columns["MaXetNghiem"] != null) dgvChiTietXN.Columns["MaXetNghiem"].HeaderText = "Mã XN";
            if (dgvChiTietXN.Columns["TenXetNghiem"] != null) dgvChiTietXN.Columns["TenXetNghiem"].HeaderText = "Tên xét nghiệm";
            if (dgvChiTietXN.Columns["LoaiXetNghiem"] != null) dgvChiTietXN.Columns["LoaiXetNghiem"].HeaderText = "Loại";
            if (dgvChiTietXN.Columns["DonGia"] != null)
            {
                dgvChiTietXN.Columns["DonGia"].HeaderText = "Đơn giá (đ)";
                dgvChiTietXN.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            if (dgvChiTietXN.Columns["ChiSoBinhThuong"] != null) dgvChiTietXN.Columns["ChiSoBinhThuong"].HeaderText = "Chỉ số chuẩn";
            if (dgvChiTietXN.Columns["DonViDo"] != null) dgvChiTietXN.Columns["DonViDo"].HeaderText = "Đơn vị";
            if (dgvChiTietXN.Columns["KetQua"] != null) dgvChiTietXN.Columns["KetQua"].HeaderText = "Kết quả";
            if (dgvChiTietXN.Columns["DanhGiaKetQua"] != null) dgvChiTietXN.Columns["DanhGiaKetQua"].HeaderText = "Đánh giá";
            if (dgvChiTietXN.Columns["KTVThucHien"] != null) dgvChiTietXN.Columns["KTVThucHien"].HeaderText = "KTV";
            if (dgvChiTietXN.Columns["NgayGioTraKQ"] != null)
            {
                dgvChiTietXN.Columns["NgayGioTraKQ"].HeaderText = "Ngày trả";
                dgvChiTietXN.Columns["NgayGioTraKQ"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvChiTietXN.Columns["GhiChu"] != null) dgvChiTietXN.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        private void CapNhatTongTien()
        {
            decimal total = 0;
            foreach (DataRow r in _dtChiTiet.Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["DonGia"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(r["DonGia"]);
                }
            }
            lblTongTien.Text = string.Format("TỔNG TIỀN XÉT NGHIỆM: {0:N0} VNĐ", total);
        }

        private void LamMoi()
        {
            txtMaChiDinh.Text = "CD" + DateTime.Now.ToString("yyMMdd") + new Random().Next(1000, 9999).ToString();
            dtpNgayChiDinh.Value = DateTime.Now;
            txtLyDo.Clear();
            cboTrangThai.SelectedIndex = 0;
            _dtChiTiet.Clear();
            dgvChiTietXN.DataSource = _dtChiTiet;
            FormatGrid();
            CapNhatTongTien();

            txtKetQua.Clear();
            txtKTV.Clear();
            txtGhiChu.Clear();
            cboDanhGia.SelectedIndex = 0;
            _currentSelectedMaXN = null;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThemVaoPhieu_Click(object sender, EventArgs e)
        {
            if (cboDanhMucXN.SelectedItem == null) return;
            DataRowView row = cboDanhMucXN.SelectedItem as DataRowView;
            if (row == null) return;

            string maXN = row["MaXetNghiem"].ToString();

            // Kiểm tra xem đã có trong danh sách chưa
            foreach (DataRow r in _dtChiTiet.Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["MaXetNghiem"].ToString() == maXN)
                {
                    MessageBox.Show("Xét nghiệm này đã có trong phiếu chỉ định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            DataRow newRow = _dtChiTiet.NewRow();
            newRow["MaXetNghiem"] = maXN;
            newRow["TenXetNghiem"] = row["TenHienThi"].ToString().Split('[')[0].Trim();
            newRow["LoaiXetNghiem"] = row["LoaiXetNghiem"];
            newRow["DonGia"] = row["DonGia"];
            newRow["ChiSoBinhThuong"] = row["ChiSoBinhThuong"];
            newRow["DonViDo"] = row["DonViDo"];
            newRow["KetQua"] = "";
            newRow["DanhGiaKetQua"] = "";
            newRow["KTVThucHien"] = "";
            newRow["GhiChu"] = "";
            _dtChiTiet.Rows.Add(newRow);

            CapNhatTongTien();
        }

        private void btnXoaKhoiPhieu_Click(object sender, EventArgs e)
        {
            if (dgvChiTietXN.CurrentRow != null && dgvChiTietXN.CurrentRow.Index >= 0)
            {
                string maXN = dgvChiTietXN.CurrentRow.Cells["MaXetNghiem"].Value.ToString();
                for (int i = 0; i < _dtChiTiet.Rows.Count; i++)
                {
                    if (_dtChiTiet.Rows[i]["MaXetNghiem"].ToString() == maXN)
                    {
                        _dtChiTiet.Rows[i].Delete();
                        break;
                    }
                }
                CapNhatTongTien();
            }
        }

        private void dgvChiTietXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvChiTietXN.Rows[e.RowIndex];
            _currentSelectedMaXN = row.Cells["MaXetNghiem"].Value.ToString();
            txtKetQua.Text = row.Cells["KetQua"].Value != null ? row.Cells["KetQua"].Value.ToString() : "";
            txtKTV.Text = row.Cells["KTVThucHien"].Value != null ? row.Cells["KTVThucHien"].Value.ToString() : "";
            txtGhiChu.Text = row.Cells["GhiChu"].Value != null ? row.Cells["GhiChu"].Value.ToString() : "";
            string danhGia = row.Cells["DanhGiaKetQua"].Value != null ? row.Cells["DanhGiaKetQua"].Value.ToString() : "";
            if (!string.IsNullOrEmpty(danhGia)) cboDanhGia.Text = danhGia;
        }

        private void btnLuuKQ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentSelectedMaXN))
            {
                MessageBox.Show("Vui lòng chọn một xét nghiệm từ danh sách trên để cập nhật kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKetQua.Text))
            {
                MessageBox.Show("Vui lòng nhập kết quả xét nghiệm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKetQua.Focus();
                return;
            }

            string ketQua = txtKetQua.Text.Trim();
            string danhGia = cboDanhGia.SelectedItem != null ? cboDanhGia.SelectedItem.ToString() : cboDanhGia.Text;
            string ktv = txtKTV.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();
            DateTime ngayTra = DateTime.Now;

            // Cập nhật DataTable
            foreach (DataRow r in _dtChiTiet.Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["MaXetNghiem"].ToString() == _currentSelectedMaXN)
                {
                    r["KetQua"] = ketQua;
                    r["DanhGiaKetQua"] = danhGia;
                    r["KTVThucHien"] = ktv;
                    r["GhiChu"] = ghiChu;
                    r["NgayGioTraKQ"] = ngayTra;
                    break;
                }
            }

            // Nếu phiếu đã lưu trong CSDL thì cập nhật trực tiếp
            string maCD = txtMaChiDinh.Text.Trim();
            object exists = Db.Scalar("SELECT COUNT(*) FROM ChiTietXetNghiem WHERE MaChiDinh = @CD AND MaXetNghiem = @XN",
                new SqlParameter("@CD", maCD), new SqlParameter("@XN", _currentSelectedMaXN));

            if (exists != null && Convert.ToInt32(exists) > 0)
            {
                try
                {
                    string updateSql = "UPDATE ChiTietXetNghiem SET " +
                                       "KetQua = @KQ, DanhGiaKetQua = @DG, KTVThucHien = @KTV, GhiChu = @GC, NgayGioTraKQ = @NgayTra " +
                                       "WHERE MaChiDinh = @CD AND MaXetNghiem = @XN";
                    Db.Execute(updateSql,
                        new SqlParameter("@KQ", ketQua),
                        new SqlParameter("@DG", danhGia),
                        new SqlParameter("@KTV", ktv),
                        new SqlParameter("@GC", ghiChu),
                        new SqlParameter("@NgayTra", ngayTra),
                        new SqlParameter("@CD", maCD),
                        new SqlParameter("@XN", _currentSelectedMaXN));

                    // Kiểm tra nếu tất cả đã có kết quả thì cập nhật trạng thái phiếu
                    CheckAndCapNhatTrangThaiPhieu(maCD);
                    MessageBox.Show("Đã lưu kết quả xét nghiệm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật kết quả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đã ghi nhận kết quả tạm. Vui lòng bấm 'Lưu phiếu CĐ' để ghi vào CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CheckAndCapNhatTrangThaiPhieu(string maCD)
        {
            try
            {
                object countChuaCo = Db.Scalar("SELECT COUNT(*) FROM ChiTietXetNghiem WHERE MaChiDinh = @CD AND (KetQua IS NULL OR KetQua = '')",
                    new SqlParameter("@CD", maCD));

                if (countChuaCo != null && Convert.ToInt32(countChuaCo) == 0)
                {
                    Db.Execute("UPDATE PhieuChiDinhXetNghiem SET TrangThai = N'Đã có kết quả' WHERE MaChiDinh = @CD", new SqlParameter("@CD", maCD));
                    cboTrangThai.Text = "Đã có kết quả";
                }
                else
                {
                    Db.Execute("UPDATE PhieuChiDinhXetNghiem SET TrangThai = N'Đang thực hiện' WHERE MaChiDinh = @CD", new SqlParameter("@CD", maCD));
                    cboTrangThai.Text = "Đang thực hiện";
                }
            }
            catch { }
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (cboPhieuKham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu khám bệnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ chỉ định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một xét nghiệm vào phiếu chỉ định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maCD = txtMaChiDinh.Text.Trim();
            string maPK = cboPhieuKham.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue.ToString();
            DateTime ngayCD = dtpNgayChiDinh.Value;
            string lyDo = txtLyDo.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : cboTrangThai.Text;

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM PhieuChiDinhXetNghiem WHERE MaChiDinh = @CD", new SqlParameter("@CD", maCD));
                bool isExist = (exists != null && Convert.ToInt32(exists) > 0);

                if (isExist)
                {
                    string updateSql = "UPDATE PhieuChiDinhXetNghiem SET " +
                                       "MaPhieuKham = @PK, MaBacSiChiDinh = @BS, NgayChiDinh = @NgayCD, LyDoChiDinh = @LyDo, TrangThai = @TT " +
                                       "WHERE MaChiDinh = @CD";
                    Db.Execute(updateSql,
                        new SqlParameter("@PK", maPK),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayCD", ngayCD),
                        new SqlParameter("@LyDo", lyDo),
                        new SqlParameter("@TT", trangThai),
                        new SqlParameter("@CD", maCD));
                }
                else
                {
                    string insertSql = "INSERT INTO PhieuChiDinhXetNghiem (MaChiDinh, MaPhieuKham, MaBacSiChiDinh, NgayChiDinh, LyDoChiDinh, TrangThai) " +
                                       "VALUES (@CD, @PK, @BS, @NgayCD, @LyDo, @TT)";
                    Db.Execute(insertSql,
                        new SqlParameter("@CD", maCD),
                        new SqlParameter("@PK", maPK),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@NgayCD", ngayCD),
                        new SqlParameter("@LyDo", lyDo),
                        new SqlParameter("@TT", trangThai));
                }

                // Lưu danh sách chi tiết
                foreach (DataRow r in _dtChiTiet.Rows)
                {
                    if (r.RowState == DataRowState.Deleted) continue;
                    string maXN = r["MaXetNghiem"].ToString();
                    string ketQua = r["KetQua"] != DBNull.Value ? r["KetQua"].ToString() : "";
                    string danhGia = r["DanhGiaKetQua"] != DBNull.Value ? r["DanhGiaKetQua"].ToString() : "";
                    string ktv = r["KTVThucHien"] != DBNull.Value ? r["KTVThucHien"].ToString() : "";
                    string ghiChu = r["GhiChu"] != DBNull.Value ? r["GhiChu"].ToString() : "";
                    object ngayTra = (r["NgayGioTraKQ"] != DBNull.Value) ? r["NgayGioTraKQ"] : DBNull.Value;

                    object ctExists = Db.Scalar("SELECT COUNT(*) FROM ChiTietXetNghiem WHERE MaChiDinh = @CD AND MaXetNghiem = @XN",
                        new SqlParameter("@CD", maCD), new SqlParameter("@XN", maXN));

                    if (ctExists != null && Convert.ToInt32(ctExists) > 0)
                    {
                        Db.Execute("UPDATE ChiTietXetNghiem SET KetQua = @KQ, DanhGiaKetQua = @DG, KTVThucHien = @KTV, GhiChu = @GC, NgayGioTraKQ = @NgayTra " +
                                   "WHERE MaChiDinh = @CD AND MaXetNghiem = @XN",
                            new SqlParameter("@KQ", string.IsNullOrEmpty(ketQua) ? (object)DBNull.Value : ketQua),
                            new SqlParameter("@DG", string.IsNullOrEmpty(danhGia) ? (object)DBNull.Value : danhGia),
                            new SqlParameter("@KTV", ktv),
                            new SqlParameter("@GC", ghiChu),
                            new SqlParameter("@NgayTra", ngayTra),
                            new SqlParameter("@CD", maCD),
                            new SqlParameter("@XN", maXN));
                    }
                    else
                    {
                        Db.Execute("INSERT INTO ChiTietXetNghiem (MaChiDinh, MaXetNghiem, KetQua, DanhGiaKetQua, KTVThucHien, GhiChu, NgayGioTraKQ) " +
                                   "VALUES (@CD, @XN, @KQ, @DG, @KTV, @GC, @NgayTra)",
                            new SqlParameter("@CD", maCD),
                            new SqlParameter("@XN", maXN),
                            new SqlParameter("@KQ", string.IsNullOrEmpty(ketQua) ? (object)DBNull.Value : ketQua),
                            new SqlParameter("@DG", string.IsNullOrEmpty(danhGia) ? (object)DBNull.Value : danhGia),
                            new SqlParameter("@KTV", ktv),
                            new SqlParameter("@GC", ghiChu),
                            new SqlParameter("@NgayTra", ngayTra));
                    }
                }

                // Xóa các chi tiết bị remove khỏi bảng
                string sqlGetExisting = "SELECT MaXetNghiem FROM ChiTietXetNghiem WHERE MaChiDinh = @CD";
                DataTable dtEx = Db.Query(sqlGetExisting, new SqlParameter("@CD", maCD));
                foreach (DataRow r in dtEx.Rows)
                {
                    string maXNEx = r["MaXetNghiem"].ToString();
                    bool found = false;
                    foreach (DataRow cur in _dtChiTiet.Rows)
                    {
                        if (cur.RowState != DataRowState.Deleted && cur["MaXetNghiem"].ToString() == maXNEx)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Db.Execute("DELETE FROM ChiTietXetNghiem WHERE MaChiDinh = @CD AND MaXetNghiem = @XN",
                            new SqlParameter("@CD", maCD), new SqlParameter("@XN", maXNEx));
                    }
                }

                MessageBox.Show("Lưu phiếu chỉ định xét nghiệm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChiTietXN(maCD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu chỉ định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string maCD = txtMaChiDinh.Text.Trim();
            if (string.IsNullOrEmpty(maCD)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu chỉ định " + maCD + " và toàn bộ xét nghiệm liên quan?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM ChiTietXetNghiem WHERE MaChiDinh = @CD", new SqlParameter("@CD", maCD));
                    Db.Execute("DELETE FROM PhieuChiDinhXetNghiem WHERE MaChiDinh = @CD", new SqlParameter("@CD", maCD));
                    MessageBox.Show("Đã xóa phiếu chỉ định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
