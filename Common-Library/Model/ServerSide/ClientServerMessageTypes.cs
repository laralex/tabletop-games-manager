using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide
{
    public enum GameClientToServerMessageType
    {
        ReqConnect,
        ReqConfig,
        ReqDisconnect,
        Dummy
    }

    public enum GameServerToClientMessageType
    {
        ReqDisconnect,
        UseConfig,
        AckConnect
    }
}
