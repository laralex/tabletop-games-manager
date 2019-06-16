using CommonLibrary.Model.ServerSide;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class SignUpResult
    {
        public ToApplicationClientMessageType Result;
        public SignupError WhatWrong;

        public SignUpResult(ToApplicationClientMessageType result, SignupError whatWrong)
        {
            Result = result;
            WhatWrong = whatWrong;
        }
    }
}
