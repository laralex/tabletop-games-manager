using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Implementation;
using CommonLibrary.Model.Application;

namespace CommonLibrary.Implementation.Networking
{
    public enum GameServerStatus
    {
        ConnectingToHost,
        WaitingToStartGame,
        RunningGame,
        PausedGame,
        PausedEverything,
        Uninitialized
    }
    public abstract class GameServer
    {
        protected int DatabaseId { get; set; }
        public string Name { get; protected set; }
        public IUser Creator { get; protected set; }
        public GameServerStatus Status { get; protected set; }
    }
}
