
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameClient.Application;

namespace GameClient.GUI.Application
{
    internal partial class AppFormDemo : Form
    {
        public AppFormDemo(AuthenticationBackend auth)
        {
            InitializeComponent();
            _auth_controller = auth;
            statusLobbyUser.Text = "User: " + _auth_controller.ConnectedUser;
            var lobby = tabsControl.TabPages[0];
            tabsControl.TabPages.Clear();
            tabsControl.TabPages.Add(lobby);

            _lobby_controller = new LobbyBackend(this.lobbyServersList);
        }

        private void OnMenuAbout(object sender, EventArgs e)
        {
            new AboutBox().Show(this);
        }

        private void GreateGameView()
        {

        }

        private AuthenticationBackend _auth_controller;
        private LobbyBackend _lobby_controller;

        private void OnLogOut(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            _auth_controller.FrontEndForm.Show();
        }
    }
}
