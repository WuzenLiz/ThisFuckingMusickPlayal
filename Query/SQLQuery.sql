CREATE PROCEDURE CREATEDATABASE
AS
	CREATE DATABASE MUSIC
RETURN 0

CREATE PROCEDURE CREATETABLEUSER
AS
	CREATE TABLE [dbo].[USER] (
		[id]       INT        IDENTITY (1, 1) NOT NULL,
		[username] NCHAR (15) NOT NULL,
		[password] NCHAR (15) NOT NULL,
		[name]     INT        NULL,
		[birth]	   DATETIME   NULL, 
		[list]     NCHAR (10) NULL,
    
		CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED ([id] ASC)
	)
RETURN 0



CREATE PROCEDURE CREATETABLESONG
AS
	CREATE TABLE [dbo].[SONG]
	(
		[id] INT NOT NULL IDENTITY, 
		[name] NVARCHAR(50) NULL, 
		[author] NVARCHAR(50) NULL, 
		[image] NVARCHAR(MAX) NULL, 
		[playing] BIT NOT NULL DEFAULT 0,

		CONSTRAINT [PK_SONG] PRIMARY KEY ([id]), 
	)
RETURN 0

CREATE PROCEDURE CREATETABLEPLAYLIST
AS
	CREATE TABLE [dbo].[PLAYLIST]
	(
		[id] INT NOT NULL IDENTITY, 

		[list] NVARCHAR(MAX) NOT NULL DEFAULT '1', 

		CONSTRAINT [PK_PLAYLIST] PRIMARY KEY ([id]), 
	)
RETURN 0

CREATE PROCEDURE REGISTER
	@username nchar(15),
	@password nchar(15)
AS
	insert into [dbo].[USER] ([username], [password])
		values (@username, @password)
RETURN 0


CREATE PROCEDURE CHANGEUSERINFOR
	@username nchar(15),
	@password nchar(15),
	@name nvarchar(50),
	@age int
AS
	UPDATE [dbo].[USER] SET [password] = @password, [name] = @name, [age] = @age
	WHERE username = @username
RETURN 0


CREATE PROCEDURE ADDSONG
	@name nvarchar(50),
	@author nvarchar(50),
	@image varchar(MAX)
AS
	insert into [dbo].[SONG] ([name], [author], [image])
		values (@name, @author, @image)

RETURN 0

CREATE PROCEDURE GETSONG
	@id int
AS
	select * from [dbo].[SONG] where id = @id
RETURN 0

CREATE PROCEDURE CHECKLOGIN
	@username nchar(15),
	@password nchar(15)
AS
	select * from [dbo].[USER] where [username] = @username and [password] = @password
RETURN 0
