CREATE   PROCEDURE [dbo].[insert_dice_game_server]
	@name NVARCHAR(60),
	@max_players INT,
	@ip BigInt,
	@port INT,
	@creator_name NVARCHAR(30),
	@enroll_time DATETIME,
	@turn_time_sec SMALLINT,
	@score_goal INT,
	@dice_number INT = 5,
	@is_joker_allowed BIT = 0,
	@is_active BIT = 1,
	@is_inserted INT OUTPUT
AS BEGIN
	DECLARE @dublicate INT = NULL
	SELECT @dublicate = id FROM [game_servers] WHERE [ip] = @ip AND [port] = @port AND [is_active] = @is_active
	IF @dublicate IS NULL BEGIN
	--IF @creator_id IS NOT NULL
	--[creator_id],
	--@creator_id,
		INSERT INTO game_servers([name],[enroll_time],[is_active],[ip],[port],[max_players])
		VALUES (@name, @enroll_time, @is_active, @ip, @port, @max_players)
		DECLARE @server_id INT = NULL
		SELECT @server_id = IDENT_CURRENT('game_servers')
		IF @server_id IS NOT NULL BEGIN
			INSERT INTO dice_game_servers([server_id],[turn_time_sec],[score_goal], [dice_number], [is_joker_allowed])
			VALUES (@server_id, @turn_time_sec, @score_goal, @dice_number, @is_joker_allowed)
			SELECT @is_inserted = 1
			RETURN
		END
		ELSE BEGIN
			SELECT @is_inserted = 2
			RETURN
		END
	END
	ELSE BEGIN 
		SELECT @is_inserted = 0 
	END
	RETURN 
END