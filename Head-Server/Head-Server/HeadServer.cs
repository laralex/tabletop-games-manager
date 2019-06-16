using System;
using System.Collections.Generic;
using System.Linq;

using System.Net.Sockets;
using System.Net;

using System.Timers;
using System.Threading;

using CommonLibrary.Implementation.Common;
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Model.ServerSide;

using HeadServer.DB;

namespace HeadServer
{
    
     /// <summary>
     /// Head server - registers game servers,
     /// authenticates users, manages main database
     /// </summary>
    internal class HeadServer : IServer // INetworkSender
    {
        public ServerStatus Status { get; internal set; }
        public IPEndPoint Socket { get; internal set; }
        public TimeSpan RecentIPsUpdateRate { get; set; }
        public AuthenticationServer.AuthenticationServer AuthServer { get; private set; }
        public DB.DatabaseServer DbServer { get; private set; }

        public event EventHandler<ThreadStateEventArgs> OnThreadStateChange;
        public event EventHandler<MessageFromGameServerEventArgs> OnMessageFromGameServer;
        public event EventHandler<MessageToGameServerEventArgs> OnMessageToGameServer;
        public event EventHandler<MessageFromUserEventArgs> OnMessageFromUser;
        public event EventHandler<MessageToUserEventArgs> OnMessageToUser;
        public event EventHandler OnInitialization;
        public event EventHandler OnTermination;

        public HeadServer(IPEndPoint head_end_point)
        {
            Socket = head_end_point;
            Status = ServerStatus.Uninitialized;
            
            RecentIPsUpdateRate = new TimeSpan(hours: 0, minutes: 0, seconds: 30);
        }

        public void Initialize()
        {
            _timer = new System.Timers.Timer(RecentIPsUpdateRate.TotalMilliseconds);
            _timer.Elapsed += OnTimerIntervalElapsed;

            _recent_server_creators_IPs = new Queue<TimestampedIP>();
            
            _tcp_listener = new TcpListener(Socket);

            DbServer = new DatabaseServer();
            AuthServer = new AuthenticationServer.AuthenticationServer(_tcp_listener, DbServer);

            DbServer.Initialize();

            _registered_servers = DbServer.SelectActiveGameServers();

            AuthServer.Initialize();

            _thread_mre = new ManualResetEvent(false);
            _main_mre = new ManualResetEvent(false);

            _network_handling_thread = new Thread(ServerLoop);
            _network_handling_thread.IsBackground = false;

            

            Status = ServerStatus.Initialized;
            OnInitialization?.Invoke(this, null);
        }
        public void ServerLoop()
        {
            while (true)
            {
                _thread_mre.WaitOne();
                TcpClient client = _tcp_listener.AcceptTcpClient();
                /*if (_registered_servers == null || _registered_servers.Count == 0)
                {
                    _registered_servers = DbServer.SelectActiveGameServers();
                } */

                var request = client.Receive<ClientToHeadServerMessage>();
                Thread clientThread = null;
                switch (request)
                {
                    case ClientToHeadServerMessage.ReqServersList:
                        var servers_list = DbServer.SelectActiveGameServers();
                        var servers_list_handler = new ServersListConnectionProcessor(client, servers_list);
                        clientThread = new Thread(
                            new ThreadStart(servers_list_handler.ProcessConnection)
                        );
                        break;
                    case ClientToHeadServerMessage.ReqLogIn:
                        var to_app_message_handler = new AuthenticationConnectionProcessor(
                            client,
                            AuthServer
                        );
                        clientThread = new Thread(
                            new ThreadStart(to_app_message_handler.ProcessLogin)
                        );
                        break;
                    case ClientToHeadServerMessage.ReqSignUp:
                        to_app_message_handler = new AuthenticationConnectionProcessor(
                            client,
                            AuthServer
                        );
                        clientThread = new Thread(
                            new ThreadStart(to_app_message_handler.ProcessSignup)
                        );
                        break;
                }
                clientThread?.Start();
            }
        }

        public void Stop()
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
            }
            if (this.Status == ServerStatus.Running)
            {
                this.AuthServer.Stop();
                this.DbServer.Stop();
                this._thread_mre.Reset();
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(CommonLibrary.Model.Common.ThreadState.Stop));
                this.Status = ServerStatus.Stopped;
            }
        }

        public void Start()
        {
            if (this.Status == ServerStatus.Initialized)
            {
                _timer.Start();
                this.DbServer.Start();
                this.AuthServer.Start();
                this.Status = ServerStatus.Running; 
                this._thread_mre.Set();

                _tcp_listener.Start();
                _network_handling_thread.Start();

                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(CommonLibrary.Model.Common.ThreadState.Begin));

            }
            
        }

        public void Resume()
        {
            if (!_timer.Enabled)
            {
                _timer.Start();
            }
            if (this.Status == ServerStatus.Stopped || this.Status == ServerStatus.Initialized)
            {
                this.DbServer.Start();
                this.AuthServer.Start();
                this._thread_mre.Set();
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(CommonLibrary.Model.Common.ThreadState.Resume));
                this.Status = ServerStatus.Running;
            }
        }

        public void Dispose()
        {
            //_main_mre.WaitOne();

            Stop();
            _timer.Dispose();

            _registered_servers = null;
            _recent_server_creators_IPs = null;

            AuthServer.Dispose();
            AuthServer = null;

            DbServer.Dispose();
            DbServer = null;
            Socket = null;

            Status = ServerStatus.Uninitialized;

            OnTermination?.Invoke(this, null);
        }

        private bool TryRegisterServer(IPAddress who_requests, DiceGameServerEntry new_server)
        {
            if (IsRecentIp(who_requests) || !DbServer.InsertDiceGameServer(new_server))
            {
                return false;
            }
            _recent_server_creators_IPs.Enqueue(new TimestampedIP(who_requests, DateTime.UtcNow));
            OnMessageToGameServer?.Invoke(
                this, 
                new MessageToGameServerEventArgs(new_server, HeadToGameServerMessage.AckRegister)
            );
            return true;
        }

        private void OnTimerIntervalElapsed(object sender, ElapsedEventArgs e)
        {
            // If <now> is older than threshold of first queue item's timestamp
            _registered_servers = null;
            while (_recent_server_creators_IPs.Count > 0 && DateTime.UtcNow.CompareTo(_recent_server_creators_IPs.Peek().AdditionTime.Add(RecentIPsUpdateRate)) > 0)
            {
                _recent_server_creators_IPs.Dequeue();
            }
        }

        private bool IsRecentIp(IPAddress who_requests)
        {
            return _recent_server_creators_IPs.Any((e) => e.IP.Equals(who_requests));
        }

        private System.Timers.Timer _timer;
        private List<GameServerEntry> _registered_servers;
        private Queue<TimestampedIP> _recent_server_creators_IPs;

        // net
        private TcpListener _tcp_listener; 

        // threading
        private ManualResetEvent _thread_mre;
        private ManualResetEvent _main_mre;
        private Thread _network_handling_thread;
    }
}



/* Test and Debug
 * 
 * 
 *  
                /*OnMessageFromUser?.Invoke(
                    this, 
                    new MessageFromUserEventArgs(
                        new CommonLibrary.Implementation.ServerSide.Authentication.UserEntry("testname", null),
                        CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer.ToHeadServerMessageType.ReqServersList
                    )
                );

 /*

 if (Status == ServerStatus.Uninitialized)
 {
     OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.End));
     _main_mre.Set();
     _main_mre.Reset();
     // Thread termination
     return;
 }

 _tcp_listener

 ParseMessageType();
 OnThreadStateChange.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Dummy));
 Thread.Sleep(800);
 //while (!_received) Thread.Sleep(500);
 //_received = false;
 // TODO: Get Messages

 *
 * 
 * 
        private void FillGameServerFields(DB.GameServer db_server_record, GameServerEntry new_server_enroll)
        {
            //DB.GameServer db_server = new DB.GameServer();
            db_server_record.Name = new_server_enroll.Name;
            db_server_record.Creator = AuthServer.DatabaseSelectUser(new_server_enroll.CreatorName);
            db_server_record.RegisterTime = DateTime.UtcNow;
            db_server_record.IsActive = new_server_enroll.IsActive;
            db_server_record.Socket = new_server_enroll.Socket;
        }
        */
/*
private DB.GameServer DatabaseSelectOneServer(GameServerEntry server_enroll)
{
    return _db_server.Context.GameServers
        .Single(e => e.Name == server_enroll.Name);
}

private bool DatabaseIsServerRegistered(GameServerEntry server_enroll)
{
    return DatabaseSelectOneServer(server_enroll) == null;
}  

            // FIXME: anyone can detach server
        private bool TryDetachServer(GameServerEntry server)
        {
            //DbServer.SetServerIsActive(server, false);
            /*if (_registered_servers == null)
            {
                _registered_servers = DbServer.SelectActiveGameServers();
            }
            int found_server_idx = _registered_servers.FindIndex(e => e.Name == server.Name);
            if (found_server_idx >= 0)
            {
                OnMessageToGameServer?.Invoke(
                    this,
                    new MessageToGameServerEventArgs(_registered_servers[found_server_idx], ToGameServerMessageType.AckRegister)
                );
                //_log_console.GameServerMessage(_registered_servers[found_server_idx], GameServerMessageType.Detached); // d
                _registered_servers.RemoveAt(found_server_idx);
                return true;
            }
            
            return false;
        }
        */

