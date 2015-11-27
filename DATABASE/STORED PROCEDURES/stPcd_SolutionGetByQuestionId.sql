USE [UBSnS_Database]
GO

/****** Object:  StoredProcedure [dbo].[stPcd_SolutionGetByQuestionId]    Script Date: 27/11/2015 17:53:24 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<E.P Darkwa>
-- Create date: <18/08/205>
-- Description:	<Get Exams by ID,,>
-- =============================================
create PROCEDURE [dbo].[stPcd_SolutionGetByQuestionId]
	-- Add the parameters for the stored procedure here
	@QuestionId int

AS

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM tbl_Solution
	WHERE QuestionId = @QuestionId





GO

