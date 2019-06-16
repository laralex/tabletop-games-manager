namespace CommonLibrary.Model.ServerSide
{
    /// <summary>
    /// Codes for messages between GameServer and HeadServer
    /// </summary>
    public enum GameToHeadServerMessage
    {
        ReqRegister,
        ReqDetach,
        ReqStatusUpdate,
        UseMyData,
        Dummy
        //UseStatus
    }

    public enum HeadToGameServerMessage
    {
        AckRegister,
        AckMyData,
        AckDetach,
        AckStatusUpdate,
        AckStatusData,
        DenyRegister,
        DenyMyData,
        DenyStatusUpdate,
        DenyStatusData,
        Dummy
    }
}
