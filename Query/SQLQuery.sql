CREATE PROCEDURE CREATETABLEUSER
AS
	CREATE TABLE [dbo].[USER] (
    [username]      nchar(15)       NOT NULL,
    [password]      nchar(15)       NULL,
    [name]          nvarchar(50)    NULL,
    [age]           INT             NULL,
    [list]          varchar(MAX)    NULL
);
RETURN 0


CREATE PROCEDURE REGISTER
	@username nchar(15),
	@password nchar(15)
AS
	insert into [dbo].[USER] ([username], [password])
		values (@username, @password)
RETURN 0


CREATE PROCEDURE CHANGEUSERINFOR
	@password nchar(15),
	@name nvarchar(50),
	@age int,
AS
	UPDATE [dbo].[USER] SET [password] = @password, [name] = @name, [age] = @age
	WHERE username = @username
RETURN 0


	-- Need to check again !!!
CREATE PROCEDURE CHECKLOGIN
	@username nchar(15),
	@password nchar(15)
AS
	SELECT [username], [password] FROM [dbo].[USER] WHERE [username] = @username, [password] = @password
RETURN 0


CREATE PROCEDURE CREATETABLESONG
AS
	CREATE TABLE [dbo].[USER] (
	[id]			INT				IDENTITY (1, 1) NOT NULL,
    [name]			nvarchar(50)    NULL,
    [author]		nvarchar(50)       NULL,
    [image]         varchar(MAX)    NULL
);
RETURN 0


CREATE PROCEDURE ADDSONG
	@name nvarchar(50),
	@author nvarchar(50),
	@image varchar(MAX)
AS
	insert into [dbo].[SONG] ([name], [author], [image])
		values (@name, @author, @image)

RETURN 0