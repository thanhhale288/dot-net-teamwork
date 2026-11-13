-- =============================================
-- CƠ SỞ DỮ LIỆU: QUẢN LÝ TÀU
-- Server: DESKTOP-JJ3UO1L
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyTau')
BEGIN
    ALTER DATABASE QuanLyTau SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyTau;
END
GO

CREATE DATABASE QuanLyTau;
GO

USE QuanLyTau;
GO

-- 1. BẢNG NHÂN VIÊN
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(50) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL, -- QuanLy, BanVe, KyThuat, LaiTau
    SoDienThoai VARCHAR(15),
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động'
);

-- 2. BẢNG TUYẾN TÀU
CREATE TABLE Tuyen (
    MaTuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenTuyen NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255),
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động'
);

-- 3. BẢNG GA TÀU
CREATE TABLE Ga (
    MaGa INT IDENTITY(1,1) PRIMARY KEY,
    TenGa NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động'
);

-- 4. BẢNG TUYẾN - GA (Thứ tự các ga dừng trên tuyến)
CREATE TABLE Tuyen_Ga (
    MaTuyen INT NOT NULL FOREIGN KEY REFERENCES Tuyen(MaTuyen),
    MaGa INT NOT NULL FOREIGN KEY REFERENCES Ga(MaGa),
    ThuTu INT NOT NULL,
    PhutDung INT DEFAULT 2,
    PRIMARY KEY (MaTuyen, MaGa)
);

-- 5. BẢNG TÀU
CREATE TABLE Tau (
    MaTau INT IDENTITY(1,1) PRIMARY KEY,
    TenTau NVARCHAR(50) NOT NULL,
    MaTuyen INT FOREIGN KEY REFERENCES Tuyen(MaTuyen),
    TrangThai NVARCHAR(20) DEFAULT N'Sẵn sàng' -- Sẵn sàng, Đang chạy, Bảo trì, Hỏng
);

-- 6. BẢNG TOA TÀU
CREATE TABLE ToaTau (
    MaToa INT IDENTITY(1,1) PRIMARY KEY,
    MaTau INT NOT NULL FOREIGN KEY REFERENCES Tau(MaTau),
    SoToa INT NOT NULL,
    LoaiToa NVARCHAR(20) DEFAULT N'Thường', -- Thường, Ưu tiên
    SucChua INT DEFAULT 50
);

-- 7. BẢNG LỊCH TRÌNH ĐỊNH KỲ
CREATE TABLE LichTrinh (
    MaLichTrinh INT IDENTITY(1,1) PRIMARY KEY,
    MaTuyen INT NOT NULL FOREIGN KEY REFERENCES Tuyen(MaTuyen),
    MaTau INT FOREIGN KEY REFERENCES Tau(MaTau),
    GioKhoiHanh TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    NgayTrongTuan NVARCHAR(50) DEFAULT N'T2,T3,T4,T5,T6,T7,CN'
);

-- 8. BẢNG CHUYẾN TÀU
CREATE TABLE ChuyenTau (
    MaChuyen INT IDENTITY(1,1) PRIMARY KEY,
    MaLichTrinh INT FOREIGN KEY REFERENCES LichTrinh(MaLichTrinh),
    MaTau INT NOT NULL FOREIGN KEY REFERENCES Tau(MaTau),
    MaLaiTau INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    NgayChay DATE NOT NULL,
    GioKhoiHanh TIME NOT NULL,
    GioDen TIME NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Chờ chạy' -- Chờ chạy, Đang chạy, Hoàn thành, Hủy
);

-- 9. BẢNG HÀNH KHÁCH
CREATE TABLE HanhKhach (
    MaHK INT IDENTITY(1,1) PRIMARY KEY,
    CCCD VARCHAR(20) NOT NULL UNIQUE,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15)
);

-- 10. BẢNG VÉ TÀU
CREATE TABLE Ve (
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaChuyen INT NOT NULL FOREIGN KEY REFERENCES ChuyenTau(MaChuyen),
    MaHK INT NOT NULL FOREIGN KEY REFERENCES HanhKhach(MaHK),
    MaGaDi INT NOT NULL FOREIGN KEY REFERENCES Ga(MaGa),
    MaGaDen INT NOT NULL FOREIGN KEY REFERENCES Ga(MaGa),
    LoaiVe NVARCHAR(20) DEFAULT N'Thường', -- Thường, Ưu tiên
    GiaVe DECIMAL(18,0) NOT NULL,
    NgayMua DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(20) DEFAULT N'Đã thanh toán' -- Đã thanh toán, Đã hủy
);

-- 11. BẢNG BẢO TRÌ
CREATE TABLE BaoTri (
    MaBaoTri INT IDENTITY(1,1) PRIMARY KEY,
    MaTau INT NOT NULL FOREIGN KEY REFERENCES Tau(MaTau),
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    NgayBatDau DATETIME NOT NULL,
    NgayHoanThanh DATETIME,
    ChiPhi DECIMAL(18,0) DEFAULT 0,
    NoiDung NVARCHAR(255),
    TrangThai NVARCHAR(20) DEFAULT N'Đang xử lý' -- Đang xử lý, Hoàn thành
);
GO

-- =============================================
-- NHẬP DỮ LIỆU MẪU ĐA DẠNG (10 - 15 BẢN GHI/BẢNG)
-- =============================================

-- 1. BẢNG NHÂN VIÊN (12 nhân viên đầy đủ các bộ phận)
INSERT INTO NhanVien (HoTen, TenDangNhap, MatKhau, VaiTro, SoDienThoai, TrangThai) VALUES
(N'Nguyễn Văn A', 'admin', '123456', N'QuanLy', '0901234567', N'Hoạt động'),
(N'Trần Thị B', 'banve', '123456', N'BanVe', '0912345678', N'Hoạt động'),
(N'Lê Văn C', 'kythuat', '123456', N'KyThuat', '0923456789', N'Hoạt động'),
(N'Phạm Văn D', 'laixe', '123456', N'LaiTau', '0934567890', N'Hoạt động'),
(N'Hoàng Minh Trí', 'quantri02', '123456', N'QuanLy', '0908889901', N'Hoạt động'),
(N'Nguyễn Thu Trang', 'banve02', '123456', N'BanVe', '0918776655', N'Hoạt động'),
(N'Đặng Thanh Mai', 'banve03', '123456', N'BanVe', '0919223344', N'Hoạt động'),
(N'Vũ Đức Thịnh', 'kythuat02', '123456', N'KyThuat', '0933445566', N'Hoạt động'),
(N'Bùi Quốc Anh', 'kythuat03', '123456', N'KyThuat', '0944556677', N'Hoạt động'),
(N'Đỗ Tuấn Hưng', 'laitau02', '123456', N'LaiTau', '0966112233', N'Hoạt động'),
(N'Ngô Đình Phúc', 'laitau03', '123456', N'LaiTau', '0977223344', N'Hoạt động'),
(N'Phan Thanh Sang', 'laitau04', '123456', N'LaiTau', '0988334455', N'Hoạt động');

-- 2. BẢNG TUYẾN TÀU (4 tuyến)
INSERT INTO Tuyen (TenTuyen, MoTa, TrangThai) VALUES
(N'Tuyến 01: Bến Thành - Suối Tiên', N'Tuyến đô thị trục Đông - Tây TP.HCM', N'Hoạt động'),
(N'Tuyến 02: Bến Thành - Tham Lương', N'Tuyến kết nối trung tâm với Tây Bắc TP.HCM', N'Hoạt động'),
(N'Tuyến 03: Cát Linh - Hà Đông', N'Tuyến đường sắt đô thị trên cao Hà Nội', N'Hoạt động'),
(N'Tuyến 04: Nhổn - Ga Hà Nội', N'Tuyến metro kết nối Nhổn và trung tâm Thủ đô', N'Hoạt động');

-- 3. BẢNG GA TÀU (14 ga)
INSERT INTO Ga (TenGa, DiaChi, TrangThai) VALUES
(N'Ga Bến Thành', N'Quận 1, TP.HCM', N'Hoạt động'),
(N'Ga Nhà hát Thành phố', N'Quận 1, TP.HCM', N'Hoạt động'),
(N'Ga Ba Son', N'Quận 1, TP.HCM', N'Hoạt động'),
(N'Ga Văn Thánh', N'Bình Thạnh, TP.HCM', N'Hoạt động'),
(N'Ga Tân Cảng', N'Bình Thạnh, TP.HCM', N'Hoạt động'),
(N'Ga Thảo Điền', N'TP. Thủ Đức, TP.HCM', N'Hoạt động'),
(N'Ga Suối Tiên', N'TP. Thủ Đức, TP.HCM', N'Hoạt động'),
(N'Ga Dân Chủ', N'Quận 3, TP.HCM', N'Hoạt động'),
(N'Ga Hòa Hưng', N'Quận 10, TP.HCM', N'Hoạt động'),
(N'Ga Bảy Hiền', N'Tân Bình, TP.HCM', N'Hoạt động'),
(N'Ga Tham Lương', N'Quận 12, TP.HCM', N'Hoạt động'),
(N'Ga Cát Linh', N'Đống Đa, Hà Nội', N'Hoạt động'),
(N'Ga Thượng Đình', N'Thanh Xuân, Hà Nội', N'Hoạt động'),
(N'Ga Yên Nghĩa', N'Hà Đông, Hà Nội', N'Hoạt động');

-- 4. BẢNG TUYẾN - GA (Chi tiết thứ tự 15 trạm trên các tuyến)
INSERT INTO Tuyen_Ga (MaTuyen, MaGa, ThuTu, PhutDung) VALUES
-- Tuyến 1: 7 ga
(1, 1, 1, 3),
(1, 2, 2, 2),
(1, 3, 3, 2),
(1, 4, 4, 2),
(1, 5, 5, 2),
(1, 6, 6, 2),
(1, 7, 7, 3),
-- Tuyến 2: 5 ga
(2, 1, 1, 3),
(2, 8, 2, 2),
(2, 9, 3, 2),
(2, 10, 4, 2),
(2, 11, 5, 3),
-- Tuyến 3: 3 ga
(3, 12, 1, 3),
(3, 13, 2, 2),
(3, 14, 3, 3);

-- 5. BẢNG TÀU (12 đoàn tàu)
INSERT INTO Tau (TenTau, MaTuyen, TrangThai) VALUES
(N'Đoàn tàu 01', 1, N'Sẵn sàng'),
(N'Đoàn tàu 02', 1, N'Đang chạy'),
(N'Đoàn tàu 03', 1, N'Sẵn sàng'),
(N'Đoàn tàu 04', 1, N'Bảo trì'),
(N'Đoàn tàu 05', 2, N'Sẵn sàng'),
(N'Đoàn tàu 06', 2, N'Đang chạy'),
(N'Đoàn tàu 07', 2, N'Sẵn sàng'),
(N'Đoàn tàu 08', 2, N'Hỏng'),
(N'Đoàn tàu 09', 3, N'Sẵn sàng'),
(N'Đoàn tàu 10', 3, N'Đang chạy'),
(N'Đoàn tàu 11', 3, N'Sẵn sàng'),
(N'Đoàn tàu 12', 4, N'Bảo trì');

-- 6. BẢNG TOA TÀU (15 toa)
INSERT INTO ToaTau (MaTau, SoToa, LoaiToa, SucChua) VALUES
(1, 1, N'Ưu tiên', 40),
(1, 2, N'Thường', 60),
(1, 3, N'Thường', 60),
(2, 1, N'Ưu tiên', 40),
(2, 2, N'Thường', 60),
(2, 3, N'Thường', 60),
(3, 1, N'Ưu tiên', 40),
(3, 2, N'Thường', 60),
(5, 1, N'Ưu tiên', 40),
(5, 2, N'Thường', 60),
(6, 1, N'Ưu tiên', 40),
(6, 2, N'Thường', 60),
(9, 1, N'Ưu tiên', 40),
(9, 2, N'Thường', 60),
(10, 1, N'Thường', 60);

-- 7. BẢNG LỊCH TRÌNH ĐỊNH KỲ (10 lịch trình)
INSERT INTO LichTrinh (MaTuyen, MaTau, GioKhoiHanh, GioKetThuc, NgayTrongTuan) VALUES
(1, 1, '06:00:00', '06:45:00', N'T2,T3,T4,T5,T6,T7,CN'),
(1, 2, '07:00:00', '07:45:00', N'T2,T3,T4,T5,T6,T7,CN'),
(1, 3, '08:00:00', '08:45:00', N'T2,T3,T4,T5,T6,T7,CN'),
(1, 1, '09:00:00', '09:45:00', N'T2,T3,T4,T5,T6,T7,CN'),
(2, 5, '06:30:00', '07:15:00', N'T2,T3,T4,T5,T6,T7,CN'),
(2, 6, '07:45:00', '08:30:00', N'T2,T3,T4,T5,T6,T7,CN'),
(2, 7, '09:00:00', '09:45:00', N'T2,T3,T4,T5,T6,T7,CN'),
(3, 9, '06:15:00', '06:55:00', N'T2,T3,T4,T5,T6,T7,CN'),
(3, 10, '07:30:00', '08:10:00', N'T2,T3,T4,T5,T6,T7,CN'),
(3, 11, '08:45:00', '09:25:00', N'T2,T3,T4,T5,T6,T7,CN');

-- 8. BẢNG CHUYẾN TÀU (12 chuyến)
INSERT INTO ChuyenTau (MaLichTrinh, MaTau, MaLaiTau, NgayChay, GioKhoiHanh, GioDen, TrangThai) VALUES
(1, 1, 4, CAST(GETDATE() AS DATE), '06:00:00', '06:45:00', N'Hoàn thành'),
(2, 2, 10, CAST(GETDATE() AS DATE), '07:00:00', '07:45:00', N'Đang chạy'),
(3, 3, 11, CAST(GETDATE() AS DATE), '08:00:00', '08:45:00', N'Chờ chạy'),
(4, 1, 12, CAST(GETDATE() AS DATE), '09:00:00', '09:45:00', N'Chờ chạy'),
(5, 5, 4, CAST(GETDATE() AS DATE), '06:30:00', '07:15:00', N'Hoàn thành'),
(6, 6, 10, CAST(GETDATE() AS DATE), '07:45:00', '08:30:00', N'Đang chạy'),
(7, 7, 11, CAST(GETDATE() AS DATE), '09:00:00', '09:45:00', N'Chờ chạy'),
(8, 9, 12, CAST(GETDATE() AS DATE), '06:15:00', '06:55:00', N'Hoàn thành'),
(9, 10, 4, CAST(GETDATE() AS DATE), '07:30:00', '08:10:00', N'Đang chạy'),
(10, 11, 10, CAST(GETDATE() AS DATE), '08:45:00', '09:25:00', N'Chờ chạy'),
(1, 1, 11, DATEADD(DAY, 1, CAST(GETDATE() AS DATE)), '06:00:00', '06:45:00', N'Chờ chạy'),
(2, 2, 12, DATEADD(DAY, 1, CAST(GETDATE() AS DATE)), '07:00:00', '07:45:00', N'Hủy');

-- 9. BẢNG HÀNH KHÁCH (14 hành khách)
INSERT INTO HanhKhach (CCCD, HoTen, SoDienThoai) VALUES
('079201001111', N'Hoàng Minh Tuấn', '0988112233'),
('079201002222', N'Đỗ Mai Phương', '0977223344'),
('079201003333', N'Trần Đình Long', '0966334455'),
('079201004444', N'Lê Ngọc Anh', '0955443322'),
('079201005555', N'Võ Quốc Bảo', '0944556677'),
('079201006666', N'Phạm Thùy Linh', '0933667788'),
('079201007777', N'Dương Gia Huy', '0922778899'),
('079201008888', N'Ngô Bảo Châu', '0911889900'),
('079201009999', N'Đinh Tiến Dũng', '0900991122'),
('001202001111', N'Trịnh Thảo Ly', '0899112233'),
('001202002222', N'Mai Văn Quân', '0888223344'),
('001202003333', N'Lương Thị Hà', '0877334455'),
('001202004444', N'Cao Văn Sơn', '0866445566'),
('001202005555', N'Tạ Hồng Nhung', '0855556677');

-- 10. BẢNG VÉ TÀU (15 vé đa dạng trạng thái, chuyến, ga)
INSERT INTO Ve (MaChuyen, MaHK, MaGaDi, MaGaDen, LoaiVe, GiaVe, NgayMua, TrangThai) VALUES
(1, 1, 1, 7, N'Thường', 20000, DATEADD(MINUTE, -120, GETDATE()), N'Đã thanh toán'),
(1, 2, 1, 4, N'Ưu tiên', 15000, DATEADD(MINUTE, -110, GETDATE()), N'Đã thanh toán'),
(1, 3, 2, 6, N'Thường', 16000, DATEADD(MINUTE, -100, GETDATE()), N'Đã thanh toán'),
(2, 4, 1, 5, N'Thường', 18000, DATEADD(MINUTE, -60, GETDATE()), N'Đã thanh toán'),
(2, 5, 3, 7, N'Ưu tiên', 15000, DATEADD(MINUTE, -55, GETDATE()), N'Đã thanh toán'),
(2, 6, 1, 3, N'Thường', 12000, DATEADD(MINUTE, -50, GETDATE()), N'Đã hủy'),
(5, 7, 1, 11, N'Thường', 25000, DATEADD(MINUTE, -90, GETDATE()), N'Đã thanh toán'),
(5, 8, 8, 10, N'Ưu tiên', 15000, DATEADD(MINUTE, -80, GETDATE()), N'Đã thanh toán'),
(6, 9, 1, 9, N'Thường', 18000, DATEADD(MINUTE, -40, GETDATE()), N'Đã thanh toán'),
(6, 10, 8, 11, N'Thường', 20000, DATEADD(MINUTE, -35, GETDATE()), N'Đã thanh toán'),
(8, 11, 12, 14, N'Thường', 15000, DATEADD(MINUTE, -150, GETDATE()), N'Đã thanh toán'),
(8, 12, 12, 13, N'Ưu tiên', 10000, DATEADD(MINUTE, -140, GETDATE()), N'Đã thanh toán'),
(9, 13, 13, 14, N'Thường', 10000, DATEADD(MINUTE, -30, GETDATE()), N'Đã thanh toán'),
(9, 14, 12, 14, N'Thường', 15000, DATEADD(MINUTE, -20, GETDATE()), N'Đã thanh toán'),
(3, 1, 1, 7, N'Thường', 20000, GETDATE(), N'Đã thanh toán');

-- 11. BẢNG BẢO TRÌ (10 lệnh bảo trì)
INSERT INTO BaoTri (MaTau, MaNV, NgayBatDau, NgayHoanThanh, ChiPhi, NoiDung, TrangThai) VALUES
(4, 3, '2026-10-25 08:00:00', NULL, 6500000, N'Kiểm tra định kỳ hệ thống phanh khí nén', N'Đang xử lý'),
(8, 8, '2026-10-26 09:30:00', NULL, 12000000, N'Thay thế bộ chuyển mạch điều tốc', N'Đang xử lý'),
(12, 9, '2026-10-27 14:00:00', NULL, 4500000, N'Bảo dưỡng và vệ sinh hệ thống điều hòa', N'Đang xử lý'),
(1, 3, '2026-10-10 07:30:00', '2026-10-10 17:00:00', 3000000, N'Kiểm tra áp suất bánh xe và khớp nối toa', N'Hoàn thành'),
(2, 8, '2026-10-12 08:00:00', '2026-10-12 16:30:00', 2500000, N'Cân chỉnh radar và cảm biến an toàn cửa toa', N'Hoàn thành'),
(3, 9, '2026-10-15 08:30:00', '2026-10-16 11:00:00', 5200000, N'Thay chổi than động cơ kéo', N'Hoàn thành'),
(5, 3, '2026-10-18 09:00:00', '2026-10-18 15:00:00', 1800000, N'Bảo dưỡng hệ thống đèn cảnh báo tín hiệu', N'Hoàn thành'),
(6, 8, '2026-10-20 07:00:00', '2026-10-20 18:00:00', 4000000, N'Kiểm tra dầu bôi trơn trục truyền động', N'Hoàn thành'),
(9, 9, '2026-10-22 08:00:00', '2026-10-22 17:30:00', 3500000, N'Kiểm tra định kỳ bình điện ắc quy dự phòng', N'Hoàn thành'),
(10, 3, '2026-10-24 08:30:00', '2026-10-24 16:00:00', 2200000, N'Vệ sinh và kiểm tra hệ thống thông gió toa lái', N'Hoàn thành');
GO
