USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 1/8/2025 4:54:18 PM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLSV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [char](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [char](10) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaNganh] [char](10) NULL,
	[SiSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganhHoc]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhHoc](
	[MaNganh] [char](10) NOT NULL,
	[TenNganh] [nvarchar](50) NULL,
	[MaKhoa] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](10) NOT NULL,
	[TenSV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [char](10) NULL,
	[Cccd] [char](12) NULL,
	[Email] [nvarchar](50) NULL,
	[MaLop] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiKhoan] [char](15) NULL,
	[MatKhau] [char](12) NULL,
	[Email] [varchar](50) NULL,
	[SoDienThoai] [char](10) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[QuyenTruyCap] [nvarchar](50) NULL,
	[TenHienThi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT      ', N'Công nghệ thông tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'DTU       ', N'Điện tử')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'KT        ', N'Kinh tế')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'LU        ', N'Luật')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'NN        ', N'Ngôn ngữ')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaNganh], [SiSo]) VALUES (N'CNT01     ', N'2623CNT01', N'CNT       ', 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaNganh], [SiSo]) VALUES (N'ENG01     ', N'2623ENG02', N'ENG       ', 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaNganh], [SiSo]) VALUES (N'ENG02     ', N'2623END04', N'ENG       ', 0)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaNganh], [SiSo]) VALUES (N'LMT01     ', N'2623LMT01', N'LMT       ', 0)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaNganh], [SiSo]) VALUES (N'TKH01     ', N'2623TKH01', N'TKH       ', 0)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaNganh], [SiSo]) VALUES (N'TKH02     ', N'2623TKH02', N'TKH       ', 0)
GO
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'CNT       ', N'Công nghệ thông tin', N'CNTT      ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'DCN       ', N'Điện công nghiệp', N'DTU       ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'DTU       ', N'Điện - Điện tử', N'DTU       ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'ENG       ', N'Ngôn ngữ Anh', N'NN        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'fadfd     ', N'fadfd', NULL)
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'JAP       ', N'Ngôn ngữ Nhật', N'NN        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'KT        ', N'Kinh tế', N'KT        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'KTO       ', N'Kế toán', N'KT        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'LKT       ', N'Luật kinh tế', N'LU        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'LMT       ', N'Lập trình máy tính', N'CNTT      ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'LQT       ', N'Luật quốc tế', N'LU        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'LUT       ', N'Luật', N'LU        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'QKD       ', N'Quản trị kinh doanh', N'KT        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'QKS       ', N'Quản trị khách sạn', N'KT        ')
INSERT [dbo].[NganhHoc] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'TKH       ', N'Thiết kế đồ họa', N'CNTT      ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [Cccd], [Email], [MaLop]) VALUES (N'001       ', N'Trọng', CAST(N'2025-01-08' AS Date), N'Nam', N'da', N'12345235  ', N'13156615    ', N'ddaada', N'ENG01     ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [Cccd], [Email], [MaLop]) VALUES (N'0023      ', N'Trọng', CAST(N'2005-04-03' AS Date), N'Nam', N'', N'          ', N'            ', N'', N'CNT01     ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [Cccd], [Email], [MaLop]) VALUES (N'2309620319', N'Nguyễn Đức Trọng', CAST(N'2005-04-03' AS Date), N'Nam', N'Hà Nội', N'0968843380', N'001205022394', N'ductrong34end@gmail.com', N'CNT01     ')
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([id], [TenTaiKhoan], [MatKhau], [Email], [SoDienThoai], [NgaySinh], [GioiTinh], [QuyenTruyCap], [TenHienThi]) VALUES (1, N'admin          ', N'12345678    ', N'ductrong34end@gmail.com', N'0968843380', CAST(N'2005-04-03' AS Date), N'Nam', N'Admin', N'Nguyễn Đức Trọng')
INSERT [dbo].[TaiKhoan] ([id], [TenTaiKhoan], [MatKhau], [Email], [SoDienThoai], [NgaySinh], [GioiTinh], [QuyenTruyCap], [TenHienThi]) VALUES (4, N'ductrong       ', N'12345678    ', N'', N'000003366 ', CAST(N'2025-01-06' AS Date), N'Nam', N'Manager', N'Nguyễn Đức Trọng')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SinhVien__0389B7BD8BB7C1AC]    Script Date: 1/8/2025 4:54:18 PM ******/
ALTER TABLE [dbo].[SinhVien] ADD UNIQUE NONCLUSTERED 
(
	[SoDienThoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SinhVien__A115BE80BE2471E2]    Script Date: 1/8/2025 4:54:18 PM ******/
ALTER TABLE [dbo].[SinhVien] ADD UNIQUE NONCLUSTERED 
(
	[Cccd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_SoDienThoai]    Script Date: 1/8/2025 4:54:18 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [uq_SoDienThoai] UNIQUE NONCLUSTERED 
(
	[SoDienThoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_TaiKhoan_TenTaiKhoan]    Script Date: 1/8/2025 4:54:18 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [uq_TaiKhoan_TenTaiKhoan] UNIQUE NONCLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lop] ADD  DEFAULT ((0)) FOR [SiSo]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [fk_Lop_NganhHoc] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NganhHoc] ([MaNganh])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [fk_Lop_NganhHoc]
GO
ALTER TABLE [dbo].[NganhHoc]  WITH CHECK ADD  CONSTRAINT [fk_NganhHoc_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[NganhHoc] CHECK CONSTRAINT [fk_NganhHoc_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [fk_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [fk_SinhVien_Lop]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLopByNganh]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetLopByNganh]
@TenNganh nvarchar(50)
as
begin
select MaLop, TenLop, SiSo, NganhHoc.MaNganh from Lop inner join NganhHoc on Lop.MaNganh = NganhHoc.MaNganh where TenNganh = @TenNganh
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetSinhVienByLop]    Script Date: 1/8/2025 4:54:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetSinhVienByLop]
@TenLop nvarchar(50)
as
begin
select MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, cccd, Email, Lop.MaLop from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop where TenLop = @TenLop
end
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
