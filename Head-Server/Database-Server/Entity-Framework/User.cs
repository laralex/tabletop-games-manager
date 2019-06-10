using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.DB
{
    public class User
    {
        [Key] public int       Id { get; set; }

        [Key] public string    Name { get; set; }
        public byte[]          PasswordHash { get; set; }
        public DateTime?       EnrollTime { get; set; }
    }
}
