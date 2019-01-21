
USE [Praxio]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 20/01/2019 22:38:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[ID] [nvarchar](20) NOT NULL,
	[ClientSecret] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO dbo.Users
           (ID
           ,ClientSecret)
     VALUES
           ('usuario01'
           ,'94be650011cf412ca906fc335f615cdc')
GO