using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Timers;
using CommonLibrary.Model.Database;
using CommonLibrary.Model.ServerSide;

using HeadServer.EntityFramework;

namespace HeadServer.Authentication
{
    public class AuthenticationServer : IServer
    {

        public IPEndPoint Socket { get; internal set; }

        UserContext UsersContext { get; }

        public ServerStatus Status => throw new NotImplementedException();

        AuthenticationServer(IPEndPoint socket, UserContext usersContext)
        {
            Socket = socket;
            UsersContext = usersContext;
        }

        public bool SignUp(IPAddress who_requests, User new_user)
        {
            if ( !( IsRecent(who_requests) || IsUserEnrolled(new_user) ) )
            {
                QueryUserInsert(new_user);
            }
            return false;
        }

        private void QueryUserInsert(string new_user)
        {
            UsersContext.Users.Add(new_user);
        }

        public bool Login()
        {
            
        }


        private bool IsUserEnrolled(User new_user)
        {
            throw new NotImplementedException();
        }

        private bool IsRecent(IPAddress who_requests)
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            int recent_IPs_update_time_ms = 1000 * 60 * 5;
            timer = new Timer(recent_IPs_update_time_ms);
            timer.Start();
            timer.Elapsed += OnTimerIntervalElapsed;

            LinkedList<IPTimestamp> recent_IPs = new LinkedList<IPTimestamp>();
        }

        private void OnTimerIntervalElapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        public void Pause()
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
        }

        public void Resume()
        {
            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        public void Dispose()
        {
            Pause();
            timer.Dispose();
            recent_IPs = null;
        }

        private Timer timer;
        private struct IPTimestamp
        {
            IPAddress IP { get; set; }
            DateTime AddedAt;
        }

        private IPTimestamp[] recent_IPs;
    }
}
