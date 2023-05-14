CREATE TABLE [dbo].[BenhNhan]
(
	[MaBenhNhan] INT NOT NULL PRIMARY KEY, 
    [HoTen] NVARCHAR(100) NOT NULL, 
    [NamSinh] INT NOT NULL, 
    [GioiTinh] NVARCHAR(10) NOT NULL, 
    [DienThoai] INT NULL, 
    [DiaChi] NVARCHAR(200) NULL
)
