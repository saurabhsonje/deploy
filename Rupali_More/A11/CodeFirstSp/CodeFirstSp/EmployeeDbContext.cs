using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSp
{
    class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("MydbConn")
        {
            Database.SetInitializer<EmployeeDbContext>(new CreateDatabaseIfNotExists<EmployeeDbContext>());
        }

        public DbSet<EmployeeCodeFirst> employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeCodeFirst>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
