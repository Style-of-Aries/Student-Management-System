create table TaiKhoan(
	id int primary key identity(1,1),
	TenTaiKhoan nvarchar(50),
	MatKhau char(32),
	Email nvarchar(50),
	SoDienThoai char(10),
	DiaChi nvarchar(100),
	NgaySinh date,
	GioiTinh bit,
	TypeAccount int
);

select * from TaiKhoan where TenTaiKhoan = 'admin' and MatKhau = 12345678