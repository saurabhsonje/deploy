using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CustomFilter.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
           : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<User> users { get; set; }
       


    }
} 