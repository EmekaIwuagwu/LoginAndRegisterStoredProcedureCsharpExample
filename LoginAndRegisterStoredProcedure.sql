USE [PeopleBase]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE LoginUser

@username varchar(50) = null,
@pwd varchar(50) = null


AS
BEGIN
SET NOCOUNT ON

select * from dbo.db_4systemUsers where username =@username and pwd=@pwd

END 
GO


ALTER PROCEDURE RegisterUser
@username varchar(50) = null,
@pwd varchar(50) = null,
@fullname varchar(50) = null,
@tel varchar(50) = null ,
@idnumber varchar(50) = null

AS 
BEGIN
SET NOCOUNT ON
insert into dbo.db_4systemUsers (username, pwd, fullname, tel, idnumber) values (@username, @pwd, @fullname, @tel, @idnumber)

END
GO



