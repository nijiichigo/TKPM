CREATE TABLE [dbo].[Thuoc] (
    [MaThuoc]  INT            NOT NULL,
    [TenThuoc] NVARCHAR (100) NOT NULL,
    [MaNhom]   INT   NOT NULL,
    [MaDonVi]  INT   NOT NULL,
    [DonGia]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([MaThuoc] ASC),
    CONSTRAINT [FK_Thuoc_NhomThuoc] FOREIGN KEY ([MaNhom]) REFERENCES [dbo].[NhomThuoc] ([MaNhom]),
    CONSTRAINT [FK_Thuoc_DonVi] FOREIGN KEY ([MaDonVi]) REFERENCES [dbo].[DonVi] ([MaDonVi])
);

