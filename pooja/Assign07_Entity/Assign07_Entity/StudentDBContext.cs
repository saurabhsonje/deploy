using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_Entity
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("MydbConn")
        {
            Database.SetInitializer<StudentDBContext>(new CreateDatabaseIfNotExists<StudentDBContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().MapToStoredProcedures();

        }


    }

}
