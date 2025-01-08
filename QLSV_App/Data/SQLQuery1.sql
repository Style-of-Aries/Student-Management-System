create table TaiKhoan(
	id int primary key identity(1,1),
	TenTaiKhoan nvarchar(50),
	MatKhau char(32),
	Email nvarchar(50),
	SoDienThoai char(10),
	NgaySinh date,
	GioiTinh nvarchar(5), check(GioiTinh in (N'Nam', N'Nữ')),
	QuyenTruyCap nvarchar(50),
	TenHienThi nvarchar(50),
	constraint uq_TaiKhoan_TenTaiKhoan unique(TenTaiKhoan),
);
alter table TaiKhoan
add constraint uq_SoDienThoai unique(SoDienThoai)

drop table TaiKhoan

create table Khoa(
	MaKhoa char(10) primary key,
	TenKhoa nvarchar(50)
);

create table NganhHoc(
	MaNganh char(10) primary key,
	TenNganh nvarchar(50),
	MaKhoa char(10),
	constraint fk_NganhHoc_Khoa foreign key(MaKhoa) references Khoa(MaKhoa)
);

create table Lop(
	MaLop char(10) primary key,
	TenLop nvarchar(50),
	MaNganh char(10),
	SiSo int default 0,
	constraint fk_Lop_NganhHoc foreign key(MaNganh) references NganhHoc(MaNganh),
);
drop table Khoa
drop table NganhHoc
drop table Lop
drop table SinhVien
 CREATE TABLE [dbo].[SinhVien] (
    [MaSV]        CHAR (10)     NOT NULL,
    [TenSV]       NVARCHAR (50) NULL,
    [NgaySinh]    DATE          NULL,
    [GioiTinh]    NVARCHAR (5)  NULL,
    [DiaChi]      NVARCHAR (50) NULL,
    [SoDienThoai] CHAR (10)     NULL,
    [Cccd]        CHAR (12)     NULL,
    [Email]       NVARCHAR (50) NULL,
    [MaLop]       CHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([MaSV] ASC),
    UNIQUE NONCLUSTERED ([SoDienThoai] ASC),
    UNIQUE NONCLUSTERED ([Cccd] ASC),
    CONSTRAINT [fk_SinhVien_Lop] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[Lop] ([MaLop])
	
);

select * from TaiKhoan 
order by QuyenTruyCap

select TenHienThi from TaiKhoan
select QuyenTruyCap from TaiKhoan where TenTaiKhoan = 'admin'

insert into TaiKhoan(TenTaiKhoan, MatKhau, QuyenTruyCap, TenHienThi) values('admin', '123', 'Admin', N'Nguyễn Đức Trọng')
insert into TaiKhoan(TenTaiKhoan, MatKhau, QuyenTruyCap) values('ductrong', '123', 'Manager')
insert into TaiKhoan(TenTaiKhoan, MatKhau, QuyenTruyCap) values('ductrong123', '123', 'Manager')


insert into TaiKhoan values('thuhang', '123', N'Nữ', 'Admin', N'Thu Hằng')
select id,TenTaiKhoan as 'Tên tài khoản', MatKhau as 'Mật khẩu', Email as 'Email', SoDienThoai as 'Số điện thoại', NgaySinh as 'Ngày sinh', GioiTinh as 'Giới tính', QuyenTruyCap as 'Quyền truy cập', tenHienThi as 'Tên hiển thị' from TaiKhoan

select MaKhoa from Khoa

select MaNganh,TenNganh,TenKhoa from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa like N'Công nghệ thông tin'
select * from NganhHoc

insert into NganhHoc values('ENG','Ngôn ngữ Anh','NN')
insert into NganhHoc values('GER',N'Ngôn ngữ Đức','NN')
update NganhHoc set TenNganh = N'Ngôn ngữ Anh' where MaNganh = 'ENG'
select MaKhoa from Khoa where TenKhoa = N'Ngôn ngữ'
insert into NganhHoc(MaNganh,TenNganh) values('fadfd',N'fadfd')

declare @MaLop char(10)
set @MaLop = 'CNTT1'


CREATE TRIGGER trgAutoGenerateCode
ON 
AFTER INSERT
AS
BEGIN
  DECLARE @maxId INT, @newCode VARCHAR(10)
  SELECT @maxId = ISNULL(MAX(RIGHT(Code, 4)), 0) + 1
  FROM Product
  SELECT @newCode = 'SP' + RIGHT('0000' + CAST(@maxId AS VARCHAR(4)), 4)
  FROM Product
  UPDATE Product SET Code = @newCode
  WHERE Id IN (SELECT Id FROM inserted)
END

select MaNganh from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa like N'Công nghệ thông tin'
declare @TenKhoa nvarchar(50)
set @TenKhoa = N'Công nghệ thông tin'
select MaNganh from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa = @TenKhoa



select MaLop, TenLop, SiSo, NganhHoc.MaNganh from Lop inner join NganhHoc on Lop.MaNganh = NganhHoc.MaNganh where TenNganh like N'Ngôn ngữ Anh'

create proc sp_GetLopByNganh
@TenNganh nvarchar(50)
as
begin
select MaLop, TenLop, SiSo, NganhHoc.MaNganh from Lop inner join NganhHoc on Lop.MaNganh = NganhHoc.MaNganh where TenNganh = @TenNganh
end

exec sp_GetLopByNganh N'Ngôn ngữ'

create proc sp_GetSinhVienByLop
@TenLop nvarchar(50)
as
begin
select MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, cccd, Email, Lop.MaLop from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop where TenLop = @TenLop
end

exec sp_GetSinhVienByLop N'2623ENG04'

select * from SinhVien
select count(*) as 'Sĩ số' from SinhVien 

select MaLop, TenLop, MaNganh, SiSo from Lop update Lop set SiSo = (select count(*) from SinhVien where Lop.MaLop = SinhVien.MaLop)
declare @TenNganh nvarchar(50)
set @TenNganh = N'Ngôn ngữ Anh'

declare @TenLop nvarchar(50)
set @TenLop = N'2623ENG02'
select MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Cccd, Email, Lop.MaLop from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop where TenLop = @TenLop

select MaLop, TenLop, SiSo, NganhHoc.MaNganh from Lop inner join NganhHoc on Lop.MaNganh = NganhHoc.MaNganh where TenNganh = @TenNganh update Lop set SiSo = (select count(*) from SinhVien where Lop.MaLop = SinhVien.MaLop)