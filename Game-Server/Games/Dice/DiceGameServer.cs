using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using CommonLibrary.Implementation.Games;
using CommonLibrary.Implementation.Games.Dice;
using CommonLibrary.Model.Application;
using CommonLibrary.Model.ServerSide;

using CommonLibrary.Model.Common;
using CommonLibrary.Model.ServerSide.ApplicationClientAndGameServer;
using CommonLibrary.Model.ServerSide.HeadServerAndGameServer;
using GameServer.Debug;
using CommonLibrary.Implementation.ServerSide.Authentication;

namespace GameServer.Games.Dice
{
    internal class DiceGameServer : IGameServer
    {
        public GameType GameType { get => GameType.Dice; }

        public GameOptions GameOptions { get; internal set; }

        public ServerStatus Status { get; private set; }

        public IPEndPoint Socket { get; internal set; }

        public string Name { get; set; }

        public int MaximumPlayers { get => GameOptions.MaxPlayers; }

        public int PlayersNumber { get => _game_controller.Players.Count; }

        public event EventHandler<ThreadStateEventArgs> OnThreadStateChange;
        public event EventHandler<MessageFromHeadServerEventArgs> OnMessageToHeadServer;
        public event EventHandler<MessageToHeadServerEventArgs> OnMessageFromHeadServer;
        public event EventHandler<MessageFromUserEventArgs> OnMessageFromUser;
        public event EventHandler<MessageToUserEventArgs> OnMessageToUser;
        public event EventHandler OnInitialization;
        public event EventHandler OnTermination;

        public DiceGameServer(DiceGameOptions options, string name)
        {
            GameOptions = options;
            Name = name;
        }

        public void Initialize()
        {
            _connected_users = new List<UserSocket>();
            _game_controller = new DiceGameController();

            Status = ServerStatus.Initialized;
            OnInitialization?.Invoke(this, null);
        }

        public void ServerLoop()
        {
            throw new NotImplementedException();
        }

        public bool ConnectUser(IUser user, IPEndPoint socket)
        {

            if (_connected_users.Any((e) => e.User == user))
            {
                return false;
            }

            _connected_users.Add(new UserSocket(user, socket));
            return true;
        }

        public bool DisconnectUser(IUser user)
        {
            return _connected_users.RemoveAll((e) => e.User == user) > 0;
        }

        public void ShutdownGame()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (this.Status == ServerStatus.Initialized)
            {
                this.Status = ServerStatus.Running;
                //this._thread_mre.Set();

                //_network_handling_thread.Start();

                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Begin));
                //_log_console.NetworkThreadMessage(ThreadStateType.Begin); // d

            }
        }

        public void StartNewGame()
        {
            if (_connected_users?.Count >= 1)
            {
                _game_controller.StartupGame(GameOptions, _connected_users);
                _game_controller.StartFirstTurn();
            }
        }

        public void Stop()
        {
            if (Status == ServerStatus.Running)
            {
                Status = ServerStatus.Stopped;
            }
        }

        public void Resume()
        {
            if (this.Status == ServerStatus.Stopped || this.Status == ServerStatus.Initialized)
            {
                //this._thread_mre.Set();
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Resume));
                //_log_console.NetworkThreadMessage(ThreadStateType.Resume); // d
                this.Status = ServerStatus.Running;
            }
        }

        public void Dispose()
        {
            _connected_users = null;
            OnTermination?.Invoke(this, null);
        }

        private List<UserSocket> _connected_users;
        private DiceGameController _game_controller;
    }

}
