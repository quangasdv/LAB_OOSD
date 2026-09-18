CREATE DATABASE QuanLyThuVienDB;
GO
USE QuanLyThuVienDB;
GO

-- 1. Bảng THELOAI
CREATE TABLE THELOAI (
    MaTheLoai VARCHAR(20) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL
);

-- 2. Bảng NHAXUATBAN (Lưu ý: Không tự thêm TenNXB theo yêu cầu)
CREATE TABLE NHAXUATBAN (
    MaNhaXuatBan VARCHAR(20) PRIMARY KEY,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(20)
);

-- 3. Bảng NHANVIEN
CREATE TABLE NHANVIEN (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    Ho NVARCHAR(50) NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    Phai NVARCHAR(10),
    NgaySinh DATE,
    ChucVu NVARCHAR(50),
    SoDienThoai VARCHAR(20)
);

-- 4. Bảng DOCGIA
CREATE TABLE DOCGIA (
    MaDocGia VARCHAR(20) PRIMARY KEY,
    Ho NVARCHAR(50) NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    Phai NVARCHAR(10),
    SoDienThoai VARCHAR(20),
    DiaChi NVARCHAR(200),
    Email VARCHAR(100),
    Anh3x4 VARCHAR(255)
);

-- 5. Bảng DAUSACH
CREATE TABLE DAUSACH (
    MaDauSach VARCHAR(20) PRIMARY KEY,
    TenSach NVARCHAR(200) NOT NULL,
    NamXuatBan INT,
    SoLuongHienCo INT,
    MaTheLoai VARCHAR(20) NOT NULL,
    MaNhaXuatBan VARCHAR(20) NOT NULL,
    CONSTRAINT FK_DauSach_TheLoai FOREIGN KEY (MaTheLoai) REFERENCES THELOAI(MaTheLoai),
    CONSTRAINT FK_DauSach_NXB FOREIGN KEY (MaNhaXuatBan) REFERENCES NHAXUATBAN(MaNhaXuatBan),
    CONSTRAINT CHK_SoLuongHienCo CHECK (SoLuongHienCo >= 0)
);

-- 6. Bảng THEDOCGIA
CREATE TABLE THEDOCGIA (
    MaThe VARCHAR(20) PRIMARY KEY,
    MaDocGia VARCHAR(20) NOT NULL,
    NgayCap DATE NOT NULL,
    HanSuDung DATE NOT NULL,
    DaDongLePhi BIT,
    TrangThai BIT,
    CONSTRAINT FK_TheDocGia_DocGia FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia),
    CONSTRAINT CHK_HanSuDung CHECK (HanSuDung >= NgayCap)
);

-- Tạo Filtered Unique Index cho thẻ hoạt động
CREATE UNIQUE INDEX UIX_TheDocGia_TrangThai 
ON THEDOCGIA(MaDocGia) 
WHERE TrangThai = 1;

-- 7. Bảng PHIEUMUON
CREATE TABLE PHIEUMUON (
    MaPhieuMuon VARCHAR(20) PRIMARY KEY,
    MaDocGia VARCHAR(20) NOT NULL,
    MaNhanVien VARCHAR(20) NOT NULL,
    NgayMuon DATE NOT NULL,
    NgayHenTra DATE NOT NULL,
    CONSTRAINT FK_PhieuMuon_DocGia FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia),
    CONSTRAINT FK_PhieuMuon_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien),
    CONSTRAINT CHK_NgayHenTra CHECK (NgayHenTra >= NgayMuon)
);

-- 8. Bảng CHITIETPHIEUMUON
CREATE TABLE CHITIETPHIEUMUON (
    MaChiTiet VARCHAR(20) PRIMARY KEY,
    MaPhieuMuon VARCHAR(20) NOT NULL,
    MaDauSach VARCHAR(20) NOT NULL,
    NgayTraThucTe DATE,
    TinhTrangTra NVARCHAR(200),
    CONSTRAINT FK_CTPM_PhieuMuon FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEUMUON(MaPhieuMuon),
    CONSTRAINT FK_CTPM_DauSach FOREIGN KEY (MaDauSach) REFERENCES DAUSACH(MaDauSach),
    CONSTRAINT UQ_PhieuMuon_DauSach UNIQUE (MaPhieuMuon, MaDauSach)
);

-- 9. Bảng PHIEUPHAT
CREATE TABLE PHIEUPHAT (
    MaPhieuPhat VARCHAR(20) PRIMARY KEY,
    MaChiTiet VARCHAR(20) NOT NULL,
    MaNhanVien VARCHAR(20) NOT NULL,
    NgayPhat DATE NOT NULL,
    LyDo NVARCHAR(250),
    PhiPhat DECIMAL(18, 2),
    CONSTRAINT FK_PhieuPhat_ChiTiet FOREIGN KEY (MaChiTiet) REFERENCES CHITIETPHIEUMUON(MaChiTiet),
    CONSTRAINT FK_PhieuPhat_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
);
GO


--- TẠO DỮ LIỆU MẪU

USE QuanLyThuVienDB;
GO

-- 1. Thêm dữ liệu Nhân viên
INSERT INTO NHANVIEN (MaNhanVien, Ho, Ten, Phai, NgaySinh, ChucVu, SoDienThoai) VALUES
('NV001', N'Nguyễn', N'An', N'Nam', '1990-02-15', N'Thủ thư', '0901000001'),
('NV002', N'Trần', N'Bình', N'Nữ', '1992-08-20', N'Nhân viên quản lý sách', '0901000002');

-- 2. Thêm dữ liệu Thể loại
INSERT INTO THELOAI (MaTheLoai, TenTheLoai) VALUES
('TL001', N'Tin học'), 
('TL002', N'Tiểu thuyết'), 
('TL003', N'Anh văn'), 
('TL004', N'Truyện ngắn');

-- 3. Thêm dữ liệu Nhà xuất bản
INSERT INTO NHAXUATBAN (MaNhaXuatBan, DiaChi, SoDienThoai) VALUES
('NXB001', N'Quận 1, TP.HCM', '0283000001'),
('NXB002', N'Quận Cầu Giấy, Hà Nội', '0243000002');

-- 4. Thêm dữ liệu Đầu sách (Cần TheLoai và NhaXuatBan có trước)
INSERT INTO DAUSACH (MaDauSach, TenSach, NamXuatBan, SoLuongHienCo, MaTheLoai, MaNhaXuatBan) VALUES
('S001', N'Lập trình C# căn bản', 2025, 5, 'TL001', 'NXB001'),
('S002', N'Cơ sở dữ liệu', 2024, 4, 'TL001', 'NXB001'),
('S003', N'Mạng máy tính', 2023, 3, 'TL001', 'NXB002'),
('S004', N'Tiếng Anh chuyên ngành', 2024, 2, 'TL003', 'NXB002');

-- 5. Thêm dữ liệu Độc giả
INSERT INTO DOCGIA (MaDocGia, Ho, Ten, NgaySinh, Phai, SoDienThoai, DiaChi, Email, Anh3x4) VALUES
('DG001', N'Lê', N'Minh', '2003-05-12', N'Nam', '0911000001', N'TP.HCM', 'minh@example.com', NULL),
('DG002', N'Phạm', N'Lan', '2002-10-23', N'Nữ', '0911000002', N'TP.HCM', 'lan@example.com', NULL);

-- 6. Thêm dữ liệu Thẻ độc giả (Cần DocGia có trước)
INSERT INTO THEDOCGIA (MaThe, MaDocGia, NgayCap, HanSuDung, DaDongLePhi, TrangThai) VALUES
('THE_DG001_2026', 'DG001', '2026-01-01', '2026-12-31', 1, 1),
('THE_DG002_2026', 'DG002', '2026-01-01', '2026-12-31', 1, 1);
GO