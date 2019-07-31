using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkAssignment2
{
    class FoodCompanyContext:DbContext
    {
        public FoodCompanyContext() : base("MydbConn")
        {
            Database.SetInitializer<FoodCompanyContext>(new CreateDatabaseIfNotExists<FoodCompanyContext>());
        }

        public DbSet<Food> foods { get; set; }
        public DbSet<Company> companys { get; set; }
        public DbSet<Mapping_Customer> mapping_customer { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().MapToStoredProcedures();
            modelBuilder.Entity<Company>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
