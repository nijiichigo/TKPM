CREATE TABLE [dbo].[DanhSachKham] (
    [MaDangKy]    INT          NOT NULL,
    [NgayKham]    VARCHAR (10) NOT NULL,
    [STT]         INT          NOT NULL,
    [MaBenhNhan]  INT          NOT NULL,
    [MaPhieuKham] INT          NULL,
    [MaDonThuoc]  INT          NULL,
	[MaHoaDon]    INT          NULL,
    [MaTinhTrang] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaDangKy] ASC),
    CONSTRAINT [FK_DanhSachKham_BenhNhan] FOREIGN KEY ([MaBenhNhan]) REFERENCES [dbo].[BenhNhan] ([MaBenhNhan]),
    CONSTRAINT [FK_DanhSachKham_TinhTrang] FOREIGN KEY ([MaTinhTrang]) REFERENCES [dbo].[TinhTrang] ([MaTinhTrang])
);

