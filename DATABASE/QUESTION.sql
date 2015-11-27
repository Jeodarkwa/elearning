USE [UBSnS_Database]
GO

/****** Object:  Table [dbo].[Question]    Script Date: 27/11/2015 16:49:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Question](
	[Id] [int] NOT NULL,
	[Question] [text] NOT NULL,
	[Notes] [nvarchar](250) NULL,
	[AnswerId] [int] NOT NULL,
	[ExamId] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

