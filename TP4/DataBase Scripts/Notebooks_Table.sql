USE [Products]
GO

/****** Object:  Table [dbo].[Notebooks]    Script Date: 12/7/2021 00:18:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Notebooks]') AND type in (N'U'))
DROP TABLE [dbo].[Notebooks]
GO

/****** Object:  Table [dbo].[Notebooks]    Script Date: 12/7/2021 00:18:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Notebooks](
	[Serial_Number] [numeric](18, 0) NOT NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[ScreenSize] [numeric](18, 0) NULL,
	[SsdModules] [numeric](18, 0) NULL,
	[RamModules] [numeric](18, 0) NULL,
	[Battery] [numeric](18, 0) NULL,
	[Speakers] [numeric](18, 0) NULL,
	[Trackpad] [numeric](18, 0) NULL,
	[HasDockingStation] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Notebooks] PRIMARY KEY CLUSTERED 
(
	[Serial_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

