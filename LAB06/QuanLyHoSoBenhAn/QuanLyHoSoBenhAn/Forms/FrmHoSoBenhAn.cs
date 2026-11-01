using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmHoSoBenhAn : Form
    {
        public FrmHoSoBenhAn()
        {
            InitializeComponent();
        }

        private void FrmHoSoBenhAn_Load(object sender, EventArgs e)
        {
            cboNhomMau.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            TaiHoSoDauTien();
        }

        private void TaiHoSoDauTien()
        {
            try
            {
                DataTable dt = Db.Query("SELECT TOP 1 MaHoSo FROM HoSoBenhAn ORDER BY NgayCap DESC");
                if (dt.Rows.Count > 0)
                {
                    TaiChiTietHoSo(dt.Rows[0]["MaHoSo"].ToString());
                }
            }
            catch { }
        }

        private void TaiChiTietHoSo(string maHoSo)
        {
            try
            {
                string sql = @"SELECT h.MaHoSo, h.MaBenhNhan, h.NgayCap, h.NhomMau, h.TienSuBenh, 
                                      h.BenhManTinh, h.ThuocDaTungDung, h.DiUngThuoc_PhanUngPhu, h.TinhTrangHoSo,
                                      b.HoTen, b.GioiTinh, b.NgaySinh, b.SoDienThoai, b.DiaChi, b.SoCCCD_BHYT
                               FROM HoSoBenhAn h
                               JOIN BenhNhan b ON h.MaBenhNhan = b.MaBenhNhan
                               WHERE h.MaHoSo = @hs OR h.MaBenhNhan = @hs OR b.SoDienThoai = @hs OR b.HoTen LIKE @ten";

                DataTable dt = Db.Query(sql,
                    new SqlParameter("@hs", maHoSo),
                    new SqlParameter("@ten", "%" + maHoSo + "%"));

                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaHoSo.Text = r["MaHoSo"].ToString();
                    dtpNgayCap.Value = Convert.ToDateTime(r["NgayCap"]);
                    cboNhomMau.Text = r["NhomMau"].ToString();
                    cboTinhTrang.Text = r["TinhTrangHoSo"].ToString();
                    txtDiUngThuoc.Text = r["DiUngThuoc_PhanUngPhu"].ToString();
                    txtTienSuBenh.Text = r["TienSuBenh"].ToString();
                    txtBenhManTinh.Text = r["BenhManTinh"].ToString();
                    txtThuocDaDung.Text = r["ThuocDaTungDung"].ToString();

                    DateTime ns = Convert.ToDateTime(r["NgaySinh"]);
                    txtThongTinBN.Text = string.Format("{0} ({1}) - {2} - Sinh: {3:dd/MM/yyyy} - SĐT: {4} - Đ/c: {5}",
                        r["MaBenhNhan"], r["HoTen"], r["GioiTinh"], ns, r["SoDienThoai"], r["DiaChi"]);

                    // Tải danh sách lịch sử khám bệnh
                    TaiLichSuKham(txtMaHoSo.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ bệnh án phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hồ sơ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiLichSuKham(string maHoSo)
        {
            try
            {
                string sql = @"SELECT d.MaDotDieuTri AS [Mã đợt], k.TenKhoa AS [Khoa điều trị], bs.HoTen AS [Bác sĩ phụ trách],
                                      d.NgayBatDau AS [Bắt đầu], d.NgayKetThuc AS [Kết thúc], d.LoaiDieuTri AS [Loại ĐT],
                                      d.LyDoDieuTri AS [Lý do khám / Chẩn đoán], d.TrangThai AS [Tình trạng đợt khám]
                               FROM DotDieuTri d
                               JOIN KhoaDieuTri k ON d.MaKhoa = k.MaKhoa
                               JOIN BacSi bs ON d.MaBacSiPhuTrach = bs.MaBacSi
                               WHERE d.MaHoSo = @hs
                               ORDER BY d.NgayBatDau DESC";

                DataTable dt = Db.Query(sql, new SqlParameter("@hs", maHoSo));
                dgvLichSuKham.DataSource = dt;
                dgvLichSuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ, Mã bệnh nhân, Họ tên hoặc Số điện thoại để tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaiChiTietHoSo(tuKhoa);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHoSo = txtMaHoSo.Text.Trim();
            if (string.IsNullOrWhiteSpace(maHoSo))
            {
                MessageBox.Show("Chưa chọn hồ sơ bệnh án để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"UPDATE HoSoBenhAn
                               SET NgayCap = @nc, NhomMau = @nm, TinhTrangHoSo = @tt,
                                   DiUngThuoc_PhanUngPhu = @du, TienSuBenh = @ts,
                                   BenhManTinh = @mt, ThuocDaTungDung = @thuoc
                               WHERE MaHoSo = @hs";

                Db.Execute(sql,
                    new SqlParameter("@nc", dtpNgayCap.Value.Date),
                    new SqlParameter("@nm", cboNhomMau.SelectedItem == null ? (object)DBNull.Value : cboNhomMau.SelectedItem.ToString()),
                    new SqlParameter("@tt", cboTinhTrang.SelectedItem == null ? "Đang theo dõi" : cboTinhTrang.SelectedItem.ToString()),
                    new SqlParameter("@du", txtDiUngThuoc.Text.Trim()),
                    new SqlParameter("@ts", txtTienSuBenh.Text.Trim()),
                    new SqlParameter("@mt", txtBenhManTinh.Text.Trim()),
                    new SqlParameter("@thuoc", txtThuocDaDung.Text.Trim()),
                    new SqlParameter("@hs", maHoSo));

                MessageBox.Show("Cập nhật thông tin Hồ sơ bệnh án & Lý lịch bệnh lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật hồ sơ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiHoSoDauTien();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
