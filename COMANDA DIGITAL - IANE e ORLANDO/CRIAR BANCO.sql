CREATE TABLE [dbo].[Acesso] (
    [idAcesso]  INT           IDENTITY (1, 1) NOT NULL,
    [descricao] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Acesso] PRIMARY KEY CLUSTERED ([idAcesso] ASC)
);

CREATE TABLE [dbo].[Pessoa] (
    [idPessoa] INT           IDENTITY (1, 1) NOT NULL,
    [nome]     NVARCHAR (100) NOT NULL,
    [cpf]      NVARCHAR (100) NOT NULL,
    [telefone]    NVARCHAR (100) NOT NULL,
    [endereco]    NVARCHAR (100) NOT NULL,
    [cidade]    NVARCHAR (100) NOT NULL,
    [senha]    NVARCHAR (50) NOT NULL,
    [idAcesso] INT           NOT NULL,
    CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED ([idPessoa] ASC),
    FOREIGN KEY ([idAcesso]) REFERENCES [dbo].[Acesso] ([idAcesso])
);

CREATE TABLE [dbo].[Produto] (
    [idProduto]  INT           IDENTITY (1, 1) NOT NULL,
    [produto] NVARCHAR (100) NULL,
    [quantidade] INT,
    [valor]   float NULL,
    CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED ([idProduto] ASC)
);

CREATE TABLE [dbo].[Pedido] (
    [idPedido]   INT IDENTITY (1, 1) NOT NULL,
    [flgEncerramento] TINYINT NULL,
    [quantidade] INT NOT NULL,
    [numeroComanda]   INT NOT NULL,
    [idProduto]     INT NOT NULL,
    CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED ([idPedido] ASC),
    FOREIGN KEY ([idProduto]) REFERENCES [dbo].[Produto] ([idProduto])
);


CREATE TABLE [dbo].[Comanda] (
    [idComanda]       INT     IDENTITY (1, 1) NOT NULL,
    [total]        float     NOT NULL,
    [data]            DATETIME    NOT NULL,
    [idPedido]        INT     NOT NULL,
    [idPessoa]        INT     NOT NULL,
    CONSTRAINT [PK_Comanda] PRIMARY KEY CLUSTERED ([idComanda] ASC),
    FOREIGN KEY ([idPessoa]) REFERENCES [dbo].[Pessoa] ([idPessoa]),
    FOREIGN KEY ([idPedido]) REFERENCES [dbo].[Pedido] ([idPedido]),
);



