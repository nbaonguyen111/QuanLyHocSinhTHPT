use DoAnQuanLyHocSinhTHPTs;
go
create proc themGV(@magiaovien int,@hoten nvarchar(100),@ngaysinh date,@gioitinh nvarchar(10),@diachi nvarchar(15),@dienthoai varchar(15),@email nvarchar(100),@mongiangday nvarchar(100),@hinhanh image)
as
insert into GVCN values(@magiaovien,@hoten,@ngaysinh,@gioitinh,@diachi,@dienthoai,@email,@mongiangday,@hinhanh)

--drop proc themGV
--drop proc sp_SuaGVCN
go
CREATE proc sp_SuaGVCN(
    @magiaovien INT,
    @hoten NVARCHAR(100),
    @ngaysinh DATE,
    @gioitinh NVARCHAR(10),
    @diachi NVARCHAR(200),
    @dienthoai NVARCHAR(20),
    @email NVARCHAR(100),
    @mongiangday NVARCHAR(100),
	@hinhanh image)
AS
BEGIN
    UPDATE GVCN
    SET HoTen = @HoTen,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        DienThoai = @DienThoai,
        Email = @Email,
        MonGiangDay = @mongiangday,
		HinhAnh = @hinhanh
    WHERE MaGiaoVien = @MaGiaoVien;
END;
go
CREATE proc sp_XoaGVCN
    @MaGiaoVien INT
AS
BEGIN
    DELETE FROM GVCN WHERE MaGiaoVien = @MaGiaoVien;
END;
go
CREATE proc sp_ThemMonHoc
    @MaMonHoc INT,
    @TenMonHoc NVARCHAR(100)
AS
BEGIN
    INSERT INTO MonHoc (MaMonHoc, TenMonHoc)
    VALUES (@MaMonHoc, @TenMonHoc);
END;
go
CREATE proc sp_SuaMonHoc
    @MaMonHoc INT,
    @TenMonHoc NVARCHAR(100)
AS
BEGIN
    UPDATE MonHoc
    SET TenMonHoc = @TenMonHoc
    WHERE MaMonHoc = @MaMonHoc;
END;
go
CREATE proc sp_XoaMonHoc
    @MaMonHoc INT
AS
BEGIN
    DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc;
END;
go
CREATE proc sp_ThemLop
    @MaLop INT,
    @TenLop NVARCHAR(50),
    @Khoi INT,
    @MaGiaoVien INT
AS
BEGIN
    INSERT INTO Lop (MaLop, TenLop, Khoi, MaGiaoVien)
    VALUES (@MaLop, @TenLop, @Khoi, @MaGiaoVien);
END;
go
CREATE proc sp_SuaLop
    @MaLop INT,
    @TenLop NVARCHAR(50),
    @Khoi INT,
    @MaGiaoVien INT
AS
BEGIN
    UPDATE Lop
    SET TenLop = @TenLop,
        Khoi = @Khoi,
        MaGiaoVien = @MaGiaoVien
    WHERE MaLop = @MaLop;
END;
go
CREATE proc sp_XoaLop
    @MaLop INT
AS
BEGIN
    DELETE FROM Lop WHERE MaLop = @MaLop
end;
go
--drop proc sp_ThemHocSinh

CREATE proc sp_ThemHocSinh
    @MaHocSinh INT,
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(200),
    @DienThoai NVARCHAR(20),
    @MaLop INT,
	@HinhAnh image
AS
BEGIN
    INSERT INTO HocSinh (MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaLop,HinhAnh)
    VALUES (@MaHocSinh, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @MaLop,@HinhAnh);
END;
go
--drop proc sp_SuaHocSinh
CREATE proc sp_SuaHocSinh
    @MaHocSinh INT,
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(200),
    @DienThoai NVARCHAR(20),
    @MaLop INT,
	@HinhAnh image
AS
BEGIN
    UPDATE HocSinh
    SET HoTen = @HoTen,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        DienThoai = @DienThoai,
        MaLop = @MaLop,
		HinhAnh = @HinhAnh
    WHERE MaHocSinh = @MaHocSinh;
END;
go
CREATE proc sp_XoaHocSinh
    @MaHocSinh INT
AS
BEGIN
    DELETE FROM HocSinh WHERE MaHocSinh = @MaHocSinh;
END;
go
drop proc sp_ThemDiem
CREATE proc sp_ThemDiem
    @MaHocSinh INT,
    @MaLop INT,
    @MaMonHoc INT,
    @HocKy NVARCHAR(50),
    @DiemMieng FLOAT,
    @Diem15Phut FLOAT,
    @Diem1Tiet FLOAT,
    @DiemHocKy FLOAT,
    @DiemTongKet FLOAT,
    @XepLoai NVARCHAR(50)
AS
BEGIN
    INSERT INTO Diem (MaHocSinh, MaLop, MaMonHoc, HocKy, DiemMieng, Diem15Phut, Diem1Tiet, DiemHocKy, DiemTongKet, XepLoai)
    VALUES (@MaHocSinh, @MaLop, @MaMonHoc, @HocKy, @DiemMieng, @Diem15Phut, @Diem1Tiet, @DiemHocKy, @DiemTongKet, @XepLoai);
END;


go

CREATE PROCEDURE sp_SuaDiem
    @MaHocSinh INT,
    @MaLop INT,
    @MaMonHoc INT,
    @HocKy NVARCHAR(50),
    @DiemMieng FLOAT,
    @Diem15Phut FLOAT,
    @Diem1Tiet FLOAT,
    @DiemHocKy FLOAT,
    @DiemTongKet FLOAT,
    @XepLoai NVARCHAR(50)
AS
BEGIN
    UPDATE Diem
    SET HocKy = @HocKy,
        DiemMieng = @DiemMieng,
        Diem15Phut = @Diem15Phut,
        Diem1Tiet = @Diem1Tiet,
        DiemHocKy = @DiemHocKy,
        DiemTongKet = @DiemTongKet,
        XepLoai = @XepLoai
    WHERE MaHocSinh = @MaHocSinh AND MaLop = @MaLop AND MaMonHoc = @MaMonHoc;
END;

go

CREATE proc sp_XoaDiem
    @MaHocSinh INT
AS
BEGIN
    DELETE FROM Diem WHERE MaHocSinh = @MaHocSinh;
END;
go
CREATE proc sp_ThemDiemDanh
    @MaDiemDanh INT,
    @MaHocSinh INT,
    @MaLop INT,
    @NgayDiemDanh DATE,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO DiemDanh (MaDiemDanh, MaHocSinh, MaLop, NgayDiemDanh, TrangThai)
    VALUES (@MaDiemDanh, @MaHocSinh, @MaLop, @NgayDiemDanh, @TrangThai);
END;
go
CREATE proc sp_SuaDiemDanh
    @MaDiemDanh INT,
    @MaHocSinh INT,
    @MaLop INT,
    @NgayDiemDanh DATE,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE DiemDanh
    SET MaHocSinh = @MaHocSinh,
        MaLop = @MaLop,
        NgayDiemDanh = @NgayDiemDanh,
        TrangThai = @TrangThai
    WHERE MaDiemDanh = @MaDiemDanh;
END;
go
CREATE proc sp_XoaDiemDanh
    @MaDiemDanh INT
AS
BEGIN
    DELETE FROM DiemDanh WHERE MaDiemDanh = @MaDiemDanh;
END;
go

create proc LayDanhSachGiaoVien
as
select * from GVCN
go

create proc LayDanhSachHocSinh
as
select * from HocSinh
go

create proc LayDanhSachLop
as
select * from Lop
go

create proc LayDanhSachDiem
as
select * from Diem
go

create proc LayDanhSachDiemDanh
as
select * from DiemDanh
go

create proc LayDanhSachMon
as
select * from MonHoc

--Drop table DiemDanh
go
create proc LayDanhSachHocSinhTheoLop(@MaLop int)
as
BEGIN
    SELECT MaHocSinh, HoTen
    FROM HocSinh
    WHERE MaLop = @MaLop;
END;

--exec LayDanhSachHocSinhTheoLop '302'
--drop proc LayDanhSachHocSinhTheoLop
select * from Diem
go
create proc SapXepDiem
as
SELECT * FROM Diem ORDER BY DiemTongKet DESC;
go

CREATE proc timkiemhocsinh
    @hoten NVARCHAR(100)
   
AS
BEGIN
    SELECT * 
    FROM HocSinh
    WHERE  HoTen LIKE '%' + @hoten + '%';
END;

go

CREATE proc timkiemhocsinhbangdiem
    @mahocsinh int
   
AS
BEGIN
    SELECT * 
    FROM Diem
    WHERE  MaHocSinh = @mahocsinh;
END;
--exec timkiemhocsinhbangdiem 2
--drop proc timkiemhocsinhbangdiem
--exec timkiemhocsinh N'Lê Thị'

--select * from HocSinh
select * from 

