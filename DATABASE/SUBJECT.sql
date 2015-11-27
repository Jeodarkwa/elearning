USE [UBSnS_Database]
GO

/****** Object:  Table [dbo].[Subject]    Script Date: 27/11/2015 16:49:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Subject](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Note] [nvarchar](50) NULL,
	[CourseId] [int] NOT NULL
) ON [PRIMARY]

GO

