using System;
using System.Net;

namespace HeadServer
{
    /// <summary>
    /// IP + timestamp, for storing them on server and prevent DDoS
    /// if one IP tries to flood database requests
    /// </summary>
    internal struct TimestampedIP
    {
        public IPAddress IP { get; set; }
        public DateTime AdditionTime;

        public TimestampedIP(IPAddress ip, DateTime additionTime) : this()
        {
            IP = ip;
            AdditionTime = additionTime;
        }
    }
}
