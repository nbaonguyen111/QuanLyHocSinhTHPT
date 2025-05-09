create database qlbh;
go
use qlbh;


CREATE TABLE ThanhPho (
    ThanhPho NVARCHAR(50) PRIMARY KEY,  
    TenThanhPho NVARCHAR(100)           
);
GO


CREATE TABLE KhachHang (
    MaKH nvarchar(10) PRIMARY KEY,      
    TenCty NVARCHAR(100),               
    DiaChi NVARCHAR(100),               
    ThanhPho NVARCHAR(50),              
    DienThoai NVARCHAR(15),             
    FOREIGN KEY (ThanhPho) REFERENCES ThanhPho(ThanhPho)  
);
GO


CREATE TABLE NhanVien (
    MaNV nvarchar(10) PRIMARY KEY,     
    Ho NVARCHAR(50),                   
    Ten NVARCHAR(50),                   
    GioiTinh NVARCHAR(10),              
    NgayNV date,                        
    DiaChi NVARCHAR(100),              
    DienThoai NVARCHAR(15),             
    Hinh nvarchar(30)                         
);
GO


CREATE TABLE SanPham (
    MaSP nvarchar(10) PRIMARY KEY,      
    TenSP NVARCHAR(100),               
    DonViTinh NVARCHAR(50),             
    DonGia INT,                       
    Hinh NVARCHAR(30)                          
);
GO


CREATE TABLE HoaDon (
    MaHD nvarchar(10) PRIMARY KEY,      
    MaKH nvarchar(10),                  
    MaNV nvarchar(10),                  
    NgayLapHD date,                    
    NgayNhanHang date,                 
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),  
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)   
);
GO


CREATE TABLE ChiTietHoaDon (
    MaHD nvarchar(10),                  
    MaSP nvarchar(10),                  
    SoLuong INT,                        
    PRIMARY KEY (MaHD, MaSP),           
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),   
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)  
);
GO

SELECT * FROM SanPham;
SELECT * FROM HoaDon;
SELECT * FROM ChiTietHoaDon;
