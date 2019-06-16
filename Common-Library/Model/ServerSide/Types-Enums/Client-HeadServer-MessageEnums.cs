namespace CommonLibrary.Model.ServerSide
{
    /// <summary>
    /// Codes for messages between HeadServer and Client
    /// </summary>
    public enum ClientToHeadServerMessage
    {
        Dummy,
        ReqLogIn, // REQ_LOGIN
        ReqLogOut,
        ReqSignUp,
        ReqServersList,
        UseMyData,
    }
    public enum HeadServerToClientMessage                         
    {
        Dummy,
        AckLogInReq,
        AckLogIn,
        AckLogOut,
        AckSignUp,
        AckSignUpReq,
        AckMyData,
        DenyLogIn,
        DenySignUp,
        DenyServerList,
        UseServerList,
    }
}
