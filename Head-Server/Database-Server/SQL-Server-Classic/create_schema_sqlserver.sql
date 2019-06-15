DROP TABLE dice_game_servers
DROP TABLE game_servers
DROP TABLE users
DROP PROCEDURE [insert_dice_game_server]
DROP PROCEDURE [insert_user]

CREATE TABLE [dbo].[users]
(
	[id] INT NOT NULL UNIQUE IDENTITY(1,1), 
    [name] NVARCHAR(30) NOT NULL PRIMARY KEY, 
    [password_hash] BINARY(1024) NOT NULL, 
    [enroll_time] DATETIME NULL
)


CREATE TABLE [dbo].[game_servers]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] NVARCHAR(60) NOT NULL, 
    [enroll_time] DATETIME NULL, 
    [is_active] BIT NOT NULL, 
    [ip] BIGINT NOT NULL, 
    [port] INT NOT NULL, 
	[max_players] SMALLINT NOT NULL,
)

-- 	[creator_id] INT NULL,
-- 	CONSTRAINT [creator_user_fk] FOREIGN KEY ([creator_id]) REFERENCES [users]([id])

CREATE TABLE [dbo].[dice_game_servers]
(
	[server_id] INT NOT NULL PRIMARY KEY, 
    [turn_time_sec] SMALLINT NULL, 
    [score_goal] INT NOT NULL, 
    [dice_number] INT NOT NULL, 
    [is_joker_allowed] BIT NOT NULL, 
    CONSTRAINT [only_game_server_fk] FOREIGN KEY ([server_id]) REFERENCES [game_servers]([id])
)