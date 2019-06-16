using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Timers;
using CommonLibrary.Model.ServerSide;

using CommonLibrary.Implementation.Networking;
using CommonLibrary.Implementation.Networking.Tcp;

using HeadServer;
using HeadServer.DB;
using HeadServer.Debug;
using System.Threading;
using CommonLibrary.Model.Common;

using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;
using System.Net.Sockets;

namespace HeadServer.AuthenticationServer
{
    internal class AuthenticationServer : IServer     
    {

        public IPEndPoint Socket { get; private set; }
        public ServerStatus Status { get; private set; }
        public TimeSpan RecentIPsUpdateRate { get; set; }
        public int AuthorizedUsersInitCapacity { get => 1000; }

        public event EventHandler<ThreadStateEventArgs> OnThreadStateChange;
        public event EventHandler<MessageFromUserEventArgs> OnMessageFromUser;
        public event EventHandler<MessageToUserEventArgs> OnMessageToUser;
        public event EventHandler OnInitialization;
        public event EventHandler OnTermination;

        public AuthenticationServer(TcpListener listener, DatabaseServer db)
        {
            Status = ServerStatus.Uninitialized;
            RecentIPsUpdateRate = new TimeSpan(hours: 0, minutes: 0, seconds: 10);

            Socket = null;
            _tcp_listener = listener;
            _db_server = db;
        }


        public void Initialize()
        {
            _timer = new System.Timers.Timer(RecentIPsUpdateRate.TotalMilliseconds);
            _timer.Elapsed += OnTimerIntervalElapsed;

            _recent_user_creators_IPs = new Queue<TimestampedIP>();
            _authenticated_users = new List<UserEntry>(AuthorizedUsersInitCapacity);

            _thread_mre = new ManualResetEvent(false);
            _main_mre = new ManualResetEvent(false);

            _network_handling_thread = new Thread(ServerLoop);
            _network_handling_thread.IsBackground = false;

            //_tcp_listener = new TcpListener(Socket);

            Status = ServerStatus.Initialized;

            OnInitialization?.Invoke(this, null);
            //_log_console.AuthenticationInitMessage(); // d
        }

        public void Stop()
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
            }
            if (this.Status == ServerStatus.Running)
            {
                _thread_mre.Reset();

                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Stop));
                //_log_console.AuthNetworkThreadMessage(ThreadStateType.Stop);  // d
                this.Status = ServerStatus.Stopped;
            }
        }

        public void Start()
        {   
            if (this.Status == ServerStatus.Initialized)
            {
                _timer.Start();
                this.Status = ServerStatus.Running; 

                this._thread_mre.Set();
                //_tcp_listener.Start();
                _network_handling_thread.Start();

                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Begin));
                //_log_console.AuthNetworkThreadMessage(ThreadStateType.Begin); // d
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
                _thread_mre.Set();

                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Resume));
                //_log_console.AuthNetworkThreadMessage(ThreadStateType.Resume); // d
                this.Status = ServerStatus.Running;
            }
        }

        public void Dispose()
        {
            Stop();
            _timer.Dispose();
            _recent_user_creators_IPs = null;
            _db_server = null;
            Status = ServerStatus.Uninitialized;

            OnTermination?.Invoke(this, null);
            //_log_console.AuthenticationTerminationMessage(); // d
        }

        public void ServerLoop()
        {
            while (true)
            {
                // TODO: collect messages
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Dummy));
                Thread.Sleep(2000);
            }
        }

        internal SignupError TrySignUp(IPAddress who_requests, UserEntry new_user)
        {
            if (IsRecentIp(who_requests))
            {
                return SignupError.HeadServerUnavailable;
            }
            if (!_db_server.InsertUser(new_user))
            {
                return SignupError.UserExists;
            }
            //DatabaseUserInsert(new_user);
            _recent_user_creators_IPs.Enqueue(new TimestampedIP(who_requests, DateTime.UtcNow));
            return SignupError.AllOk;
        }

        internal bool TryLogIn(UserEntry user)
        {
            if (_authenticated_users.Count > AuthorizedUsersInitCapacity ||
                _authenticated_users.Find(e => e.LoginName == user.LoginName && e.PasswordHash == user.PasswordHash) != null)
            {
                return false;
            }
            // throws InvalidOperation if multiple rows
            //UserEntry db_user = DatabaseAuthenticateAndSelectUser(user);

            if (!_db_server.CheckUserLogin(user.LoginName, user.PasswordHash))
            {
                return false;
            }

            _authenticated_users.Add(user);
            return true;
        }

        internal bool TryLogOut(UserEntry user)
        {
            int found_user_idx = _authenticated_users.FindIndex(e => e.LoginName == user.LoginName && e.PasswordHash == user.PasswordHash);
            if (found_user_idx >= 0)
            {
                _authenticated_users.RemoveAt(found_user_idx);
                return true;
            }
            return false;
        }

        private bool IsRecentIp(IPAddress who_requests)
        {
            return _recent_user_creators_IPs.Any((e) => e.IP.Equals(who_requests));
        }

        private void OnTimerIntervalElapsed(object sender, ElapsedEventArgs e)
        {
            // If <now> is older than threshold of first queue item's timestamp
            while (_recent_user_creators_IPs.Count > 0 && DateTime.UtcNow.CompareTo(_recent_user_creators_IPs.Peek().AdditionTime.Add(RecentIPsUpdateRate)) > 0)
            {
                _recent_user_creators_IPs.Dequeue();
            }
        }

        private System.Timers.Timer _timer;
        private List<UserEntry> _authenticated_users;
        private Queue<TimestampedIP> _recent_user_creators_IPs;
        private DatabaseServer _db_server;

        // net 
        private TcpListener _tcp_listener;

        // threading
        private ManualResetEvent _thread_mre;
        private ManualResetEvent _main_mre;
        private Thread _network_handling_thread;

    }
}
