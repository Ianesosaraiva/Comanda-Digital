﻿CREATE TABLE [dbo].[Comanda](
   [idComanda] [int] IDENTITY(1,1) NOT NULL,
   [flgEncerramento] [tinyint] NULL,
   [data] [date] NULL,

CONSTRAINT [PK_Comanda] PRIMARY KEY CLUSTERED 
(
[idComanda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO