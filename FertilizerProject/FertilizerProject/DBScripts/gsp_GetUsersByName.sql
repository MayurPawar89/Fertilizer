USE [H:\DB\TEST\TESTDB.MDF]
GO

/****** Object: SqlProcedure [dbo].[gsp_GetUsersByName] Script Date: 7/12/2015 1:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[gsp_GetUsersByName];


GO
CREATE PROCEDURE gsp_GetUsersByName
	@sUserName varchar(100)
AS
Begin
	IF @sUserName=''
		BEGIN	
			SELECT -1
		END	
	ELSE
		BEGIN
			SELECT nUserID,sFirstName,sLastName,sEmail,sUserName,sPassword FROM Fert_Users WHERE sUserName=@sUserName
		END
End
