using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.EntityFramework
{
    class GameServer
    {
        [Key]
        int Id;
        User Creator;
        DateTime CreationTime;


    }
}
