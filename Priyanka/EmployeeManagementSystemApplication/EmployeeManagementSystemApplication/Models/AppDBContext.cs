using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Employee.Data;

namespace EmployeeManagementSystemApplication.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("EmployeeConnection")
        {
        }

        public DbSet<RegistrationModel> registrationModels { get; set; }

        public DbSet<StudioModel> studioModels { get; set; }

        public DbSet<RoleModel> roleModels { get; set; }

        public DbSet<EmployeeRoleModel> employeeRoleModels { get; set; }

        public DbSet<FeedbackModel> feedbackModels { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<RegistrationModel>().ToTable("Registration");
            //modelBuilder.Entity<StudioModel>().ToTable("Studio");
            //modelBuilder.Entity<RoleModel>().ToTable("Role");
            //modelBuilder.Entity<EmployeeRoleModel>().ToTable("EmployeeRole");
        }
    }
}