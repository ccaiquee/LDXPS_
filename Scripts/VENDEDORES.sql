USE [LDXPSDB]
GO

/****** Object:  Table [dbo].[VENDEDORES]    Script Date: 02/09/2018 19:30:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[VENDEDORES](
	[CDVEND] [uniqueidentifier] NOT NULL DEFAULT ('DC22634F-2B40-4C63-8128-E47522B8B56A'),
	[DSNOME] [varchar](50) NOT NULL,
	[CDTAB] [int] NOT NULL,
	[DTNASC] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CDVEND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


