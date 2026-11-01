using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmHoanTatDieuTri : Form
    {
        private decimal _tienKham = 0;
        private decimal _tienXN = 0;
        private decimal _tienThuoc = 0;
        private decimal _tongVienPhi = 0;

        public FrmHoanTatDieuTri()
        {
            InitializeComponent();
        }

        private void FrmHoanTatDieuTri_Load(object sender, EventArgs e)
        {
            LoadBacSi();
            LoadDotDieuTri();
            cboKetQua.SelectedIndex = 0;
            LamMoi();
            LoadDanhSachHoanTat();
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

        private void LoadDotDieuTri()
        {
            try
            {
                string sql = "SELECT ddt.MaDotDieuTri, " +
                             "ddt.MaDotDieuTri + ' - ' + bn.HoTen + ' (' + ddt.LoaiDieuTri + ' - ' + ddt.TrangThai + ')' AS TenHienThi, " +
                             "bn.HoTen, bn.SoCCCD_BHYT, k.TenKhoa, bs.HoTen AS TenBacSi, ddt.LoaiDieuTri, ddt.TrangThai " +
                             "FROM DotDieuTri ddt " +
                             "JOIN HoSoBenhAn hs ON ddt.MaHoSo = hs.MaHoSo " +
                             "JOIN BenhNhan bn ON hs.MaBenhNhan = bn.MaBenhNhan " +
                             "JOIN KhoaDieuTri k ON ddt.MaKhoa = k.MaKhoa " +
                             "JOIN BacSi bs ON ddt.MaBacSiPhuTrach = bs.MaBacSi " +
                             "ORDER BY ddt.NgayBatDau DESC";
                DataTable dt = Db.Query(sql);
                cboDotDieuTri.DataSource = dt;
                cboDotDieuTri.DisplayMember = "TenHienThi";
                cboDotDieuTri.ValueMember = "MaDotDieuTri";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải đợt điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDotDieuTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDotDieuTri.SelectedValue == null) return;
            DataRowView row = cboDotDieuTri.SelectedItem as DataRowView;
            if (row != null)
            {
                string hoTen = row["HoTen"].ToString();
                string khoa = row["TenKhoa"].ToString();
                string bs = row["TenBacSi"].ToString();
                string loai = row["LoaiDieuTri"].ToString();
                string trangThai = row["TrangThai"].ToString();
                string bhyt = row["SoCCCD_BHYT"] != DBNull.Value ? row["SoCCCD_BHYT"].ToString() : "";

                lblThongTinDot.Text = string.Format("Bệnh nhân: {0} | Khoa: {1} | BS: {2} | Loại: {3} ({4})",
                    hoTen, khoa, bs, loai, trangThai);

                if (!string.IsNullOrEmpty(bhyt))
                {
                    numPhanTramBHYT.Value = 80;
                }
                else
                {
                    numPhanTramBHYT.Value = 0;
                }

                string maDot = row["MaDotDieuTri"].ToString();
                TinhChiPhiDieuTri(maDot);
                KiemTraDaHoanTatChua(maDot);
            }
        }

        private void TinhChiPhiDieuTri(string maDot)
        {
            try
            {
                // 1. Tiền khám: mỗi lần khám 150,000 đ
                object countKham = Db.Scalar("SELECT COUNT(*) FROM PhieuKhamBenh WHERE MaDotDieuTri = @Dot", new SqlParameter("@Dot", maDot));
                int soLanKham = (countKham != null) ? Convert.ToInt32(countKham) : 1;
                if (soLanKham < 1) soLanKham = 1;
                _tienKham = soLanKham * 150000m;

                // 2. Tiền xét nghiệm: sum từ DanhMucXetNghiem qua ChiTietXetNghiem
                string sqlXN = "SELECT ISNULL(SUM(dmxn.DonGia), 0) " +
                               "FROM PhieuChiDinhXetNghiem cdxn " +
                               "JOIN ChiTietXetNghiem ctxn ON cdxn.MaChiDinh = ctxn.MaChiDinh " +
                               "JOIN DanhMucXetNghiem dmxn ON ctxn.MaXetNghiem = dmxn.MaXetNghiem " +
                               "JOIN PhieuKhamBenh pk ON cdxn.MaPhieuKham = pk.MaPhieuKham " +
                               "WHERE pk.MaDotDieuTri = @Dot";
                object sumXN = Db.Scalar(sqlXN, new SqlParameter("@Dot", maDot));
                _tienXN = (sumXN != null && sumXN != DBNull.Value) ? Convert.ToDecimal(sumXN) : 0;

                // 3. Tiền thuốc: sum từ ChiTietToaThuoc
                string sqlThuoc = "SELECT ISNULL(SUM(cttt.SoLuong * cttt.DonGiaLucKe), 0) " +
                                  "FROM ToaThuoc tt " +
                                  "JOIN ChiTietToaThuoc cttt ON tt.MaToaThuoc = cttt.MaToaThuoc " +
                                  "JOIN PhieuKhamBenh pk ON tt.MaPhieuKham = pk.MaPhieuKham " +
                                  "WHERE pk.MaDotDieuTri = @Dot";
                object sumThuoc = Db.Scalar(sqlThuoc, new SqlParameter("@Dot", maDot));
                _tienThuoc = (sumThuoc != null && sumThuoc != DBNull.Value) ? Convert.ToDecimal(sumThuoc) : 0;

                _tongVienPhi = _tienKham + _tienXN + _tienThuoc;

                lblChiTietChiPhi.Text = string.Format("Bao gồm: Khám bệnh ({0} lần): {1:N0} đ | Xét nghiệm: {2:N0} đ | Toa thuốc: {3:N0} đ",
                    soLanKham, _tienKham, _tienXN, _tienThuoc);

                txtTongVienPhi.Text = string.Format("{0:N0}", _tongVienPhi);

                TinhToanVienPhi(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính viện phí: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhToanVienPhi(object sender, EventArgs e)
        {
            decimal ptBHYT = numPhanTramBHYT.Value;
            decimal bhytChiTra = Math.Round(_tongVienPhi * (ptBHYT / 100m));
            decimal bnTra = _tongVienPhi - bhytChiTra;

            txtBHYTChiTra.Text = string.Format("{0:N0}", bhytChiTra);
            txtBenhNhanTra.Text = string.Format("{0:N0}", bnTra);
        }

        private void KiemTraDaHoanTatChua(string maDot)
        {
            try
            {
                string sql = "SELECT * FROM HoanTatDieuTri WHERE MaDotDieuTri = @Dot";
                DataTable dt = Db.Query(sql, new SqlParameter("@Dot", maDot));
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaHoanTat.Text = r["MaHoanTat"].ToString();
                    if (r["NgayHoanTat"] != DBNull.Value) dtpNgayHoanTat.Value = Convert.ToDateTime(r["NgayHoanTat"]);
                    if (r["MaBacSiXacNhan"] != DBNull.Value) cboBacSi.SelectedValue = r["MaBacSiXacNhan"].ToString();
                    if (r["KetQuaDieuTri"] != DBNull.Value) cboKetQua.Text = r["KetQuaDieuTri"].ToString();
                    txtTinhTrang.Text = r["TinhTrangXuatVien"] != DBNull.Value ? r["TinhTrangXuatVien"].ToString() : "";
                    txtDanDo.Text = r["DanDoSauXuatVien"] != DBNull.Value ? r["DanDoSauXuatVien"].ToString() : "";

                    if (r["TongTienVienPhi"] != DBNull.Value) txtTongVienPhi.Text = string.Format("{0:N0}", Convert.ToDecimal(r["TongTienVienPhi"]));
                    if (r["BHYTChiTra"] != DBNull.Value) txtBHYTChiTra.Text = string.Format("{0:N0}", Convert.ToDecimal(r["BHYTChiTra"]));
                    if (r["BenhNhanThanhToan"] != DBNull.Value) txtBenhNhanTra.Text = string.Format("{0:N0}", Convert.ToDecimal(r["BenhNhanThanhToan"]));

                    btnHoanTat.Text = "Cập nhật hoàn tất";
                }
                else
                {
                    txtMaHoanTat.Text = "HT" + DateTime.Now.ToString("yyMMdd") + new Random().Next(1000, 9999).ToString();
                    dtpNgayHoanTat.Value = DateTime.Now;
                    cboKetQua.Text = "Thuyên giảm";
                    txtTinhTrang.Text = "Tình trạng ổn định, các chỉ số sinh hiệu trong giới hạn bình thường, hết sốt.";
                    txtDanDo.Text = "Uống thuốc theo đúng toa hướng dẫn, nghỉ ngơi hợp lý, tái khám sau 1 tuần hoặc khi có dấu hiệu bất thường.";
                    btnHoanTat.Text = "✓ Quyết toán & Xuất viện";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra hồ sơ hoàn tất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachHoanTat()
        {
            try
            {
                string sql = "SELECT ht.MaHoanTat, ht.MaDotDieuTri, bn.HoTen AS TenBenhNhan, " +
                             "bs.HoTen AS BacSiXacNhan, ht.NgayHoanTat, ht.KetQuaDieuTri, " +
                             "ht.TongTienVienPhi, ht.BHYTChiTra, ht.BenhNhanThanhToan " +
                             "FROM HoanTatDieuTri ht " +
                             "JOIN DotDieuTri ddt ON ht.MaDotDieuTri = ddt.MaDotDieuTri " +
                             "JOIN HoSoBenhAn hs ON ddt.MaHoSo = hs.MaHoSo " +
                             "JOIN BenhNhan bn ON hs.MaBenhNhan = bn.MaBenhNhan " +
                             "JOIN BacSi bs ON ht.MaBacSiXacNhan = bs.MaBacSi " +
                             "ORDER BY ht.NgayHoanTat DESC";
                DataTable dt = Db.Query(sql);
                dgvHoanTat.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hoàn tất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvHoanTat.Columns.Count == 0) return;
            if (dgvHoanTat.Columns["MaHoanTat"] != null) dgvHoanTat.Columns["MaHoanTat"].HeaderText = "Mã HT";
            if (dgvHoanTat.Columns["MaDotDieuTri"] != null) dgvHoanTat.Columns["MaDotDieuTri"].HeaderText = "Mã đợt ĐT";
            if (dgvHoanTat.Columns["TenBenhNhan"] != null) dgvHoanTat.Columns["TenBenhNhan"].HeaderText = "Bệnh nhân";
            if (dgvHoanTat.Columns["BacSiXacNhan"] != null) dgvHoanTat.Columns["BacSiXacNhan"].HeaderText = "BS xác nhận";
            if (dgvHoanTat.Columns["NgayHoanTat"] != null)
            {
                dgvHoanTat.Columns["NgayHoanTat"].HeaderText = "Ngày xuất viện";
                dgvHoanTat.Columns["NgayHoanTat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvHoanTat.Columns["KetQuaDieuTri"] != null) dgvHoanTat.Columns["KetQuaDieuTri"].HeaderText = "Kết quả";
            if (dgvHoanTat.Columns["TongTienVienPhi"] != null)
            {
                dgvHoanTat.Columns["TongTienVienPhi"].HeaderText = "Tổng viện phí";
                dgvHoanTat.Columns["TongTienVienPhi"].DefaultCellStyle.Format = "N0";
            }
            if (dgvHoanTat.Columns["BHYTChiTra"] != null)
            {
                dgvHoanTat.Columns["BHYTChiTra"].HeaderText = "BHYT trả";
                dgvHoanTat.Columns["BHYTChiTra"].DefaultCellStyle.Format = "N0";
            }
            if (dgvHoanTat.Columns["BenhNhanThanhToan"] != null)
            {
                dgvHoanTat.Columns["BenhNhanThanhToan"].HeaderText = "BN thanh toán";
                dgvHoanTat.Columns["BenhNhanThanhToan"].DefaultCellStyle.Format = "N0";
            }
        }

        private void LamMoi()
        {
            txtMaHoanTat.Text = "HT" + DateTime.Now.ToString("yyMMdd") + new Random().Next(1000, 9999).ToString();
            dtpNgayHoanTat.Value = DateTime.Now;
            cboKetQua.SelectedIndex = 1;
            txtTinhTrang.Text = "Tình trạng ổn định, các chỉ số sinh hiệu trong giới hạn bình thường, hết sốt.";
            txtDanDo.Text = "Uống thuốc theo đúng toa hướng dẫn, nghỉ ngơi hợp lý, tái khám sau 1 tuần hoặc khi có dấu hiệu bất thường.";
            btnHoanTat.Text = "✓ Quyết toán & Xuất viện";

            if (cboDotDieuTri.SelectedValue != null)
            {
                TinhChiPhiDieuTri(cboDotDieuTri.SelectedValue.ToString());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (cboDotDieuTri.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đợt điều trị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ xác nhận xuất viện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTinhTrang.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng xuất viện của người bệnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTinhTrang.Focus();
                return;
            }

            string maHT = txtMaHoanTat.Text.Trim();
            string maDot = cboDotDieuTri.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue.ToString();
            DateTime ngayHT = dtpNgayHoanTat.Value;
            string ketQua = cboKetQua.SelectedItem != null ? cboKetQua.SelectedItem.ToString() : cboKetQua.Text;
            string tinhTrang = txtTinhTrang.Text.Trim();
            string danDo = txtDanDo.Text.Trim();

            decimal ptBHYT = numPhanTramBHYT.Value;
            decimal bhytChiTra = Math.Round(_tongVienPhi * (ptBHYT / 100m));
            decimal bnTra = _tongVienPhi - bhytChiTra;

            try
            {
                object exists = Db.Scalar("SELECT COUNT(*) FROM HoanTatDieuTri WHERE MaDotDieuTri = @Dot", new SqlParameter("@Dot", maDot));
                bool isExist = (exists != null && Convert.ToInt32(exists) > 0);

                if (isExist)
                {
                    string updateSql = "UPDATE HoanTatDieuTri SET " +
                                       "NgayHoanTat = @NgayHT, MaBacSiXacNhan = @BS, KetQuaDieuTri = @KQ, " +
                                       "TinhTrangXuatVien = @TT, DanDoSauXuatVien = @DanDo, " +
                                       "TongTienVienPhi = @Tong, BHYTChiTra = @BHYT, BenhNhanThanhToan = @BN " +
                                       "WHERE MaDotDieuTri = @Dot";
                    Db.Execute(updateSql,
                        new SqlParameter("@NgayHT", ngayHT),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@KQ", ketQua),
                        new SqlParameter("@TT", tinhTrang),
                        new SqlParameter("@DanDo", danDo),
                        new SqlParameter("@Tong", _tongVienPhi),
                        new SqlParameter("@BHYT", bhytChiTra),
                        new SqlParameter("@BN", bnTra),
                        new SqlParameter("@Dot", maDot));
                }
                else
                {
                    string insertSql = "INSERT INTO HoanTatDieuTri (MaHoanTat, MaDotDieuTri, NgayHoanTat, MaBacSiXacNhan, KetQuaDieuTri, " +
                                       "TinhTrangXuatVien, DanDoSauXuatVien, TongTienVienPhi, BHYTChiTra, BenhNhanThanhToan) " +
                                       "VALUES (@HT, @Dot, @NgayHT, @BS, @KQ, @TT, @DanDo, @Tong, @BHYT, @BN)";
                    Db.Execute(insertSql,
                        new SqlParameter("@HT", maHT),
                        new SqlParameter("@Dot", maDot),
                        new SqlParameter("@NgayHT", ngayHT),
                        new SqlParameter("@BS", maBS),
                        new SqlParameter("@KQ", ketQua),
                        new SqlParameter("@TT", tinhTrang),
                        new SqlParameter("@DanDo", danDo),
                        new SqlParameter("@Tong", _tongVienPhi),
                        new SqlParameter("@BHYT", bhytChiTra),
                        new SqlParameter("@BN", bnTra));
                }

                // Cập nhật trạng thái đợt điều trị sang Hoàn tất
                Db.Execute("UPDATE DotDieuTri SET TrangThai = N'Hoàn tất', NgayKetThuc = @NgayHT WHERE MaDotDieuTri = @Dot",
                    new SqlParameter("@NgayHT", ngayHT), new SqlParameter("@Dot", maDot));

                MessageBox.Show("Quyết toán viện phí và hoàn tất xuất viện thành công!\nHồ sơ đợt điều trị đã được số hóa và chuyển vào lưu trữ lâu dài.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDotDieuTri();
                cboDotDieuTri.SelectedValue = maDot;
                LoadDanhSachHoanTat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hoàn tất điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInGiayRaVien_Click(object sender, EventArgs e)
        {
            if (cboDotDieuTri.SelectedItem == null) return;
            DataRowView row = cboDotDieuTri.SelectedItem as DataRowView;
            if (row == null) return;

            string info = string.Format("=== GIẤY RA VIỆN & BẢNG KÊ QUYẾT TOÁN VIỆN PHÍ ===\n\n" +
                                        "Mã xuất viện: {0}\n" +
                                        "Đợt điều trị: {1} ({2})\n" +
                                        "Bệnh nhân: {3}\n" +
                                        "Khoa điều trị: {4}\n" +
                                        "Bác sĩ xác nhận: {5}\n" +
                                        "Ngày hoàn tất: {6:dd/MM/yyyy HH:mm}\n\n" +
                                        "KẾT QUẢ ĐIỀU TRỊ: {7}\n" +
                                        "Tình trạng xuất viện: {8}\n" +
                                        "Lời dặn bác sĩ: {9}\n\n" +
                                        "QUYẾT TOÁN VIỆN PHÍ:\n" +
                                        "- {10}\n" +
                                        "- Tổng viện phí: {11} đ\n" +
                                        "- BHYT thanh toán ({12}%): {13} đ\n" +
                                        "- BỆNH NHÂN CÙNG CHI TRẢ: {14} VNĐ\n\n" +
                                        "Đã thanh toán đủ viện phí và hoàn tất thủ tục bàn giao bệnh án số.",
                                        txtMaHoanTat.Text, row["MaDotDieuTri"], row["LoaiDieuTri"],
                                        row["HoTen"], row["TenKhoa"], cboBacSi.Text,
                                        dtpNgayHoanTat.Value, cboKetQua.Text, txtTinhTrang.Text, txtDanDo.Text,
                                        lblChiTietChiPhi.Text, txtTongVienPhi.Text, numPhanTramBHYT.Value,
                                        txtBHYTChiTra.Text, txtBenhNhanTra.Text);

            MessageBox.Show(info, "In giấy ra viện & bảng kê viện phí", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvHoanTat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvHoanTat.Rows[e.RowIndex];
            string maDot = row.Cells["MaDotDieuTri"].Value.ToString();
            cboDotDieuTri.SelectedValue = maDot;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
