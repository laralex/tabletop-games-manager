
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide;
using HeadToAppMessageType = CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer.ToApplicationClientMessageType;

namespace HeadServer
{
    internal class AuthenticationConnectionProcessor
    {
        private TcpClient _client;
        private AuthenticationServer.AuthenticationServer _auth;
        public AuthenticationConnectionProcessor(TcpClient tcp_client, AuthenticationServer.AuthenticationServer auth)
        {
            _client = tcp_client;
            _auth = auth;
        }

        public void ProcessLogin()
        {
            _client.Send(HeadToAppMessageType.AckLogInReq);
            while (_client.Available == 0) { Thread.Sleep(100); }
            var request_data = _client.Receive<UserEntry>();
            bool result = _auth.TryLogIn(request_data);
            _client.Send(result ? HeadToAppMessageType.AckLogIn : HeadToAppMessageType.DenyLogIn);
            _client.Close();
            return;
        }

        public void ProcessSignup()
        {
            _client.Send(HeadToAppMessageType.AckSignUpReq);
            while (_client.Available == 0) { Thread.Sleep(100); }
            var request_data = _client.Receive<UserEntry>();
            // FIX ME
            SignupError result = _auth.TrySignUp(IPAddress.Loopback,request_data);
            SignUpResult to_send = null;
            if (result == SignupError.AllOk)
            {
                to_send = new SignUpResult(
                    HeadToAppMessageType.AckSignUp, result);
            }
            else
            {
                to_send = new SignUpResult(
                    HeadToAppMessageType.DenySignUp, result);
            }
            _client.Send(to_send);
            _client.Close();
            return;
        }
    }
}
