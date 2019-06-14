using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide.ApplicationClientAndGameServer
{
    public enum ToGameServerMessageType
    {
        ReqConnect,
        ReqConfig,
        ReqDisconnect,
        SelectDie,
        GetScoreOfSelection,
        SubmitDice,
        EndTurn,
        Dummy
    }

    public enum ToApplicationClientMessageType
    {
        ReqDisconnect,
        UseConfig,
        AckConnect,
        TurnSwitch,
        Reroll,
        YourTurn,
        Failure,
        PlayerKicked,
        GameEnd,
        GameStart,
        GameShutdown,
        UseScoreOfSelection,
        DiceSubmitted,
        // TODO: ? more
        Dummy
    }
}
