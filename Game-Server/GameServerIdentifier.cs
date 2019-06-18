using CommonLibrary.Model.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    internal class GameServerIdentifier : SubsystemIdentifier
    {
        public GameServerIdentifier() {
            _identifier = "GAME_SERVER";
        }
    }
}
