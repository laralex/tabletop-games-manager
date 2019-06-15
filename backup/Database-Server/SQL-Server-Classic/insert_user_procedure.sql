CREATE PROCEDURE [dbo].[insert_user]
	@name NVARCHAR(30),
	@passhash BINARY(1024),
	@enroll_time DATETIME
AS
	INSERT INTO users([name],[password_hash], [enroll_time] )
	VALUES (@name, @passhash, @enroll_time)
RETURN 0

