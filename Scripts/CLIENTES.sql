USE [LDXPSDB]
GO

/****** Object:  Table [dbo].[CLIENTES]    Script Date: 02/09/2018 19:28:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CLIENTES](
	[CDCL] [uniqueidentifier] NOT NULL DEFAULT ('C962264E-5DE9-4639-BD9C-AE6831823AE2'),
	[DSNOME] [varchar](50) NOT NULL,
	[IDTIPO] [char](2) NOT NULL,
	[CDVEND] [uniqueidentifier] NOT NULL,
	[DSLIM] [decimal](15, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CDCL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_VENDEDORES] FOREIGN KEY([CDVEND])
REFERENCES [dbo].[VENDEDORES] ([CDVEND])
GO

ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_CLIENTES_VENDEDORES]
GO


