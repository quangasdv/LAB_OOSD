using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKhenThuongKyLuat : Form
    {
        public FrmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void FrmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            cboLoaiQuyetDinh.SelectedIndex = 0;
            cboHinhThuc.SelectedIndex = 0;
            dtpNgayBanHanh.Value = DateTime.Now;
            LoadDoiTuong();
            SinhSoQuyetDinh();
            LoadDanhSach();
        }

        private void LoadDoiTuong()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaNhanVien, (MaNhanVien + ' - ' + HoTen) AS TenHienThi FROM NhanVien");
                cboDoiTuong.DataSource = dt;
                cboDoiTuong.DisplayMember = "TenHienThi";
                cboDoiTuong.ValueMember = "MaNhanVien";
            }
            catch { }
        }

        private void SinhSoQuyetDinh()
        {
            string prefix = (cboLoaiQuyetDinh.Text == "Kỷ luật") ? "QDKL" : "QDKT";
            txtSoQuyetDinh.Text = string.Format("{0}/{1}/{2:D3}", prefix, DateTime.Now.Year, new Random().Next(10, 99));
        }

        private void cboLoaiQuyetDinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SinhSoQuyetDinh();
            if (cboLoaiQuyetDinh.Text == "Kỷ luật")
            {
                txtLyDo.Text = "Vi phạm nội quy an toàn lao động";
                numSoTien.Value = 500000;
                txtSoPhieuThuChi.Text = "PTNP" + new Random().Next(100, 999);
            }
            else if (cboLoaiQuyetDinh.Text == "Lương tháng 13")
            {
                txtLyDo.Text = "Chi trả lương tháng 13 cuối năm";
                numSoTien.Value = 10000000;
                txtSoPhieuThuChi.Text = "PCL13" + new Random().Next(100, 999);
            }
            else
            {
                txtLyDo.Text = "Khen thưởng hoàn thành xuất sắc nhiệm vụ";
                numSoTien.Value = 1000000;
                txtSoPhieuThuChi.Text = "PCKT" + new Random().Next(100, 999);
            }
        }

        private void LoadDanhSach()
        {
            try
            {
                string sql = @"SELECT kt.SoQuyetDinhKTKL AS [Số QĐ], kt.LoaiQuyetDinh AS [Loại QĐ],
                                      kt.DoiTuong AS [Đối tượng], nv.HoTen AS [Người thụ hưởng/bị phạt],
                                      kt.NgayBanHanh AS [Ngày ban hành], kt.SoTien AS [Số tiền],
                                      kt.HinhThucXuLy AS [Hình thức], kt.LyDo AS [Lý do],
                                      kt.SoPhieuThuChi AS [Số phiếu], kt.NguoiKy AS [Người ký]
                               FROM KhenThuongKyLuat kt
                               LEFT JOIN NhanVien nv ON kt.MaDoiTuong = nv.MaNhanVien
                               ORDER BY kt.NgayBanHanh DESC";
                DataTable dt = Db.Query(sql);
                dgvDanhSach.DataSource = dt;

                if (dgvDanhSach.Columns["Số tiền"] != null)
                {
                    dgvDanhSach.Columns["Số tiền"].DefaultCellStyle.Format = "#,##0";
                    dgvDanhSach.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SinhSoQuyetDinh();
            txtLyDo.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoQuyetDinh.Text) || cboDoiTuong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đủ Số QĐ và chọn Đối tượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"IF EXISTS (SELECT 1 FROM KhenThuongKyLuat WHERE SoQuyetDinhKTKL = @So)
                                UPDATE KhenThuongKyLuat SET LoaiQuyetDinh = @Loai, MaDoiTuong = @MaDT, NgayBanHanh = @Ngay,
                                       LyDo = @LyDo, SoTien = @Tien, HinhThucXuLy = @HinhThuc, SoPhieuThuChi = @Phieu, NguoiKy = @NguoiKy
                                WHERE SoQuyetDinhKTKL = @So
                               ELSE
                                INSERT INTO KhenThuongKyLuat (SoQuyetDinhKTKL, DoiTuong, MaDoiTuong, LoaiQuyetDinh, NgayBanHanh, LyDo, SoTien, HinhThucXuLy, SoPhieuThuChi, NguoiKy)
                                VALUES (@So, N'Cá nhân', @MaDT, @Loai, @Ngay, @LyDo, @Tien, @HinhThuc, @Phieu, @NguoiKy)";
                Db.Execute(sql,
                    new SqlParameter("@So", txtSoQuyetDinh.Text.Trim()),
                    new SqlParameter("@Loai", cboLoaiQuyetDinh.Text),
                    new SqlParameter("@MaDT", cboDoiTuong.SelectedValue),
                    new SqlParameter("@Ngay", dtpNgayBanHanh.Value.Date),
                    new SqlParameter("@LyDo", txtLyDo.Text.Trim()),
                    new SqlParameter("@Tien", numSoTien.Value),
                    new SqlParameter("@HinhThuc", cboHinhThuc.Text),
                    new SqlParameter("@Phieu", txtSoPhieuThuChi.Text.Trim()),
                    new SqlParameter("@NguoiKy", txtNguoiKy.Text.Trim())
                );

                MessageBox.Show("Ban hành Quyết định khen thưởng/kỷ luật thành công!\n(Nếu chọn hình thức 'Trừ/Cộng vào bảng lương', số tiền sẽ tự động cập nhật khi bấm Tính Lương)",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SinhSoQuyetDinh();
                LoadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu QĐ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                object val = dgvDanhSach.CurrentRow.Cells["Số QĐ"].Value;
                string soQD = val != null ? val.ToString() : "";
                if (!string.IsNullOrEmpty(soQD) && MessageBox.Show("Bạn có muốn xóa quyết định " + soQD + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Db.Execute("DELETE FROM KhenThuongKyLuat WHERE SoQuyetDinhKTKL = @So", new SqlParameter("@So", soQD));
                        LoadDanhSach();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
