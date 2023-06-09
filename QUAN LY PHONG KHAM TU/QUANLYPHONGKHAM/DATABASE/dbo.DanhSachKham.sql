﻿CREATE TABLE [dbo].[DanhSachKham] (
    [MaDangKy]    INT          NOT NULL,
    [NgayKham]    CHAR(10) NOT NULL,
    [STT]         INT          NOT NULL,
    [MaBenhNhan]  INT          NOT NULL,
    [MaTinhTrang] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([MaDangKy] ASC),
    CONSTRAINT [FK_DanhSachKham_TinhTrang] FOREIGN KEY ([MaTinhTrang]) REFERENCES [dbo].[TinhTrang] ([MaTinhTrang]),
    CONSTRAINT [FK_DanhSachKham_BenhNhan] FOREIGN KEY ([MaBenhNhan]) REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
);

