using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer
{

    public enum ToHeadServerMessageType
    {
        ReqLogIn, // REQ_LOGIN
        ReqLogOut,
        ReqSignUp,
        ReqServersList,
        UseMyData,
        Dummy
    }
    public enum ToApplicationClientMessageType                         
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
