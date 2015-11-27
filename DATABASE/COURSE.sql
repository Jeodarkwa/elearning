USE [UBSnS_Database]
GO

/****** Object:  Table [dbo].[Course]    Script Date: 27/11/2015 17:08:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Course](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Note] [nvarchar](50) NULL
) ON [PRIMARY]

GO

