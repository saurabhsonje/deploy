using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RegistrationDAL.Model;

namespace RegistrationDAL.Model
{
    public class AppDbContext: DbContext
        {
            public AppDbContext() : base("EmployeeConnection")
            {
            }

            public DbSet<Register> registerModel { get; set; }

           


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                
            }
        
    }
}