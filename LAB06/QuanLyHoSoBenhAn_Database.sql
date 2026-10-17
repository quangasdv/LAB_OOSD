-- ===================================================================
-- HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN BỆNH NHÂN (BÀI 5 - OOSD)
-- Script khởi tạo Cơ sở Dữ liệu Microsoft SQL Server (T-SQL)
-- Chuẩn hóa theo phong cách thiết kế Database Lab 4 & Lab 5
-- ===================================================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyHoSoBenhAnDB')
BEGIN
    ALTER DATABASE QuanLyHoSoBenhAnDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyHoSoBenhAnDB;
END
GO

CREATE DATABASE QuanLyHoSoBenhAnDB;
GO

USE QuanLyHoSoBenhAnDB;
GO

-- 1. BẢNG KHOA ĐIỀU TRỊ / PHÒNG BAN Y TẾ
CREATE TABLE KhoaDieuTri (
    MaKhoa VARCHAR(20) NOT NULL PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL,
    ViTri NVARCHAR(100) NULL,
    DienThoaiKhoa VARCHAR(20) NULL,
    TruongKhoa NVARCHAR(100) NULL
);
GO

-- 2. BẢNG BÁC SĨ / NHÂN VIÊN Y TẾ
CREATE TABLE BacSi (
    MaBacSi VARCHAR(20) NOT NULL PRIMARY KEY,
    MaKhoa VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    HocHamHocVi NVARCHAR(50) NULL,        -- BS.CKI, BS.CKII, ThS.BS, TS.BS...
    ChuyenKhoa NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NULL,
    CONSTRAINT FK_BacSi_Khoa FOREIGN KEY (MaKhoa) REFERENCES KhoaDieuTri(MaKhoa)
);
GO

-- 3. BẢNG BỆNH NHÂN (ĐĂNG KÝ MỚI & THÔNG TIN HÀNH CHÍNH)
CREATE TABLE BenhNhan (
    MaBenhNhan VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK(GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    DiaChi NVARCHAR(250) NOT NULL,
    SoDienThoai VARCHAR(20) NOT NULL,
    SoCCCD_BHYT VARCHAR(25) NULL,
    HinhAnh3x4 VARCHAR(255) NULL,         -- Đường dẫn file ảnh 3x4 dán trang bìa
    NgayDangKy DATETIME NOT NULL DEFAULT GETDATE(),
    NguoiLienHeKhan NVARCHAR(100) NULL,
    SDTNguoiLienHe VARCHAR(20) NULL
);
GO

-- 4. BẢNG LỆ PHÍ HẰNG NĂM (THU CỐ ĐỊNH 1 NĂM KHI ĐĂNG KÝ/GIA HẠN)
CREATE TABLE LePhiNam (
    MaLePhi VARCHAR(30) NOT NULL PRIMARY KEY,
    MaBenhNhan VARCHAR(20) NOT NULL,
    NamThu INT NOT NULL CHECK(NamThu >= 2020),
    SoTien DECIMAL(18,2) NOT NULL CHECK(SoTien > 0),
    NgayThu DATETIME NOT NULL DEFAULT GETDATE(),
    NgayHetHan DATE NOT NULL,              -- 1 năm kể từ ngày thu
    HinhThucThanhToan NVARCHAR(50) NOT NULL DEFAULT N'Tiền mặt' CHECK(HinhThucThanhToan IN (N'Tiền mặt', N'Chuyển khoản', N'Thẻ POS')),
    NguoiThu NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã thanh toán',
    CONSTRAINT FK_LePhiNam_BenhNhan FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan)
);
GO

-- 5. BẢNG HỒ SƠ BỆNH ÁN (TRANG BÌA & LÝ LỊCH BỆNH ÁN LÂU DÀI)
CREATE TABLE HoSoBenhAn (
    MaHoSo VARCHAR(20) NOT NULL PRIMARY KEY,
    MaBenhNhan VARCHAR(20) NOT NULL UNIQUE,
    NgayCap DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    NhomMau VARCHAR(10) NULL CHECK(NhomMau IN ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-')),
    TienSuBenh NVARCHAR(MAX) NULL,        -- Tiền sử bệnh lý bản thân & gia đình
    BenhManTinh NVARCHAR(500) NULL,       -- Cao huyết áp, Đái tháo đường típ 2, Tim mạch...
    ThuocDaTungDung NVARCHAR(MAX) NULL,   -- Danh sách thuốc đã từng điều trị
    DiUngThuoc_PhanUngPhu NVARCHAR(MAX) NULL, -- RẤT QUAN TRỌNG: Cảnh báo dị ứng Penicillin, Aspirin...
    TinhTrangHoSo NVARCHAR(50) NOT NULL DEFAULT N'Đang theo dõi' CHECK(TinhTrangHoSo IN (N'Đang theo dõi', N'Đã kết thúc', N'Lưu trữ')),
    CONSTRAINT FK_HoSoBenhAn_BenhNhan FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan)
);
GO

-- 6. BẢNG ĐỢT ĐIỀU TRỊ (MỖI LẦN BỆNH NHÂN NHẬP VIỆN / ĐIỀU TRỊ ĐỢT MỚI)
CREATE TABLE DotDieuTri (
    MaDotDieuTri VARCHAR(30) NOT NULL PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    MaBacSiPhuTrach VARCHAR(20) NOT NULL,
    MaKhoa VARCHAR(20) NOT NULL,
    NgayBatDau DATETIME NOT NULL DEFAULT GETDATE(),
    NgayKetThuc DATETIME NULL,
    LoaiDieuTri NVARCHAR(50) NOT NULL DEFAULT N'Ngoại trú' CHECK(LoaiDieuTri IN (N'Ngoại trú', N'Nội trú', N'Khám ban ngày')),
    LyDoDieuTri NVARCHAR(255) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đang điều trị' CHECK(TrangThai IN (N'Đang điều trị', N'Hoàn tất', N'Chuyển viện', N'Bỏ dở')),
    CONSTRAINT FK_DotDieuTri_HoSo FOREIGN KEY (MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
    CONSTRAINT FK_DotDieuTri_BacSi FOREIGN KEY (MaBacSiPhuTrach) REFERENCES BacSi(MaBacSi),
    CONSTRAINT FK_DotDieuTri_Khoa FOREIGN KEY (MaKhoa) REFERENCES KhoaDieuTri(MaKhoa)
);
GO

-- 7. BẢNG PHIẾU KHÁM BỆNH (GHI NHẬN SINH HIỆU & TRIỆU CHỨNG LÂM SÀNG)
CREATE TABLE PhieuKhamBenh (
    MaPhieuKham VARCHAR(30) NOT NULL PRIMARY KEY,
    MaDotDieuTri VARCHAR(30) NOT NULL,
    MaBacSiKham VARCHAR(20) NOT NULL,
    NgayGioKham DATETIME NOT NULL DEFAULT GETDATE(),
    LanKham INT NOT NULL DEFAULT 1,
    NhietDo DECIMAL(4,1) NOT NULL CHECK(NhietDo BETWEEN 34.0 AND 43.0), -- Độ C
    HuyetAp VARCHAR(20) NOT NULL,                                       -- mmHg (vd: 120/80)
    Mach INT NOT NULL CHECK(Mach BETWEEN 30 AND 220),                   -- Lần/phút
    NhipTho INT NULL CHECK(NhipTho BETWEEN 10 AND 60),                  -- Lần/phút
    CanNang DECIMAL(5,2) NULL CHECK(CanNang > 0),                       -- kg
    ChieuCao DECIMAL(5,2) NULL CHECK(ChieuCao > 0),                     -- cm
    TrieuChungLamsang NVARCHAR(MAX) NOT NULL,                           -- Sốt, đau đầu, ho đờm...
    ChanDoanSoBo NVARCHAR(500) NOT NULL,
    ChanDoanXacDinh NVARCHAR(500) NULL,
    MaBenhICD10 VARCHAR(20) NULL,
    HuongXuLy NVARCHAR(500) NULL,
    CONSTRAINT FK_PhieuKham_DotDieuTri FOREIGN KEY (MaDotDieuTri) REFERENCES DotDieuTri(MaDotDieuTri),
    CONSTRAINT FK_PhieuKham_BacSi FOREIGN KEY (MaBacSiKham) REFERENCES BacSi(MaBacSi)
);
GO

-- 8. BẢNG DANH MỤC XÉT NGHIỆM CẬN LÂM SÀNG
CREATE TABLE DanhMucXetNghiem (
    MaXetNghiem VARCHAR(20) NOT NULL PRIMARY KEY,
    TenXetNghiem NVARCHAR(150) NOT NULL,
    LoaiXetNghiem NVARCHAR(100) NOT NULL,                               -- Huyết học, Sinh hóa, Nước tiểu, X-quang, Siêu âm...
    DonGia DECIMAL(18,2) NOT NULL CHECK(DonGia >= 0),
    ChiSoBinhThuong NVARCHAR(100) NULL,                                 -- Khoảng tham chiếu
    DonViDo NVARCHAR(50) NULL,
    ThoiGianTraKetQua NVARCHAR(50) NULL
);
GO

-- 9. BẢNG PHIẾU CHỈ ĐỊNH XÉT NGHIỆM
CREATE TABLE PhieuChiDinhXetNghiem (
    MaChiDinh VARCHAR(30) NOT NULL PRIMARY KEY,
    MaPhieuKham VARCHAR(30) NOT NULL,
    MaBacSiChiDinh VARCHAR(20) NOT NULL,
    NgayChiDinh DATETIME NOT NULL DEFAULT GETDATE(),
    LyDoChiDinh NVARCHAR(255) NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Chờ thực hiện' CHECK(TrangThai IN (N'Chờ thực hiện', N'Đang thực hiện', N'Đã có kết quả')),
    CONSTRAINT FK_ChiDinh_PhieuKham FOREIGN KEY (MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham),
    CONSTRAINT FK_ChiDinh_BacSi FOREIGN KEY (MaBacSiChiDinh) REFERENCES BacSi(MaBacSi)
);
GO

-- 10. BẢNG CHI TIẾT KẾT QUẢ XÉT NGHIỆM
CREATE TABLE ChiTietXetNghiem (
    MaChiDinh VARCHAR(30) NOT NULL,
    MaXetNghiem VARCHAR(20) NOT NULL,
    KetQua NVARCHAR(250) NULL,
    DanhGiaKetQua NVARCHAR(50) NULL CHECK(DanhGiaKetQua IN (N'Bình thường', N'Cao', N'Thấp', N'Bất thường', N'Dương tính', N'Âm tính')),
    NgayGioTraKQ DATETIME NULL,
    KTVThucHien NVARCHAR(100) NULL,
    GhiChu NVARCHAR(255) NULL,
    PRIMARY KEY (MaChiDinh, MaXetNghiem),
    CONSTRAINT FK_CTXN_ChiDinh FOREIGN KEY (MaChiDinh) REFERENCES PhieuChiDinhXetNghiem(MaChiDinh),
    CONSTRAINT FK_CTXN_DanhMuc FOREIGN KEY (MaXetNghiem) REFERENCES DanhMucXetNghiem(MaXetNghiem)
);
GO

-- 11. BẢNG DANH MỤC THUỐC
CREATE TABLE Thuoc (
    MaThuoc VARCHAR(20) NOT NULL PRIMARY KEY,
    TenThuoc NVARCHAR(150) NOT NULL,
    HoatChatChinh NVARCHAR(150) NOT NULL,
    DonViTinh NVARCHAR(30) NOT NULL,                                    -- Viên, Gói, Chai, Vỉ, Ống...
    HamLuong NVARCHAR(50) NOT NULL,                                     -- 500mg, 10mg, 250mg/5ml...
    DuongDung NVARCHAR(50) NOT NULL,                                    -- Uống, Tiêm bắp, Tiêm tĩnh mạch, Bôi ngoài da...
    DonGia DECIMAL(18,2) NOT NULL CHECK(DonGia >= 0),
    ChongChiDinh NVARCHAR(500) NULL,                                    -- Chống chỉ định suy gan, suy thận, phụ nữ có thai...
    TuongTacThuoc NVARCHAR(500) NULL                                    -- Tương tác cảnh báo nguy hiểm
);
GO

-- 12. BẢNG TOA THUỐC ĐIỀU TRỊ
CREATE TABLE ToaThuoc (
    MaToaThuoc VARCHAR(30) NOT NULL PRIMARY KEY,
    MaPhieuKham VARCHAR(30) NOT NULL,
    MaBacSiKeToa VARCHAR(20) NOT NULL,
    NgayKeToa DATETIME NOT NULL DEFAULT GETDATE(),
    SoNgayDungThuoc INT NOT NULL CHECK(SoNgayDungThuoc > 0),
    LoiDanBacSi NVARCHAR(MAX) NULL,
    LuuYPhanUngPhu NVARCHAR(500) NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã kê toa' CHECK(TrangThai IN (N'Đã kê toa', N'Đã cấp phát', N'Hủy toa')),
    CONSTRAINT FK_ToaThuoc_PhieuKham FOREIGN KEY (MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham),
    CONSTRAINT FK_ToaThuoc_BacSi FOREIGN KEY (MaBacSiKeToa) REFERENCES BacSi(MaBacSi)
);
GO

-- 13. BẢNG CHI TIẾT TOA THUỐC
CREATE TABLE ChiTietToaThuoc (
    MaToaThuoc VARCHAR(30) NOT NULL,
    MaThuoc VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK(SoLuong > 0),
    Sang DECIMAL(4,1) NOT NULL DEFAULT 0,
    Trua DECIMAL(4,1) NOT NULL DEFAULT 0,
    Chieu DECIMAL(4,1) NOT NULL DEFAULT 0,
    Toi DECIMAL(4,1) NOT NULL DEFAULT 0,
    CachDung NVARCHAR(200) NOT NULL,                                    -- Sau ăn 30 phút, trước ăn...
    DonGiaLucKe DECIMAL(18,2) NOT NULL CHECK(DonGiaLucKe >= 0),
    PRIMARY KEY (MaToaThuoc, MaThuoc),
    CONSTRAINT FK_CTTT_ToaThuoc FOREIGN KEY (MaToaThuoc) REFERENCES ToaThuoc(MaToaThuoc),
    CONSTRAINT FK_CTTT_Thuoc FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
);
GO

-- 14. BẢNG LỊCH HẸN TÁI KHÁM ĐỊNH KỲ
CREATE TABLE LichHenTaiKham (
    MaLichHen VARCHAR(30) NOT NULL PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    MaBacSiHen VARCHAR(20) NOT NULL,
    NgayHenKham DATE NOT NULL,
    GioHenKham TIME NULL,
    NoiDungKham NVARCHAR(255) NOT NULL,
    DanDoChuanBi NVARCHAR(500) NULL,
    TrangThaiHen NVARCHAR(50) NOT NULL DEFAULT N'Chưa đến hẹn' CHECK(TrangThaiHen IN (N'Chưa đến hẹn', N'Đã đến khám', N'Quá hẹn/Hủy')),
    CONSTRAINT FK_LichHen_HoSo FOREIGN KEY (MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
    CONSTRAINT FK_LichHen_BacSi FOREIGN KEY (MaBacSiHen) REFERENCES BacSi(MaBacSi)
);
GO

-- 15. BẢNG HOÀN TẤT ĐỢT ĐIỀU TRỊ (XUẤT VIỆN / TỔNG KẾT ĐỢT KHÁM)
CREATE TABLE HoanTatDieuTri (
    MaHoanTat VARCHAR(30) NOT NULL PRIMARY KEY,
    MaDotDieuTri VARCHAR(30) NOT NULL UNIQUE,
    NgayHoanTat DATETIME NOT NULL DEFAULT GETDATE(),
    MaBacSiXacNhan VARCHAR(20) NOT NULL,
    KetQuaDieuTri NVARCHAR(100) NOT NULL CHECK(KetQuaDieuTri IN (N'Khỏi bệnh', N'Thuyên giảm', N'Không thay đổi', N'Nặng hơn', N'Tử vong')),
    TinhTrangXuatVien NVARCHAR(500) NOT NULL,
    DanDoSauXuatVien NVARCHAR(MAX) NULL,
    TongTienVienPhi DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK(TongTienVienPhi >= 0),
    BHYTChiTra DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK(BHYTChiTra >= 0),
    BenhNhanThanhToan DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK(BenhNhanThanhToan >= 0),
    CONSTRAINT FK_HoanTat_DotDieuTri FOREIGN KEY (MaDotDieuTri) REFERENCES DotDieuTri(MaDotDieuTri),
    CONSTRAINT FK_HoanTat_BacSi FOREIGN KEY (MaBacSiXacNhan) REFERENCES BacSi(MaBacSi)
);
GO

-- ===================================================================
-- DỮ LIỆU MẪU THỰC TẾ (SEED DATA)
-- ===================================================================

-- 1. Khoa Điều trị
INSERT INTO KhoaDieuTri (MaKhoa, TenKhoa, ViTri, DienThoaiKhoa, TruongKhoa) VALUES
('KHOA_KB', N'Khoa Khám bệnh', N'Tầng 1 - Khu A', '02838112233', N'BS.CKII Nguyễn Văn Cảnh'),
('KHOA_NOI', N'Khoa Nội Tổng Hợp', N'Tầng 3 - Khu B', '02838112234', N'ThS.BS Trần Mai Loan'),
('KHOA_TIM', N'Khoa Tim Mạch Can Thiệp', N'Tầng 4 - Khu B', '02838112235', N'TS.BS Phạm Đức Trọng'),
('KHOA_XN', N'Khoa Xét nghiệm & Cận lâm sàng', N'Tầng 2 - Khu C', '02838112236', N'BS.CKI Lê Thị Minh');

-- 2. Bác sĩ
INSERT INTO BacSi (MaBacSi, MaKhoa, HoTen, HocHamHocVi, ChuyenKhoa, DienThoai, Email) VALUES
('BS01', 'KHOA_KB', N'Nguyễn Văn Cảnh', N'BS.CKII', N'Nội khoa chung', '0903123456', 'canh.nv@bv.vn'),
('BS02', 'KHOA_NOI', N'Trần Mai Loan', N'ThS.BS', N'Nội tiết - Tiêu hóa', '0908765432', 'loan.tm@bv.vn'),
('BS03', 'KHOA_TIM', N'Phạm Đức Trọng', N'TS.BS', N'Tim mạch can thiệp', '0912345678', 'trong.pd@bv.vn'),
('BS04', 'KHOA_KB', N'Vũ Hoàng Anh', N'BS.CKI', N'Khám bệnh & Cấp cứu', '0987654321', 'anh.vh@bv.vn');

-- 3. Bệnh nhân
INSERT INTO BenhNhan (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, SoCCCD_BHYT, HinhAnh3x4, NgayDangKy, NguoiLienHeKhan, SDTNguoiLienHe) VALUES
('BN20260001', N'Trần Văn An', '1985-05-15', N'Nam', N'Số 123 Lê Duẩn, Quận 1, TP.HCM', '0913555777', '079085001122', '/uploads/anh3x4/BN20260001.jpg', '2026-01-10 08:30:00', N'Nguyễn Thị Thu (Vợ)', '0913555888'),
('BN20260002', N'Lê Thị Hương Mai', '1992-10-22', N'Nữ', N'Số 45/2 Hoàng Hoa Thám, Tân Bình, TP.HCM', '0988222333', '079192003344', '/uploads/anh3x4/BN20260002.jpg', '2026-02-14 09:15:00', N'Lê Văn Hùng (Bố)', '0988222444'),
('BN20260003', N'Phạm Đức Dũng', '1960-03-08', N'Nam', N'Số 78 Nguyễn Văn Linh, Quận 7, TP.HCM', '0903888999', '079060005566', '/uploads/anh3x4/BN20260003.jpg', '2026-03-01 10:00:00', N'Phạm Thị Mai (Con gái)', '0903888000');

-- 4. Lệ phí hằng năm (Cố định trong 1 năm: 200,000 VND / năm)
INSERT INTO LePhiNam (MaLePhi, MaBenhNhan, NamThu, SoTien, NgayThu, NgayHetHan, HinhThucThanhToan, NguoiThu, TrangThai) VALUES
('LP2026_001', 'BN20260001', 2026, 200000, '2026-01-10 08:35:00', '2027-01-10', N'Tiền mặt', N'Thu ngân Nguyễn Lan', N'Đã thanh toán'),
('LP2026_002', 'BN20260002', 2026, 200000, '2026-02-14 09:20:00', '2027-02-14', N'Chuyển khoản', N'Thu ngân Nguyễn Lan', N'Đã thanh toán'),
('LP2026_003', 'BN20260003', 2026, 200000, '2026-03-01 10:05:00', '2027-03-01', N'Tiền mặt', N'Thu ngân Lê Hồng', N'Đã thanh toán');

-- 5. Hồ sơ bệnh án
INSERT INTO HoSoBenhAn (MaHoSo, MaBenhNhan, NgayCap, NhomMau, TienSuBenh, BenhManTinh, ThuocDaTungDung, DiUngThuoc_PhanUngPhu, TinhTrangHoSo) VALUES
('HS20260001', 'BN20260001', '2026-01-10', 'O+', N'Viêm loét dạ dày tá tràng năm 2022', NULL, N'Omeprazole, Phosphalugel', N'Dị ứng nhẹ với Paracetamol (nổi mẩn ngứa da)', N'Đang theo dõi'),
('HS20260002', 'BN20260002', '2026-02-14', 'A+', N'Không ghi nhận tiền sử bệnh lý gia đình', NULL, N'Vitamin C, Kháng histamin', N'DỊ ỨNG NẶNG VỚI PENICILLIN (Khó thở, sốc phản vệ độ 2)', N'Đang theo dõi'),
('HS20260003', 'BN20260003', '2026-03-01', 'B+', N'Tiền sử gia đình có bố bị tim mạch', N'Tăng huyết áp vô căn (độ 2), Rối loạn mỡ máu', N'Amlodipine 5mg, Atorvastatin 20mg', N'Không có tiền sử dị ứng thuốc', N'Đang theo dõi');

-- 6. Đợt điều trị
INSERT INTO DotDieuTri (MaDotDieuTri, MaHoSo, MaBacSiPhuTrach, MaKhoa, NgayBatDau, NgayKetThuc, LoaiDieuTri, LyDoDieuTri, TrangThai) VALUES
('DOT202610_01', 'HS20260001', 'BS01', 'KHOA_KB', '2026-10-15 08:00:00', '2026-10-15 11:30:00', N'Ngoại trú', N'Sốt cao, đau họng, nhức mỏi người 2 ngày', N'Hoàn tất'),
('DOT202610_02', 'HS20260002', 'BS02', 'KHOA_NOI', '2026-10-16 09:00:00', NULL, N'Ngoại trú', N'Đau âm ỉ vùng thượng vị kèm ợ chua nhiều', N'Đang điều trị'),
('DOT202610_03', 'HS20260003', 'BS03', 'KHOA_TIM', '2026-10-17 08:30:00', NULL, N'Khám ban ngày', N'Khám định kỳ huyết áp, đau đầu chóng mặt buổi sáng', N'Đang điều trị');

-- 7. Phiếu khám bệnh
INSERT INTO PhieuKhamBenh (MaPhieuKham, MaDotDieuTri, MaBacSiKham, NgayGioKham, LanKham, NhietDo, HuyetAp, Mach, NhipTho, CanNang, ChieuCao, TrieuChungLamsang, ChanDoanSoBo, ChanDoanXacDinh, MaBenhICD10, HuongXuLy) VALUES
('PK20261015001', 'DOT202610_01', 'BS01', '2026-10-15 08:15:00', 1, 38.8, '120/80', 92, 20, 68.5, 172.0, N'Bệnh nhân sốt cao rét run, đau rát cổ họng khi nuốt, nhức đầu, hắt hơi, mệt mỏi toàn thân', N'Nhiễm khuẩn đường hô hấp trên / Sốt siêu vi', N'Viêm họng cấp (J02)', 'J02', N'Chỉ định công thức máu, kê toa thuốc giảm đau hạ sốt (tránh paracetamol), kháng viêm'),
('PK20261016001', 'DOT202610_02', 'BS02', '2026-10-16 09:15:00', 1, 37.0, '115/75', 76, 18, 52.0, 160.0, N'Đau cồn cào vùng thượng vị sau khi ăn, ợ hơi ợ chua, buồn nôn nhẹ, chán ăn', N'Viêm dạ dày tá tràng cấp', N'Viêm dạ dày cấp tính có trào ngược (K29.1)', 'K29.1', N'Chỉ định test vi khuẩn HP, kê đơn thuốc ức chế tiết acid dạ dày và bảo vệ niêm mạc'),
('PK20261017001', 'DOT202610_03', 'BS03', '2026-10-17 08:45:00', 1, 36.8, '150/95', 84, 19, 74.0, 168.0, N'Huyết áp đo tại nhà dao động 150-160mmHg, nặng đầu vùng gáy, chóng mặt khi đổi tư thế', N'Tăng huyết áp kiểm soát chưa tốt / Rối loạn lipid máu', N'Bệnh tăng huyết áp nguyên phát (I10)', 'I10', N'Làm xét nghiệm bộ mỡ máu, điện tim (ECG), điều chỉnh phác đồ thuốc hạ áp');

-- 8. Danh mục xét nghiệm
INSERT INTO DanhMucXetNghiem (MaXetNghiem, TenXetNghiem, LoaiXetNghiem, DonGia, ChiSoBinhThuong, DonViDo, ThoiGianTraKetQua) VALUES
('XN_CTM', N'Tổng phân tích tế bào máu ngoại vi (24 thông số)', N'Huyết học', 120000, N'WBC: 4.0 - 10.0; RBC: 4.0 - 5.8', 'G/L, T/L', N'45 phút'),
('XN_GLU', N'Định lượng Glucose máu lúc đói', N'Sinh hóa', 60000, N'3.9 - 6.4', 'mmol/L', N'30 phút'),
('XN_LIPID', N'Bộ mỡ máu toàn phần (Cholesterol, Triglycerid, HDL, LDL)', N'Sinh hóa', 180000, N'Cholesterol < 5.2; Triglycerid < 1.7', 'mmol/L', N'60 phút'),
('XN_HP', N'Nội soi & Test hơi thở tìm vi khuẩn Helicobacter Pylori (HP)', N'Vi sinh', 350000, N'Âm tính (Negative)', N'Định tính', N'30 phút'),
('XN_ECG', N'Điện tâm đồ vi tính 12 chuyển đạo (ECG)', N'Thăm dò chức năng', 80000, N'Nhịp xoang đều, tần số 60-90 ck/p', N'Điện thế', N'15 phút');

-- 9. Phiếu chỉ định xét nghiệm
INSERT INTO PhieuChiDinhXetNghiem (MaChiDinh, MaPhieuKham, MaBacSiChiDinh, NgayChiDinh, LyDoChiDinh, TrangThai) VALUES
('CD2026101501', 'PK20261015001', 'BS01', '2026-10-15 08:30:00', N'Kiểm tra chỉ số bạch cầu và dấu hiệu nhiễm trùng hô hấp', N'Đã có kết quả'),
('CD2026101601', 'PK20261016001', 'BS02', '2026-10-16 09:30:00', N'Kiểm tra nhiễm khuẩn dạ dày HP', N'Đã có kết quả'),
('CD2026101701', 'PK20261017001', 'BS03', '2026-10-17 09:00:00', N'Đánh giá mỡ máu và tầm soát phì đại thất trái / thiếu máu cơ tim', N'Đã có kết quả');

-- 10. Chi tiết kết quả xét nghiệm
INSERT INTO ChiTietXetNghiem (MaChiDinh, MaXetNghiem, KetQua, DanhGiaKetQua, NgayGioTraKQ, KTVThucHien, GhiChu) VALUES
('CD2026101501', 'XN_CTM', N'WBC: 12.8 G/L (Neu%: 78%), RBC: 4.8 T/L, HGB: 145 g/L', N'Bất thường', '2026-10-15 09:20:00', N'KTV Trần Văn Khoa', N'Bạch cầu tăng cao, gợi ý tình trạng nhiễm khuẩn cấp'),
('CD2026101601', 'XN_HP', N'Dương tính (+)', N'Dương tính', '2026-10-16 10:10:00', N'KTV Lê Hồng Hạnh', N'Phát hiện có vi khuẩn H.Pylori hoạt động trong niêm mạc dạ dày'),
('CD2026101701', 'XN_LIPID', N'Cholesterol TP: 6.8 mmol/L; Triglycerid: 2.9 mmol/L; LDL-C: 4.2 mmol/L', N'Cao', '2026-10-17 10:05:00', N'KTV Trần Văn Khoa', N'Tăng lipid máu hỗn hợp, cần duy trì Statin'),
('CD2026101701', 'XN_ECG', N'Nhịp xoang 82 lần/phút, trục trung gian, dày thất trái nhẹ', N'Bất thường', '2026-10-17 09:25:00', N'BS Nguyễn Văn Cảnh', N'Dấu hiệu dày thất trái do tăng huyết áp lâu năm');

-- 11. Danh mục thuốc
INSERT INTO Thuoc (MaThuoc, TenThuoc, HoatChatChinh, DonViTinh, HamLuong, DuongDung, DonGia, ChongChiDinh, TuongTacThuoc) VALUES
('TH01', N'Ibuprofen 400mg', N'Ibuprofen', N'Viên', '400mg', N'Uống', 2500, N'Viêm loét dạ dày đang tiến triển, suy gan thận nặng', N'Tăng nguy cơ chảy máu khi dùng chung với thuốc chống đông'),
('TH02', N'Amoxicillin 500mg', N'Amoxicillin', N'Viên', '500mg', N'Uống', 3000, N'TIỀN SỬ DỊ ỨNG PENICILLIN, Beta-lactam', N'Giảm hiệu quả của thuốc tránh thai đường uống'),
('TH03', N'Esomeprazole 40mg', N'Esomeprazole', N'Viên', '40mg', N'Uống', 12000, N'Quá mẫn với thuốc ức chế bơm proton (PPI)', N'Giảm hấp thu Ketoconazole, tăng nồng độ Diazepam'),
('TH04', N'Clarithromycin 500mg', N'Clarithromycin', N'Viên', '500mg', N'Uống', 8500, N'Quá mẫn Macrolid, dùng chung với Simvastatin liều cao', N'Tương tác nguy cơ loạn nhịp với Terfenadine'),
('TH05', N'Amlodipine 5mg', N'Amlodipine besylate', N'Viên', '5mg', N'Uống', 4500, N'Hạ huyết áp nặng, sốc tim', N'Tăng nồng độ Simvastatin khi dùng đồng thời'),
('TH06', N'Telmisartan 40mg', N'Telmisartan', N'Viên', '40mg', N'Uống', 7500, N'Phụ nữ mang thai 3 tháng giữa và cuối, suy gan nặng', N'Tăng kali huyết khi dùng chung thuốc lợi tiểu giữ kali');

-- 12. Toa thuốc điều trị
INSERT INTO ToaThuoc (MaToaThuoc, MaPhieuKham, MaBacSiKeToa, NgayKeToa, SoNgayDungThuoc, LoiDanBacSi, LuuYPhanUngPhu, TrangThai) VALUES
('TOA2026101501', 'PK20261015001', 'BS01', '2026-10-15 10:00:00', 5, N'Uống nhiều nước ấm, súc miệng nước muối ngày 3 lần. Uống thuốc đúng giờ sau ăn.', N'Bệnh nhân có tiền sử dị ứng Paracetamol nên đã thay thế bằng Ibuprofen (uống sau ăn no). Nếu có dấu hiệu đau dạ dày thì ngưng dùng.', N'Đã kê toa'),
('TOA2026101601', 'PK20261016001', 'BS02', '2026-10-16 10:45:00', 14, N'Kiêng ăn chua cay, cà phê, rượu bia. Ăn đúng bữa, không thức khuya.', N'BỆNH NHÂN DỊ ỨNG PENICILLIN: Tuyệt đối không dùng Amoxicillin. Đã sử dụng phác đồ thay thế Clarithromycin + Esomeprazole.', N'Đã kê toa'),
('TOA2026101701', 'PK20261017001', 'BS03', '2026-10-17 10:30:00', 30, N'Uống thuốc đều đặn vào mỗi buổi sáng. Ăn nhạt (giảm muối), tập thể dục nhẹ nhàng 30 phút mỗi ngày.', N'Theo dõi huyết áp hằng ngày ghi vào sổ. Nếu huyết áp tâm thu > 180 hoặc < 90 cần tái khám ngay.', N'Đã kê toa');

-- 13. Chi tiết toa thuốc
-- Toa 1: Điều trị viêm họng cấp cho BN20260001 (Dị ứng Paracetamol)
INSERT INTO ChiTietToaThuoc (MaToaThuoc, MaThuoc, SoLuong, Sang, Trua, Chieu, Toi, CachDung, DonGiaLucKe) VALUES
('TOA2026101501', 'TH01', 10, 1.0, 0.0, 1.0, 0.0, N'Uống sau khi ăn no', 2500),
('TOA2026101501', 'TH02', 15, 1.0, 1.0, 1.0, 0.0, N'Uống sau ăn 30 phút', 3000);

-- Toa 2: Điều trị viêm dạ dày HP cho BN20260002 (Dị ứng Penicillin - dùng PPI + Macrolid)
INSERT INTO ChiTietToaThuoc (MaToaThuoc, MaThuoc, SoLuong, Sang, Trua, Chieu, Toi, CachDung, DonGiaLucKe) VALUES
('TOA2026101601', 'TH03', 28, 1.0, 0.0, 1.0, 0.0, N'Uống trước ăn sáng và ăn tối 30 phút', 12000),
('TOA2026101601', 'TH04', 28, 1.0, 0.0, 1.0, 0.0, N'Uống sau ăn no', 8500);

-- Toa 3: Điều trị tăng huyết áp vô căn cho BN20260003
INSERT INTO ChiTietToaThuoc (MaToaThuoc, MaThuoc, SoLuong, Sang, Trua, Chieu, Toi, CachDung, DonGiaLucKe) VALUES
('TOA2026101701', 'TH05', 30, 1.0, 0.0, 0.0, 0.0, N'Uống cố định vào buổi sáng lúc 8h', 4500),
('TOA2026101701', 'TH06', 30, 1.0, 0.0, 0.0, 0.0, N'Uống cùng lúc với Amlodipine buổi sáng', 7500);

-- 14. Lịch hẹn khám định kỳ
INSERT INTO LichHenTaiKham (MaLichHen, MaHoSo, MaBacSiHen, NgayHenKham, GioHenKham, NoiDungKham, DanDoChuanBi, TrangThaiHen) VALUES
('HEN202610_01', 'HS20260001', 'BS01', '2026-10-22', '08:30:00', N'Tái khám kiểm tra họng và xét nghiệm lại bạch cầu nếu còn sốt', N'Mang theo toa thuốc cũ và phiếu xét nghiệm đợt trước', N'Chưa đến hẹn'),
('HEN202610_02', 'HS20260002', 'BS02', '2026-11-02', '09:00:00', N'Tái khám sau 2 tuần dùng phác đồ diệt HP', N'Nhịn ăn sáng nếu cần làm lại test hơi thở HP', N'Chưa đến hẹn'),
('HEN202610_03', 'HS20260003', 'BS03', '2026-11-17', '08:00:00', N'Khám định kỳ huyết áp hằng tháng và kiểm tra men gan, mỡ máu', N'Nhịn ăn sáng từ 22h đêm hôm trước để xét nghiệm máu', N'Chưa đến hẹn');

-- 15. Hoàn tất đợt điều trị (Xuất viện / Kết thúc đợt khám)
INSERT INTO HoanTatDieuTri (MaHoanTat, MaDotDieuTri, NgayHoanTat, MaBacSiXacNhan, KetQuaDieuTri, TinhTrangXuatVien, DanDoSauXuatVien, TongTienVienPhi, BHYTChiTra, BenhNhanThanhToan) VALUES
('HT2026101501', 'DOT202610_01', '2026-10-15 11:30:00', 'BS01', N'Thuyên giảm', N'Hết sốt cao, họng giảm sưng đỏ, sinh hiệu ổn định (HA 120/80, Mạch 80)', N'Uống hết 5 ngày thuốc theo toa, súc miệng nước muối, tái khám đúng hẹn nếu tái sốt', 255000, 180000, 75000);
GO