USE [H:\DB\TEST\TESTDB.MDF]
GO

/****** Object: SqlProcedure [dbo].[gsp_GetUsers] Script Date: 7/12/2015 1:33:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[gsp_GetUsers];


GO
CREATE PROCEDURE [dbo].gsp_GetUsers
	@nUserID numeric(18,0)
AS
Begin
	IF @nUserID=0
		BEGIN	
			SELECT nUserID,sFirstName,sLastName,sEmail,sUserName,sPassword FROM Fert_Users
		END	
	ELSE
		BEGIN
			SELECT nUserID,sFirstName,sLastName,sEmail,sUserName,sPassword FROM Fert_Users WHERE nUserID=@nUserID
		END
End
