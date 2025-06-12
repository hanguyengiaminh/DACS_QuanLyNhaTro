-- Tạo database
CREATE DATABASE QuanLyNhaTro;
GO

USE QuanLyNhaTro;
GO

-- Bảng KhuVuc (Khu vực)
CREATE TABLE KhuVuc (
    MaKhuVuc INT IDENTITY(1,1) PRIMARY KEY,
    TenKhuVuc NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(500),
    TrangThai BIT DEFAULT 1,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME
);

-- Bảng NguoiDung (Users)
CREATE TABLE NguoiDung (
    MaNguoiDung INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(100) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    SoDienThoai NVARCHAR(20),
    VaiTro NVARCHAR(20) NOT NULL, -- Admin/Chủ trọ/Nhân viên
    Avatar NVARCHAR(200) NULL,
    MatKhauCu NVARCHAR(100) NULL,
    NgayDoiMatKhau DATETIME NULL,
    SoLanDangNhapSai INT DEFAULT 0,
    NgayKhoa DATETIME NULL,
    LyDoKhoa NVARCHAR(500) NULL,
    TrangThai BIT DEFAULT 1,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME
);

-- Bảng PhongTro (Rooms)
CREATE TABLE PhongTro (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    MaKhuVuc INT NOT NULL,
    PhongSo NVARCHAR(10) NOT NULL,
    DienTich FLOAT NOT NULL,
    GiaThue DECIMAL(18,2) NOT NULL,
    SoLuongToiDa INT NOT NULL,
    SoLuongHienTai INT DEFAULT 0,
    TrangThai NVARCHAR(20) NOT NULL, -- Trống/Đã cho thuê/Đang sửa chữa
    GhiChu NVARCHAR(500),
    NguoiTao INT NOT NULL,
    NguoiCapNhat INT NULL,
    TongTienThue DECIMAL(18,2) DEFAULT 0,
    TongTienDichVu DECIMAL(18,2) DEFAULT 0,
    TongTienThu DECIMAL(18,2) DEFAULT 0,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME,
    FOREIGN KEY (MaKhuVuc) REFERENCES KhuVuc(MaKhuVuc),
    FOREIGN KEY (NguoiTao) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (NguoiCapNhat) REFERENCES NguoiDung(MaNguoiDung),
    CONSTRAINT UQ_PhongTro UNIQUE (MaKhuVuc, PhongSo),
   -- CONSTRAINT CHK_PhongTro_DienTich CHECK (DienTich > 0),
   -- CONSTRAINT CHK_PhongTro_GiaThue CHECK (GiaThue >= 0),
   -- CONSTRAINT CHK_PhongTro_SoLuongToiDa CHECK (SoLuongToiDa > 0),
   -- CONSTRAINT CHK_PhongTro_SoLuongHienTai CHECK (SoLuongHienTai >= 0),
    --CONSTRAINT CHK_PhongTro_TrangThai CHECK (TrangThai IN ('Trống', 'Đã cho thuê', 'Đang sửa chữa'))
);

-- Bảng NguoiThue (Tenants)
CREATE TABLE NguoiThue (
    MaNguoiThue INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    CCCD NVARCHAR(20) NOT NULL UNIQUE,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SoDienThoai NVARCHAR(20) UNIQUE,
    Email NVARCHAR(100),
    DiaChi NVARCHAR(200),
    NguoiTao INT NOT NULL,
    NguoiCapNhat INT NULL,
    TongTienDaThanhToan DECIMAL(18,2) DEFAULT 0,
    TongTienConNo DECIMAL(18,2) DEFAULT 0,
    TrangThai BIT DEFAULT 1,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME,
    FOREIGN KEY (NguoiTao) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (NguoiCapNhat) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng HopDongThue (RentalContracts)
CREATE TABLE HopDongThue (
    MaHopDong INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    MaNguoiThue INT NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    TienCoc DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL, -- Đang hiệu lực/Đã kết thúc/Hủy
    LyDoKetThuc NVARCHAR(500),
    NgayTao DATETIME DEFAULT GETDATE(),
    NguoiTao INT NOT NULL,
    NguoiCapNhat INT NULL,
    NgayCapNhat DATETIME,
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong),
    FOREIGN KEY (MaNguoiThue) REFERENCES NguoiThue(MaNguoiThue),
    FOREIGN KEY (NguoiTao) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (NguoiCapNhat) REFERENCES NguoiDung(MaNguoiDung),
    CONSTRAINT CHK_HopDongThue_NgayKetThuc CHECK (NgayKetThuc > NgayBatDau),
    CONSTRAINT CHK_HopDongThue_TienCoc CHECK (TienCoc >= 0),
    CONSTRAINT CHK_HopDongThue_TrangThai CHECK (TrangThai IN ('Đang hiệu lực', 'Đã kết thúc', 'Hủy'))
);

-- Bảng DichVu (Services)
CREATE TABLE DichVu (
    MaDichVu INT IDENTITY(1,1) PRIMARY KEY,
    TenDichVu NVARCHAR(100) NOT NULL UNIQUE,
    DonViTinh NVARCHAR(20) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    MoTa NVARCHAR(500),
    TrangThai BIT DEFAULT 1,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME,
    CONSTRAINT CHK_DichVu_DonGia CHECK (DonGia >= 0)
);

-- Bảng ChiTietDichVu (RoomServiceDetails)
CREATE TABLE ChiTietDichVu (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    MaDichVu INT NOT NULL,
    ChiSoDau FLOAT,
    ChiSoCuoi FLOAT,
    SoLuong FLOAT NOT NULL,
    ThanhTien DECIMAL(18,2) NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    TrangThaiThanhToan BIT DEFAULT 0,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME,
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu),
    CONSTRAINT CHK_ChiTietDichVu_SoLuong CHECK (SoLuong > 0),
    CONSTRAINT CHK_ChiTietDichVu_ThanhTien CHECK (ThanhTien >= 0),
    CONSTRAINT CHK_ChiTietDichVu_Thang CHECK (Thang BETWEEN 1 AND 12),
    CONSTRAINT CHK_ChiTietDichVu_Nam CHECK (Nam >= 2000)
);

-- Bảng HoaDon (Invoices)
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    MaNguoiThue INT NOT NULL,
    NgayLap DATE NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    TrangThaiThanhToan BIT DEFAULT 0,
    LoaiHoaDon NVARCHAR(20) NOT NULL DEFAULT 'Thường', -- Thường/Điện/Nước/Dịch vụ
    GhiChu NVARCHAR(500),
    NguoiLap INT NOT NULL,
    NguoiCapNhat INT NULL,
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME,
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong),
    FOREIGN KEY (MaNguoiThue) REFERENCES NguoiThue(MaNguoiThue),
    FOREIGN KEY (NguoiLap) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (NguoiCapNhat) REFERENCES NguoiDung(MaNguoiDung),
    CONSTRAINT CHK_HoaDon_TongTien CHECK (TongTien >= 0),
    CONSTRAINT CHK_HoaDon_Thang CHECK (Thang BETWEEN 1 AND 12),
    CONSTRAINT CHK_HoaDon_Nam CHECK (Nam >= 2000),
    CONSTRAINT CHK_HoaDon_LoaiHoaDon CHECK (LoaiHoaDon IN ('Thường', 'Điện', 'Nước', 'Dịch vụ'))
);

-- Bảng ChiTietHoaDon (InvoiceDetails)
CREATE TABLE ChiTietHoaDon (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT NOT NULL,
    MaDichVu INT NOT NULL,
    SoLuong FLOAT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    ThanhTien DECIMAL(18,2) NOT NULL,
    LoaiDichVu NVARCHAR(20) NOT NULL DEFAULT 'Thường', -- Thường/Điện/Nước/Dịch vụ
    NgayTao DATETIME DEFAULT GETDATE(),
    NgayCapNhat DATETIME,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu),
    CONSTRAINT CHK_ChiTietHoaDon_SoLuong CHECK (SoLuong > 0),
    CONSTRAINT CHK_ChiTietHoaDon_DonGia CHECK (DonGia >= 0),
    CONSTRAINT CHK_ChiTietHoaDon_ThanhTien CHECK (ThanhTien >= 0),
    CONSTRAINT CHK_ChiTietHoaDon_LoaiDichVu CHECK (LoaiDichVu IN ('Thường', 'Điện', 'Nước', 'Dịch vụ'))
);

-- Bảng LichSuThue (RentalHistory)
CREATE TABLE LichSuThue (
    MaLichSu INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    MaNguoiThue INT NOT NULL,
    MaHopDong INT NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    LyDoKetThuc NVARCHAR(500),
    NgayTao DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong),
    FOREIGN KEY (MaNguoiThue) REFERENCES NguoiThue(MaNguoiThue),
    FOREIGN KEY (MaHopDong) REFERENCES HopDongThue(MaHopDong)
);

-- Tạo bảng LogHoatDong
CREATE TABLE LogHoatDong (
    MaLog INT IDENTITY(1,1) PRIMARY KEY,
    MaNguoiDung INT NOT NULL,
    ThaoTac NVARCHAR(50) NOT NULL, -- Thêm/Sửa/Xóa/Truy vấn
    BangDuLieu NVARCHAR(50) NOT NULL, -- Tên bảng được thao tác
    MaBanGhi INT, -- ID của bản ghi được thao tác
    DuLieuCu NVARCHAR(MAX), -- Dữ liệu cũ (JSON)
    DuLieuMoi NVARCHAR(MAX), -- Dữ liệu mới (JSON)
    MoTa NVARCHAR(500), -- Mô tả chi tiết thao tác
    DiaChiIP NVARCHAR(50), -- IP của người dùng
    ThietBi NVARCHAR(200), -- Thông tin thiết bị
    NgayThucHien DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-------------------------------------------------------------------------------- Chưa tạo
-- Tạo các Index
CREATE INDEX IX_PhongTro_MaKhuVuc ON PhongTro(MaKhuVuc);
CREATE INDEX IX_PhongTro_TrangThai ON PhongTro(TrangThai);
CREATE INDEX IX_HopDongThue_MaPhong ON HopDongThue(MaPhong);
CREATE INDEX IX_HopDongThue_MaNguoiThue ON HopDongThue(MaNguoiThue);
CREATE INDEX IX_HopDongThue_TrangThai ON HopDongThue(TrangThai);
CREATE INDEX IX_HopDongThue_NgayBatDau ON HopDongThue(NgayBatDau);
CREATE INDEX IX_HopDongThue_NgayKetThuc ON HopDongThue(NgayKetThuc);
CREATE INDEX IX_HoaDon_MaPhong ON HoaDon(MaPhong);
CREATE INDEX IX_HoaDon_ThangNam ON HoaDon(Thang, Nam);
CREATE INDEX IX_HoaDon_NgayLap ON HoaDon(NgayLap);
CREATE INDEX IX_ChiTietDichVu_MaPhong ON ChiTietDichVu(MaPhong);
CREATE INDEX IX_ChiTietDichVu_ThangNam ON ChiTietDichVu(Thang, Nam);
CREATE INDEX IX_ChiTietHoaDon_MaHoaDon ON ChiTietHoaDon(MaHoaDon);
CREATE INDEX IX_ChiTietHoaDon_MaDichVu ON ChiTietHoaDon(MaDichVu);
CREATE INDEX IX_LichSuThue_NgayBatDau ON LichSuThue(NgayBatDau);
CREATE INDEX IX_LichSuThue_NgayKetThuc ON LichSuThue(NgayKetThuc);
CREATE INDEX IX_NguoiDung_TenDangNhap ON NguoiDung(TenDangNhap);
CREATE INDEX IX_NguoiDung_Email ON NguoiDung(Email);
CREATE INDEX IX_NguoiDung_SoDienThoai ON NguoiDung(SoDienThoai);
CREATE INDEX IX_NguoiThue_HoTen ON NguoiThue(HoTen);
CREATE INDEX IX_NguoiThue_SoDienThoai ON NguoiThue(SoDienThoai);
CREATE INDEX IX_DichVu_TenDichVu ON DichVu(TenDichVu);

-- Tạo index cho bảng LogHoatDong
CREATE INDEX IX_LogHoatDong_MaNguoiDung ON LogHoatDong(MaNguoiDung);
CREATE INDEX IX_LogHoatDong_NgayThucHien ON LogHoatDong(NgayThucHien);
CREATE INDEX IX_LogHoatDong_BangDuLieu ON LogHoatDong(BangDuLieu);


-- Stored Procedure cho quản lý người dùng
CREATE PROCEDURE sp_DangNhap
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT MaNguoiDung, TenDangNhap, HoTen, Email, SoDienThoai, VaiTro, Avatar
    FROM NguoiDung
    WHERE TenDangNhap = @TenDangNhap 
    AND MatKhau = @MatKhau
    AND TrangThai = 1;
END
GO

CREATE PROCEDURE sp_CapNhatMatKhau
    @MaNguoiDung INT,
    @MatKhauMoi NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE NguoiDung
    SET MatKhau = @MatKhauMoi,
        MatKhauCu = MatKhau,
        NgayDoiMatKhau = GETDATE(),
        NgayCapNhat = GETDATE()
    WHERE MaNguoiDung = @MaNguoiDung;
END
GO

-- Stored Procedure cho quản lý phòng trọ
CREATE PROCEDURE sp_ThemPhongTro
    @MaKhuVuc INT,
    @PhongSo NVARCHAR(10),
    @DienTich FLOAT,
    @GiaThue DECIMAL(18,2),
    @SoLuongToiDa INT,
    @GhiChu NVARCHAR(500),
    @NguoiTao INT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO PhongTro (MaKhuVuc, PhongSo, DienTich, GiaThue, SoLuongToiDa, 
                         TrangThai, GhiChu, NguoiTao)
    VALUES (@MaKhuVuc, @PhongSo, @DienTich, @GiaThue, @SoLuongToiDa, 
            'Trống', @GhiChu, @NguoiTao);
            
    SELECT SCOPE_IDENTITY() AS MaPhong;
END
GO

CREATE PROCEDURE sp_CapNhatPhongTro
    @MaPhong INT,
    @MaKhuVuc INT,
    @PhongSo NVARCHAR(10),
    @DienTich FLOAT,
    @GiaThue DECIMAL(18,2),
    @SoLuongToiDa INT,
    @TrangThai NVARCHAR(20),
    @GhiChu NVARCHAR(500),
    @NguoiCapNhat INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE PhongTro
    SET MaKhuVuc = @MaKhuVuc,
        PhongSo = @PhongSo,
        DienTich = @DienTich,
        GiaThue = @GiaThue,
        SoLuongToiDa = @SoLuongToiDa,
        TrangThai = @TrangThai,
        GhiChu = @GhiChu,
        NguoiCapNhat = @NguoiCapNhat,
        NgayCapNhat = GETDATE()
    WHERE MaPhong = @MaPhong;
END
GO

-- Stored Procedure cho quản lý hợp đồng
CREATE PROCEDURE sp_TaoHopDongThue
    @MaPhong INT,
    @MaNguoiThue INT,
    @NgayBatDau DATE,
    @NgayKetThuc DATE,
    @TienCoc DECIMAL(18,2),
    @NguoiTao INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Kiểm tra phòng có trống không
        IF EXISTS (SELECT 1 FROM PhongTro WHERE MaPhong = @MaPhong AND TrangThai != 'Trống')
            RAISERROR('Phòng đã được cho thuê', 16, 1);
            
        -- Tạo hợp đồng
        INSERT INTO HopDongThue (MaPhong, MaNguoiThue, NgayBatDau, NgayKetThuc, 
                                TienCoc, TrangThai, NguoiTao)
        VALUES (@MaPhong, @MaNguoiThue, @NgayBatDau, @NgayKetThuc, 
                @TienCoc, 'Đang hiệu lực', @NguoiTao);
                
        -- Cập nhật trạng thái phòng
        UPDATE PhongTro
        SET TrangThai = 'Đã cho thuê',
            SoLuongHienTai = 1,
            NguoiCapNhat = @NguoiTao,
            NgayCapNhat = GETDATE()
        WHERE MaPhong = @MaPhong;
        
        -- Thêm vào lịch sử
        INSERT INTO LichSuThue (MaPhong, MaNguoiThue, MaHopDong, NgayBatDau, NgayKetThuc)
        VALUES (@MaPhong, @MaNguoiThue, SCOPE_IDENTITY(), @NgayBatDau, @NgayKetThuc);
        
        COMMIT TRANSACTION;
        SELECT SCOPE_IDENTITY() AS MaHopDong;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Stored Procedure cho quản lý hóa đơn
CREATE PROCEDURE sp_TaoHoaDon
    @MaPhong INT,
    @MaNguoiThue INT,
    @Thang INT,
    @Nam INT,
    @NguoiLap INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Kiểm tra đã có hóa đơn chưa
        IF EXISTS (SELECT 1 FROM HoaDon 
                  WHERE MaPhong = @MaPhong AND Thang = @Thang AND Nam = @Nam)
            RAISERROR('Đã tồn tại hóa đơn cho tháng này', 16, 1);
            
        -- Tạo hóa đơn
        INSERT INTO HoaDon (MaPhong, MaNguoiThue, NgayLap, Thang, Nam, 
                           TongTien, TrangThaiThanhToan, NguoiLap)
        VALUES (@MaPhong, @MaNguoiThue, GETDATE(), @Thang, @Nam, 
                0, 0, @NguoiLap);
                
        SELECT SCOPE_IDENTITY() AS MaHoaDon;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE PROCEDURE sp_ThemChiTietHoaDon
    @MaHoaDon INT,
    @MaDichVu INT,
    @SoLuong FLOAT,
    @DonGia DECIMAL(18,2),
    @LoaiDichVu NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @ThanhTien DECIMAL(18,2) = @SoLuong * @DonGia;
        
        -- Thêm chi tiết hóa đơn
        INSERT INTO ChiTietHoaDon (MaHoaDon, MaDichVu, SoLuong, DonGia, 
                                  ThanhTien, LoaiDichVu)
        VALUES (@MaHoaDon, @MaDichVu, @SoLuong, @DonGia, @ThanhTien, @LoaiDichVu);
        
        -- Cập nhật tổng tiền hóa đơn
        UPDATE HoaDon
        SET TongTien = TongTien + @ThanhTien,
            NgayCapNhat = GETDATE()
        WHERE MaHoaDon = @MaHoaDon;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Stored Procedure cho báo cáo
CREATE PROCEDURE sp_BaoCaoDoanhThu
    @Thang INT,
    @Nam INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.MaPhong,
        p.PhongSo,
        k.TenKhuVuc,
        h.TongTien AS TienPhong,
        ISNULL(SUM(ct.SoLuong * ct.DonGia), 0) AS TienDichVu,
        h.TongTien + ISNULL(SUM(ct.SoLuong * ct.DonGia), 0) AS TongCong
    FROM HoaDon h
    INNER JOIN PhongTro p ON h.MaPhong = p.MaPhong
    INNER JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc
    LEFT JOIN ChiTietHoaDon ct ON h.MaHoaDon = ct.MaHoaDon
    WHERE h.Thang = @Thang AND h.Nam = @Nam
    GROUP BY p.MaPhong, p.PhongSo, k.TenKhuVuc, h.TongTien;
END
GO

CREATE PROCEDURE sp_BaoCaoPhongTrong
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.MaPhong,
        p.PhongSo,
        k.TenKhuVuc,
        p.DienTich,
        p.GiaThue,
        p.TrangThai,
        p.GhiChu
    FROM PhongTro p
    INNER JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc
    WHERE p.TrangThai = 'Trống';
END
GO

-- Stored Procedure cho tìm kiếm
CREATE PROCEDURE sp_TimKiemPhongTro
    @Keyword NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.MaPhong,
        p.PhongSo,
        k.TenKhuVuc,
        p.DienTich,
        p.GiaThue,
        p.SoLuongHienTai,
        p.TrangThai,
        p.GhiChu
    FROM PhongTro p
    INNER JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc
    WHERE p.PhongSo LIKE '%' + @Keyword + '%'
    OR k.TenKhuVuc LIKE '%' + @Keyword + '%'
    OR p.GhiChu LIKE '%' + @Keyword + '%';
END
GO

CREATE PROCEDURE sp_TimKiemNguoiThue
    @Keyword NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        nt.MaNguoiThue,
        nt.HoTen,
        nt.CCCD,
        nt.SoDienThoai,
        nt.Email,
        nt.DiaChi,
        p.PhongSo,
        k.TenKhuVuc,
        hd.TrangThai AS TrangThaiHopDong
    FROM NguoiThue nt
    LEFT JOIN HopDongThue hd ON nt.MaNguoiThue = hd.MaNguoiThue
    LEFT JOIN PhongTro p ON hd.MaPhong = p.MaPhong
    LEFT JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc
    WHERE nt.HoTen LIKE '%' + @Keyword + '%'
    OR nt.CCCD LIKE '%' + @Keyword + '%'
    OR nt.SoDienThoai LIKE '%' + @Keyword + '%'
    OR nt.Email LIKE '%' + @Keyword + '%';
END
GO

-- Stored Procedure ghi log
CREATE PROCEDURE sp_GhiLogHoatDong
    @MaNguoiDung INT,
    @ThaoTac NVARCHAR(50),
    @BangDuLieu NVARCHAR(50),
    @MaBanGhi INT = NULL,
    @DuLieuCu NVARCHAR(MAX) = NULL,
    @DuLieuMoi NVARCHAR(MAX) = NULL,
    @MoTa NVARCHAR(500) = NULL,
    @DiaChiIP NVARCHAR(50) = NULL,
    @ThietBi NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO LogHoatDong (
        MaNguoiDung,
        ThaoTac,
        BangDuLieu,
        MaBanGhi,
        DuLieuCu,
        DuLieuMoi,
        MoTa,
        DiaChiIP,
        ThietBi
    )
    VALUES (
        @MaNguoiDung,
        @ThaoTac,
        @BangDuLieu,
        @MaBanGhi,
        @DuLieuCu,
        @DuLieuMoi,
        @MoTa,
        @DiaChiIP,
        @ThietBi
    );
END
GO

-- Stored Procedure xem log theo thời gian
CREATE PROCEDURE sp_XemLogHoatDong
    @TuNgay DATETIME = NULL,
    @DenNgay DATETIME = NULL,
    @MaNguoiDung INT = NULL,
    @BangDuLieu NVARCHAR(50) = NULL,
    @ThaoTac NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        l.MaLog,
        l.MaNguoiDung,
        nd.HoTen AS TenNguoiDung,
        l.ThaoTac,
        l.BangDuLieu,
        l.MaBanGhi,
        l.DuLieuCu,
        l.DuLieuMoi,
        l.MoTa,
        l.DiaChiIP,
        l.ThietBi,
        l.NgayThucHien
    FROM LogHoatDong l
    INNER JOIN NguoiDung nd ON l.MaNguoiDung = nd.MaNguoiDung
    WHERE (@TuNgay IS NULL OR l.NgayThucHien >= @TuNgay)
    AND (@DenNgay IS NULL OR l.NgayThucHien <= @DenNgay)
    AND (@MaNguoiDung IS NULL OR l.MaNguoiDung = @MaNguoiDung)
    AND (@BangDuLieu IS NULL OR l.BangDuLieu = @BangDuLieu)
    AND (@ThaoTac IS NULL OR l.ThaoTac = @ThaoTac)
    ORDER BY l.NgayThucHien DESC;
END
GO

-- Stored Procedure xóa log cũ
CREATE PROCEDURE sp_XoaLogHoatDongCu
    @SoNgayLuu INT = 90 -- Mặc định lưu 90 ngày
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE FROM LogHoatDong
    WHERE NgayThucHien < DATEADD(DAY, -@SoNgayLuu, GETDATE());
END
GO

-- Trigger tự động ghi log khi thêm phòng trọ
CREATE TRIGGER tr_PhongTro_Insert
ON PhongTro
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @MaNguoiDung INT = (SELECT NguoiTao FROM inserted);
    DECLARE @MaPhong INT = (SELECT MaPhong FROM inserted);
    DECLARE @DuLieuMoi NVARCHAR(MAX) = (
        SELECT 
            MaPhong, MaKhuVuc, PhongSo, DienTich, GiaThue,
            SoLuongToiDa, SoLuongHienTai, TrangThai, GhiChu
        FROM inserted
        FOR JSON PATH
    );
    
    EXEC sp_GhiLogHoatDong
        @MaNguoiDung = @MaNguoiDung,
        @ThaoTac = 'Thêm',
        @BangDuLieu = 'PhongTro',
        @MaBanGhi = @MaPhong,
        @DuLieuMoi = @DuLieuMoi,
        @MoTa = 'Thêm phòng trọ mới';
END
GO

-- Trigger tự động ghi log khi cập nhật phòng trọ
CREATE TRIGGER tr_PhongTro_Update
ON PhongTro
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @MaNguoiDung INT = (SELECT NguoiCapNhat FROM inserted);
    DECLARE @MaPhong INT = (SELECT MaPhong FROM inserted);
    DECLARE @DuLieuCu NVARCHAR(MAX) = (
        SELECT 
            MaPhong, MaKhuVuc, PhongSo, DienTich, GiaThue,
            SoLuongToiDa, SoLuongHienTai, TrangThai, GhiChu
        FROM deleted
        FOR JSON PATH
    );
    DECLARE @DuLieuMoi NVARCHAR(MAX) = (
        SELECT 
            MaPhong, MaKhuVuc, PhongSo, DienTich, GiaThue,
            SoLuongToiDa, SoLuongHienTai, TrangThai, GhiChu
        FROM inserted
        FOR JSON PATH
    );
    
    EXEC sp_GhiLogHoatDong
        @MaNguoiDung = @MaNguoiDung,
        @ThaoTac = 'Sửa',
        @BangDuLieu = 'PhongTro',
        @MaBanGhi = @MaPhong,
        @DuLieuCu = @DuLieuCu,
        @DuLieuMoi = @DuLieuMoi,
        @MoTa = 'Cập nhật thông tin phòng trọ';
END
GO

-- Tương tự, tạo các trigger cho các bảng khác
-- Ví dụ: HopDongThue, HoaDon, NguoiThue, ...

-- Stored Procedure thống kê hoạt động
CREATE PROCEDURE sp_ThongKeHoatDong
    @TuNgay DATETIME = NULL,
    @DenNgay DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Thống kê theo loại thao tác
    SELECT 
        ThaoTac,
        COUNT(*) AS SoLuong
    FROM LogHoatDong
    WHERE (@TuNgay IS NULL OR NgayThucHien >= @TuNgay)
    AND (@DenNgay IS NULL OR NgayThucHien <= @DenNgay)
    GROUP BY ThaoTac;
    
    -- Thống kê theo bảng dữ liệu
    SELECT 
        BangDuLieu,
        COUNT(*) AS SoLuong
    FROM LogHoatDong
    WHERE (@TuNgay IS NULL OR NgayThucHien >= @TuNgay)
    AND (@DenNgay IS NULL OR NgayThucHien <= @DenNgay)
    GROUP BY BangDuLieu;
    
    -- Thống kê theo người dùng
    SELECT 
        nd.HoTen,
        COUNT(*) AS SoLuong
    FROM LogHoatDong l
    INNER JOIN NguoiDung nd ON l.MaNguoiDung = nd.MaNguoiDung
    WHERE (@TuNgay IS NULL OR l.NgayThucHien >= @TuNgay)
    AND (@DenNgay IS NULL OR l.NgayThucHien <= @DenNgay)
    GROUP BY nd.HoTen;
END
GO

------------- them du lieu------------------------
-- them khu vuc
INSERT INTO KhuVuc (TenKhuVuc, MoTa) VALUES
(N'A', N'Khu vực trung tâm'),
(N'B', N'Khu vực gần cổng sau'),
(N'C', N'Khu vực Phia Đông'),
(N'D', N'Khu vực Phía Nam');

-- them nguoi dung 
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Email, SoDienThoai, VaiTro)
VALUES
('admin01', '123456', N'Nguyễn Văn A', 'admin@example.com', '0901234567', 'Admin'),
('chutro01', '123456', N'Lê Thị B', 'chutro@example.com', '0902345678', 'Chủ trọ');


--them phong tro

INSERT INTO PhongTro (MaKhuVuc, PhongSo, DienTich, GiaThue, SoLuongToiDa, TrangThai, GhiChu, NguoiTao)  
VALUES  
(1, '101', 25, 2000000, 2, N'Trống', N'Phòng rộng rãi, thoáng mát', 1),  
(2, '201', 30, 2500000, 3, N'Đã cho thuê', N'Có ban công, view đẹp', 2),  
(3, '102', 25, 2000000, 2, N'Trống', N'Phòng rộng rãi', 1),  
(4, '103', 25, 2000000, 2, N'Đang sửa chữa', N'Đang bảo trì nội thất', 1);  

-- them	nguoi thue

INSERT INTO NguoiThue (HoTen, CCCD, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, NguoiTao)
VALUES
(N'Phạm Văn C', '123456789012', '2000-05-20', N'Nam', '0911122233', 'phamc@gmail.com', N'Quận 1, TP.HCM', 1),
(N'Trần Thị D', '987654321098', '1998-09-15', N'Nữ', '0911333444', 'trand@gmail.com', N'Quận 2, TP.HCM', 2);


-- them dich vu

INSERT INTO DichVu (TenDichVu, DonViTinh, DonGia, MoTa)
VALUES
(N'Điện', N'kWh', 3500, N'Tiền điện'),
(N'Nước', N'm3', 15000, N'Tiền nước'),
(N'Internet', N'tháng', 100000, N'Wi-Fi tốc độ cao');

-- tao hop dong thue

EXEC sp_TaoHopDongThue
    @MaPhong = 1,
    @MaNguoiThue = 1,
    @NgayBatDau = '2025-06-01',
    @NgayKetThuc = '2026-06-01',
    @TienCoc = 2000000,
    @NguoiTao = 1;

	SELECT * FROM PhongTro WHERE MaPhong = 1;

--tao hoa don thang 6
EXEC sp_TaoHoaDon
    @MaPhong = 1,
    @MaNguoiThue = 1,
    @Thang = 6,
    @Nam = 2025,
    @NguoiLap = 1;




------------- truy van ------------------------
SELECT * FROM KhuVuc;
