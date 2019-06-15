using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CommonLibrary.Implementation.Crypto;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;
using GameClient.GUI.Application;
using GameClient.GUI.Login;
using GameClient.ServerSide;

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
            _head_connection = new HeadServerMessenger();

            FrontEndForm.Login += Login;
            FrontEndForm.Signup += Signup;

        }

        private void Login(object sender, LoginFormEventArgs e)
        {
            var passw_hash = ShaEncryptor.Encrypt(e.PasswordText);
            // TODO: get user's hash from DB
            var entry = new UserEntry(e.Username, passw_hash);
            /*_head_connection.SendMessage(
                ToHeadServerMessageType.ReqLogIn,
                entry
            );

            _head_connection.GetMessage();
            switch (_head_connection.MessageType)
            {
                case ToApplicationClientMessageType.AckLogIn:
                    _current_login_data = entry;
                    _frontend.Reset();
                    _frontend.Close();
                    break;
                case ToApplicationClientMessageType.DenyLogIn:
                    _frontend.FailLogin();
                    break;
                // TODO: login, provide user info to app
                // TODO: pass to a next form
                
            }
            */
            FrontEndForm.Reset();
            FrontEndForm.Visible = false;

            _current_login_data = entry;
            NextForm = new AppFormDemo(this);

            //FrontEndForm.Close();
            NextForm.Show();

        }

        private void Signup(object sender, LoginFormEventArgs e)
        {
            /*
            var passw_hash = ShaEncryptor.Encrypt(e.PasswordText);
            // TODO: if user does not exist ...
            _head_connection.SendMessage(
               ToHeadServerMessageType.ReqSignUp,
               null
            );
            _head_connection.GetMessage();
            var entry = new UserEntry(e.Username, passw_hash);
            // TODO: add in DB
            switch(_head_connection.MessageType)
            {
                case ToApplicationClientMessageType.AckSignUp:
                // TODO: login, provide user info to app
                    _head_connection.SendMessage(
                        ToHeadServerMessageType.UseMyData,
                        entry
                    );
                    _head_connection.GetMessage();
                    if (_head_connection.MessageType == ToApplicationClientMessageType.AckMyData)
                    {
                        // TODO: login action
                        Login(this, e);
                        // TODO: pass to a next form
                        NextForm.Show();
                    }
                    else
                    {
                        _frontend.FainSignup(_head_connection.Message);
                    }
                    break;
                case ToApplicationClientMessageType.DenySignUp:
                    _frontend.FainSignup(_head_connection.Message);
                    break;
                
            }
            */
            
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

        private HeadServerMessenger _head_connection;

        private UserEntry _current_login_data;
    }

}
