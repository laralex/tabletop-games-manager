using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide.HeadServerAndGameServer
{
    public enum ToHeadServerMessageType
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
}
