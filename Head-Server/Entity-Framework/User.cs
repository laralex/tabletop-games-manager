using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.EntityFramework
{
    public class User : DbContext
    {
        [Key]
        int Id;
        [Key]
        string Name;
        byte[] PasswordHash;
        DateTime? SignupTime;

    }
}
