CREATE PROCEDURE [dbo].[insert_dice_game_server]
	@name NVARCHAR(60),
	@max_players INT,
	@ip INT,
	@port INT,
	@creator_name NVARCHAR(30),
	@enroll_time DATETIME,
	@turn_time_sec INT,
	@score_goal INT,
	@dice_number INT = 5,
	@is_joker_allowed BIT = 0,
	@is_active BIT = 1
AS
	
	DECLARE @creator_id INT
	SELECT @creator_id = id FROM users WHERE [name] = @creator_name
	IF @creator_id IS NOT NULL
		INSERT INTO game_servers([name],[enroll_time],[is_active],[ip],[port],[creator_id],[max_players])
		VALUES (@name, @enroll_time, @is_active, @ip, @port, @creator_id, @max_players)
		DECLARE @server_id INT = IDENT_CURRENT('game_servers.id')
		IF @server_id IS NOT NULL
		INSERT INTO dice_game_servers([server_id],[turn_time_sec],[score_goal], [dice_number], [is_joker_allowed])
		VALUES (@server_id, @turn_time_sec, @score_goal, @dice_number, @is_joker_allowed)
RETURN 0
