USE MobileShop;

-- Tạo bảng Sản phẩm
CREATE TABLE SanPham (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tenSP NVARCHAR(100) NOT NULL,
    gia DECIMAL(18,2) NOT NULL,
    hangSX NVARCHAR(50) NOT NULL
);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tenKH NVARCHAR(100) NOT NULL,
    diachi NVARCHAR(200),
    sdt NVARCHAR(15)
);

-- Tạo bảng Đơn hàng
CREATE TABLE DonHang (
    id INT IDENTITY(1,1) PRIMARY KEY,
    khachhangid INT NOT NULL FOREIGN KEY REFERENCES KhachHang(id),
    sanphamid INT NOT NULL FOREIGN KEY REFERENCES SanPham(id),
    soluong INT NOT NULL,
    ngaymua DATE NOT NULL
);

-- Tạo bảng Người dùng
CREATE TABLE NguoiDung (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tendangnhap NVARCHAR(50) NOT NULL UNIQUE,
    matkhau NVARCHAR(50) NOT NULL
);
-- Thêm dữ liệu vào bảng Sản phẩm
INSERT INTO SanPham (tenSP, gia, hangSX)
VALUES 
    ('iPhone 14 Pro Max', 35000000, 'Apple'),
    ('Samsung Galaxy S23 Ultra', 29000000, 'Samsung'),
    ('Xiaomi 13 Pro', 22000000, 'Xiaomi');

-- Thêm dữ liệu vào bảng Khách hàng
INSERT INTO KhachHang (tenKH, diachi, sdt)
VALUES 
    ('Nguyen Van A', '123 Ly Thuong Kiet, Ha Noi', '0912345678'),
    ('Tran Thi B', '456 Nguyen Trai, TP HCM', '0987654321');

-- Thêm dữ liệu vào bảng Đơn hàng
INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua)
VALUES 
    (1, 1, 1, '2024-11-01'),
    (2, 2, 2, '2024-11-15');

-- Thêm dữ liệu vào bảng Người dùng
INSERT INTO NguoiDung (tendangnhap, matkhau)
VALUES 
    ('admin', 'admin123'),
    ('user1', 'password');
