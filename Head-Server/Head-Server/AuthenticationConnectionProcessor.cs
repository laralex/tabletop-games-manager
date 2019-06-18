
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide;

namespace HeadServer
{
    /// <summary>
    /// When head server receives TCP connection with request to 
    /// login or sign up user,
    /// This class's method should be opened in new THREAD
    /// Class will send data asynchronously
    /// </summary>
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
            _client.Send(HeadServerToClientMessage.AckLogInReq);
            while (_client.Available == 0) { Thread.Sleep(50); }
            var request_data = _client.Receive<UserEntry>();
            bool result = _auth.TryLogIn(request_data);
            _client.Send(result ? HeadServerToClientMessage.AckLogIn : HeadServerToClientMessage.DenyLogIn);
            _client.Close();
            return;
        }

        public void ProcessSignup()
        {
            _client.Send(HeadServerToClientMessage.AckSignUpReq);
            while (_client.Available == 0) { Thread.Sleep(50); }
            var request_data = _client.Receive<UserEntry>();
            // FIX ME
            SignupError result = _auth.TrySignUp(IPAddress.Loopback,request_data);
            SignupResult to_send = null;
            if (result == SignupError.AllOk)
            {
                to_send = new SignupResult(
                    HeadServerToClientMessage.AckSignUp, result);
            }
            else
            {
                to_send = new SignupResult(
                    HeadServerToClientMessage.DenySignUp, result);
            }
            _client.Send(to_send);
            _client.Close();
            return;
        }
    }
}
