USE [UBSnS_Database]
GO

/****** Object:  Table [dbo].[Exmas]    Script Date: 27/11/2015 16:48:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Exam](
	[Id] [int] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Note] [nvarchar](250) NULL,
	[SubjectId] [int] NOT NULL
) ON [PRIMARY]

GO

