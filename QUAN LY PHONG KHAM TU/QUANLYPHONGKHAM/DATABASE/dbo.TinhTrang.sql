CREATE TABLE [dbo].[TinhTrang] (
    [MaTinhTrang]  VARCHAR(20)           NOT NULL,
    [TenTinhTrang] NVARCHAR (50) NOT NULL,
    [GhiChu] NVARCHAR(100) NOT NULL, 
    PRIMARY KEY CLUSTERED ([MaTinhTrang] ASC)
);

