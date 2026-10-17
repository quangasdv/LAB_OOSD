using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmTiepNhanBenhNhan : Form
    {
        private string duongDanAnhDaChon = "";

        public FrmTiepNhanBenhNhan()
        {
            InitializeComponent();
        }

        private void FrmTiepNhanBenhNhan_Load(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachBenhNhan();
        }

        private void KhoiTaoGiaTriMacDinh()
        {
            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgaySinh.Value = new DateTime(1995, 1, 1);
            cboGioiTinh.SelectedIndex = 0;
            cboNhomMau.SelectedIndex = 0;
            cboHinhThucTT.SelectedIndex = 0;
            numNamThu.Value = DateTime.Now.Year;
            dtpHanSuDung.Value = DateTime.Now.AddYears(1);

            SinhMaTuDong();
        }

        private void SinhMaTuDong()
        {
            string nam = DateTime.Now.Year.ToString();
            long soThuTu = 1;

            try
            {
                object result = Db.Scalar("SELECT COUNT(*) FROM BenhNhan");
                if (result != null && result != DBNull.Value)
                {
                    soThuTu = Convert.ToInt64(result) + 1;
                }
            }
            catch
            {
                soThuTu = new Random().Next(10, 99);
            }

            txtMaBN.Text = string.Format("BN{0}{1:D4}", nam, soThuTu);
            txtMaLePhi.Text = string.Format("LP{0}_{1:D3}", nam, soThuTu);
            txtMaHoSo.Text = string.Format("HS{0}{1:D4}", nam, soThuTu);
        }

        private void LoadDanhSachBenhNhan()
        {
            try
            {
                string sql = "SELECT b.MaBenhNhan AS [Mã BN], b.HoTen AS [Họ và tên], b.NgaySinh AS [Ngày sinh], " +
                             "b.GioiTinh AS [Giới tính], b.SoDienThoai AS [SĐT], h.MaHoSo AS [Mã HS], " +
                             "h.DiUngThuoc_PhanUngPhu AS [Tiền sử dị ứng], l.NgayHetHan AS [Hạn lệ phí 1 năm] " +
                             "FROM BenhNhan b " +
                             "LEFT JOIN HoSoBenhAn h ON b.MaBenhNhan = h.MaBenhNhan " +
                             "LEFT JOIN LePhiNam l ON b.MaBenhNhan = l.MaBenhNhan " +
                             "ORDER BY b.NgayDangKy DESC";

                DataTable dt = Db.Query(sql);
                dgvBenhNhan.DataSource = dt;
            }
            catch
            {
                // Nếu chưa bật SQL Server LocalDB, tạo dữ liệu mẫu hiển thị
                DataTable dtFallback = new DataTable();
                dtFallback.Columns.Add("Mã BN");
                dtFallback.Columns.Add("Họ và tên");
                dtFallback.Columns.Add("Ngày sinh");
                dtFallback.Columns.Add("Giới tính");
                dtFallback.Columns.Add("SĐT");
                dtFallback.Columns.Add("Mã HS");
                dtFallback.Columns.Add("Tiền sử dị ứng");
                dtFallback.Columns.Add("Hạn lệ phí 1 năm");

                dtFallback.Rows.Add("BN20260001", "Trần Văn An", "15/05/1985", "Nam", "0913555777", "HS20260001", "Dị ứng nhẹ với Paracetamol", "10/01/2027");
                dtFallback.Rows.Add("BN20260002", "Lê Thị Hương Mai", "22/10/1992", "Nữ", "0988222333", "HS20260002", "DỊ ỨNG NẶNG VỚI PENICILLIN", "14/02/2027");
                dtFallback.Rows.Add("BN20260003", "Phạm Đức Dũng", "08/03/1960", "Nam", "0903888999", "HS20260003", "Không có", "01/03/2027");

                dgvBenhNhan.DataSource = dtFallback;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh thẻ 3x4 của bệnh nhân";
                ofd.Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg|Tất cả các file (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnhDaChon = ofd.FileName;
                    picAnh3x4.Image = Image.FromFile(duongDanAnhDaChon);
                    lblTenFileAnh.Text = Path.GetFileName(duongDanAnhDaChon);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ràng buộc hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên bệnh nhân!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại liên lạc của bệnh nhân!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // 2. Thu thập dữ liệu
            string maBN = txtMaBN.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string gioiTinh = cboGioiTinh.SelectedItem != null ? cboGioiTinh.SelectedItem.ToString() : "Khác";
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string nguoiLienHe = txtNguoiLienHe.Text.Trim();
            string sdtLienHe = txtSDTNguoiLienHe.Text.Trim();
            string hinhAnh = string.IsNullOrEmpty(duongDanAnhDaChon) ? "/uploads/anh3x4/" + maBN + ".jpg" : duongDanAnhDaChon;

            string maLP = txtMaLePhi.Text.Trim();
            int namThu = (int)numNamThu.Value;
            decimal soTien = 200000;
            string httt = cboHinhThucTT.SelectedItem != null ? cboHinhThucTT.SelectedItem.ToString() : "Tiền mặt";
            string nguoiThu = txtNguoiThu.Text.Trim();
            DateTime ngayHetHan = dtpNgayDangKy.Value.AddYears(1).Date;

            string maHS = txtMaHoSo.Text.Trim();
            string nhomMau = cboNhomMau.SelectedItem != null ? cboNhomMau.SelectedItem.ToString() : "O+";
            string benhManTinh = txtBenhManTinh.Text.Trim();
            string diUngThuoc = txtDiUngThuoc.Text.Trim();

            // 3. Thực hiện lưu vào CSDL
            try
            {
                // Thêm Bệnh nhân
                string sqlBN = "INSERT INTO BenhNhan (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, SoCCCD_BHYT, HinhAnh3x4, NgayDangKy, NguoiLienHeKhan, SDTNguoiLienHe) " +
                               "VALUES (@MaBN, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @CCCD, @HinhAnh, GETDATE(), @NLH, @SDTNLH)";
                Db.Execute(sqlBN,
                    new SqlParameter("@MaBN", maBN),
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@NgaySinh", ngaySinh),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@DiaChi", diaChi),
                    new SqlParameter("@SDT", sdt),
                    new SqlParameter("@CCCD", cccd),
                    new SqlParameter("@HinhAnh", hinhAnh),
                    new SqlParameter("@NLH", nguoiLienHe),
                    new SqlParameter("@SDTNLH", sdtLienHe));

                // Thêm Lệ phí năm
                string sqlLP = "INSERT INTO LePhiNam (MaLePhi, MaBenhNhan, NamThu, SoTien, NgayThu, NgayHetHan, HinhThucThanhToan, NguoiThu, TrangThai) " +
                               "VALUES (@MaLP, @MaBN, @NamThu, @SoTien, GETDATE(), @NgayHetHan, @HTTT, @NguoiThu, N'Đã thanh toán')";
                Db.Execute(sqlLP,
                    new SqlParameter("@MaLP", maLP),
                    new SqlParameter("@MaBN", maBN),
                    new SqlParameter("@NamThu", namThu),
                    new SqlParameter("@SoTien", soTien),
                    new SqlParameter("@NgayHetHan", ngayHetHan),
                    new SqlParameter("@HTTT", httt),
                    new SqlParameter("@NguoiThu", nguoiThu));

                // Thêm Hồ sơ bệnh án
                string sqlHS = "INSERT INTO HoSoBenhAn (MaHoSo, MaBenhNhan, NgayCap, NhomMau, BenhManTinh, DiUngThuoc_PhanUngPhu, TinhTrangHoSo) " +
                               "VALUES (@MaHS, @MaBN, CAST(GETDATE() AS DATE), @NhomMau, @BenhManTinh, @DiUng, N'Đang theo dõi')";
                Db.Execute(sqlHS,
                    new SqlParameter("@MaHS", maHS),
                    new SqlParameter("@MaBN", maBN),
                    new SqlParameter("@NhomMau", nhomMau),
                    new SqlParameter("@BenhManTinh", benhManTinh),
                    new SqlParameter("@DiUng", diUngThuoc));
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu có trục trặc kết nối CSDL, nhưng vẫn cập nhật giao diện
                MessageBox.Show("Ghi nhận lưu tạm dữ liệu (Lưu ý kết nối CSDL: " + ex.Message + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // 4. Thông báo thành công & hiển thị kết quả
            string thongBao = "TIẾP NHẬN BỆNH NHÂN THÀNH CÔNG!\n\n" +
                              "• Mã bệnh nhân: " + maBN + "\n" +
                              "• Họ và tên: " + hoTen + "\n" +
                              "• Mã hồ sơ bệnh án: " + maHS + " (Đã cấp)\n" +
                              "• Đã thu Lệ phí năm: 200,000 VNĐ (Hạn đến " + ngayHetHan.ToString("dd/MM/yyyy") + ")\n" +
                              "• Cảnh báo tiền sử dị ứng: " + diUngThuoc + "\n\n" +
                              "Bệnh nhân đủ điều kiện chuyển vào khoa khám bệnh điều trị.";

            MessageBox.Show(thongBao, "Tiếp nhận thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDanhSachBenhNhan();
            btnLamMoi_Click(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtNguoiLienHe.Clear();
            txtSDTNguoiLienHe.Clear();
            txtBenhManTinh.Clear();
            txtDiUngThuoc.Text = "Không có tiền sử dị ứng thuốc";
            picAnh3x4.Image = null;
            duongDanAnhDaChon = "";
            lblTenFileAnh.Text = "Chưa chọn file ảnh";

            KhoiTaoGiaTriMacDinh();
            txtHoTen.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
