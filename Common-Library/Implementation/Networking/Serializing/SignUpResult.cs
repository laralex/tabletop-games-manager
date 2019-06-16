using System;
using CommonLibrary.Model.ServerSide;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// When client tries to sign up,
    /// error codes are sent by Head Server
    /// </summary>
    [Serializable]
    public class SignupResult
    {
        public HeadServerToClientMessage Result;
        public SignupError WhatWrong;

        public SignupResult(HeadServerToClientMessage result, SignupError whatWrong)
        {
            Result = result;
            WhatWrong = whatWrong;
        }
    }
}
