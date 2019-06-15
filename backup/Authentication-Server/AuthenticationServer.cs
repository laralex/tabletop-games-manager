using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Timers;
using CommonLibrary.Model.Database;
using CommonLibrary.Model.ServerSide;

using HeadServer.DB;
using HeadServer.DB.Context;
using System.Threading;
using HeadServer.Debug;
using CommonLibrary.Model.Common;

using CommonLibrary.Implementation.ServerSide.Authentication;

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

        public AuthenticationServer(IPEndPoint socket, MainContext usersContext)
        {
            Status = ServerStatus.Uninitialized;
            RecentIPsUpdateRate = new TimeSpan(hours: 0, minutes: 3, seconds: 0);

            Socket = socket;
            _db_context = usersContext;
        }


        public void Initialize()
        {
            _timer = new System.Timers.Timer(RecentIPsUpdateRate.TotalMilliseconds);
            _timer.Elapsed += OnTimerIntervalElapsed;

            _recent_user_creators_IPs = new Queue<TimestampedIP>();
            _authenticated_users = new List<DB.User>(AuthorizedUsersInitCapacity);

            _thread_mre = new ManualResetEvent(false);
            _main_mre = new ManualResetEvent(false);

            _network_handling_thread = new Thread(ServerLoop);
            _network_handling_thread.IsBackground = false;


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
            _db_context = null;
            Status = ServerStatus.Uninitialized;

            OnTermination?.Invoke(this, null);
            //_log_console.AuthenticationTerminationMessage(); // d
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
                    //_log_console.AuthNetworkThreadMessage(ThreadStateType.End); // d
                    // finish tasks and terminate
                    return;
                }
                // TODO: collect messages
                OnThreadStateChange?.Invoke(this, new ThreadStateEventArgs(ThreadStateType.Dummy));
                Thread.Sleep(2000);
            }
        }

        private bool TrySignUp(IPAddress who_requests, UserEntry new_user)
        {
            if (IsRecentIp(who_requests) || DatabaseIsUserEnrolled(new_user.Name))
            {
                return false;
            }
            DatabaseUserInsert(new_user);
            _recent_user_creators_IPs.Append(new TimestampedIP(who_requests, DateTime.UtcNow));
            return true;
        }

        private bool TryLogIn(UserEntry user)
        {
            if (_authenticated_users.Count > AuthorizedUsersInitCapacity ||
                _authenticated_users.Find(e => e.Name == user.Name && e.PasswordHash == user.PasswordHash) != null)
            {
                return false;
            }
            // throws InvalidOperation if multiple rows
            DB.User db_user = DatabaseAuthenticateAndSelectUser(user);

            if (db_user == null)
            {
                return false;
            }

            _authenticated_users.Add(db_user);
            return true;
        }

        private bool TryLogOut(UserEntry user)
        {
            int found_user_idx = _authenticated_users.FindIndex(e => e.Name == user.Name && e.PasswordHash == user.PasswordHash);
            if (found_user_idx >= 0)
            {
                _authenticated_users.RemoveAt(found_user_idx);
                return true;
            }
            return false;
        }

        internal DB.User DatabaseSelectUser(string name)
        {
            return _db_context.Users
                .Single(e => e.Name == name);
        }

        private void DatabaseUserInsert(UserEntry new_user_enroll)
        {
            DB.User db_user = new DB.User();
            db_user.Name = new_user_enroll.Name;
            db_user.PasswordHash = new_user_enroll.PasswordHash;
            db_user.EnrollTime = DateTime.UtcNow;
            _db_context.Users.Add(db_user);
            _db_context.SaveChanges();
        }

        private DB.User DatabaseAuthenticateAndSelectUser(UserEntry user)
        {
            return _db_context.Users
                .Single(e => e.Name == user.Name && e.PasswordHash == user.PasswordHash);
        }



        private bool DatabaseIsUserEnrolled(string user_name)
        {
            // throws InvalidOperation if multiple rows
            DB.User db_user = _db_context.Users
                .Single(e => e.Name == user_name);

            return db_user == null;
        }

        private bool IsRecentIp(IPAddress who_requests)
        {
            return _recent_user_creators_IPs.Any((e) => e.IP.Equals(who_requests));
        }

        private void OnTimerIntervalElapsed(object sender, ElapsedEventArgs e)
        {
            // If <now> is older than threshold of first queue item's timestamp
            while (DateTime.UtcNow.CompareTo(_recent_user_creators_IPs.Peek().AdditionTime.Add(RecentIPsUpdateRate)) > 0)
            {
                _recent_user_creators_IPs.Dequeue();
            }
        }

        private System.Timers.Timer _timer;
        private List<DB.User> _authenticated_users;
        private Queue<TimestampedIP> _recent_user_creators_IPs;
        private MainContext _db_context;

        // threading
        private ManualResetEvent _thread_mre;
        private ManualResetEvent _main_mre;
        private Thread _network_handling_thread;

    }
}
