using CommonLibrary.Model.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameClient
{
    [Serializable]
    internal class GameClientIdentifier : SubsystemIdentifier
    {
        public GameClientIdentifier() => _identifier = "GAME_CLIENT";
    }
}
