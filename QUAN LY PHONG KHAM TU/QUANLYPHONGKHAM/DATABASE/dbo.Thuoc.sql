CREATE TABLE [dbo].[Thuoc]
(
	[MaThuoc] INT NOT NULL PRIMARY KEY, 
    [TenThuoc] NVARCHAR(100) NOT NULL, 
    [MaNhom] VARCHAR(10) NOT NULL, 
    [MaDonVi] VARCHAR(10) NOT NULL, 
    [DonGia] INT NOT NULL, 
    CONSTRAINT [FK_Thuoc_NhomThuoc] FOREIGN KEY ([MaNhom]) REFERENCES [NhomThuoc]([MaNhom]), 
    CONSTRAINT [FK_Thuoc_DonVi] FOREIGN KEY ([MaDonVi]) REFERENCES [DonVi]([MaDonVi])
)
