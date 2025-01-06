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
	SoLuongSV int,
	constraint fk_Lop_NganhHoc foreign key(MaNganh) references NganhHoc(MaNganh)
 );

 create table SinhVien(
	 MaSV char(10) primary key,
	 TenSV nvarchar(50),
	 MaLop char(10),
	 NgaySinh date,
	 GioiTinh nchar(10),
	 DiaChi nvarchar(50),
	 SoDienThoai char(10),
	 cccd char(12),
	 Email nvarchar(50),
	 constraint fk_SinhVien_Lop foreign key(MaLop) references Lop(MaLop)
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