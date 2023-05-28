CREATE TABLE [dbo].[BenhNhan] (
    [MaBenhNhan] INT            NOT NULL,
    [HoTen]      NVARCHAR (100) NOT NULL,
    [NamSinh]    INT            NOT NULL,
    [GioiTinh]   NVARCHAR (10)  NOT NULL,
    [DienThoai]  VARCHAR(15)            NOT NULL,
    [DiaChi]     NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaBenhNhan] ASC)
);

