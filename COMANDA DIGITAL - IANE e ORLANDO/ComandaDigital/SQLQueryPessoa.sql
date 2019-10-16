CREATE TABLE [dbo].[Pessoa](
   [idPessoa] [int] IDENTITY(1,1) NOT NULL,
   [nome] [nvarchar] (50) NULL,
   [cpf] [int] NULL,
   [senha] [nvarchar] (50) NULL,

CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
[idPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO