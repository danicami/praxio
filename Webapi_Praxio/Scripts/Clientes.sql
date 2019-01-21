USE [Praxio]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 20/01/2019 22:36:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cep] [int] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO