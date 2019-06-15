CREATE OR ALTER PROCEDURE [dbo].[get_user_hash]
	@name NVARCHAR(60),
	@hash BINARY(1024) OUTPUT
AS BEGIN
	SELECT @hash = NULL
	SELECT @hash = password_hash FROM users WHERE [name] = @name
	RETURN
END