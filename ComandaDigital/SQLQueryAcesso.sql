﻿CREATE TABLE [dbo].[Acesso](
   [idAcesso] [int] IDENTITY(1,1) NOT NULL,
   [descricao] [nvarchar](50) NULL,
CONSTRAINT [PK_Acesso] PRIMARY KEY CLUSTERED 
(
[idAcesso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO