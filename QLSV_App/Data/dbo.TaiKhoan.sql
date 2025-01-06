CREATE TABLE [dbo].[TaiKhoan] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [TenTaiKhoan]  NVARCHAR (50) NULL,
    [MatKhau]      CHAR (32)     NULL,
    [Email]        NVARCHAR (50) NULL,
    [SoDienThoai]  CHAR (10)     NULL,
    [NgaySinh]     DATE          NULL,
    [GioiTinh]     NCHAR (10)    NULL,
    [QuyenTruyCap] NVARCHAR (50) NULL,
    [TenHienThi]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

