using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

using CommonLibrary;
using CommonLibrary.Implementation.Networking;
using CommonLibrary.Implementation.ServerSide ;
using CommonLibrary.Model;
using CommonLibrary.Model.Networking;
using CommonLibrary.Model.ServerSide;

using HeadServer.DB;
using HeadServer.DB.Context;
using HeadServer.AuthenticationServer;
using System.Collections;
using System.Timers;
using System.Threading;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;
using CommonLibrary.Model.ServerSide.HeadServerAndGameServer;
using CommonLibrary.Model.Common;
using HeadServer.Debug;

namespace HeadServer
{
    

    internal class HeadServer : IServer, INetworkReceiver // INetworkSender
    {
        public ServerStatus Status { get; internal set; }
        public IPEndPoint Socket { get; internal set; }
        public TimeSpan RecentIPsUpdateRate { get; set; }
        public AuthenticationServer.AuthenticationServer AuthServer { get; private set; }

        public event EventHandler<ThreadStateEventArgs> OnThreadStateChange;
        public event EventHandler<MessageFromGameServerEventArgs> OnMessageFromGameServer;
        public event EventHandler<MessageToGameServerEventArgs> OnMessageToGameServer;
        public event EventHandler OnInitialization;
        public event EventHandler OnTermination;

        public HeadServer(IPEndPoint socket)
        {
            Socket = socket;
            Status = ServerStatus.Uninitialized;

            RecentIPsUpdateRate = new TimeSpan(hours: 0, minutes: 3, seconds: 0);

            _listening_to = new IPEndPoint(IPAddress.Any, 42077);
            _udp_listener = new UdpClient(_listening_to);
        }

        public void Initialize()
        {
            _timer = new System.Timers.Timer(RecentIPsUpdateRate.TotalMilliseconds);
            _timer.Elapsed += OnTimerIntervalElapsed;

            _recent_server_creators_IPs = new Queue<TimestampedIP>();
            _registered_servers = new List<DB.GameServer>();

            _db_server = new DatabaseServer();
            AuthServer = new AuthenticationServer.AuthenticationServer(Socket, _db_server.Context);
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
                if (Status == ServerStatus.Uninitialized)
                {
                    OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.End));
                    _main_mre.Set();
                    _main_mre.Reset();
                    //_log_console.NetworkThreadMessage(ThreadStateType.End); // d 
                    // finish tasks and terminate thread
                    return;
                }

                /*_udp_listener.BeginReceive(
                    ParseMessageType, 
                    new UdpState(_udp_listener, _listening_to)
                );

                ParseMessageType();*/
                OnThreadStateChange.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Dummy));
                Thread.Sleep(800);
                //while (!_received) Thread.Sleep(500);
                //_received = false;
                // TODO: Get Messages
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
                this._db_server.Stop();
                this._thread_mre.Reset();
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Stop));
                // _log_console.NetworkThreadMessage(ThreadStateType.Stop);  // d
                this.Status = ServerStatus.Stopped;
            }
        }

        public void Start()
        {
            if (this.Status == ServerStatus.Initialized)
            {
                _timer.Start();
                this._db_server.Start();
                this.AuthServer.Start();
                this.Status = ServerStatus.Running; 
                this._thread_mre.Set();

                _network_handling_thread.Start();

                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Begin));
                //_log_console.NetworkThreadMessage(ThreadStateType.Begin); // d

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
                this._db_server.Start();
                this.AuthServer.Start();
                this._thread_mre.Set();
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Resume));
                //_log_console.NetworkThreadMessage(ThreadStateType.Resume); // d
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

            _db_server = null;
            Socket = null;

            Status = ServerStatus.Uninitialized;

            OnTermination?.Invoke(this, null);
            //_log_console.TerminationMessage(); // d
        }

        private bool TryRegisterServer(IPAddress who_requests, DiceGameServerEntry new_server)
        {
            if (IsRecentIp(who_requests) || DatabaseIsServerRegistered(new_server))
            {
                return false;
            }
            var db_server = DatabaseRegisterServer(new_server);
            _recent_server_creators_IPs.Append(new TimestampedIP(who_requests, DateTime.UtcNow));
            OnMessageToGameServer?.Invoke(
                this, 
                new MessageToGameServerEventArgs(db_server, ToGameServerMessageType.AckRegister)
            );
            //_log_console.GameServerMessage(db_server, GameServerMessageType.Registered); // d
            return true;
        }

        // FIXME: anyone can detach server (security leak)
        private bool TryDetachServer(GameServerEnroll server)
        {
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

        private DiceGameServer DatabaseRegisterServer(DiceGameServerEntry new_server_record)
        {
            DiceGameServer db_server_record = new DiceGameServer();
            FillGameServerFields(db_server_record, new_server_record);

            db_server_record.TurnTimeSec = new_server_record.TurnTimeSec;
            db_server_record.ScoreGoal = new_server_record.ScoreGoal;
            db_server_record.IsJokerAllowed = new_server_record.IsJokerAllowed;
            db_server_record.DiceNumber = new_server_record.DiceNumber;

            _db_server.Context.GameServers.Add(db_server_record);
            _db_server.Context.SaveChanges();

            return db_server_record;
        }

        private void FillGameServerFields(DB.GameServer db_server_record, GameServerEnroll new_server_enroll)
        {
            //DB.GameServer db_server = new DB.GameServer();
            db_server_record.Name = new_server_enroll.Name;
            db_server_record.Creator = AuthServer.DatabaseSelectUser(new_server_enroll.CreatorName);
            db_server_record.RegisterTime = DateTime.UtcNow;
            db_server_record.IsActive = new_server_enroll.IsActive;
            db_server_record.Socket = new_server_enroll.Socket;
        }

        private DB.GameServer DatabaseSelectOneServer(GameServerEnroll server_enroll)
        {
            return _db_server.Context.GameServers
                .Single(e => e.Name == server_enroll.Name);
        }

        private bool DatabaseIsServerRegistered(GameServerEnroll server_enroll)
        {
            return DatabaseSelectOneServer(server_enroll) == null;
        }

        private void OnTimerIntervalElapsed(object sender, ElapsedEventArgs e)
        {
            // If <now> is older than threshold of first queue item's timestamp
            while (DateTime.UtcNow.CompareTo(_recent_server_creators_IPs.Peek().AdditionTime.Add(RecentIPsUpdateRate)) > 0)
            {
                _recent_server_creators_IPs.Dequeue();
            }
        }

        private bool IsRecentIp(IPAddress who_requests)
        {
            return _recent_server_creators_IPs.Any((e) => e.IP.Equals(who_requests));
        }

        // TODO:
        private void ParseMessageType(IAsyncResult ares)
        {
            UdpState st = (UdpState)(ares.AsyncState);
            byte[] raw_received = st.Client.EndReceive(ares, ref st.Remote);

            _received = true;
            OnThreadStateChange(this, new ThreadStateEventArgs(ThreadStateType.Dummy));
        }

        private System.Timers.Timer _timer;
        private List<DB.GameServer> _registered_servers;
        private Queue<TimestampedIP> _recent_server_creators_IPs;
        
        private DB.DatabaseServer _db_server;

        // net // TODO:
        private UdpClient _udp_listener;
        private IPEndPoint _listening_to;
        private bool _received;
            //private UdpMessageReceiver _udp;

        // threading
        private ManualResetEvent _thread_mre;
        private ManualResetEvent _main_mre;
        private Thread _network_handling_thread;
    }
}
