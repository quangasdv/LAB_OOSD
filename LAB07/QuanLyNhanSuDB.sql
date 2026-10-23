-- ===================================================================
-- HỆ THỐNG QUẢN LÝ NHÂN SỰ - CÔNG TY SƠN ĐÔNG Á (BÀI 7 - OOSD)
-- Sinh viên: Nguyễn Đăng Quang - MSSV: 1250080152 - Lớp: 12_ĐH_CNPM2
-- CSDL: Chuẩn hóa 3NF, kế thừa phong cách thiết kế Lab 02 -> Lab 06
-- ===================================================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyNhanSuDB')
BEGIN
    ALTER DATABASE QuanLyNhanSuDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyNhanSuDB;
END
GO

CREATE DATABASE QuanLyNhanSuDB;
GO

USE QuanLyNhanSuDB;
GO

-- ===================================================================
-- PHẦN 1: CÁC BẢNG DANH MỤC CƠ SỞ
-- ===================================================================

-- 1. BẢNG PHÒNG BAN / PHÂN XƯỞNG
CREATE TABLE PhongBan (
    MaPhongBan VARCHAR(20) NOT NULL PRIMARY KEY,
    TenPhongBan NVARCHAR(100) NOT NULL,
    LoaiDonVi NVARCHAR(50) NOT NULL,            -- N'Phòng hành chính', N'Phân xưởng sản xuất', N'Ban chuyên trách'
    DiaDiem NVARCHAR(200) NOT NULL,
    SoDienThoai VARCHAR(20) NULL,
    MaTruongPhong VARCHAR(20) NULL,             -- Sẽ gán Foreign Key sau khi tạo bảng NhanVien
    CoMoiTruongDocHai BIT NOT NULL DEFAULT 0    -- 1: Phân xưởng sơn tiếp xúc hóa chất/dung môi; 0: Bình thường
);
GO

-- 2. BẢNG CHỨC VỤ / VỊ TRÍ CÔNG TÁC
CREATE TABLE ChucVu (
    MaChucVu VARCHAR(20) NOT NULL PRIMARY KEY,
    TenChucVu NVARCHAR(100) NOT NULL,
    PhuCapChucVuDinhMuc DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (PhuCapChucVuDinhMuc >= 0),
    MoTaNhiemVu NVARCHAR(255) NULL
);
GO

-- 3. BẢNG CA LÀM VIỆC
CREATE TABLE CaLamViec (
    MaCa VARCHAR(20) NOT NULL PRIMARY KEY,
    TenCa NVARCHAR(50) NOT NULL,                -- Ca sáng, Ca chiều, Ca đêm, Giờ hành chính
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    SoGioTieuChuan DECIMAL(4,2) NOT NULL DEFAULT 8.00 CHECK (SoGioTieuChuan > 0),
    HeSoCa DECIMAL(4,2) NOT NULL DEFAULT 1.00 CHECK (HeSoCa >= 1.00)
);
GO

-- ===================================================================
-- PHẦN 2: HỒ SƠ NHÂN VIÊN, TUYỂN DỤNG, HỢP ĐỒNG & BẢO HIỂM
-- ===================================================================

-- 4. BẢNG HỒ SƠ NHÂN VIÊN
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    SoCCCD VARCHAR(20) NOT NULL UNIQUE,
    DiaChi NVARCHAR(255) NULL,
    SoDienThoai VARCHAR(20) NULL,
    Email VARCHAR(100) NULL,
    MaPhongBan VARCHAR(20) NOT NULL,
    MaChucVu VARCHAR(20) NOT NULL,
    NgayVaoLam DATE NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Thử việc',
    CONSTRAINT CK_NhanVien_TrangThai CHECK (TrangThai IN (N'Thử việc', N'Chính thức', N'Đã nghỉ việc', N'Tạm hoãn')),
    CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan),
    CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);
GO

-- Cập nhật khóa ngoại Trưởng phòng cho bảng PhongBan (tự tham chiếu an toàn)
ALTER TABLE PhongBan
ADD CONSTRAINT FK_PhongBan_TruongPhong FOREIGN KEY (MaTruongPhong) REFERENCES NhanVien(MaNhanVien);
GO

-- 5. BẢNG QUYẾT ĐỊNH TUYỂN DỤNG & THỬ VIỆC
CREATE TABLE QuyetDinhTuyenDung (
    SoQuyetDinhTD VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    MaPhongBan VARCHAR(20) NOT NULL,
    NgayBanHanh DATE NOT NULL,
    NgayBatDauThuViec DATE NOT NULL,
    NgayKetThucThuViec DATE NOT NULL,
    LuongThuViec DECIMAL(18,2) NOT NULL CHECK (LuongThuViec >= 0),
    DieuKhoanHaiBen NVARCHAR(MAX) NULL,
    KetQuaThuViec NVARCHAR(50) NOT NULL DEFAULT N'Đang thử việc',
    NguoiKy NVARCHAR(100) NOT NULL,
    CONSTRAINT CK_QDTD_NgayThuViec CHECK (NgayKetThucThuViec >= NgayBatDauThuViec),
    CONSTRAINT CK_QDTD_KetQua CHECK (KetQuaThuViec IN (N'Đang thử việc', N'Đạt yêu cầu', N'Không đạt')),
    CONSTRAINT FK_QDTD_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    CONSTRAINT FK_QDTD_PhongBan FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);
GO

-- 6. BẢNG HỢP ĐỒNG LAO ĐỘNG CHÍNH THỨC
CREATE TABLE HopDongLaoDong (
    SoHopDong VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    LoaiHopDong NVARCHAR(50) NOT NULL,          -- N'Ngắn hạn', N'Dài hạn', N'Không xác định thời hạn'
    NgayKy DATE NOT NULL,
    NgayHieuLuc DATE NOT NULL,
    NgayHetHan DATE NULL,                       -- Cho phép NULL nếu là HĐ không xác định thời hạn
    DiaDiemLamViec NVARCHAR(200) NOT NULL DEFAULT N'Công ty Sơn Đông Á',
    LuongDongBaoHiem DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (LuongDongBaoHiem >= 0),
    TrangThaiHopDong NVARCHAR(30) NOT NULL DEFAULT N'Hiệu lực',
    CONSTRAINT CK_HDLD_Loai CHECK (LoaiHopDong IN (N'Ngắn hạn', N'Dài hạn', N'Không xác định thời hạn')),
    CONSTRAINT CK_HDLD_TrangThai CHECK (TrangThaiHopDong IN (N'Hiệu lực', N'Đã hết hạn', N'Đã thanh lý')),
    CONSTRAINT FK_HDLD_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 7. BẢNG HỒ SƠ BẢO HIỂM (BHXH, BHYT, BHTN - BẮT BUỘC VỚI HỢP ĐỒNG DÀI HẠN)
CREATE TABLE HoSoBaoHiem (
    MaHoSoBH VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL UNIQUE,
    SoSoBHXH VARCHAR(30) NOT NULL UNIQUE,
    MaTheBHYT VARCHAR(30) NOT NULL UNIQUE,
    NoiDangKyKCB NVARCHAR(150) NOT NULL,        -- Bệnh viện đăng ký khám chữa bệnh ban đầu
    TyLeDongBHXH DECIMAL(5,4) NOT NULL DEFAULT 0.0800,  -- Người lao động đóng 8%
    TyLeDongBHYT DECIMAL(5,4) NOT NULL DEFAULT 0.0150,  -- Người lao động đóng 1.5%
    TyLeDongBHTN DECIMAL(5,4) NOT NULL DEFAULT 0.0100,  -- Người lao động đóng 1%
    NgayThamGia DATE NOT NULL,
    TrangThaiSo NVARCHAR(30) NOT NULL DEFAULT N'Đang tham gia',
    CONSTRAINT CK_HSBH_TrangThai CHECK (TrangThaiSo IN (N'Đang tham gia', N'Tạm dừng', N'Đã chốt sổ')),
    CONSTRAINT FK_HSBH_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- ===================================================================
-- PHẦN 3: LỊCH SỬ QUYẾT ĐỊNH CHỨC VỤ, LƯƠNG & PHỤ CẤP ĐỘC HẠI
-- ===================================================================

-- 8. BẢNG QUYẾT ĐỊNH CHỨC VỤ (BỔ NHIỆM / ĐIỀU CHUYỂN)
CREATE TABLE QuyetDinhChucVu (
    SoQuyetDinhCV VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    MaChucVuMoi VARCHAR(20) NOT NULL,
    PhuCapChucVu DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (PhuCapChucVu >= 0),
    NgayHieuLuc DATE NOT NULL,
    LyDoBoNhiem NVARCHAR(255) NULL,
    NguoiKyDuyet NVARCHAR(100) NOT NULL,
    HieuLucHienHanh BIT NOT NULL DEFAULT 1,      -- 1: Đang áp dụng, 0: Đã có quyết định mới
    CONSTRAINT FK_QDCV_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    CONSTRAINT FK_QDCV_ChucVuMoi FOREIGN KEY (MaChucVuMoi) REFERENCES ChucVu(MaChucVu)
);
GO

-- 9. BẢNG QUYẾT ĐỊNH LƯƠNG & PHỤ CẤP ĐỘC HẠI
CREATE TABLE QuyetDinhLuong (
    SoQuyetDinhLuong VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    LuongCoBan DECIMAL(18,2) NOT NULL CHECK (LuongCoBan >= 0),
    HeSoLuong DECIMAL(4,2) NOT NULL DEFAULT 1.00 CHECK (HeSoLuong > 0),
    PhuCapLuong DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (PhuCapLuong >= 0),
    PhuCapDocHai DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (PhuCapDocHai >= 0), -- Áp dụng cho phân xưởng sơn
    NgayHieuLuc DATE NOT NULL,
    LyDoThayDoi NVARCHAR(255) NULL,
    NguoiKyDuyet NVARCHAR(100) NOT NULL,
    HieuLucHienHanh BIT NOT NULL DEFAULT 1,      -- 1: Đang áp dụng, 0: Đã có quyết định mới
    CONSTRAINT FK_QDL_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- ===================================================================
-- PHẦN 4: KẾ HOẠCH TUẦN, PHÂN CÔNG CA & PHỤ TRỘI (TĂNG CA / OT)
-- ===================================================================

-- 10. BẢNG KẾ HOẠCH LÀM VIỆC TUẦN
CREATE TABLE KeHoachTuan (
    MaKeHoachTuan VARCHAR(30) NOT NULL PRIMARY KEY,
    MaPhongBan VARCHAR(20) NOT NULL,
    TuanThu INT NOT NULL CHECK (TuanThu BETWEEN 1 AND 53),
    Nam INT NOT NULL CHECK (Nam >= 2020),
    TuNgay DATE NOT NULL,
    DenNgay DATE NOT NULL,
    KeHoachPhuTroiDuKien NVARCHAR(500) NULL,
    NguoiLap NVARCHAR(100) NOT NULL,
    TrangThaiKeHoach NVARCHAR(50) NOT NULL DEFAULT N'Dự thảo',
    CONSTRAINT CK_KHT_Ngay CHECK (DenNgay >= TuNgay),
    CONSTRAINT CK_KHT_TrangThai CHECK (TrangThaiKeHoach IN (N'Dự thảo', N'Đã chuyển Ban chấm công', N'Đã duyệt')),
    CONSTRAINT FK_KHT_PhongBan FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);
GO

-- 11. BẢNG PHÂN CÔNG CA LÀM VIỆC CHO NHÂN VIÊN
CREATE TABLE PhanCongCa (
    MaPhanCong INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MaKeHoachTuan VARCHAR(30) NOT NULL,
    MaNhanVien VARCHAR(20) NOT NULL,
    NgayLamViec DATE NOT NULL,
    MaCa VARCHAR(20) NOT NULL,
    CoDangKyPhuTroi BIT NOT NULL DEFAULT 0,
    GhiChuCongViec NVARCHAR(255) NULL,
    CONSTRAINT UQ_PhanCongCa UNIQUE (MaNhanVien, NgayLamViec, MaCa),
    CONSTRAINT FK_PCC_KeHoachTuan FOREIGN KEY (MaKeHoachTuan) REFERENCES KeHoachTuan(MaKeHoachTuan) ON DELETE CASCADE,
    CONSTRAINT FK_PCC_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    CONSTRAINT FK_PCC_CaLamViec FOREIGN KEY (MaCa) REFERENCES CaLamViec(MaCa)
);
GO

-- 12. BẢNG PHIẾU GHI NHẬN GIỜ PHỤ TRỘI (BAN CHẤM CÔNG LẬP)
CREATE TABLE PhieuPhuTroi (
    SoPhieuPhuTroi VARCHAR(30) NOT NULL PRIMARY KEY,
    NgayPhuTroi DATE NOT NULL,
    HinhThucPhuTroi NVARCHAR(50) NOT NULL,      -- Tăng ca ngày thường, Ngày nghỉ, Ngày lễ tết
    HeSoPhuTroi DECIMAL(4,2) NOT NULL DEFAULT 1.50, -- 1.5: ngày thường; 2.0: ngày nghỉ; 3.0: ngày lễ
    MaPhongBan VARCHAR(20) NOT NULL,
    LyDoPhuTroi NVARCHAR(255) NOT NULL,
    NguoiLapPhieu NVARCHAR(100) NOT NULL,
    TrangThaiDuyet NVARCHAR(30) NOT NULL DEFAULT N'Chờ duyệt',
    CONSTRAINT CK_PPT_HinhThuc CHECK (HinhThucPhuTroi IN (N'Tăng ca ngày thường', N'Ngày nghỉ hàng tuần', N'Ngày lễ tết')),
    CONSTRAINT CK_PPT_HeSo CHECK (HeSoPhuTroi IN (1.50, 2.00, 3.00)),
    CONSTRAINT CK_PPT_TrangThai CHECK (TrangThaiDuyet IN (N'Chờ duyệt', N'Đã duyệt', N'Từ chối')),
    CONSTRAINT FK_PPT_PhongBan FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);
GO

-- 13. BẢNG CHI TIẾT PHỤ TRỘI TỪNG NHÂN VIÊN
CREATE TABLE ChiTietPhuTroi (
    MaChiTietPhuTroi INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    SoPhieuPhuTroi VARCHAR(30) NOT NULL,
    MaNhanVien VARCHAR(20) NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    SoGioPhuTroi DECIMAL(4,2) NOT NULL CHECK (SoGioPhuTroi > 0),
    NoiDungCongViec NVARCHAR(255) NULL,
    CONSTRAINT UQ_ChiTietPhuTroi UNIQUE (SoPhieuPhuTroi, MaNhanVien),
    CONSTRAINT FK_CTPT_PhieuPhuTroi FOREIGN KEY (SoPhieuPhuTroi) REFERENCES PhieuPhuTroi(SoPhieuPhuTroi) ON DELETE CASCADE,
    CONSTRAINT FK_CTPT_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- ===================================================================
-- PHẦN 5: CHẤM CÔNG, KHEN THƯỞNG, KỶ LUẬT & BẢNG LƯƠNG THÁNG
-- ===================================================================

-- 14. BẢNG CHẤM CÔNG TỔNG HỢP THÁNG
CREATE TABLE BangChamCong (
    MaChamCong VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    Thang INT NOT NULL CHECK (Thang BETWEEN 1 AND 12),
    Nam INT NOT NULL CHECK (Nam >= 2020),
    SoNgayCongChuan DECIMAL(4,2) NOT NULL DEFAULT 26.00 CHECK (SoNgayCongChuan > 0),
    SoNgayCongThucTe DECIMAL(4,2) NOT NULL DEFAULT 0 CHECK (SoNgayCongThucTe >= 0),
    SoNgayNghiPhep DECIMAL(4,2) NOT NULL DEFAULT 0 CHECK (SoNgayNghiPhep >= 0),
    SoNgayNghiKhongLuong DECIMAL(4,2) NOT NULL DEFAULT 0 CHECK (SoNgayNghiKhongLuong >= 0),
    TongGioPhuTroi DECIMAL(6,2) NOT NULL DEFAULT 0 CHECK (TongGioPhuTroi >= 0),
    NguoiChotCong NVARCHAR(100) NOT NULL,
    CONSTRAINT UQ_BangChamCong UNIQUE (MaNhanVien, Thang, Nam),
    CONSTRAINT FK_BCC_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- 15. BẢNG QUYẾT ĐỊNH KHEN THƯỞNG & KỶ LUẬT
CREATE TABLE KhenThuongKyLuat (
    SoQuyetDinhKTKL VARCHAR(30) NOT NULL PRIMARY KEY,
    DoiTuong NVARCHAR(20) NOT NULL CHECK (DoiTuong IN (N'Cá nhân', N'Tập thể')),
    MaDoiTuong VARCHAR(20) NOT NULL,            -- Mã nhân viên (nếu Cá nhân) hoặc Mã phòng ban (nếu Tập thể)
    LoaiQuyetDinh NVARCHAR(50) NOT NULL,        -- Khen thưởng, Kỷ luật, Thưởng ngày lễ, Thưởng cuối năm, Lương tháng 13
    NgayBanHanh DATE NOT NULL,
    LyDo NVARCHAR(255) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien > 0),
    HinhThucXuLy NVARCHAR(50) NOT NULL,         -- N'Chi tiền mặt ngay', N'Trừ/Cộng vào bảng lương'
    SoPhieuThuChi VARCHAR(30) NULL,             -- Số phiếu chi khen thưởng hoặc phiếu thu nộp phạt
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc',
    CONSTRAINT CK_KTKL_Loai CHECK (LoaiQuyetDinh IN (N'Khen thưởng', N'Kỷ luật', N'Thưởng ngày lễ', N'Thưởng cuối năm', N'Lương tháng 13')),
    CONSTRAINT CK_KTKL_HinhThuc CHECK (HinhThucXuLy IN (N'Chi tiền mặt ngay', N'Trừ/Cộng vào bảng lương'))
);
GO

-- 16. BẢNG THANH TOÁN TIỀN LƯƠNG HẰNG THÁNG
CREATE TABLE BangLuongThang (
    MaBangLuong VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    Thang INT NOT NULL CHECK (Thang BETWEEN 1 AND 12),
    Nam INT NOT NULL CHECK (Nam >= 2020),
    
    -- Các khoản thu nhập
    LuongNgayCong DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (LuongNgayCong >= 0),
    TienPhuCapChucVu DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienPhuCapChucVu >= 0),
    TienPhuCapDocHai DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienPhuCapDocHai >= 0),
    TienPhuCapLuong DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienPhuCapLuong >= 0),
    TienLuongPhuTroi DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienLuongPhuTroi >= 0),
    TienKhenThuong DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienKhenThuong >= 0),
    
    -- Các khoản khấu trừ
    TienTrichBHXH_BHYT DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienTrichBHXH_BHYT >= 0),
    TienPhatKyLuat DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienPhatKyLuat >= 0),
    ThueTNCN DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (ThueTNCN >= 0),
    
    -- Thực lĩnh = Tổng thu nhập - Tổng khấu trừ
    ThucLinh DECIMAL(18,2) NOT NULL DEFAULT 0,
    TrangThaiLuong NVARCHAR(30) NOT NULL DEFAULT N'Dự thảo',
    CONSTRAINT CK_BLT_TrangThai CHECK (TrangThaiLuong IN (N'Dự thảo', N'Đã duyệt', N'Đã thanh toán')),
    CONSTRAINT UQ_BangLuongThang UNIQUE (MaNhanVien, Thang, Nam),
    CONSTRAINT FK_BLT_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO

-- ===================================================================
-- PHẦN 6: CÁC VIEW HỖ TRỢ HIỂN THỊ TRÊN GIAO DIỆN WINFORMS
-- ===================================================================

-- VIEW 1: THÔNG TIN HỒ SƠ NHÂN VIÊN ĐẦY ĐỦ
CREATE OR ALTER VIEW vw_ThongTinNhanVienDayDu AS
SELECT 
    nv.MaNhanVien,
    nv.HoTen,
    nv.NgaySinh,
    nv.GioiTinh,
    nv.SoCCCD,
    nv.SoDienThoai,
    nv.Email,
    pb.MaPhongBan,
    pb.TenPhongBan,
    pb.CoMoiTruongDocHai,
    cv.MaChucVu,
    cv.TenChucVu,
    nv.NgayVaoLam,
    nv.TrangThai,
    hd.SoHopDong,
    hd.LoaiHopDong,
    hd.LuongDongBaoHiem,
    bh.SoSoBHXH,
    bh.MaTheBHYT,
    ql.LuongCoBan,
    ql.HeSoLuong,
    ql.PhuCapLuong,
    ql.PhuCapDocHai,
    qc.PhuCapChucVu
FROM NhanVien nv
LEFT JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
LEFT JOIN ChucVu cv ON nv.MaChucVu = cv.MaChucVu
LEFT JOIN HopDongLaoDong hd ON nv.MaNhanVien = hd.MaNhanVien AND hd.TrangThaiHopDong = N'Hiệu lực'
LEFT JOIN HoSoBaoHiem bh ON nv.MaNhanVien = bh.MaNhanVien AND bh.TrangThaiSo = N'Đang tham gia'
LEFT JOIN QuyetDinhLuong ql ON nv.MaNhanVien = ql.MaNhanVien AND ql.HieuLucHienHanh = 1
LEFT JOIN QuyetDinhChucVu qc ON nv.MaNhanVien = qc.MaNhanVien AND qc.HieuLucHienHanh = 1;
GO

-- VIEW 2: BẢNG LƯƠNG TỔNG HỢP TOÀN CÔNG TY (KÈM CHI TIẾT PHÒNG BAN & HỌ TÊN)
CREATE OR ALTER VIEW vw_BangLuongChiTietToanCongTy AS
SELECT 
    bl.MaBangLuong,
    bl.Thang,
    bl.Nam,
    nv.MaNhanVien,
    nv.HoTen,
    pb.TenPhongBan,
    cv.TenChucVu,
    (bl.LuongNgayCong + bl.TienPhuCapChucVu + bl.TienPhuCapDocHai + bl.TienPhuCapLuong + bl.TienLuongPhuTroi + bl.TienKhenThuong) AS TongThuNhap,
    bl.LuongNgayCong,
    bl.TienPhuCapChucVu,
    bl.TienPhuCapDocHai,
    bl.TienPhuCapLuong,
    bl.TienLuongPhuTroi,
    bl.TienKhenThuong,
    (bl.TienTrichBHXH_BHYT + bl.TienPhatKyLuat + bl.ThueTNCN) AS TongKhauTru,
    bl.TienTrichBHXH_BHYT,
    bl.TienPhatKyLuat,
    bl.ThueTNCN,
    bl.ThucLinh,
    bl.TrangThaiLuong
FROM BangLuongThang bl
JOIN NhanVien nv ON bl.MaNhanVien = nv.MaNhanVien
JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
JOIN ChucVu cv ON nv.MaChucVu = cv.MaChucVu;
GO

-- ===================================================================
-- PHẦN 7: STORED PROCEDURES NGHIỆP VỤ (TỰ ĐỘNG TÍNH LƯƠNG THÁNG)
-- ===================================================================

-- SP 1: TÍNH LƯƠNG TỰ ĐỘNG CHO MỘT NHÂN VIÊN TRONG THÁNG
CREATE OR ALTER PROCEDURE sp_TinhLuongThangNhanVien
    @MaNhanVien VARCHAR(20),
    @Thang INT,
    @Nam INT,
    @NguoiThucHien NVARCHAR(100) = N'Hệ thống tự động'
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Lấy thông tin chấm công tháng
    DECLARE @SoNgayCongChuan DECIMAL(4,2) = 26.00,
            @SoNgayCongThucTe DECIMAL(4,2) = 0.00,
            @TongGioPhuTroi DECIMAL(6,2) = 0.00;

    SELECT 
        @SoNgayCongChuan = ISNULL(SoNgayCongChuan, 26.00),
        @SoNgayCongThucTe = ISNULL(SoNgayCongThucTe, 0.00),
        @TongGioPhuTroi = ISNULL(TongGioPhuTroi, 0.00)
    FROM BangChamCong
    WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang AND Nam = @Nam;

    -- 2. Lấy thông tin Quyết định Lương hiện hành
    DECLARE @LuongCoBan DECIMAL(18,2) = 0,
            @HeSoLuong DECIMAL(4,2) = 1.00,
            @PhuCapLuong DECIMAL(18,2) = 0,
            @PhuCapDocHai DECIMAL(18,2) = 0;

    SELECT TOP 1
        @LuongCoBan = LuongCoBan,
        @HeSoLuong = HeSoLuong,
        @PhuCapLuong = PhuCapLuong,
        @PhuCapDocHai = PhuCapDocHai
    FROM QuyetDinhLuong
    WHERE MaNhanVien = @MaNhanVien AND HieuLucHienHanh = 1;

    -- 3. Lấy thông tin Quyết định Chức vụ hiện hành
    DECLARE @PhuCapChucVu DECIMAL(18,2) = 0;
    SELECT TOP 1
        @PhuCapChucVu = PhuCapChucVu
    FROM QuyetDinhChucVu
    WHERE MaNhanVien = @MaNhanVien AND HieuLucHienHanh = 1;

    -- 4. Tính Lương ngày công: (Lương cơ bản * Hệ số / Ngày chuẩn) * Ngày thực tế
    DECLARE @LuongNgayCong DECIMAL(18,2) = 0;
    IF (@SoNgayCongChuan > 0)
    BEGIN
        SET @LuongNgayCong = ROUND((@LuongCoBan * @HeSoLuong / @SoNgayCongChuan) * @SoNgayCongThucTe, 0);
    END

    -- 5. Tính Tiền phụ trội (OT) dựa trên các phiếu phụ trội ĐÃ DUYỆT trong tháng
    DECLARE @TienLuongPhuTroi DECIMAL(18,2) = 0;
    SELECT @TienLuongPhuTroi = ISNULL(ROUND(SUM(
        (@LuongCoBan * @HeSoLuong / @SoNgayCongChuan / 8.00) * ct.SoGioPhuTroi * pt.HeSoPhuTroi
    ), 0), 0)
    FROM ChiTietPhuTroi ct
    JOIN PhieuPhuTroi pt ON ct.SoPhieuPhuTroi = pt.SoPhieuPhuTroi
    WHERE ct.MaNhanVien = @MaNhanVien
      AND pt.TrangThaiDuyet = N'Đã duyệt'
      AND MONTH(pt.NgayPhuTroi) = @Thang
      AND YEAR(pt.NgayPhuTroi) = @Nam;

    -- 6. Tiền Khen thưởng cộng vào bảng lương trong tháng
    DECLARE @TienKhenThuong DECIMAL(18,2) = 0;
    SELECT @TienKhenThuong = ISNULL(SUM(SoTien), 0)
    FROM KhenThuongKyLuat
    WHERE MaDoiTuong = @MaNhanVien
      AND LoaiQuyetDinh IN (N'Khen thưởng', N'Thưởng ngày lễ', N'Thưởng cuối năm', N'Lương tháng 13')
      AND HinhThucXuLy = N'Trừ/Cộng vào bảng lương'
      AND MONTH(NgayBanHanh) = @Thang
      AND YEAR(NgayBanHanh) = @Nam;

    -- 7. Tiền trích BHXH, BHYT, BHTN (Tổng 10.5% = 8% + 1.5% + 1%) đối với HỢP ĐỒNG DÀI HẠN
    DECLARE @TienTrichBH DECIMAL(18,2) = 0;
    DECLARE @LoaiHopDong NVARCHAR(50) = N'';
    DECLARE @LuongDongBaoHiem DECIMAL(18,2) = 0;

    SELECT TOP 1 
        @LoaiHopDong = LoaiHopDong,
        @LuongDongBaoHiem = LuongDongBaoHiem
    FROM HopDongLaoDong
    WHERE MaNhanVien = @MaNhanVien AND TrangThaiHopDong = N'Hiệu lực';

    IF (@LoaiHopDong IN (N'Dài hạn', N'Không xác định thời hạn'))
    BEGIN
        SET @TienTrichBH = ROUND(@LuongDongBaoHiem * (0.08 + 0.015 + 0.010), 0);
    END

    -- 8. Tiền phạt Kỷ luật trừ vào lương trong tháng
    DECLARE @TienPhat DECIMAL(18,2) = 0;
    SELECT @TienPhat = ISNULL(SUM(SoTien), 0)
    FROM KhenThuongKyLuat
    WHERE MaDoiTuong = @MaNhanVien
      AND LoaiQuyetDinh = N'Kỷ luật'
      AND HinhThucXuLy = N'Trừ/Cộng vào bảng lương'
      AND MONTH(NgayBanHanh) = @Thang
      AND YEAR(NgayBanHanh) = @Nam;

    -- 9. Tạm tính Thuế TNCN (ví dụ thu nhập chịu thuế vượt mức giảm trừ cá nhân 11.000.000)
    DECLARE @TongThuNhap DECIMAL(18,2) = @LuongNgayCong + @PhuCapChucVu + @PhuCapDocHai + @PhuCapLuong + @TienLuongPhuTroi + @TienKhenThuong;
    DECLARE @ThuNhapChiuThue DECIMAL(18,2) = @TongThuNhap - @TienTrichBH - 11000000;
    DECLARE @ThueTNCN DECIMAL(18,2) = 0;
    IF (@ThuNhapChiuThue > 0)
    BEGIN
        SET @ThueTNCN = ROUND(@ThuNhapChiuThue * 0.05, 0); -- Tạm tính bậc 1: 5%
    END

    -- 10. Tính Thực Lĩnh
    DECLARE @ThucLinh DECIMAL(18,2) = @TongThuNhap - (@TienTrichBH + @TienPhat + @ThueTNCN);

    -- 11. Lưu hoặc Cập nhật vào BangLuongThang
    DECLARE @MaBangLuong VARCHAR(30) = 'BL/' + CAST(@Nam AS VARCHAR(4)) + '/' + RIGHT('0' + CAST(@Thang AS VARCHAR(2)), 2) + '/' + @MaNhanVien;

    IF EXISTS (SELECT 1 FROM BangLuongThang WHERE MaBangLuong = @MaBangLuong)
    BEGIN
        UPDATE BangLuongThang
        SET LuongNgayCong = @LuongNgayCong,
            TienPhuCapChucVu = @PhuCapChucVu,
            TienPhuCapDocHai = @PhuCapDocHai,
            TienPhuCapLuong = @PhuCapLuong,
            TienLuongPhuTroi = @TienLuongPhuTroi,
            TienKhenThuong = @TienKhenThuong,
            TienTrichBHXH_BHYT = @TienTrichBH,
            TienPhatKyLuat = @TienPhat,
            ThueTNCN = @ThueTNCN,
            ThucLinh = @ThucLinh,
            TrangThaiLuong = N'Dự thảo'
        WHERE MaBangLuong = @MaBangLuong;
    END
    ELSE
    BEGIN
        INSERT INTO BangLuongThang (
            MaBangLuong, MaNhanVien, Thang, Nam,
            LuongNgayCong, TienPhuCapChucVu, TienPhuCapDocHai, TienPhuCapLuong, TienLuongPhuTroi, TienKhenThuong,
            TienTrichBHXH_BHYT, TienPhatKyLuat, ThueTNCN, ThucLinh, TrangThaiLuong
        )
        VALUES (
            @MaBangLuong, @MaNhanVien, @Thang, @Nam,
            @LuongNgayCong, @PhuCapChucVu, @PhuCapDocHai, @PhuCapLuong, @TienLuongPhuTroi, @TienKhenThuong,
            @TienTrichBH, @TienPhat, @ThueTNCN, @ThucLinh, N'Dự thảo'
        );
    END
END;
GO

-- SP 2: TÍNH LƯƠNG TỰ ĐỘNG CHO TOÀN BỘ NHÂN VIÊN TRONG CÔNG TY
CREATE OR ALTER PROCEDURE sp_TinhLuongToanCongTy
    @Thang INT,
    @Nam INT,
    @NguoiThucHien NVARCHAR(100) = N'Ban Giám Đốc'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaNV VARCHAR(20);
    DECLARE cur_nv CURSOR FOR
        SELECT MaNhanVien 
        FROM NhanVien 
        WHERE TrangThai IN (N'Chính thức', N'Thử việc');

    OPEN cur_nv;
    FETCH NEXT FROM cur_nv INTO @MaNV;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        EXEC sp_TinhLuongThangNhanVien @MaNhanVien = @MaNV, @Thang = @Thang, @Nam = @Nam, @NguoiThucHien = @NguoiThucHien;
        FETCH NEXT FROM cur_nv INTO @MaNV;
    END

    CLOSE cur_nv;
    DEALLOCATE cur_nv;

    PRINT N'Đã hoàn tất tính lương toàn công ty cho Tháng ' + CAST(@Thang AS VARCHAR(2)) + '/' + CAST(@Nam AS VARCHAR(4));
END;
GO

-- ===================================================================
-- PHẦN 8: BỘ DỮ LIỆU MẪU CHUẨN XÁC THỰC TẾ (SEED DATA)
-- ===================================================================

-- 1. Thêm Phòng ban / Phân xưởng công ty Sơn Đông Á
INSERT INTO PhongBan (MaPhongBan, TenPhongBan, LoaiDonVi, DiaDiem, SoDienThoai, CoMoiTruongDocHai) VALUES
('PB_BGD',  N'Ban Giám Đốc',               N'Ban chuyên trách',    N'Tầng 3 - Tòa nhà điều hành', '02838990001', 0),
('PB_TCKT', N'Phòng Tài chính Kế toán',    N'Phòng hành chính',    N'Tầng 2 - Tòa nhà điều hành', '02838990002', 0),
('PB_HCNS', N'Phòng Hành chính Nhân sự',   N'Phòng hành chính',    N'Tầng 2 - Tòa nhà điều hành', '02838990003', 0),
('PB_KT',   N'Phòng Kỹ thuật & R&D Màu',   N'Phòng chuyên môn',    N'Khu thí nghiệm Lab Hóa',    '02838990004', 0),
('PX_SX',   N'Phân xưởng Sản xuất Pha sơn', N'Phân xưởng sản xuất', N'Khu nhà xưởng A - Cụm SX', '02838990005', 1), -- Độc hại!
('BAN_CC',  N'Ban Chấm công & An toàn',    N'Ban chuyên trách',    N'Cổng kiểm soát nhà máy',     '02838990006', 0);
GO

-- 2. Thêm Chức vụ
INSERT INTO ChucVu (MaChucVu, TenChucVu, PhuCapChucVuDinhMuc, MoTaNhiemVu) VALUES
('GD',   N'Giám đốc điều hành',       5000000, N'Quản lý điều hành toàn bộ công ty sơn'),
('TP',   N'Trưởng phòng / Kế toán trưởng', 2500000, N'Phụ trách phòng chuyên môn nghiệp vụ'),
('QD',   N'Quản đốc phân xưởng',      2000000, N'Chỉ đạo ca sản xuất, dây chuyền pha sơn'),
('KS',   N'Kỹ sư hóa chất & màu sơn', 1200000, N'Nghiên cứu công thức sơn, kiểm định chất lượng'),
('CN',   N'Công nhân pha chế sơn',     600000, N'Vận hành máy trộn, pha màu, tiếp xúc dung môi'),
('NV',   N'Nhân viên nghiệp vụ',            0, N'Thực hiện các công việc văn phòng, chấm công');
GO

-- 3. Thêm Ca làm việc
INSERT INTO CaLamViec (MaCa, TenCa, GioBatDau, GioKetThuc, SoGioTieuChuan, HeSoCa) VALUES
('CA_HC', N'Hành chính văn phòng', '08:00', '17:00', 8.00, 1.00),
('CA1',   N'Ca sáng sản xuất',     '06:00', '14:00', 8.00, 1.00),
('CA2',   N'Ca chiều sản xuất',    '14:00', '22:00', 8.00, 1.00),
('CA3',   N'Ca đêm sản xuất',      '22:00', '06:00', 8.00, 1.30);
GO

-- 4. Thêm Nhân viên
INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, SoCCCD, DiaChi, SoDienThoai, Email, MaPhongBan, MaChucVu, NgayVaoLam, TrangThai) VALUES
('NV001', N'Trần Văn Đông',    '1980-05-15', N'Nam', '079080000001', N'123 CMT8, Q.3, TP.HCM',       '0903111222', 'dong.tran@sondonga.vn', 'PB_BGD',  'GD', '2018-01-01', N'Chính thức'),
('NV002', N'Lê Thị Ánh',       '1985-09-20', N'Nữ',  '079185000002', N'45 Lê Lợi, Q.1, TP.HCM',       '0918333444', 'anh.le@sondonga.vn',   'PB_TCKT', 'TP', '2019-03-01', N'Chính thức'),
('NV003', N'Phạm Quốc Hùng',   '1988-11-10', N'Nam', '079088000003', N'78 Quang Trung, Gò Vấp',       '0988555666', 'hung.pham@sondonga.vn', 'PX_SX',   'QD', '2020-05-15', N'Chính thức'),
('NV004', N'Đỗ Minh Tuấn',     '1995-03-25', N'Nam', '079095000004', N'12 Tân Kỳ Tân Quý, Tân Phú',   '0977888999', 'tuan.do@sondonga.vn',   'PX_SX',   'CN', '2021-06-01', N'Chính thức'),
('NV005', N'Vũ Hoàng Nam',     '1998-07-12', N'Nam', '079098000005', N'89 Xô Viết Nghệ Tĩnh, Bình Thạnh','0933444555','nam.vu@sondonga.vn',    'PB_KT',   'KS', '2026-05-01', N'Chính thức'),
('NV006', N'Nguyễn Đăng Quang','2002-10-23', N'Nam', '125008015201', N'36 Điện Biên Phủ, Bình Thạnh', '0912500801', 'quang.nguyen@sondonga.vn','PB_HCNS', 'NV', '2026-09-01', N'Thử việc');
GO

-- Cập nhật Trưởng phòng cho các phòng ban
UPDATE PhongBan SET MaTruongPhong = 'NV001' WHERE MaPhongBan = 'PB_BGD';
UPDATE PhongBan SET MaTruongPhong = 'NV002' WHERE MaPhongBan = 'PB_TCKT';
UPDATE PhongBan SET MaTruongPhong = 'NV003' WHERE MaPhongBan = 'PX_SX';
GO

-- 5. Thêm Quyết định tuyển dụng & thử việc
INSERT INTO QuyetDinhTuyenDung (SoQuyetDinhTD, MaNhanVien, MaPhongBan, NgayBanHanh, NgayBatDauThuViec, NgayKetThucThuViec, LuongThuViec, DieuKhoanHaiBen, KetQuaThuViec, NguoiKy) VALUES
('QDTD/2021/045', 'NV004', 'PX_SX',   '2021-05-20', '2021-06-01', '2021-07-31', 6500000,  N'Thử việc vị trí công nhân pha màu sơn tại xưởng', N'Đạt yêu cầu',   N'Trần Văn Đông'),
('QDTD/2026/012', 'NV005', 'PB_KT',   '2026-04-20', '2026-05-01', '2026-06-30', 8500000,  N'Thử việc kỹ sư thí nghiệm hóa màu sơn',           N'Đạt yêu cầu',   N'Trần Văn Đông'),
('QDTD/2026/030', 'NV006', 'PB_HCNS', '2026-08-25', '2026-09-01', '2026-10-31', 6800000,  N'Thử việc nhân viên quản trị nhân sự 2 tháng',     N'Đang thử việc', N'Trần Văn Đông');
GO

-- 6. Thêm Hợp đồng lao động
INSERT INTO HopDongLaoDong (SoHopDong, MaNhanVien, LoaiHopDong, NgayKy, NgayHieuLuc, NgayHetHan, DiaDiemLamViec, LuongDongBaoHiem, TrangThaiHopDong) VALUES
('HDLD/2018/001', 'NV001', N'Không xác định thời hạn', '2018-01-01', '2018-01-01', NULL,         N'Công ty Sơn Đông Á', 25000000, N'Hiệu lực'),
('HDLD/2019/005', 'NV002', N'Dài hạn',                '2019-03-01', '2019-03-01', '2027-03-01', N'Công ty Sơn Đông Á', 18000000, N'Hiệu lực'),
('HDLD/2020/010', 'NV003', N'Dài hạn',                '2020-05-15', '2020-05-15', '2025-05-15', N'Công ty Sơn Đông Á', 15000000, N'Hiệu lực'),
('HDLD/2021/022', 'NV004', N'Dài hạn',                '2021-08-01', '2021-08-01', '2026-08-01', N'Xưởng sản xuất sơn',  8000000, N'Hiệu lực'),
('HDLD/2026/040', 'NV005', N'Ngắn hạn',               '2026-07-01', '2026-07-01', '2026-12-31', N'Phòng R&D hóa màu',         0, N'Hiệu lực');
GO

-- 7. Thêm Hồ sơ bảo hiểm cho nhân viên HĐ dài hạn
INSERT INTO HoSoBaoHiem (MaHoSoBH, MaNhanVien, SoSoBHXH, MaTheBHYT, NoiDangKyKCB, TyLeDongBHXH, TyLeDongBHYT, TyLeDongBHTN, NgayThamGia, TrangThaiSo) VALUES
('BH/2018/001', 'NV001', 'BHXH79018001', 'BHYT79018001', N'Bệnh viện ĐK Sài Gòn',    0.0800, 0.0150, 0.0100, '2018-01-01', N'Đang tham gia'),
('BH/2019/005', 'NV002', 'BHXH79019002', 'BHYT79019002', N'Bệnh viện Thống Nhất',     0.0800, 0.0150, 0.0100, '2019-03-01', N'Đang tham gia'),
('BH/2020/010', 'NV003', 'BHXH79020003', 'BHYT79020003', N'Bệnh viện 175',           0.0800, 0.0150, 0.0100, '2020-05-15', N'Đang tham gia'),
('BH/2021/022', 'NV004', 'BHXH79021004', 'BHYT79021004', N'Bệnh viện ĐK Khu vực Q.12',0.0800, 0.0150, 0.0100, '2021-08-01', N'Đang tham gia');
GO

-- 8. Thêm Quyết định chức vụ
INSERT INTO QuyetDinhChucVu (SoQuyetDinhCV, MaNhanVien, MaChucVuMoi, PhuCapChucVu, NgayHieuLuc, LyDoBoNhiem, NguoiKyDuyet, HieuLucHienHanh) VALUES
('QDCV/2018/001', 'NV001', 'GD', 5000000, '2018-01-01', N'Bổ nhiệm Giám đốc công ty sơn', N'Hội đồng quản trị', 1),
('QDCV/2019/008', 'NV002', 'TP', 2500000, '2019-03-01', N'Bổ nhiệm Kế toán trưởng',       N'Trần Văn Đông',     1),
('QDCV/2020/015', 'NV003', 'QD', 2000000, '2020-05-15', N'Bổ nhiệm Quản đốc xưởng sơn',   N'Trần Văn Đông',     1),
('QDCV/2021/030', 'NV004', 'CN',  600000, '2021-08-01', N'Công nhận bậc thợ sản xuất',      N'Trần Văn Đông',     1),
('QDCV/2026/018', 'NV005', 'KS',        0, '2026-07-01', N'Kỹ sư hóa chất hợp đồng ngắn hạn',N'Trần Văn Đông',     1),
('QDCV/2026/025', 'NV006', 'NV',        0, '2026-09-01', N'Nhân viên hành sự thử việc',      N'Trần Văn Đông',     1);
GO

-- 9. Thêm Quyết định lương & phụ cấp độc hại
INSERT INTO QuyetDinhLuong (SoQuyetDinhLuong, MaNhanVien, LuongCoBan, HeSoLuong, PhuCapLuong, PhuCapDocHai, NgayHieuLuc, LyDoThayDoi, NguoiKyDuyet, HieuLucHienHanh) VALUES
('QDL/2026/001', 'NV001', 25000000, 1.20, 3000000,       0, '2026-01-01', N'Nâng bậc lương định kỳ',    N'HĐQT',          1),
('QDL/2026/002', 'NV002', 18000000, 1.10, 2000000,       0, '2026-01-01', N'Nâng ngạch lương năm 2026', N'Trần Văn Đông', 1),
('QDL/2026/003', 'NV003', 15000000, 1.05, 1500000, 1800000, '2026-01-01', N'Phụ cấp quản đốc + độc hại',N'Trần Văn Đông', 1),
('QDL/2026/004', 'NV004',  8000000, 1.00, 1000000, 1500000, '2026-01-01', N'Phụ cấp độc hại tiếp xúc sơn',N'Trần Văn Đông',1),
('QDL/2026/005', 'NV005', 10000000, 1.00,  500000,       0, '2026-07-01', N'Lương theo HĐ ngắn hạn',   N'Trần Văn Đông', 1),
('QDL/2026/006', 'NV006',  8000000, 0.85,       0,       0, '2026-09-01', N'Mức 85% lương thử việc',    N'Trần Văn Đông', 1);
GO

-- 10. Kế hoạch làm việc tuần (Tuần 42, Tháng 10/2026)
INSERT INTO KeHoachTuan (MaKeHoachTuan, MaPhongBan, TuanThu, Nam, TuNgay, DenNgay, KeHoachPhuTroiDuKien, NguoiLap, TrangThaiKeHoach) VALUES
('KH/2026/W42/PX', 'PX_SX', 42, 2026, '2026-10-12', '2026-10-18', N'Tăng ca ngày 15/10 để kịp tiến độ xuất kho 50 tấn sơn công nghiệp', N'Phạm Quốc Hùng', N'Đã duyệt');
GO

-- 11. Phân công ca làm việc
INSERT INTO PhanCongCa (MaKeHoachTuan, MaNhanVien, NgayLamViec, MaCa, CoDangKyPhuTroi, GhiChuCongViec) VALUES
('KH/2026/W42/PX', 'NV003', '2026-10-15', 'CA1', 0, N'Giám sát vận hành xưởng'),
('KH/2026/W42/PX', 'NV004', '2026-10-15', 'CA1', 1, N'Pha màu sơn lót epoxy, đăng ký OT 4 giờ');
GO

-- 12. Phiếu ghi nhận phụ trội (Ban chấm công lập)
INSERT INTO PhieuPhuTroi (SoPhieuPhuTroi, NgayPhuTroi, HinhThucPhuTroi, HeSoPhuTroi, MaPhongBan, LyDoPhuTroi, NguoiLapPhieu, TrangThaiDuyet) VALUES
('PT/2026/10/01', '2026-10-15', N'Tăng ca ngày thường', 1.50, 'PX_SX', N'Hoàn thành mẻ sơn chống rỉ bàn giao dự án Cầu Mỹ Thuận', N'Nguyễn Văn Công', N'Đã duyệt');
GO

-- 13. Chi tiết phụ trội cho nhân viên
INSERT INTO ChiTietPhuTroi (SoPhieuPhuTroi, MaNhanVien, GioBatDau, GioKetThuc, SoGioPhuTroi, NoiDungCongViec) VALUES
('PT/2026/10/01', 'NV004', '14:30', '18:30', 4.00, N'Trực tiếp đứng máy khuấy pha màu đợt 2');
GO

-- 14. Bảng chấm công tổng hợp Tháng 10/2026
INSERT INTO BangChamCong (MaChamCong, MaNhanVien, Thang, Nam, SoNgayCongChuan, SoNgayCongThucTe, SoNgayNghiPhep, SoNgayNghiKhongLuong, TongGioPhuTroi, NguoiChotCong) VALUES
('CC/2026/10/NV001', 'NV001', 10, 2026, 26, 26, 0, 0,  0.00, N'Nguyễn Văn Công'),
('CC/2026/10/NV002', 'NV002', 10, 2026, 26, 25, 1, 0,  0.00, N'Nguyễn Văn Công'),
('CC/2026/10/NV003', 'NV003', 10, 2026, 26, 26, 0, 0,  0.00, N'Nguyễn Văn Công'),
('CC/2026/10/NV004', 'NV004', 10, 2026, 26, 26, 0, 0,  4.00, N'Nguyễn Văn Công'),
('CC/2026/10/NV005', 'NV005', 10, 2026, 26, 24, 0, 2,  0.00, N'Nguyễn Văn Công'),
('CC/2026/10/NV006', 'NV006', 10, 2026, 26, 26, 0, 0,  0.00, N'Nguyễn Văn Công');
GO

-- 15. Quyết định khen thưởng và kỷ luật trong tháng
INSERT INTO KhenThuongKyLuat (SoQuyetDinhKTKL, DoiTuong, MaDoiTuong, LoaiQuyetDinh, NgayBanHanh, LyDo, SoTien, HinhThucXuLy, SoPhieuThuChi, NguoiKy) VALUES
('QDKT/2026/015', N'Cá nhân', 'NV004', N'Khen thưởng', '2026-10-20', N'Sáng kiến cải tiến đầu khuấy giúp giảm hao hụt hóa chất sơn', 1000000, N'Trừ/Cộng vào bảng lương', 'PCKT001', N'Trần Văn Đông'),
('QDKL/2026/003', N'Cá nhân', 'NV005', N'Kỷ luật',     '2026-10-22', N'Vi phạm quy định an toàn hóa chất phòng thí nghiệm màu',     500000, N'Trừ/Cộng vào bảng lương', 'PTNP001', N'Trần Văn Đông');
GO

-- 16. TÍNH LƯƠNG TỰ ĐỘNG THÁNG 10/2026
EXEC sp_TinhLuongToanCongTy @Thang = 10, @Nam = 2026, @NguoiThucHien = N'Trần Văn Đông';
GO
