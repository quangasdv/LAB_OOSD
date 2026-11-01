using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadKhoaCombo();
            LoadThuoc();
            LoadXN();
            LoadKhoa();
            LoadBacSi();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabThuoc) LoadThuoc();
            else if (tabControl.SelectedTab == tabXetNghiem) LoadXN();
            else if (tabControl.SelectedTab == tabKhoa) LoadKhoa();
            else if (tabControl.SelectedTab == tabBacSi)
            {
                LoadKhoaCombo();
                LoadBacSi();
            }
        }

        #region TAB 1: THUỐC
        private void LoadThuoc()
        {
            try
            {
                string sql = "SELECT * FROM Thuoc ORDER BY TenThuoc";
                DataTable dt = Db.Query(sql);
                dgvThuoc.DataSource = dt;
                FormatGridThuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridThuoc()
        {
            if (dgvThuoc.Columns.Count == 0) return;
            if (dgvThuoc.Columns["MaThuoc"] != null) dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            if (dgvThuoc.Columns["TenThuoc"] != null) dgvThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            if (dgvThuoc.Columns["HoatChatChinh"] != null) dgvThuoc.Columns["HoatChatChinh"].HeaderText = "Hoạt chất chính";
            if (dgvThuoc.Columns["DonViTinh"] != null) dgvThuoc.Columns["DonViTinh"].HeaderText = "ĐVT";
            if (dgvThuoc.Columns["HamLuong"] != null) dgvThuoc.Columns["HamLuong"].HeaderText = "Hàm lượng";
            if (dgvThuoc.Columns["DuongDung"] != null) dgvThuoc.Columns["DuongDung"].HeaderText = "Đường dùng";
            if (dgvThuoc.Columns["DonGia"] != null)
            {
                dgvThuoc.Columns["DonGia"].HeaderText = "Đơn giá (đ)";
                dgvThuoc.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            if (dgvThuoc.Columns["ChongChiDinh"] != null) dgvThuoc.Columns["ChongChiDinh"].HeaderText = "Chống chỉ định";
            if (dgvThuoc.Columns["TuongTacThuoc"] != null) dgvThuoc.Columns["TuongTacThuoc"].HeaderText = "Tương tác thuốc";
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvThuoc.Rows[e.RowIndex];
            txtMaThuoc.Text = r.Cells["MaThuoc"].Value != null ? r.Cells["MaThuoc"].Value.ToString() : "";
            txtTenThuoc.Text = r.Cells["TenThuoc"].Value != null ? r.Cells["TenThuoc"].Value.ToString() : "";
            txtHoatChat.Text = r.Cells["HoatChatChinh"].Value != null ? r.Cells["HoatChatChinh"].Value.ToString() : "";
            txtDonViTinh.Text = r.Cells["DonViTinh"].Value != null ? r.Cells["DonViTinh"].Value.ToString() : "";
            txtHamLuong.Text = r.Cells["HamLuong"].Value != null ? r.Cells["HamLuong"].Value.ToString() : "";
            txtDuongDung.Text = r.Cells["DuongDung"].Value != null ? r.Cells["DuongDung"].Value.ToString() : "";
            txtDonGiaThuoc.Text = r.Cells["DonGia"].Value != null ? Convert.ToDecimal(r.Cells["DonGia"].Value).ToString("N0") : "0";
            txtChongChiDinh.Text = r.Cells["ChongChiDinh"].Value != null ? r.Cells["ChongChiDinh"].Value.ToString() : "";
            txtTuongTacThuoc.Text = r.Cells["TuongTacThuoc"].Value != null ? r.Cells["TuongTacThuoc"].Value.ToString() : "";
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            txtMaThuoc.Text = "T" + DateTime.Now.ToString("yyMMdd") + new Random().Next(10, 99).ToString();
            txtTenThuoc.Clear();
            txtHoatChat.Clear();
            txtDonViTinh.Text = "Viên";
            txtHamLuong.Clear();
            txtDuongDung.Text = "Uống";
            txtDonGiaThuoc.Text = "0";
            txtChongChiDinh.Clear();
            txtTuongTacThuoc.Clear();
            txtTenThuoc.Focus();
        }

        private void btnLuuThuoc_Click(object sender, EventArgs e)
        {
            string ma = txtMaThuoc.Text.Trim();
            string ten = txtTenThuoc.Text.Trim();
            string hc = txtHoatChat.Text.Trim();
            string dvt = txtDonViTinh.Text.Trim();
            string hl = txtHamLuong.Text.Trim();
            string dd = txtDuongDung.Text.Trim();
            decimal gia;
            decimal.TryParse(txtDonGiaThuoc.Text.Replace(",", "").Replace(".", "").Trim(), out gia);
            string ccd = txtChongChiDinh.Text.Trim();
            string tt = txtTuongTacThuoc.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(hc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã thuốc, Tên thuốc và Hoạt chất chính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM Thuoc WHERE MaThuoc = @Ma", new SqlParameter("@Ma", ma));
                if (exists != null && Convert.ToInt32(exists) > 0)
                {
                    string sql = "UPDATE Thuoc SET TenThuoc = @Ten, HoatChatChinh = @HC, DonViTinh = @DVT, " +
                                 "HamLuong = @HL, DuongDung = @DD, DonGia = @Gia, ChongChiDinh = @CCD, TuongTacThuoc = @TT " +
                                 "WHERE MaThuoc = @Ma";
                    Db.Execute(sql,
                        new SqlParameter("@Ten", ten), new SqlParameter("@HC", hc),
                        new SqlParameter("@DVT", dvt), new SqlParameter("@HL", hl),
                        new SqlParameter("@DD", dd), new SqlParameter("@Gia", gia),
                        new SqlParameter("@CCD", ccd), new SqlParameter("@TT", tt),
                        new SqlParameter("@Ma", ma));
                }
                else
                {
                    string sql = "INSERT INTO Thuoc (MaThuoc, TenThuoc, HoatChatChinh, DonViTinh, HamLuong, DuongDung, DonGia, ChongChiDinh, TuongTacThuoc) " +
                                 "VALUES (@Ma, @Ten, @HC, @DVT, @HL, @DD, @Gia, @CCD, @TT)";
                    Db.Execute(sql,
                        new SqlParameter("@Ma", ma), new SqlParameter("@Ten", ten),
                        new SqlParameter("@HC", hc), new SqlParameter("@DVT", dvt),
                        new SqlParameter("@HL", hl), new SqlParameter("@DD", dd),
                        new SqlParameter("@Gia", gia), new SqlParameter("@CCD", ccd),
                        new SqlParameter("@TT", tt));
                }

                MessageBox.Show("Lưu thông tin thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            string ma = txtMaThuoc.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa thuốc " + ma + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM Thuoc WHERE MaThuoc = @Ma", new SqlParameter("@Ma", ma));
                    MessageBox.Show("Đã xóa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuoc();
                    btnThemThuoc_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa thuốc (đang có trong toa thuốc): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region TAB 2: XÉT NGHIỆM
        private void LoadXN()
        {
            try
            {
                string sql = "SELECT * FROM DanhMucXetNghiem ORDER BY LoaiXetNghiem, TenXetNghiem";
                DataTable dt = Db.Query(sql);
                dgvXN.DataSource = dt;
                FormatGridXN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục xét nghiệm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridXN()
        {
            if (dgvXN.Columns.Count == 0) return;
            if (dgvXN.Columns["MaXetNghiem"] != null) dgvXN.Columns["MaXetNghiem"].HeaderText = "Mã XN";
            if (dgvXN.Columns["TenXetNghiem"] != null) dgvXN.Columns["TenXetNghiem"].HeaderText = "Tên xét nghiệm";
            if (dgvXN.Columns["LoaiXetNghiem"] != null) dgvXN.Columns["LoaiXetNghiem"].HeaderText = "Loại xét nghiệm";
            if (dgvXN.Columns["DonGia"] != null)
            {
                dgvXN.Columns["DonGia"].HeaderText = "Đơn giá (đ)";
                dgvXN.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            if (dgvXN.Columns["ChiSoBinhThuong"] != null) dgvXN.Columns["ChiSoBinhThuong"].HeaderText = "Chỉ số chuẩn";
            if (dgvXN.Columns["DonViDo"] != null) dgvXN.Columns["DonViDo"].HeaderText = "Đơn vị";
            if (dgvXN.Columns["ThoiGianTraKetQua"] != null) dgvXN.Columns["ThoiGianTraKetQua"].HeaderText = "Thời gian trả";
        }

        private void dgvXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvXN.Rows[e.RowIndex];
            txtMaXN.Text = r.Cells["MaXetNghiem"].Value != null ? r.Cells["MaXetNghiem"].Value.ToString() : "";
            txtTenXN.Text = r.Cells["TenXetNghiem"].Value != null ? r.Cells["TenXetNghiem"].Value.ToString() : "";
            txtLoaiXN.Text = r.Cells["LoaiXetNghiem"].Value != null ? r.Cells["LoaiXetNghiem"].Value.ToString() : "";
            txtDonGiaXN.Text = r.Cells["DonGia"].Value != null ? Convert.ToDecimal(r.Cells["DonGia"].Value).ToString("N0") : "0";
            txtChiSoBinhThuong.Text = r.Cells["ChiSoBinhThuong"].Value != null ? r.Cells["ChiSoBinhThuong"].Value.ToString() : "";
            txtDonViDo.Text = r.Cells["DonViDo"].Value != null ? r.Cells["DonViDo"].Value.ToString() : "";
            txtThoiGianTra.Text = r.Cells["ThoiGianTraKetQua"].Value != null ? r.Cells["ThoiGianTraKetQua"].Value.ToString() : "";
        }

        private void btnThemXN_Click(object sender, EventArgs e)
        {
            txtMaXN.Text = "XN" + DateTime.Now.ToString("yyMMdd") + new Random().Next(10, 99).ToString();
            txtTenXN.Clear();
            txtLoaiXN.Text = "Huyết học";
            txtDonGiaXN.Text = "0";
            txtChiSoBinhThuong.Clear();
            txtDonViDo.Clear();
            txtThoiGianTra.Text = "60 phút";
            txtTenXN.Focus();
        }

        private void btnLuuXN_Click(object sender, EventArgs e)
        {
            string ma = txtMaXN.Text.Trim();
            string ten = txtTenXN.Text.Trim();
            string loai = txtLoaiXN.Text.Trim();
            decimal gia;
            decimal.TryParse(txtDonGiaXN.Text.Replace(",", "").Replace(".", "").Trim(), out gia);
            string chuan = txtChiSoBinhThuong.Text.Trim();
            string dvi = txtDonViDo.Text.Trim();
            string tg = txtThoiGianTra.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(loai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã XN, Tên XN và Loại XN!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM DanhMucXetNghiem WHERE MaXetNghiem = @Ma", new SqlParameter("@Ma", ma));
                if (exists != null && Convert.ToInt32(exists) > 0)
                {
                    string sql = "UPDATE DanhMucXetNghiem SET TenXetNghiem = @Ten, LoaiXetNghiem = @Loai, " +
                                 "DonGia = @Gia, ChiSoBinhThuong = @Chuan, DonViDo = @Dvi, ThoiGianTraKetQua = @TG " +
                                 "WHERE MaXetNghiem = @Ma";
                    Db.Execute(sql,
                        new SqlParameter("@Ten", ten), new SqlParameter("@Loai", loai),
                        new SqlParameter("@Gia", gia), new SqlParameter("@Chuan", chuan),
                        new SqlParameter("@Dvi", dvi), new SqlParameter("@TG", tg),
                        new SqlParameter("@Ma", ma));
                }
                else
                {
                    string sql = "INSERT INTO DanhMucXetNghiem (MaXetNghiem, TenXetNghiem, LoaiXetNghiem, DonGia, ChiSoBinhThuong, DonViDo, ThoiGianTraKetQua) " +
                                 "VALUES (@Ma, @Ten, @Loai, @Gia, @Chuan, @Dvi, @TG)";
                    Db.Execute(sql,
                        new SqlParameter("@Ma", ma), new SqlParameter("@Ten", ten),
                        new SqlParameter("@Loai", loai), new SqlParameter("@Gia", gia),
                        new SqlParameter("@Chuan", chuan), new SqlParameter("@Dvi", dvi),
                        new SqlParameter("@TG", tg));
                }

                MessageBox.Show("Lưu thông tin xét nghiệm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadXN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu xét nghiệm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaXN_Click(object sender, EventArgs e)
        {
            string ma = txtMaXN.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa xét nghiệm " + ma + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM DanhMucXetNghiem WHERE MaXetNghiem = @Ma", new SqlParameter("@Ma", ma));
                    MessageBox.Show("Đã xóa xét nghiệm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadXN();
                    btnThemXN_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa xét nghiệm (đang có trong phiếu chỉ định): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region TAB 3: KHOA ĐIỀU TRỊ
        private void LoadKhoa()
        {
            try
            {
                string sql = "SELECT * FROM KhoaDieuTri ORDER BY MaKhoa";
                DataTable dt = Db.Query(sql);
                dgvKhoa.DataSource = dt;
                FormatGridKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridKhoa()
        {
            if (dgvKhoa.Columns.Count == 0) return;
            if (dgvKhoa.Columns["MaKhoa"] != null) dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã khoa";
            if (dgvKhoa.Columns["TenKhoa"] != null) dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";
            if (dgvKhoa.Columns["ViTri"] != null) dgvKhoa.Columns["ViTri"].HeaderText = "Vị trí";
            if (dgvKhoa.Columns["DienThoaiKhoa"] != null) dgvKhoa.Columns["DienThoaiKhoa"].HeaderText = "Điện thoại";
            if (dgvKhoa.Columns["TruongKhoa"] != null) dgvKhoa.Columns["TruongKhoa"].HeaderText = "Trưởng khoa";
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvKhoa.Rows[e.RowIndex];
            txtMaKhoa.Text = r.Cells["MaKhoa"].Value != null ? r.Cells["MaKhoa"].Value.ToString() : "";
            txtTenKhoa.Text = r.Cells["TenKhoa"].Value != null ? r.Cells["TenKhoa"].Value.ToString() : "";
            txtViTri.Text = r.Cells["ViTri"].Value != null ? r.Cells["ViTri"].Value.ToString() : "";
            txtDienThoaiKhoa.Text = r.Cells["DienThoaiKhoa"].Value != null ? r.Cells["DienThoaiKhoa"].Value.ToString() : "";
            txtTruongKhoa.Text = r.Cells["TruongKhoa"].Value != null ? r.Cells["TruongKhoa"].Value.ToString() : "";
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "K" + new Random().Next(10, 99).ToString();
            txtTenKhoa.Clear();
            txtViTri.Text = "Khu khám bệnh - Tầng 1";
            txtDienThoaiKhoa.Clear();
            txtTruongKhoa.Clear();
            txtTenKhoa.Focus();
        }

        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            string ten = txtTenKhoa.Text.Trim();
            string vt = txtViTri.Text.Trim();
            string dt = txtDienThoaiKhoa.Text.Trim();
            string tk = txtTruongKhoa.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập Mã khoa và Tên khoa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM KhoaDieuTri WHERE MaKhoa = @Ma", new SqlParameter("@Ma", ma));
                if (exists != null && Convert.ToInt32(exists) > 0)
                {
                    string sql = "UPDATE KhoaDieuTri SET TenKhoa = @Ten, ViTri = @VT, DienThoaiKhoa = @DT, TruongKhoa = @TK " +
                                 "WHERE MaKhoa = @Ma";
                    Db.Execute(sql,
                        new SqlParameter("@Ten", ten), new SqlParameter("@VT", vt),
                        new SqlParameter("@DT", dt), new SqlParameter("@TK", tk),
                        new SqlParameter("@Ma", ma));
                }
                else
                {
                    string sql = "INSERT INTO KhoaDieuTri (MaKhoa, TenKhoa, ViTri, DienThoaiKhoa, TruongKhoa) " +
                                 "VALUES (@Ma, @Ten, @VT, @DT, @TK)";
                    Db.Execute(sql,
                        new SqlParameter("@Ma", ma), new SqlParameter("@Ten", ten),
                        new SqlParameter("@VT", vt), new SqlParameter("@DT", dt),
                        new SqlParameter("@TK", tk));
                }

                MessageBox.Show("Lưu khoa điều trị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa khoa " + ma + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM KhoaDieuTri WHERE MaKhoa = @Ma", new SqlParameter("@Ma", ma));
                    MessageBox.Show("Đã xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhoa();
                    btnThemKhoa_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa khoa (đang có bác sĩ hoặc bệnh án trực thuộc): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region TAB 4: BÁC SĨ
        private void LoadKhoaCombo()
        {
            try
            {
                string sql = "SELECT MaKhoa, TenKhoa FROM KhoaDieuTri ORDER BY TenKhoa";
                DataTable dt = Db.Query(sql);
                cboKhoaBS.DataSource = dt;
                cboKhoaBS.DisplayMember = "TenKhoa";
                cboKhoaBS.ValueMember = "MaKhoa";
            }
            catch { }
        }

        private void LoadBacSi()
        {
            try
            {
                string sql = "SELECT bs.MaBacSi, bs.HoTen, k.TenKhoa, bs.ChuyenKhoa, " +
                             "bs.HocHamHocVi, bs.DienThoai, bs.Email, bs.MaKhoa " +
                             "FROM BacSi bs JOIN KhoaDieuTri k ON bs.MaKhoa = k.MaKhoa " +
                             "ORDER BY bs.HoTen";
                DataTable dt = Db.Query(sql);
                dgvBacSi.DataSource = dt;
                FormatGridBS();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridBS()
        {
            if (dgvBacSi.Columns.Count == 0) return;
            if (dgvBacSi.Columns["MaBacSi"] != null) dgvBacSi.Columns["MaBacSi"].HeaderText = "Mã BS";
            if (dgvBacSi.Columns["HoTen"] != null) dgvBacSi.Columns["HoTen"].HeaderText = "Họ tên bác sĩ";
            if (dgvBacSi.Columns["TenKhoa"] != null) dgvBacSi.Columns["TenKhoa"].HeaderText = "Khoa";
            if (dgvBacSi.Columns["ChuyenKhoa"] != null) dgvBacSi.Columns["ChuyenKhoa"].HeaderText = "Chuyên khoa";
            if (dgvBacSi.Columns["HocHamHocVi"] != null) dgvBacSi.Columns["HocHamHocVi"].HeaderText = "Học vị";
            if (dgvBacSi.Columns["DienThoai"] != null) dgvBacSi.Columns["DienThoai"].HeaderText = "Điện thoại";
            if (dgvBacSi.Columns["Email"] != null) dgvBacSi.Columns["Email"].HeaderText = "Email";
            if (dgvBacSi.Columns["MaKhoa"] != null) dgvBacSi.Columns["MaKhoa"].Visible = false;
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvBacSi.Rows[e.RowIndex];
            txtMaBS.Text = r.Cells["MaBacSi"].Value != null ? r.Cells["MaBacSi"].Value.ToString() : "";
            txtHoTenBS.Text = r.Cells["HoTen"].Value != null ? r.Cells["HoTen"].Value.ToString() : "";
            if (r.Cells["MaKhoa"].Value != null) cboKhoaBS.SelectedValue = r.Cells["MaKhoa"].Value.ToString();
            txtHocHam.Text = r.Cells["HocHamHocVi"].Value != null ? r.Cells["HocHamHocVi"].Value.ToString() : "";
            txtChuyenKhoa.Text = r.Cells["ChuyenKhoa"].Value != null ? r.Cells["ChuyenKhoa"].Value.ToString() : "";
            txtDienThoaiBS.Text = r.Cells["DienThoai"].Value != null ? r.Cells["DienThoai"].Value.ToString() : "";
            txtEmailBS.Text = r.Cells["Email"].Value != null ? r.Cells["Email"].Value.ToString() : "";
        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            txtMaBS.Text = "BS" + new Random().Next(10, 99).ToString();
            txtHoTenBS.Clear();
            txtHocHam.Text = "BS.CKI";
            txtChuyenKhoa.Clear();
            txtDienThoaiBS.Clear();
            txtEmailBS.Clear();
            txtHoTenBS.Focus();
        }

        private void btnLuuBS_Click(object sender, EventArgs e)
        {
            string ma = txtMaBS.Text.Trim();
            string ten = txtHoTenBS.Text.Trim();
            string khoa = (cboKhoaBS.SelectedValue != null) ? cboKhoaBS.SelectedValue.ToString() : "K01";
            string hh = txtHocHam.Text.Trim();
            string ck = txtChuyenKhoa.Text.Trim();
            string dt = txtDienThoaiBS.Text.Trim();
            string em = txtEmailBS.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ck) || string.IsNullOrEmpty(dt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã BS, Họ tên, Chuyên khoa và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM BacSi WHERE MaBacSi = @Ma", new SqlParameter("@Ma", ma));
                if (exists != null && Convert.ToInt32(exists) > 0)
                {
                    string sql = "UPDATE BacSi SET HoTen = @Ten, MaKhoa = @Khoa, HocHamHocVi = @HH, " +
                                 "ChuyenKhoa = @CK, DienThoai = @DT, Email = @EM WHERE MaBacSi = @Ma";
                    Db.Execute(sql,
                        new SqlParameter("@Ten", ten), new SqlParameter("@Khoa", khoa),
                        new SqlParameter("@HH", hh), new SqlParameter("@CK", ck),
                        new SqlParameter("@DT", dt), new SqlParameter("@EM", em),
                        new SqlParameter("@Ma", ma));
                }
                else
                {
                    string sql = "INSERT INTO BacSi (MaBacSi, MaKhoa, HoTen, HocHamHocVi, ChuyenKhoa, DienThoai, Email) " +
                                 "VALUES (@Ma, @Khoa, @Ten, @HH, @CK, @DT, @EM)";
                    Db.Execute(sql,
                        new SqlParameter("@Ma", ma), new SqlParameter("@Khoa", khoa),
                        new SqlParameter("@Ten", ten), new SqlParameter("@HH", hh),
                        new SqlParameter("@CK", ck), new SqlParameter("@DT", dt),
                        new SqlParameter("@EM", em));
                }

                MessageBox.Show("Lưu thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBacSi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaBS_Click(object sender, EventArgs e)
        {
            string ma = txtMaBS.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa bác sĩ " + ma + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("DELETE FROM BacSi WHERE MaBacSi = @Ma", new SqlParameter("@Ma", ma));
                    MessageBox.Show("Đã xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBacSi();
                    btnThemBS_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa bác sĩ (đang liên kết với các đợt khám/điều trị): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
