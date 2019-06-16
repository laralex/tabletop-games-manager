using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CommonLibrary.Implementation.Crypto;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;
using CommonLibrary.Implementation.Networking.Tcp;
using GameClient.GUI.Application;
using GameClient.GUI.Login;
using System.Net.Sockets;
using System.Threading;
using CommonLibrary.Model.ServerSide;
using CommonLibrary.Implementation.Networking.Serializing;

namespace GameClient.Application
{
    internal class AuthenticationBackend
    {

        public Form NextForm { get; set; }
        public LoginForm FrontEndForm { get; }

        public string ConnectedUser { get => _current_login_data.LoginName; }

        public AuthenticationBackend()
        {
            FrontEndForm = new LoginForm();
            //_head_connection = new HeadServerMessenger();

            FrontEndForm.Login += Login;
            FrontEndForm.Signup += Signup;

        }

        private void Login(object sender, LoginFormEventArgs e)
        {
            FrontEndForm.Enabled = false;
            var passw_hash = ShaEncryptor.Encrypt(e.PasswordText);
            var entry = new UserEntry(e.Username, passw_hash);

            var to_head_client = EntryPoint.InitHeadTcpClient();

            // wait release of socket
            while (to_head_client.Connected) { }

            using (to_head_client)
            {
                try
                {
                    to_head_client.Connect(EntryPoint.HeadTcpEndPoint);
                    if (to_head_client.Connected)
                    {
                        to_head_client.Send(ToHeadServerMessageType.ReqLogIn);
                        while (to_head_client.Available == 0) { Thread.Sleep(100); }
                        var response = to_head_client.Receive<ToApplicationClientMessageType>();
                        if (response == null || response != ToApplicationClientMessageType.AckLogInReq)
                        {
                            FrontEndForm.FailLogin(LoginError.HeadServerUnavailable);
                            return;
                        }
                        to_head_client.Send(entry);
                        while (to_head_client.Available == 0) { Thread.Sleep(100); }
                        response = to_head_client.Receive<ToApplicationClientMessageType>();
                        if (response == null)
                        {
                            FrontEndForm.FailLogin(LoginError.HeadServerUnavailable);
                            return;
                        }
                        switch (response)
                        {
                            case ToApplicationClientMessageType.AckLogIn:
                                FrontEndForm.Reset();
                                FrontEndForm.Visible = false;

                                _current_login_data = entry;
                                NextForm = new AppFormDemo(this);

                                NextForm.Show(); ;
                                break;
                            case ToApplicationClientMessageType.DenyLogIn:
                                FrontEndForm.FailLogin(LoginError.WrongEntry);
                                break;
                        }
                    }
                }
                catch (SocketException exc)
                {
                    MessageBox.Show("Head-server is unavailable");
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
            // wait release of socket
            while (to_head_client.Connected) { }

            using (to_head_client)
            {
                try
                {
                    to_head_client.Connect(EntryPoint.HeadTcpEndPoint);
                    if (to_head_client.Connected)
                    {
                        to_head_client.Send(ToHeadServerMessageType.ReqSignUp);
                        while (to_head_client.Available == 0) { Thread.Sleep(100); }
                        var response = to_head_client.Receive<ToApplicationClientMessageType>();
                        if (response == null || response != ToApplicationClientMessageType.AckSignUpReq)
                        {
                            FrontEndForm.FailSignup(SignupError.HeadServerUnavailable);
                            return;
                        }
                        to_head_client.Send(entry);
                        while (to_head_client.Available == 0) { Thread.Sleep(100); }
                        var signup_response = to_head_client.Receive<SignUpResult>();
                        if (signup_response == null)
                        {
                            FrontEndForm.FailSignup(SignupError.HeadServerUnavailable);
                            return;
                        }
                        switch (signup_response.Result)
                        {
                            case ToApplicationClientMessageType.AckSignUp:
                                FrontEndForm.Reset();
                                FrontEndForm.Visible = false;

                                _current_login_data = entry;
                                NextForm = new AppFormDemo(this);

                                NextForm.Show();
                                break;
                            case ToApplicationClientMessageType.DenySignUp:
                                FrontEndForm.FailSignup(signup_response.WhatWrong);
                                break;
                        }
                    }
                }
                catch (SocketException exc)
                {
                    MessageBox.Show("Head-server is unavailable");
                }
            }
            FrontEndForm.Enabled = true;
        }

        public void Logout()
        {
            /*
            _head_connection.SendMessage(
               ToHeadServerMessageType.ReqLogOut,
               _current_login_data
            );
            */
        }

        public void Show()
        {
            FrontEndForm?.Show();
        }

        private UserEntry _current_login_data;
    }

}
