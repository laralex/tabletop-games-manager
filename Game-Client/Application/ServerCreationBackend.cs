using System;
using System.Net;
using CommonLibrary.Implementation.Games;
using CommonLibrary.Implementation.Networking.Uitlities;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Implementation.ServerSide.Authentication;
using GameClient.GUI.ServerManager.ServerCreator;
using CommonLibrary.Implementation.Networking.Tcp;

using GameServer;

namespace GameClient.Application
{
    internal class ServerCreationBackend
    {
        public ServerCreationBackend(UserEntry current_user)
        {
            _creator = current_user;
            _frontend = new ServerCreationForm();
            _frontend.Show();
            _frontend.OptionsSubmitted += OnOptionsSubmitted;
        }

        private void OnOptionsSubmitted(object sender, ServerCreationEventArgs e)
        {
            // create server
            e.Options.CreatorName = _creator.LoginName;
            e.Options.IsActive = true;
            IPAddress my_ip = HostConfigRetriever.GetLocalOutsideIP();
            int game_server_port = new Random().Next(40000, 65000);
            e.Options.Socket = new IPEndPoint(my_ip, game_server_port);

            GameServer.EntryPoint.Main(nu)

        }

        public GameServerEntry GetOptions()
        {
            if (_frontend.FieldsFilled)
            {
                _frontend
            }
        }
        private ServerCreationForm _frontend;
        private UserEntry _creator;
    }
}
