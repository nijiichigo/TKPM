CREATE TABLE [dbo].[TinhTrang] (
    [MaTinhTrang]  INT   NOT NULL,
    [TenTinhTrang] NVARCHAR (50)  NOT NULL,
    [GhiChu]       NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaTinhTrang] ASC)
);

