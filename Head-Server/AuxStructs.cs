using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace HeadServer
{
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
