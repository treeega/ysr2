using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.DB.DBCONTEXT
{
   public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public DateTime datereg { get; set; }
        public DateTime lastonline { get; set; }

    }
}
