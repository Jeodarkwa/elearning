USE [UBSnS_Database]
GO

/****** Object:  Table [dbo].[tbl_Solution]    Script Date: 27/11/2015 17:07:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Solution](
	[Id] [int] NOT NULL,
	[Solution] [text] NOT NULL,
	[Note] [nvarchar](250) NULL,
	[QuestionId] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

