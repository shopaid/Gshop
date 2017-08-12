USE [gShop]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 8/12/2017 7:42:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Product](
	[Pdt_Id] [nvarchar](100) NOT NULL,
	[Pdt_Name] [varchar](max) NOT NULL,
	[Pdt_BuyPrice] [numeric](18, 2) NULL,
	[Pdt_GST] [numeric](18, 2) NULL,
	[Pdt_SellPrice] [numeric](18, 2) NULL,
	[Pdt_Discount] [decimal](18, 2) NULL,
	[Pdt_PurchaseDate] [date] NULL,
	[Pdt_Quantity] [int] NULL,
	[Pdt_Tax_Type] [bit] NULL,
	[CreatedBy] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[Created_DateTime] [date] NOT NULL,
	[Updated_DateTime] [date] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Pdt_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Pdt_PurchaseDate]  DEFAULT (getdate()) FOR [Pdt_PurchaseDate]
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Created_DateTime]  DEFAULT (getdate()) FOR [Created_DateTime]
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Updated_DateTime]  DEFAULT (getdate()) FOR [Updated_DateTime]
GO


