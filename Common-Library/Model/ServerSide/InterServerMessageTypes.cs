using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide
{
    public enum ThreadStateType
    {
        Begin,
        Resume,
        Stop,
        End,
        Dummy
    }
    public enum FromGameServerMessageType
    {
        ReqRegister,
        ReqDetach,
        ReqStatusUpdate,
        UseMyData,
        Dummy
        //UseStatus
    }

    public enum ToGameServerMessageType
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

    public enum FromUserMessageType
    {
        ReqLogIn,
        ReqLogOut,
        ReqSignUp,
        ReqServersList,
        UseMyData,
        Dummy
    }
    public enum ToUserMessageType
    {
        AckLogIn,
        AckLogOut,
        AckSignUp,
        AckMyData,
        DenyLogIn,
        DenySignUp,
        DenyServerList,
        UseServerList,
        Dummy
    }
}
