﻿CREATE TABLE [dbo].[Menu](
   [idMenu] [int] IDENTITY(1,1) NOT NULL,
   [produto] [nvarchar](50) NULL,
   [valor] [nvarchar](50) NULL,

CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
[idMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO