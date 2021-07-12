USE [Products]
GO

/****** Object:  Table [dbo].[Keyboards]    Script Date: 12/7/2021 00:19:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Keyboards]') AND type in (N'U'))
DROP TABLE [dbo].[Keyboards]
GO

/****** Object:  Table [dbo].[Keyboards]    Script Date: 12/7/2021 00:19:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Keyboards](
	[Serial_Number] [numeric](18, 0) NOT NULL,
	[Model] [varchar](50) NULL,
	[Price] [float] NULL,
	[KeyboardSize] [numeric](18, 0) NULL,
	[CableAmount] [numeric](18, 0) NULL,
	[KeyCapsAmount] [numeric](18, 0) NULL,
	[SwitchesAmount] [numeric](18, 0) NULL,
	[SwtichColor] [varchar](50) NULL,
	[SwitchType] [varchar](50) NULL,
	[Stabilazers] [numeric](18, 0) NULL,
	[HasBluetooth] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Keyboards] PRIMARY KEY CLUSTERED 
(
	[Serial_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

