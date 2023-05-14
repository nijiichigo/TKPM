CREATE TABLE [dbo].[DanhSachKham]
(
	[MaDangKy] INT NOT NULL PRIMARY KEY, 
    [NgayKham] DATE NOT NULL, 
    [STT] INT NOT NULL, 
    [MaBenhNhan] INT NOT NULL, 
    [MaPhieuKham] INT NOT NULL, 
    [MaHoaDon] INT NOT NULL
)
