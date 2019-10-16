CREATE TABLE [dbo].[Produtos] (
    [idProdutos]  INT           IDENTITY (1, 1) NOT NULL,
    [produto] NVARCHAR (50) NULL,
    [valor]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED ([idProdutos] ASC)
);
