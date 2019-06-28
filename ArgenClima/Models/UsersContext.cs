using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArgenClima.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Usuarios { get; set; }
    }
}