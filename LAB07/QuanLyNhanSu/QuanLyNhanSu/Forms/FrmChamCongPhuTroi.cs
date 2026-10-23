using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChamCongPhuTroi : Form
    {
        public FrmChamCongPhuTroi()
        {
            InitializeComponent();
        }

        private void FrmChamCongPhuTroi_Load(object sender, EventArgs e)
        {
            dtpNgayOT.Value = DateTime.Now;
            cboHinhThucOT.SelectedIndex = 0;
            cboThang.Text = "10";
            numNam.Value = 2026;

            LoadPhongBan();
            LoadNhanVien();
            SinhMaPhieuOT();
            LoadDanhSachPhuTroi();
            LoadDanhSachChamCong();
        }

        private void LoadPhongBan()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaPhongBan, TenPhongBan FROM PhongBan");
                cboPhongBanOT.DataSource = dt;
                cboPhongBanOT.DisplayMember = "TenPhongBan";
                cboPhongBanOT.ValueMember = "MaPhongBan";
            }
            catch { }
        }

        private void LoadNhanVien()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaNhanVien, (MaNhanVien + ' - ' + HoTen) AS DisplayName FROM NhanVien WHERE TrangThai IN (N'Chính thức', N'Thử việc')");
                cboNhanVien.DataSource = dt;
                cboNhanVien.DisplayMember = "DisplayName";
                cboNhanVien.ValueMember = "MaNhanVien";
            }
            catch { }
        }

        private void SinhMaPhieuOT()
        {
            string dateStr = DateTime.Now.ToString("yyyy/MM");
            txtSoPhieu.Text = "PT/" + dateStr + "/" + new Random().Next(10, 99);
        }

        private void LoadDanhSachPhuTroi()
        {
            try
            {
                string sql = @"SELECT pt.SoPhieuPhuTroi AS [Số phiếu], pt.NgayPhuTroi AS [Ngày OT],
                                      pt.HinhThucPhuTroi AS [Hình thức], pt.HeSoPhuTroi AS [Hệ số],
                                      pb.TenPhongBan AS [Phòng/Xưởng], nv.HoTen AS [Nhân viên],
                                      ct.SoGioPhuTroi AS [Số giờ], pt.LyDoPhuTroi AS [Lý do], pt.TrangThaiDuyet AS [Trạng thái]
                               FROM PhieuPhuTroi pt
                               JOIN ChiTietPhuTroi ct ON pt.SoPhieuPhuTroi = ct.SoPhieuPhuTroi
                               JOIN NhanVien nv ON ct.MaNhanVien = nv.MaNhanVien
                               JOIN PhongBan pb ON pt.MaPhongBan = pb.MaPhongBan
                               ORDER BY pt.NgayPhuTroi DESC";
                dgvPhuTroi.DataSource = Db.Query(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp phụ trội: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachChamCong()
        {
            try
            {
                int thang = int.Parse(cboThang.Text);
                int nam = (int)numNam.Value;

                string sql = @"SELECT cc.MaChamCong AS [Mã CC], nv.MaNhanVien AS [Mã NV], nv.HoTen AS [Họ và Tên],
                                      pb.TenPhongBan AS [Phòng ban / Xưởng],
                                      cc.SoNgayCongChuan AS [Công chuẩn],
                                      cc.SoNgayCongThucTe AS [Công thực tế],
                                      cc.SoNgayNghiPhep AS [Nghỉ phép],
                                      cc.SoNgayNghiKhongLuong AS [Nghỉ KL],
                                      cc.TongGioPhuTroi AS [Tổng giờ OT],
                                      cc.NguoiChotCong AS [Người chốt]
                               FROM BangChamCong cc
                               JOIN NhanVien nv ON cc.MaNhanVien = nv.MaNhanVien
                               JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                               WHERE cc.Thang = @Thang AND cc.Nam = @Nam";
                dgvChamCong.DataSource = Db.Query(sql, new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp chấm công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemPhuTroi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhieu.Text) || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu phụ trội!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal heSo = 1.50m;
                string hinhThuc = "Tăng ca ngày thường";
                if (cboHinhThucOT.SelectedIndex == 1)
                {
                    heSo = 2.00m;
                    hinhThuc = "Ngày nghỉ hàng tuần";
                }
                else if (cboHinhThucOT.SelectedIndex == 2)
                {
                    heSo = 3.00m;
                    hinhThuc = "Ngày lễ tết";
                }

                // 1. Thêm PhieuPhuTroi
                string sqlPhieu = @"IF NOT EXISTS (SELECT 1 FROM PhieuPhuTroi WHERE SoPhieuPhuTroi = @So)
                                    INSERT INTO PhieuPhuTroi (SoPhieuPhuTroi, NgayPhuTroi, HinhThucPhuTroi, HeSoPhuTroi, MaPhongBan, LyDoPhuTroi, NguoiLapPhieu, TrangThaiDuyet)
                                    VALUES (@So, @Ngay, @HinhThuc, @HeSo, @PB, @LyDo, N'Ban chấm công', N'Chờ duyệt')";
                Db.Execute(sqlPhieu,
                    new SqlParameter("@So", txtSoPhieu.Text.Trim()),
                    new SqlParameter("@Ngay", dtpNgayOT.Value.Date),
                    new SqlParameter("@HinhThuc", hinhThuc),
                    new SqlParameter("@HeSo", heSo),
                    new SqlParameter("@PB", cboPhongBanOT.SelectedValue),
                    new SqlParameter("@LyDo", txtLyDo.Text.Trim())
                );

                // 2. Thêm ChiTietPhuTroi
                string sqlChiTiet = @"INSERT INTO ChiTietPhuTroi (SoPhieuPhuTroi, MaNhanVien, GioBatDau, GioKetThuc, SoGioPhuTroi, NoiDungCongViec)
                                      VALUES (@So, @MaNV, '17:00', '21:00', @SoGio, @LyDo)";
                Db.Execute(sqlChiTiet,
                    new SqlParameter("@So", txtSoPhieu.Text.Trim()),
                    new SqlParameter("@MaNV", cboNhanVien.SelectedValue),
                    new SqlParameter("@SoGio", numSoGioOT.Value),
                    new SqlParameter("@LyDo", txtLyDo.Text.Trim())
                );

                MessageBox.Show("Đã lưu Phiếu phụ trội thành công! (Trạng thái: Chờ duyệt)", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SinhMaPhieuOT();
                LoadDanhSachPhuTroi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuyetPhieu_Click(object sender, EventArgs e)
        {
            if (dgvPhuTroi.CurrentRow != null)
            {
                object val = dgvPhuTroi.CurrentRow.Cells["Số phiếu"].Value;
                string soPhieu = val != null ? val.ToString() : "";
                if (!string.IsNullOrEmpty(soPhieu))
                {
                    try
                    {
                        Db.Execute("UPDATE PhieuPhuTroi SET TrangThaiDuyet = N'Đã duyệt' WHERE SoPhieuPhuTroi = @So",
                                   new SqlParameter("@So", soPhieu));
                        MessageBox.Show("Đã duyệt phiếu phụ trội " + soPhieu + "!\n(Số giờ phụ trội sẽ được tự động tính vào kỳ lương tháng tương ứng)",
                                        "Đã duyệt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachPhuTroi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi duyệt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu phụ trội cần duyệt trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemChamCong_Click(object sender, EventArgs e)
        {
            LoadDanhSachChamCong();
        }

        private void btnCapNhatCong_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cboThang.Text);
            int nam = (int)numNam.Value;

            try
            {
                // Tự động đồng bộ số giờ phụ trội từ ChiTietPhuTroi vào BangChamCong
                string sqlSyncOT = @"
                    UPDATE cc
                    SET cc.TongGioPhuTroi = ISNULL((
                        SELECT SUM(ct.SoGioPhuTroi)
                        FROM ChiTietPhuTroi ct
                        JOIN PhieuPhuTroi pt ON ct.SoPhieuPhuTroi = pt.SoPhieuPhuTroi
                        WHERE ct.MaNhanVien = cc.MaNhanVien
                          AND pt.TrangThaiDuyet = N'Đã duyệt'
                          AND MONTH(pt.NgayPhuTroi) = cc.Thang
                          AND YEAR(pt.NgayPhuTroi) = cc.Nam
                    ), 0)
                    FROM BangChamCong cc
                    WHERE cc.Thang = @Thang AND cc.Nam = @Nam";

                Db.Execute(sqlSyncOT, new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));
                MessageBox.Show("Đã chốt và đồng bộ tổng giờ phụ trội (OT) vào Bảng chấm công Tháng " + thang + "/" + nam + " thành công!",
                                "Chốt công thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachChamCong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chốt công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
