using System.Windows.Forms;

using CommonLibrary.Implementation.Crypto;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Implementation.Networking.Tcp;
using GameClient.GUI.Application;
using GameClient.GUI.Login;
using System.Net.Sockets;
using System.Threading;
using CommonLibrary.Model.ServerSide;
using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Implementation.ServerSide;

namespace GameClient.Application
{

    /// <summary>
    /// Backend class for managing "Login/Signup" form in application
    /// </summary>
    internal class AuthenticationBackend
    {

        public Form NextForm { get; set; }
        public LoginForm FrontEndForm { get; }

        public string ConnectedUser { get => _current_login_data.LoginName; }

        public AuthenticationBackend()
        {
            FrontEndForm = new LoginForm();

            FrontEndForm.Login += Login;
            FrontEndForm.Signup += Signup;

        }

        private void Login(object sender, LoginFormEventArgs e)
        {
            FrontEndForm.Enabled = false;
            var passw_hash = ShaEncryptor.Encrypt(e.PasswordText);
            var entry = new UserEntry(e.Username, passw_hash);

            var to_head_client = EntryPoint.InitHeadTcpClient();
            if (!ConnectionProtocolUtility.SendGreetings(to_head_client, EntryPoint.HeadTcpEndPoint, EntryPoint.ProjectIdentifier))
            {
                MessageBox.Show("Head-server is unavailable");
                return;
            }
            using (to_head_client)
            {
                if (to_head_client.Connected)
                {
                    to_head_client.Send(ClientToHeadServerMessage.ReqLogIn);
                    while (to_head_client.Available == 0) { Thread.Sleep(50); }
                    var response = to_head_client.Receive<HeadServerToClientMessage>();
                    if (response == null || response != HeadServerToClientMessage.AckLogInReq)
                    {
                        FrontEndForm.FailLogin(LoginError.HeadServerUnavailable);
                        return;
                    }
                    to_head_client.Send(entry);
                    while (to_head_client.Available == 0) { Thread.Sleep(50); }
                    response = to_head_client.Receive<HeadServerToClientMessage>();
                    if (response == null)
                    {
                        FrontEndForm.FailLogin(LoginError.HeadServerUnavailable);
                        return;
                    }
                    switch (response)
                    {
                        case HeadServerToClientMessage.AckLogIn:
                            FrontEndForm.Reset();
                            FrontEndForm.Visible = false;

                            _current_login_data = entry;
                            NextForm = new AppForm(this);

                            NextForm.Show(); ;
                            break;
                        case HeadServerToClientMessage.DenyLogIn:
                            FrontEndForm.FailLogin(LoginError.WrongEntry);
                            break;
                    }
                }
            }
            FrontEndForm.Enabled = true;
        }

        private void Signup(object sender, LoginFormEventArgs e)
        {
            FrontEndForm.Enabled = false;
            var passw_hash = ShaEncryptor.Encrypt(e.PasswordText);
            var entry = new UserEntry(e.Username, passw_hash);

            var to_head_client = EntryPoint.InitHeadTcpClient();
            if (!ConnectionProtocolUtility.SendGreetings(to_head_client, EntryPoint.HeadTcpEndPoint, EntryPoint.ProjectIdentifier))
            {
                MessageBox.Show("Head-server is unavailable");
                return;
            }
            using (to_head_client)
            {
                if (to_head_client.Connected)
                {
                    to_head_client.Send(ClientToHeadServerMessage.ReqSignUp);
                    while (to_head_client.Available == 0) { Thread.Sleep(100); }
                    var response = to_head_client.Receive<HeadServerToClientMessage>();
                    if (response == null || response != HeadServerToClientMessage.AckSignUpReq)
                    {
                        FrontEndForm.FailSignup(SignupError.HeadServerUnavailable);
                        return;
                    }
                    to_head_client.Send(entry);
                    while (to_head_client.Available == 0) { Thread.Sleep(100); }
                    var signup_response = to_head_client.Receive<SignupResult>();
                    if (signup_response == null)
                    {
                        FrontEndForm.FailSignup(SignupError.HeadServerUnavailable);
                        return;
                    }
                    switch (signup_response.Result)
                    {
                        case HeadServerToClientMessage.AckSignUp:
                            FrontEndForm.Reset();
                            FrontEndForm.Visible = false;

                            _current_login_data = entry;
                            NextForm = new AppForm(this);

                            NextForm.Show();
                            break;
                        case HeadServerToClientMessage.DenySignUp:
                            FrontEndForm.FailSignup(signup_response.WhatWrong);
                            break;
                    }
                }
            }
            FrontEndForm.Enabled = true;
        }

        public void Show()
        {
            FrontEndForm?.Show();
        }

        private UserEntry _current_login_data;
    }

}
