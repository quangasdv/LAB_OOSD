using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxPhongBan();
            LoadComboBoxChucVu();
            cboGioiTinh.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            cboLoaiHD.SelectedIndex = 0;
            LoadDanhSachNhanVien();
        }

        private void LoadComboBoxPhongBan()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaPhongBan, TenPhongBan, CoMoiTruongDocHai FROM PhongBan");
                cboPhongBan.DataSource = dt;
                cboPhongBan.DisplayMember = "TenPhongBan";
                cboPhongBan.ValueMember = "MaPhongBan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng ban: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadComboBoxChucVu()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaChucVu, TenChucVu, PhuCapChucVuDinhMuc FROM ChucVu");
                cboChucVu.DataSource = dt;
                cboChucVu.DisplayMember = "TenChucVu";
                cboChucVu.ValueMember = "MaChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chức vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                DataTable dt = Db.Query("SELECT * FROM vw_ThongTinNhanVienDayDu");
                dgvNhanVien.DataSource = dt;

                if (dgvNhanVien.Columns["MaNhanVien"] != null)
                {
                    dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
                    dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và Tên";
                    dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    dgvNhanVien.Columns["GioiTinh"].HeaderText = "Phái";
                    dgvNhanVien.Columns["TenPhongBan"].HeaderText = "Phòng ban / Xưởng";
                    dgvNhanVien.Columns["TenChucVu"].HeaderText = "Chức vụ";
                    dgvNhanVien.Columns["LoaiHopDong"].HeaderText = "Loại HĐ";
                    dgvNhanVien.Columns["LuongCoBan"].HeaderText = "Lương cơ bản";
                    dgvNhanVien.Columns["PhuCapDocHai"].HeaderText = "PC Độc hại";
                    dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

                    dgvNhanVien.Columns["LuongCoBan"].DefaultCellStyle.Format = "#,##0";
                    dgvNhanVien.Columns["PhuCapDocHai"].DefaultCellStyle.Format = "#,##0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhongBan.SelectedValue != null)
            {
                string maPB = cboPhongBan.SelectedValue.ToString();
                if (maPB == "PX_SX") // Phân xưởng sản xuất sơn
                {
                    chkDocHai.Checked = true;
                    if (numPhuCapDocHai.Value == 0)
                        numPhuCapDocHai.Value = 1500000; // Định mức phụ cấp độc hại xưởng sơn
                }
                else
                {
                    chkDocHai.Checked = false;
                    numPhuCapDocHai.Value = 0;
                }
            }
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cboChucVu.SelectedItem as DataRowView;
            if (drv != null)
            {
                decimal dinhMuc = Convert.ToDecimal(drv["PhuCapChucVuDinhMuc"]);
                numPhuCapCV.Value = dinhMuc;
            }
        }

        private void cboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // BR03: HĐ ngắn hạn không trích BHXH/BHYT trên bảng lương
            if (cboLoaiHD.Text == "Ngắn hạn")
            {
                numLuongDongBH.Value = 0;
                numLuongDongBH.Enabled = false;
                txtSoBHXH.Enabled = false;
                txtMaBHYT.Enabled = false;
                txtSoBHXH.Text = "";
                txtMaBHYT.Text = "";
            }
            else
            {
                numLuongDongBH.Enabled = true;
                txtSoBHXH.Enabled = true;
                txtMaBHYT.Enabled = true;
                if (numLuongDongBH.Value == 0)
                    numLuongDongBH.Value = numLuongCoBan.Value;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                object count = Db.Scalar("SELECT COUNT(*) FROM NhanVien");
                int stt = Convert.ToInt32(count) + 1;
                txtMaNV.Text = string.Format("NV{0:D3}", stt);
            }
            catch
            {
                txtMaNV.Text = "NV" + new Random().Next(100, 999);
            }

            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            dtpNgayVaoLam.Value = DateTime.Now;
            cboTrangThai.Text = "Thử việc";
            numLuongCoBan.Value = 7000000;
            numHeSoLuong.Value = 1.00m;
            numLuongDongBH.Value = 7000000;
            txtSoBHXH.Text = "";
            txtMaBHYT.Text = "";
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Họ tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Kiểm tra thêm mới hay cập nhật NhanVien
                string checkSql = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @Ma";
                int exist = Convert.ToInt32(Db.Scalar(checkSql, new SqlParameter("@Ma", txtMaNV.Text.Trim())));

                if (exist == 0)
                {
                    string insertNV = @"INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, SoCCCD, DiaChi, SoDienThoai, Email, MaPhongBan, MaChucVu, NgayVaoLam, TrangThai)
                                        VALUES (@Ma, @Ten, @Sinh, @Phai, @CCCD, @DiaChi, @SDT, @Email, @PB, @CV, @Vao, @TrangThai)";
                    Db.Execute(insertNV,
                        new SqlParameter("@Ma", txtMaNV.Text.Trim()),
                        new SqlParameter("@Ten", txtHoTen.Text.Trim()),
                        new SqlParameter("@Sinh", dtpNgaySinh.Value.Date),
                        new SqlParameter("@Phai", cboGioiTinh.Text),
                        new SqlParameter("@CCCD", txtCCCD.Text.Trim()),
                        new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                        new SqlParameter("@SDT", txtSDT.Text.Trim()),
                        new SqlParameter("@Email", txtEmail.Text.Trim()),
                        new SqlParameter("@PB", cboPhongBan.SelectedValue),
                        new SqlParameter("@CV", cboChucVu.SelectedValue),
                        new SqlParameter("@Vao", dtpNgayVaoLam.Value.Date),
                        new SqlParameter("@TrangThai", cboTrangThai.Text)
                    );
                }
                else
                {
                    string updateNV = @"UPDATE NhanVien SET HoTen = @Ten, NgaySinh = @Sinh, GioiTinh = @Phai, SoCCCD = @CCCD,
                                        DiaChi = @DiaChi, SoDienThoai = @SDT, Email = @Email, MaPhongBan = @PB, MaChucVu = @CV,
                                        NgayVaoLam = @Vao, TrangThai = @TrangThai WHERE MaNhanVien = @Ma";
                    Db.Execute(updateNV,
                        new SqlParameter("@Ma", txtMaNV.Text.Trim()),
                        new SqlParameter("@Ten", txtHoTen.Text.Trim()),
                        new SqlParameter("@Sinh", dtpNgaySinh.Value.Date),
                        new SqlParameter("@Phai", cboGioiTinh.Text),
                        new SqlParameter("@CCCD", txtCCCD.Text.Trim()),
                        new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                        new SqlParameter("@SDT", txtSDT.Text.Trim()),
                        new SqlParameter("@Email", txtEmail.Text.Trim()),
                        new SqlParameter("@PB", cboPhongBan.SelectedValue),
                        new SqlParameter("@CV", cboChucVu.SelectedValue),
                        new SqlParameter("@Vao", dtpNgayVaoLam.Value.Date),
                        new SqlParameter("@TrangThai", cboTrangThai.Text)
                    );
                }

                // 2. Cập nhật Quyết định lương
                string qdlSql = @"IF EXISTS (SELECT 1 FROM QuyetDinhLuong WHERE MaNhanVien = @Ma AND HieuLucHienHanh = 1)
                                    UPDATE QuyetDinhLuong SET LuongCoBan = @LCB, HeSoLuong = @HS, PhuCapDocHai = @PCDocHai WHERE MaNhanVien = @Ma AND HieuLucHienHanh = 1
                                  ELSE
                                    INSERT INTO QuyetDinhLuong (SoQuyetDinhLuong, MaNhanVien, LuongCoBan, HeSoLuong, PhuCapLuong, PhuCapDocHai, NgayHieuLuc, NguoiKyDuyet, HieuLucHienHanh)
                                    VALUES ('QDL/' + @Ma, @Ma, @LCB, @HS, 0, @PCDocHai, GETDATE(), N'Giám đốc', 1)";
                Db.Execute(qdlSql,
                    new SqlParameter("@Ma", txtMaNV.Text.Trim()),
                    new SqlParameter("@LCB", numLuongCoBan.Value),
                    new SqlParameter("@HS", numHeSoLuong.Value),
                    new SqlParameter("@PCDocHai", numPhuCapDocHai.Value)
                );

                // 3. Cập nhật Quyết định chức vụ
                string qdcSql = @"IF EXISTS (SELECT 1 FROM QuyetDinhChucVu WHERE MaNhanVien = @Ma AND HieuLucHienHanh = 1)
                                    UPDATE QuyetDinhChucVu SET MaChucVuMoi = @CV, PhuCapChucVu = @PCCV WHERE MaNhanVien = @Ma AND HieuLucHienHanh = 1
                                  ELSE
                                    INSERT INTO QuyetDinhChucVu (SoQuyetDinhCV, MaNhanVien, MaChucVuMoi, PhuCapChucVu, NgayHieuLuc, NguoiKyDuyet, HieuLucHienHanh)
                                    VALUES ('QDCV/' + @Ma, @Ma, @CV, @PCCV, GETDATE(), N'Giám đốc', 1)";
                Db.Execute(qdcSql,
                    new SqlParameter("@Ma", txtMaNV.Text.Trim()),
                    new SqlParameter("@CV", cboChucVu.SelectedValue),
                    new SqlParameter("@PCCV", numPhuCapCV.Value)
                );

                MessageBox.Show("Lưu thông tin nhân sự thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) return;

            if (MessageBox.Show("Bạn có muốn chuyển trạng thái nhân viên " + txtMaNV.Text + " sang 'Đã nghỉ việc'?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Db.Execute("UPDATE NhanVien SET TrangThai = N'Đã nghỉ việc' WHERE MaNhanVien = @Ma",
                               new SqlParameter("@Ma", txtMaNV.Text.Trim()));
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChuyenChinhThuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) return;

            // Quy tắc FR02 & BR02: Đánh giá thử việc đạt yêu cầu -> Ký HĐLĐ Dài hạn, khởi tạo BHYT & BHXH
            try
            {
                string maNV = txtMaNV.Text.Trim();
                // 1. Chuyển trạng thái nhân viên sang Chính thức
                Db.Execute("UPDATE NhanVien SET TrangThai = N'Chính thức' WHERE MaNhanVien = @Ma", new SqlParameter("@Ma", maNV));

                // 2. Tạo Hợp đồng dài hạn nếu chưa có
                string hdSql = @"IF NOT EXISTS (SELECT 1 FROM HopDongLaoDong WHERE MaNhanVien = @Ma)
                                 INSERT INTO HopDongLaoDong (SoHopDong, MaNhanVien, LoaiHopDong, NgayKy, NgayHieuLuc, NgayHetHan, DiaDiemLamViec, LuongDongBaoHiem, TrangThaiHopDong)
                                 VALUES ('HDLD/DH/' + @Ma, @Ma, N'Dài hạn', GETDATE(), GETDATE(), DATEADD(YEAR, 3, GETDATE()), N'Công ty Sơn Đông Á', @LuongBH, N'Hiệu lực')";
                Db.Execute(hdSql, new SqlParameter("@Ma", maNV), new SqlParameter("@LuongBH", numLuongCoBan.Value));

                // 3. Khởi tạo hồ sơ bảo hiểm nếu chưa có
                string soBHXH = "BHXH" + maNV;
                string maBHYT = "BHYT" + maNV;
                string bhSql = @"IF NOT EXISTS (SELECT 1 FROM HoSoBaoHiem WHERE MaNhanVien = @Ma)
                                INSERT INTO HoSoBaoHiem (MaHoSoBH, MaNhanVien, SoSoBHXH, MaTheBHYT, NoiDangKyKCB, TyLeDongBHXH, TyLeDongBHYT, TyLeDongBHTN, NgayThamGia, TrangThaiSo)
                                VALUES ('BH/' + @Ma, @Ma, @SoBHXH, @MaBHYT, N'Bệnh viện ĐK Sài Gòn', 0.08, 0.015, 0.01, GETDATE(), N'Đang tham gia')";
                Db.Execute(bhSql,
                    new SqlParameter("@Ma", maNV),
                    new SqlParameter("@SoBHXH", soBHXH),
                    new SqlParameter("@MaBHYT", maBHYT));

                MessageBox.Show("Đã đánh giá thử việc ĐẠT YÊU CẦU và chuyển nhân viên " + maNV + " sang CHÍNH THỨC thành công!\n(Đã tự động khởi tạo HĐLĐ Dài hạn & Hồ sơ BHXH/BHYT)",
                                "Quy trình tuyển dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển chính thức: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                var row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value != null ? row.Cells["MaNhanVien"].Value.ToString() : "";
                txtHoTen.Text = row.Cells["HoTen"].Value != null ? row.Cells["HoTen"].Value.ToString() : "";
                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                cboGioiTinh.Text = row.Cells["GioiTinh"].Value != null ? row.Cells["GioiTinh"].Value.ToString() : "Nam";
                txtCCCD.Text = row.Cells["SoCCCD"].Value != null ? row.Cells["SoCCCD"].Value.ToString() : "";
                txtSDT.Text = row.Cells["SoDienThoai"].Value != null ? row.Cells["SoDienThoai"].Value.ToString() : "";
                txtEmail.Text = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString() : "";
                
                if (row.Cells["MaPhongBan"].Value != null)
                    cboPhongBan.SelectedValue = row.Cells["MaPhongBan"].Value.ToString();
                if (row.Cells["MaChucVu"].Value != null)
                    cboChucVu.SelectedValue = row.Cells["MaChucVu"].Value.ToString();

                cboTrangThai.Text = row.Cells["TrangThai"].Value != null ? row.Cells["TrangThai"].Value.ToString() : "Thử việc";
                cboLoaiHD.Text = row.Cells["LoaiHopDong"].Value != null ? row.Cells["LoaiHopDong"].Value.ToString() : "Dài hạn";

                if (row.Cells["LuongCoBan"].Value != null && row.Cells["LuongCoBan"].Value != DBNull.Value)
                    numLuongCoBan.Value = Convert.ToDecimal(row.Cells["LuongCoBan"].Value);

                if (row.Cells["HeSoLuong"].Value != null && row.Cells["HeSoLuong"].Value != DBNull.Value)
                    numHeSoLuong.Value = Convert.ToDecimal(row.Cells["HeSoLuong"].Value);

                if (row.Cells["PhuCapChucVu"].Value != null && row.Cells["PhuCapChucVu"].Value != DBNull.Value)
                    numPhuCapCV.Value = Convert.ToDecimal(row.Cells["PhuCapChucVu"].Value);

                if (row.Cells["PhuCapDocHai"].Value != null && row.Cells["PhuCapDocHai"].Value != DBNull.Value)
                    numPhuCapDocHai.Value = Convert.ToDecimal(row.Cells["PhuCapDocHai"].Value);

                txtSoBHXH.Text = row.Cells["SoSoBHXH"].Value != null ? row.Cells["SoSoBHXH"].Value.ToString() : "";
                txtMaBHYT.Text = row.Cells["MaTheBHYT"].Value != null ? row.Cells["MaTheBHYT"].Value.ToString() : "";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
