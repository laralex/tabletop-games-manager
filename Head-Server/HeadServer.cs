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

using HeadServer.Debug;

namespace HeadServer
{
    

    internal class HeadServer : IServer, INetworkReceiver // INetworkSender
    {
        public ServerStatus Status { get; internal set; }
        public IPEndPoint Socket { get; internal set; }
        public TimeSpan RecentIPsUpdateRate { get; set; }

        public HeadServer(IPEndPoint socket, MainContext db_context)
        {
            Socket = socket;
            Status = ServerStatus.Uninitialized;

            RecentIPsUpdateRate = new TimeSpan(hours: 0, minutes: 3, seconds: 0);
        }

        public void Initialize()
        {
            _timer = new System.Timers.Timer(RecentIPsUpdateRate.TotalMilliseconds);
            _timer.Elapsed += OnTimerIntervalElapsed;

            _recent_server_creators_IPs = new Queue<TimestampedIP>();
            _registered_servers = new List<DB.GameServer>();

            _auth_server = new AuthenticationServer.AuthenticationServer(Socket, _db_server.Context);
            _auth_server.Initialize();

            _thread_mre = new ManualResetEvent(false);

            _network_handling_thread = new Thread(ServerLoop);
            _network_handling_thread.IsBackground = false;

            Status = ServerStatus.Initialized;
            _log_console.InitMessage(); // d
        }

        public void Stop()
        {
            if (this.Status == ServerStatus.Running)
            {
                this._auth_server.Stop();
                this._db_server.Stop();
                this._thread_mre.Reset();
                _log_console.NetworkThreadMessage(ThreadStateType.Stop);  // d
                this.Status = ServerStatus.Stopped;
            }
        }

        public void Start()
        {
            if (this.Status == ServerStatus.Initialized)
            {
                this.Status = ServerStatus.Stopped; // just to enter 'if' a few lines below
                _network_handling_thread.Start();

                _log_console.NetworkThreadMessage(ThreadStateType.Begin); // d
            }
            if (this.Status == ServerStatus.Stopped || this.Status == ServerStatus.Initialized)
            {
                this._db_server.Start();
                this._auth_server.Start();
                this._thread_mre.Set();
                _log_console.NetworkThreadMessage(ThreadStateType.Resume); // d
                this.Status = ServerStatus.Running;
            }
        }

        public void Dispose()
        {
            Stop();
            _registered_servers = null;
            _recent_server_creators_IPs = null;
            _auth_server = null;
            _db_server = null;
            Socket = null;
            _log_console.TerminationMessage(); // d
        }

        public void ServerLoop()
        {
            while (true)
            {
                _thread_mre.WaitOne();
                if (Status == ServerStatus.Uninitialized)
                {
                    _log_console.NetworkThreadMessage(ThreadStateType.End); // d 
                    // finish tasks and terminate thread
                    return;
                }
                // TODO: Get Messages
            }
        }

        public bool TryRegisterServer(IPAddress who_requests, DiceGameServerEntry new_server)
        {
            if (IsRecentIp(who_requests) || DatabaseIsServerRegistered(new_server))
            {
                return false;
            }
            var db_server = DatabaseRegisterServer(new_server);
            _recent_server_creators_IPs.Append(new TimestampedIP(who_requests, DateTime.UtcNow));
            _log_console.GameServerMessage(db_server, GameServerMessageType.Registered); // d
            return true;
        }

        // FIXME: anyone can detach server (security leak)
        public bool TryDetachServer(GameServerEnroll server)
        {
            int found_server_idx = _registered_servers.FindIndex(e => e.Name == server.Name);
            if (found_server_idx >= 0)
            {
                _log_console.GameServerMessage(_registered_servers[found_server_idx], GameServerMessageType.Detached); // d
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
            db_server_record.Creator = _auth_server.DatabaseSelectUser(new_server_enroll.CreatorName);
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

        private System.Timers.Timer _timer;
        private List<DB.GameServer> _registered_servers;
        private Queue<TimestampedIP> _recent_server_creators_IPs;
        private AuthenticationServer.AuthenticationServer _auth_server;
        private DB.DatabaseServer _db_server;

        // threading
        private ManualResetEvent _thread_mre;
        private Thread _network_handling_thread;

        // debug
        private HeadServerConsole _log_console;
    }
}
