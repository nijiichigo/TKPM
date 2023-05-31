CREATE TABLE [dbo].[PhieuKham] (
    [MaPhieuKham] INT            NOT NULL,
    [TrieuChung]  NVARCHAR (200) NOT NULL,
    [ChanDoan]    NVARCHAR (200) NOT NULL,
    [LoiDan]      NVARCHAR (200) NOT NULL,
    [MaDonThuoc]  INT            NOT NULL,
    [TaiKhoan] NVARCHAR(20) NOT NULL, 
    PRIMARY KEY CLUSTERED ([MaPhieuKham] ASC),
    CONSTRAINT [FK_PhieuKham_DanhSachKham] FOREIGN KEY ([MaPhieuKham]) REFERENCES [dbo].[DanhSachKham] ([MaDangKy])
);

