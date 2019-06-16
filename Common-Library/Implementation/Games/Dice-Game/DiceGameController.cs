using System;
using System.Collections.Generic;
using System.Linq;

using CommonLibrary.Model.Games;
using CommonLibrary.Implementation.ServerSide.Authentication;
using System.Timers;

namespace CommonLibrary.Implementation.Games.Dice
{
    /// <summary>
    /// Class controlls "Dice" game from start to finish
    /// Uses "DiceGameEngine" as tool with useful functions
    /// for implementing game logic
    /// </summary>
    public class DiceGameController
    {
        public event EventHandler<TurnSwitchedEventArgs> TurnSwitched;
        public event EventHandler<TurnSubmittedEventArgs> TurnSubmitted;
        public event EventHandler<GameStartedEventArgs> GameStarted;
        public event EventHandler<GameEndedEventArgs> GameEnded;
        public event EventHandler GameShutdowned;
        //public event EventHandler<PlayerStateEventArgs> PlayerJoined;
        public event EventHandler<PlayerStateEventArgs> PlayerLeft;
        public event EventHandler<PlayerStateEventArgs> SpectatorJoined;
        public event EventHandler<PlayerStateEventArgs> SpectatorLeft;
        public event EventHandler<DiceSelectChangedEventArgs> DiceSelectChanged;
        public event EventHandler<DiceSubmittedEventArgs> DiceSubmitted;
        public event EventHandler<RerollEventArgs> DiceRerolled;
        public event EventHandler<PlayerStateEventArgs> TurnFailure;

        public List<IPlayer> Players { get; private set; } 
        public DiceGameEngine DiceEngine { get; }

        public DiceGameController()
        {
            _timer = new Timer();
            DiceEngine = new DiceGameEngine();
            _is_game_alive = false;
        }

        public void StartupGame(GameOptions options, List<UserSocket> server_users)
        {
            if (options == null)
            {
                throw new InvalidOperationException("Invalid game options");
            }
            if (server_users.Count == 0)
            {
                throw new InvalidOperationException("No users connected");
            }

            DiceGameOptions dice_options = options as DiceGameOptions;
            _current_game_options = dice_options;

            List<IPlayer> players = 
                server_users.GetRange(0,Math.Min(dice_options.MaxPlayers, server_users.Count))
                .ConvertAll( (e) => new DiceGamePlayer(e.User.LoginName, 0) as IPlayer ); 
            // Send to picked users event of started game

            DiceEngine.SetPlayers(players, 0);
            DiceEngine.CreateDice(dice_options.DiceNumber);

            _timer.Interval = dice_options.TurnTimeSecs * 1000;
            _timer.AutoReset = true;
            _timer.Enabled = false;
            _timer.Elapsed += OnTimerElapsed;

            _is_game_alive = true;

            GameStarted?.Invoke(
                this,
                new GameStartedEventArgs(players.ToArray())
            );

            StartFirstTurn(players.First());
        }

        public void KickPlayer(IPlayer player)
        {
            if ((DiceGamePlayer)player == DiceEngine.CurrentPlayer)
            {
                DiceEngine.KickPlayer(player);
                SwitchTurn();
            }

        }

        public void StartFirstTurn(IPlayer first_player = null)
        {
            if (first_player == null)
            {
                first_player = Players.First();
            }
            DiceEngine.SwitchTurnTo(first_player);
            DiceEngine.CurrentPlayerTurnScore = 0;
            TurnSwitched?.Invoke(
                this,
                new TurnSwitchedEventArgs(null, first_player)
            );

            DiceEngine.Reroll(DiceEngine.AllDice);
            if (DiceEngine.IsCurrentDiceFailure())
            {
                TurnFailure?.Invoke(
                    this,
                    new PlayerStateEventArgs(first_player)
                );
            }
            _timer.Enabled = true;
            _timer.Start();
        }

        public int GetScoreGainOf(List<Die> dice)
        {
            return DiceEngine.CalculateGainOf(dice).TotalScore;
        }

        public void SubmitDice(List<Die> dice)
        {
            if (dice == null || dice.Count == 0)
            {
                return;
            }

            var combos_result = DiceEngine.CalculateGainOf(dice);

            DiceEngine.CurrentPlayerTurnScore += combos_result.TotalScore;

            DiceSubmitted?.Invoke(
                this, 
                new DiceSubmittedEventArgs(combos_result, DiceEngine.CurrentPlayerTurnScore)
            );

            var to_reroll = DiceEngine.SelectedDice;
            DiceEngine.Reroll(to_reroll);

            DiceRerolled?.Invoke(
                this, 
                new RerollEventArgs(to_reroll)
            );

            IfFailureSwitchTurn();
        }

        public void SwitchTurn()
        {
            _timer.Enabled = false;
            _timer.Stop();

            IPlayer old_player = DiceEngine.CurrentPlayer;

            DiceEngine.SwitchTurnToNextPlayer();
            DiceEngine.CurrentPlayerTurnScore = 0;

            TurnSwitched?.Invoke(
                this,
                new TurnSwitchedEventArgs(old_player, DiceEngine.CurrentPlayer)
            );

            var all_dice = DiceEngine.AllDice;
            DiceEngine.DeselectAll();
            DiceEngine.Reroll(all_dice);

            DiceRerolled?.Invoke(
                this,
                new RerollEventArgs(all_dice)
            );

            _timer.Stop();
            _timer.Start();
            _timer.Enabled = true;
        }

        public void SubmitSelected()
        {
            SubmitDice(DiceEngine.SelectedDice);
        }

        public void SubmitTurn()
        {
            SubmitSelected();

            DiceEngine.CurrentPlayer.Score += DiceEngine.CurrentPlayerTurnScore;

            TurnSubmitted?.Invoke(
                this,
                new TurnSubmittedEventArgs(DiceEngine.CurrentPlayer, DiceEngine.CurrentPlayer.Score)
            );

            if (DidCurrentWinByScore())
            {
                EndGame(DiceEngine.CurrentPlayer);
                return;
            }
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            SubmitTurn();
            SwitchTurn();
        }

        public bool DidCurrentWinByScore()
        {
            return DiceEngine.CurrentPlayer.Score > _current_game_options.ScoreGoal;
        }

        public void ShutdownGame()
        {
            _is_game_alive = false;
            _timer.Enabled = false;
            GameShutdowned?.Invoke(
                this,
                null
            );
        }

        public void EndGame(IPlayer winner = null)
        {
            if (winner == null)
            {
                winner = DiceEngine.CurrentPlayer;
            }
            _is_game_alive = false;
            _timer.Enabled = false;
            GameEnded?.Invoke(this, new GameEndedEventArgs(winner));
        }
        
        public void IfFailureSwitchTurn()
        {
            if (DiceEngine.IsCurrentDiceFailure())
            {
                DiceEngine.CurrentPlayerTurnScore = 0;

                TurnFailure?.Invoke(
                    this,
                    new PlayerStateEventArgs(DiceEngine.CurrentPlayer)
                );

                SwitchTurn();
            }
        }

        private DiceGameOptions _current_game_options;
        private Timer _timer;
        private bool _is_game_alive;
    }
}
