create database QUANLYTIEMCAPHE
go

use QUANLYTIEMCAPHE
go

CREATE TABLE Users (
    ID_User INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(15) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);
go

CREATE TABLE Khach (
    ID_Khach INT PRIMARY KEY,
    NgayThangNamSinh DATE,
    LoaiThanhVien NVARCHAR(50),
    TichDiem INT DEFAULT 0,
    FOREIGN KEY (ID_Khach) REFERENCES Users(ID_User)
);
go

CREATE TABLE Admin (
    ID_Admin INT PRIMARY KEY,
    FOREIGN KEY (ID_Admin) REFERENCES Users(ID_User)
);
go

CREATE TABLE SanPham (
    ID_SanPham INT PRIMARY KEY IDENTITY,
    Ten NVARCHAR(100) NOT NULL,
    Loai NVARCHAR(50),
    Gia DECIMAL(18, 2) NOT NULL,
    MoTa NVARCHAR(MAX),
    Image NVARCHAR(255)
);
go

CREATE TABLE Ban (
    ID_Ban INT PRIMARY KEY IDENTITY,
    SoBan INT NOT NULL,
    Status NVARCHAR(20),			--'Trống' hoặc 'Đã đặt'
    ChuaDuoc INT NOT NULL
);
go

CREATE TABLE DatBan (
    ID_DatBan INT PRIMARY KEY IDENTITY,
    ID_Khach INT NOT NULL,
    ID_Ban INT NOT NULL,
    ThoiGIanDatBan DATETIME NOT NULL,
    SoLuongKhach INT NOT NULL,
    Status NVARCHAR(20), -- 'Đã xác nhận', 'Đã hủy'
    FOREIGN KEY (ID_Khach) REFERENCES Khach(ID_Khach),
    FOREIGN KEY (ID_Ban) REFERENCES Ban(ID_Ban)
);
go

CREATE TABLE DonHang (
    ID_Don INT PRIMARY KEY IDENTITY,
    ID_Khach INT NOT NULL,
    ID_Admin INT NOT NULL,
    ThoiGianDat DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (ID_Khach) REFERENCES Khach(ID_Khach),
    FOREIGN KEY (ID_Admin) REFERENCES Admin(ID_Admin)
);
go

CREATE TABLE ChiTietDonHang (
    ID_ChiTietDonHang INT PRIMARY KEY IDENTITY,
    ID_Don INT NOT NULL,
    ID_SanPham INT NOT NULL,
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (ID_Don) REFERENCES DonHang(ID_Don),
    FOREIGN KEY (ID_SanPham) REFERENCES SanPham(ID_SanPham)
);
go

CREATE TABLE Bill (
    ID_Bill INT PRIMARY KEY IDENTITY,
    ID_Don INT NOT NULL,
    NgayXuatBill DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18, 2) NOT NULL,
    CachThanhToan NVARCHAR(50),							--'Tiền mặt', 'Thẻ', v.v.
    FOREIGN KEY (ID_Don) REFERENCES DonHang(ID_Don)
);
go

CREATE TABLE NhanXetSanPham (
    ID_DanhGia INT PRIMARY KEY IDENTITY,
    ID_SanPham INT NOT NULL,
    ID_Khach INT NOT NULL,
    NoiDung NVARCHAR(MAX),
    DanhGia INT NOT NULL CHECK (DanhGia BETWEEN 1 AND 5),
    NgayNhanXet DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (ID_SanPham) REFERENCES SanPham(ID_SanPham),
    FOREIGN KEY (ID_Khach) REFERENCES Khach(ID_Khach)
);
go

CREATE TABLE NguyenLieu (
    ID_NguyenLieu INT PRIMARY KEY IDENTITY,
    Ten NVARCHAR(100) NOT NULL,
    Unit NVARCHAR(20), -- Đơn vị tính
    SoLuongHangTonKho DECIMAL(18, 2) NOT NULL,
    DonGia DECIMAL(18, 2)
);
go

CREATE TABLE BenCungCap (
    ID_BenCungCap INT PRIMARY KEY IDENTITY,
    Ten NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    SDT NVARCHAR(15),
    Email NVARCHAR(100)
);
go

CREATE TABLE HangCungCap (
    ID_HangCungCap INT PRIMARY KEY IDENTITY,
    ID_BenCungCap INT NOT NULL,
    ID_NguyenLieu INT NOT NULL,
    NgayCungCap DATETIME NOT NULL DEFAULT GETDATE(),
    SoLuong DECIMAL(18, 2) NOT NULL,
    TongGIa DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (ID_BenCungCap) REFERENCES BenCungCap(ID_BenCungCap),
    FOREIGN KEY (ID_NguyenLieu) REFERENCES NguyenLieu(ID_NguyenLieu)
);


