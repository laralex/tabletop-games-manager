using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Implementation.Games.Dice;
using CommonLibrary.Implementation.Games.Dice.Combos;
using CommonLibrary.Model.Games;
using CommonLibrary.Model.Games.Dice;
using CommonLibrary.Model.Application;
using System.Timers;

namespace CommonLibrary.Implementation.Games.Dice
{
    public class DiceGameController
    {
        public event EventHandler<TurnSwitchedEventArgs> TurnSwitched;
        public event EventHandler<TurnSubmittedEventArgs> TurnSubmitted;
        public event EventHandler<GameStartedEventArgs> GameStarted;
        public event EventHandler<GameEndedEventArgs> GameEnded;
        public event EventHandler GameShutdowned;
        public event EventHandler<PlayerStateEventArgs> PlayerJoined;
        public event EventHandler<PlayerStateEventArgs> PlayerLeaved;
        public event EventHandler<PlayerStateEventArgs> SpectatorJoined;
        public event EventHandler<PlayerStateEventArgs> SpectatorLeaved;
        public event EventHandler<DiceSelectChangedEventArgs> DiceSelectChanged;
        public event EventHandler<DiceSubmittedEventArgs> DiceSubmitted;
        public event EventHandler<RerollEventArgs> DiceRerolled;
        public event EventHandler<PlayerStateEventArgs> TurnFailure;

        public List<IUser> ConnectedUsers { get; internal set; }

        public DiceGameController()
        {
            _engine = new DiceGameEngine();
            ConnectedUsers = new List<IUser>();
        }

        public void StartupGame(GameOptions options)
        {
            var dice_options = options as DiceGameOptions;
            _current_game_options = dice_options;

            List<IPlayer> players = 
                ((List<IUser>)ConnectedUsers.Take(dice_options.MaxPlayers))
                .ConvertAll( (e) => new DiceGamePlayer(e.LoginName, 0) as IPlayer ); 
            // Send to picked users event of started game

            _engine.SetPlayers(players, 0);
            _engine.CreateDice(dice_options.DiceNumber);
            // _engine.

            _timer.AutoReset = false;
            _timer.Elapsed += OnTimerElapsed;

            GameStarted?.Invoke(
                this,
                new GameStartedEventArgs(players.ToArray())
            );
        }

        public void SubmitDice(List<Die> dice)
        { 
            var combos_result = _engine.CalulateGainOf();
            _engine.CurrentPlayer.AddScore(combos_result.TotalScore);
            DiceSubmitted?.Invoke(this, new DiceSubmittedEventArgs(combos_result));

            var to_reroll = _engine.SelectedDice;
            _engine.Reroll(to_reroll);
            DiceRerolled?.Invoke(this, new RerollEventArgs(to_reroll));

            if (_engine.IsFailure())
            {

                TurnFailure?.Invoke(this, new PlayerStateEventArgs(_engine.CurrentPlayer));
            }
        }

        public void SwitchTurn()
        {
            OnTimerElapsed(this, null);
        }

        private 

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _engine.SubmitTurnScore();
            if (DidCurrentWin())
            {
                EndGame(_engine.CurrentPlayer);
                return;
            }

            int old_score = _engine.CurrentPlayer.Score;
            IPlayer old_player = _engine.CurrentPlayer;

            _engine.SwitchTurnToNextPlayer();
            TurnSwitched?.Invoke(
                this,
                new TurnSwitchedEventArgs(old_player, _engine.CurrentPlayer)
            );

            var all_dice = _engine.AllDice;
            _engine.Reroll(all_dice);
            DiceRerolled?.Invoke(this, new RerollEventArgs(all_dice));
            TurnSubmitted?.Invoke(this, new TurnSubmittedEventArgs(old_player, old_score));
            Turn
        }

        public void ShutdownGame()
        {
            _is_game_alive = false;
            GameShutdowned?.Invoke(
                this,
                null
            );
        } 

        public bool DidCurrentWin()
        {
            return _engine.CurrentPlayer.Score > _current_game_options.ScoreGoal;
        }

        public void EndGame(IPlayer winner = null)
        {
            if (winner == null)
            {
                winner = _engine.CurrentPlayer;
            }
            _is_game_alive = false;
            GameEnded?.Invoke(this, new GameEndedEventArgs(winner));
        }
        
        private DiceGameEngine _engine;
        private DiceGameOptions _current_game_options;
        private Timer _timer;
        private bool _is_game_alive;
    }
}
