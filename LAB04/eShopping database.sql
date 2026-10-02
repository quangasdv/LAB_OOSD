-- 1. Tạo Database
CREATE DATABASE eShoppingDB;
GO

USE eShoppingDB;
GO

-- 2. Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    SoCMND_Passport VARCHAR(20),
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(15),
    Email VARCHAR(100),
    NgayDangKy DATETIME DEFAULT GETDATE()
);
GO

-- 3. Bảng Đơn đặt hàng
CREATE TABLE DonHang (
    MaDonHang VARCHAR(20) PRIMARY KEY,       -- VD: DH001, DH002
    MaKhachHang INT NOT NULL,
    ThoiDiemDatHang DATETIME DEFAULT GETDATE(),
    
    -- Thông tin giao hàng
    LoaiPhieuDatHang NVARCHAR(50) NOT NULL,  -- Thường, CP Nhanh, CP Nhanh trong ngày
    HoTenNguoiNhan NVARCHAR(100) NOT NULL,
    DiaChiNhan NVARCHAR(255) NOT NULL,
    DienThoaiNhan VARCHAR(15) NOT NULL,
    
    -- Thông tin chi phí
    TongTriGia DECIMAL(18,2) NOT NULL,       -- Trị giá hàng hóa
    PhiGiaoHang DECIMAL(18,2) DEFAULT 0,     -- Phí giao hàng
    TongTienThanhToan DECIMAL(18,2) NOT NULL,-- Tổng cộng phải trả
    
    TrangThai NVARCHAR(50) DEFAULT N'Chờ xử lý',
    
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);
GO

-- 4. Bảng Chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    MaDonHang VARCHAR(20) NOT NULL,
    MaSanPham VARCHAR(50) NOT NULL,          -- Mã SP từ Hệ thống QLSP bên ngoài
    TenSanPham NVARCHAR(200) NOT NULL,       -- Lưu lại tên lúc đặt mua
    DonGia DECIMAL(18,2) NOT NULL,           -- Giá lúc mua
    SoLuong INT NOT NULL,
    ThanhTien DECIMAL(18,2) NOT NULL,
    
    PRIMARY KEY (MaDonHang, MaSanPham),
    CONSTRAINT FK_ChiTietDonHang_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang)
);
GO

-- 5. Bảng Thanh toán (Lưu lịch sử và thông tin thanh toán an toàn)
CREATE TABLE ThanhToan (
    MaThanhToan INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang VARCHAR(20) NOT NULL,
    
    LoaiThe VARCHAR(20) NOT NULL,            -- VISA, Master, Discover, American Express
    SoTheMasked VARCHAR(20) NOT NULL,        -- Chỉ lưu 4 số cuối, VD: **** **** **** 1234
    TenChuThe NVARCHAR(100) NOT NULL,
    LePhiGiaoDich DECIMAL(18,2) DEFAULT 0,
    
    NgayThanhToan DATETIME DEFAULT GETDATE(),
    KetQuaThanhToan NVARCHAR(50) DEFAULT N'Thành công',
    
    CONSTRAINT FK_ThanhToan_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang)
);
GO

-- ==========================================
-- 6. Dữ liệu mẫu (Mock Data)
-- ==========================================

-- Thêm dữ liệu Khách Hàng
INSERT INTO KhachHang (TenDangNhap, MatKhau, HoTen, NgaySinh, SoCMND_Passport, DiaChi, DienThoai, Email)
VALUES 
('nguyenvana', 'hashpassword1', N'Nguyễn Văn A', '1990-05-15', '0123456789', N'123 Lê Lợi, Quận 1, TP.HCM', '0901234567', 'nguyenvana@gmail.com'),
('lethib', 'hashpassword2', N'Lê Thị B', '1995-10-20', '0987654321', N'456 Trần Hưng Đạo, Quận 5, TP.HCM', '0912345678', 'lethib@yahoo.com'),
('tranc', 'hashpassword3', N'Trần Văn C', '1988-02-28', '1122334455', N'789 Nguyễn Hữu Thọ, Quận 7, TP.HCM', '0923456789', 'tran.c@outlook.com');
GO

-- Thêm dữ liệu Đơn Hàng (Lấy MaKhachHang = 1 và 2)
INSERT INTO DonHang (MaDonHang, MaKhachHang, LoaiPhieuDatHang, HoTenNguoiNhan, DiaChiNhan, DienThoaiNhan, TongTriGia, PhiGiaoHang, TongTienThanhToan, TrangThai)
VALUES 
('DH001', 1, N'Thường', N'Nguyễn Văn A', N'123 Lê Lợi, Quận 1, TP.HCM', '0901234567', 1500000, 30000, 1530000, N'Đã xác nhận'),
('DH002', 2, N'CP Nhanh', N'Lê Văn D', N'12 Nguyễn Văn Linh, Đà Nẵng', '0988776655', 5500000, 0, 5500000, N'Đang giao hàng'),
('DH003', 1, N'CP Nhanh trong ngày', N'Nguyễn Thị E', N'45 Lê Duẩn, Quận 1, TP.HCM', '0933445566', 800000, 50000, 850000, N'Chờ xử lý');
GO

-- Thêm dữ liệu Chi tiết đơn hàng
INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, TenSanPham, DonGia, SoLuong, ThanhTien)
VALUES 
('DH001', 'SP001', N'Cây thông Noel mini', 300000, 2, 600000),
('DH001', 'SP002', N'Hộp quà Giáng Sinh', 450000, 2, 900000),

('DH002', 'SP003', N'Máy ảnh kỹ thuật số Canon', 5500000, 1, 5500000),

('DH003', 'SP004', N'Bộ đồ chơi trẻ em Lego', 800000, 1, 800000);
GO

-- Thêm dữ liệu Thanh toán
INSERT INTO ThanhToan (MaDonHang, LoaiThe, SoTheMasked, TenChuThe, LePhiGiaoDich, KetQuaThanhToan)
VALUES 
('DH001', 'VISA', '**** 1234', N'NGUYEN VAN A', 15300, N'Thành công'),
('DH002', 'Master', '**** 5678', N'LE THI B', 55000, N'Thành công'),
('DH003', 'American Express', '**** 9012', N'NGUYEN VAN A', 8500, N'Chờ thanh toán');
GO
