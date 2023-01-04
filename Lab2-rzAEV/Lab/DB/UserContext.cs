using LAB2.DB.DBCONTEXT;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LAB2.DB
{
    internal class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(): base("Context")
        {
           
        }

       
    }
}
