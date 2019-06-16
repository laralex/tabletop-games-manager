using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer
{

    public enum ToHeadServerMessageType
    {
        Dummy,
        ReqLogIn, // REQ_LOGIN
        ReqLogOut,
        ReqSignUp,
        ReqServersList,
        UseMyData,
    }
    public enum ToApplicationClientMessageType                         
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
