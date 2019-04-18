using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEFDemo.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversityConnection") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}