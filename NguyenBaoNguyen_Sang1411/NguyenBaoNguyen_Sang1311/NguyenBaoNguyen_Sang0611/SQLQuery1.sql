

use QLSV
go
-- tao sp themsv
SET DATEFORMAT DMY;
go
create proc sp_themsv (@masv char(6),@hosv nvarchar(30),@tensv nvarchar(30),@gioitinh char(3),@ngaysinh date,@noisinh nvarchar(50),@diachi nvarchar(30),@quan nvarchar(10),@makhoa char(6),@hocbong int)
as
insert into SINHVIEN
values (@masv,@hosv,@tensv,@gioitinh,@ngaysinh,@noisinh,@diachi,@quan,@makhoa,@hocbong)

--exec sp_themsv 'A07',N'Nguyễn',N'Bảo Nguyên','Nam','20/12/1997',N'Bình Thuận',N'34 Vũ Tùng Phường 2',N'Bình Thạnh','TH','10000000'


-- tao sp suasv
go
create proc sp_suasv (@masv char(6),@hosv nvarchar(30),@tensv nvarchar(30),@gioitinh char(3),@ngaysinh date,@noisinh nvarchar(50),@diachi nvarchar(30),@quan nvarchar(10),@makhoa char(6),@hocbong int)
as
update SINHVIEN
set HOSV=@hosv,TenSV=@tensv,GIOITINH=@gioitinh,NGAYSINH=@ngaysinh,NOISINH=@noisinh,DIACHI=@diachi,Quan=@quan,MAKHOA=@makhoa,HOCBONG=@hocbong
where MASV=@masv

-- test sua sv
--exec sp_suasv 'SV002',N'Lâm Chấn','Khang','Nam','2005/01/08',N'Bình Thuận',N'Mương Mán','Q1',5000000

-- tao sp xoasv
go
create proc sp_xoasv(@masv char(6))
as
Delete SINHVIEN
where MASV=@masv
--test xóa--
--exec sp_xoasv 'C03'

select * from MONHOC
-- them mh --
go
create proc sp_themmh(@mamh char(6),@tenmh nvarchar(50),@sotiet int)
as
insert into MONHOC(MAMH,TENMH,SOTIET) values(@mamh,@tenmh,@sotiet)

--exec sp_themmh '11',N'Giáo Dục Thể Chất','45'

-- sua mh--
go
create proc sp_suamh(@mamh char(6),@tenmh nvarchar(50),@sotiet int)
as
update MONHOC
set TENMH = @tenmh,SOTIET=@sotiet
where MAMH=@mamh
-- test suamh--
--exec sp_suamh '11',N'Thanh Nhạc','50'

-- xoa mh --
go
create proc sp_xoamh(@mamh char(6))
as
Delete MONHOC
where MAMH=@mamh
--test xóa--
--exec sp_xoamh '09'


--select * from KHOA
-- them khoa --
go
create proc sp_themkhoa (@makhoa char(6),@tenkhoa nvarchar(30))
as
insert into KHOA values (@makhoa,@tenkhoa)


--exec sp_themkhoa 'DH',N'Đồ Họa'
-- sua khoa--
go
create proc sp_suakhoa(@makhoa char(6),@tenkhoa nvarchar(30))
as
update KHOA
set TENKHOA =@tenkhoa
where MAKHOA=@makhoa



--exec sp_suakhoa 'AV',N'Khoa Tiếng Anh'
-- xoa khoa--
go
create proc sp_xoakhoa (@makhoa char(6))
as
delete KHOA
where MAKHOA=@makhoa


--exec sp_xoakhoa 'DH'

--select * from KETQUA
--them ketqua-- 
go
create proc sp_themkq
    @masv char(6),
    @mamh char(6),
    @diemthi int
as
insert into KETQUA values(@masv,@mamh,@diemthi)

--exec sp_themkq 'A04','01',9
--select* from KETQUA
--xoa ket qua--
go
create proc sp_xoakq
    @masv char(6),
    @mamh char(6)
as
begin
    delete from KETQUA
    where MASV = @masv AND MAMH = @mamh;
end;
go
--exec sp_xoakq 'A01','01'
go
create proc sp_suaketqua(@masv char(6),@mamh char (6),@diemthi int)
as
update KETQUA
set DIEMTHI=@diemthi
where MASV=@masv and  MAMH = @mamh
--exec sp_suaketqua 'A01','10'

--3.--
-- xuat so luong gioi tinh nam va nu
select * from SINHVIEN
go
create proc sp_slgoitinh(@gioitinh char(3))
as
select count(*) as SL
from SINHVIEN
where GIOITINH=@gioitinh
--exec sp_slgoitinh 'Nu'
--exec sp_slgoitinh 'Nam'


-- function--

--CREATE FUNCTION DemSLGT(@gioitinh CHAR(3))
--RETURNS INT 
--AS
--BEGIN
--    RETURN (
--        SELECT COUNT(*)  
--        FROM SINHVIEN 
--        WHERE GIOITINH = @gioitinh
--    );
--END;


--DECLARE @sl INT;
--SET @sl = dbo.DemSLGT('Nam');

--PRINT 'SL GT Nam Là:';
--PRINT @sl;
--select * from SINHVIEN


--CREATE FUNCTION fn_countSinhVienByGender(@gioitinh CHAR(3))
--RETURNS INT
--AS
--BEGIN
--    RETURN (SELECT COUNT(*) FROM SINHVIEN WHERE GIOITINH = @gioitinh);
--END;
--GO

--declare @slsv int;
--set @slsv = dbo.fn_countSinhVienByGender('Nam');
--print 'sl sv nam la:';
--print @slsv


--CREATE FUNCTION fn_getSoTiet(@mamh CHAR(6))
--RETURNS INT
--AS
--BEGIN
--    RETURN (SELECT SOTIET FROM MONHOC WHERE MAMH = @mamh);
--END;
--GO
--select * from MONHOC
--declare @tongsotiet int;
--set @tongsotiet = dbo.fn_getSoTiet('01');
--print 'tong so tiet cua mot mon hoc:'
--print @tongsotiet


--CREATE FUNCTION fn_getTenKhoa(@makhoa CHAR(6))
--RETURNS NVARCHAR(30)
--AS
--BEGIN
--    RETURN (SELECT TENKHOA FROM KHOA WHERE MAKHOA = @makhoa);
--END;
--GO
--select * from KHOA

--declare @tenkhoa nvarchar(30);
--set @tenkhoa = dbo.fn_getTenKhoa('AV');
--print 'Ten Khoa:'
--print @tenkhoa
go
create proc sp_danhsachkhoa
as
select * from KHOA 
go
create proc sp_danhsachsinhvien
as 
select * from sinhvien
go
create proc sp_danhsachmonhoc
as
select * from MONHOC
go
create proc sp_danhsachketqua
as 
select * from KETQUA
go
create proc sp_timkiemsinhvien(@masv char(6))
as
select * from SINHVIEN where MASV like @masv
--exec sp_timkiemsinhvien 'A01';
