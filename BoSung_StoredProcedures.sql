-- =============================================
-- CÁC STORED PROCEDURES BỔ SUNG CHO HỆ THỐNG QUẢN LÝ TÀU
-- (Tuỳ chọn: Chạy file này trên database QuanLyTau nếu muốn sử dụng SPs)
-- Ghi chú: Ứng dụng C# đã có sẵn Fallback tự động truy vấn trực tiếp 
-- nên hệ thống hoạt động hoàn hảo ngay cả khi chưa chạy file này.
-- =============================================

USE QuanLyTau;
GO

-- 1. STORED PROCEDURE ĐĂNG NHẬP
IF OBJECT_ID('sp_DangNhap', 'P') IS NOT NULL
    DROP PROCEDURE sp_DangNhap;
GO
CREATE PROCEDURE sp_DangNhap
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaNV, HoTen, TenDangNhap, VaiTro, SoDienThoai, TrangThai
    FROM NhanVien
    WHERE TenDangNhap = @TenDangNhap 
      AND MatKhau = @MatKhau 
      AND TrangThai LIKE N'%Ho%t d%ng%';
END
GO

-- 2. STORED PROCEDURE THỐNG KÊ DASHBOARD TRANG CHỦ
IF OBJECT_ID('sp_ThongKeTrangChu', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThongKeTrangChu;
GO
CREATE PROCEDURE sp_ThongKeTrangChu
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        (SELECT COUNT(*) FROM Tau WHERE TrangThai LIKE N'%S%n s%ng%') AS SoTauSanSang,
        (SELECT COUNT(*) FROM Tau) AS TongTau,
        (SELECT COUNT(*) FROM ChuyenTau WHERE CAST(NgayChay AS DATE) = CAST(GETDATE() AS DATE)) AS SoChuyenHomNay,
        (SELECT COUNT(*) FROM ChuyenTau WHERE CAST(NgayChay AS DATE) = CAST(GETDATE() AS DATE)) AS ChuyenHomNay,
        (SELECT COUNT(*) FROM Ve WHERE CAST(NgayMua AS DATE) = CAST(GETDATE() AS DATE) AND TrangThai LIKE N'%thanh to%n%') AS SoVeBanHomNay,
        (SELECT ISNULL(SUM(GiaVe), 0) FROM Ve WHERE CAST(NgayMua AS DATE) = CAST(GETDATE() AS DATE) AND TrangThai LIKE N'%thanh to%n%') AS DoanhThuHomNay;
END
GO

-- 3. STORED PROCEDURE SINH CHUYẾN TÀU TỪ LỊCH TRÌNH
IF OBJECT_ID('sp_SinhChuyen', 'P') IS NOT NULL
    DROP PROCEDURE sp_SinhChuyen;
GO
CREATE PROCEDURE sp_SinhChuyen
    @NgayChay DATE,
    @MaLichTrinh INT = NULL,
    @MaTau INT = NULL,
    @MaLaiTau INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @MaLichTrinh IS NOT NULL
    BEGIN
        DECLARE @GioKhoiHanh TIME, @GioKetThuc TIME, @TauChay INT;
        SELECT @GioKhoiHanh = GioKhoiHanh, @GioKetThuc = GioKetThuc, @TauChay = ISNULL(@MaTau, MaTau)
        FROM LichTrinh
        WHERE MaLichTrinh = @MaLichTrinh;

        IF @GioKhoiHanh IS NOT NULL
        BEGIN
            INSERT INTO ChuyenTau (MaLichTrinh, MaTau, MaLaiTau, NgayChay, GioKhoiHanh, GioDen, TrangThai)
            VALUES (@MaLichTrinh, @TauChay, @MaLaiTau, @NgayChay, @GioKhoiHanh, @GioKetThuc, N'Chờ chạy');
            
            SELECT SCOPE_IDENTITY() AS MaChuyenMoi;
        END
    END
END
GO

-- 4. STORED PROCEDURE BÁN VÉ TÀU (TỰ ĐỘNG XỬ LÝ HÀNH KHÁCH & VÉ AN TOÀN)
IF OBJECT_ID('sp_BanVe', 'P') IS NOT NULL
    DROP PROCEDURE sp_BanVe;
GO
CREATE PROCEDURE sp_BanVe
    @MaChuyen INT,
    @CCCD VARCHAR(20),
    @HoTen NVARCHAR(100),
    @SoDienThoai VARCHAR(15),
    @MaGaDi INT,
    @MaGaDen INT,
    @LoaiVe NVARCHAR(20) = N'Thường',
    @GiaVe DECIMAL(18,0)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @MaHK INT;
        SELECT @MaHK = MaHK FROM HanhKhach WHERE CCCD = @CCCD;

        IF @MaHK IS NULL
        BEGIN
            INSERT INTO HanhKhach (CCCD, HoTen, SoDienThoai) 
            VALUES (@CCCD, @HoTen, @SoDienThoai);
            SET @MaHK = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
            UPDATE HanhKhach 
            SET HoTen = @HoTen, SoDienThoai = @SoDienThoai 
            WHERE MaHK = @MaHK;
        END

        INSERT INTO Ve (MaChuyen, MaHK, MaGaDi, MaGaDen, LoaiVe, GiaVe, NgayMua, TrangThai)
        VALUES (@MaChuyen, @MaHK, @MaGaDi, @MaGaDen, @LoaiVe, @GiaVe, GETDATE(), N'Đã thanh toán');

        DECLARE @MaVeMoi INT = SCOPE_IDENTITY();
        COMMIT TRANSACTION;

        SELECT @MaVeMoi AS MaVeMoi;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- 5. STORED PROCEDURE HỦY VÉ TÀU
IF OBJECT_ID('sp_HuyVe', 'P') IS NOT NULL
    DROP PROCEDURE sp_HuyVe;
GO
CREATE PROCEDURE sp_HuyVe
    @MaVe INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Ve
    SET TrangThai = N'Đã hủy'
    WHERE MaVe = @MaVe;
END
GO
