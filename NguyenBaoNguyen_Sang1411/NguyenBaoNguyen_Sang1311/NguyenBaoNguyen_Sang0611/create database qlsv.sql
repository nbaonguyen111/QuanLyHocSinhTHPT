create database QLSV
go
use QLSV
go
set dateformat dmy 
go
create table  KHOA(MAKHOA char (6) not null ,TENKHOA nvarchar(30)
	constraint pkkhoa primary key (MAKHOA))
go
create table SINHVIEN(MASV char(6) primary key , 
	HOSV nvarchar (30) not null,
	TenSV nvarchar(15) not null,
	GIOITINH char(3) check (GIOITINH in('Nam', 'Nu')), 
	NGAYSINH Date, 
	NOISINH nvarchar(50), 
	DIACHI	 NVARCHAR(50),
	Quan nvarchar(10), 
	MAKHOA char(6),
	HOCBONG int,
	constraint  FK_SV_Khoa foreign key (MAKHOA) references KHOA(MaKHOA))
go
create table MONHOC(MAMH char(6) primary key,
	TENMH nvarchar(50) not null,
	SOTIET int)

go
create table KETQUA(MASV char(6) , MAMH char(6), 
	 DIEMTHI int, 
	constraint pk_ketqua primary key (MaSV, MaMH),
	constraint fk_KQ_SV foreign key (MASV) references SINHVIEN(MASV),
	constraint fk_KQ_MH foreign key (MAMH) references MONHOC(Mamh)
		)


		--select * from SINHVIEN
		--select * from KHOA
		--select *from MONHOC
		--select *from KETQUA