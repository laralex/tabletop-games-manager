namespace CommonLibrary.Model.ServerSide
{
    /// <summary>
    /// Codes for messages between GameServer and Client
    /// </summary>
    public enum ClientToGameServerMessage
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

    public enum GameServerToClientMessage
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
