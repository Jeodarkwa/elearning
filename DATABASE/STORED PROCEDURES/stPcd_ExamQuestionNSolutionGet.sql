USE [UBSnS_Database]
GO

/****** Object:  StoredProcedure [dbo].[stPcd_ExamQuestionNSolutionGet]    Script Date: 27/11/2015 17:52:49 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<E.P Darkwa>
-- Create date: <18/08/205>
-- Description:	<Get Exams by ID,,>
-- =============================================
CREATE PROCEDURE [dbo].[stPcd_ExamQuestionNSolutionGet]
	-- Add the parameters for the stored procedure here
	@ExamsId int

AS

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM tbl_Question INNER JOIN tbl_Solution on tbl_Question.Id = tbl_Solution.QuestionId
	WHERE tbl_Question.ExamId = @ExamsId


GO

