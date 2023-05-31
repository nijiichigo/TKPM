CREATE TABLE [dbo].[TaiKhoan]
(
	[TenTaiKhoan] VARCHAR(20) NOT NULL PRIMARY KEY, 
    [TenHienThi] NVARCHAR(100) NOT NULL, 
    [MatKhau] VARCHAR(50) NOT NULL, 
    [MaLoaiTaiKhoan] INT NOT NULL, 
    CONSTRAINT [FK_TaiKhoan_LoaiTaikhoan] FOREIGN KEY ([MaLoaiTaikhoan]) REFERENCES [LoaiTaikhoan]([MaLoaiTaikhoan])
)
