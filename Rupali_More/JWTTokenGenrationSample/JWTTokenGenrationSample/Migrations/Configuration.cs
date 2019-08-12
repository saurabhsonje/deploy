namespace JWTTokenGenrationSample.Migrations
{
    using JWTTokenGenrationSample.Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JWTTokenGenrationSample.Infrastructure.EmployeeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JWTTokenGenrationSample.Infrastructure.EmployeeDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //protected override void Seed(AspNetIdentity.WebApi.Infrastructure.ApplicationDbContext context)
            // {
            //  This method will be called after migrating to the latest version.


            /*rupali more----
                var manager = new UserManager<EmployeeData>(new UserStore<EmployeeData>(new EmployeeDBContext()));

                var user = new EmployeeData()
                {
                    UserName = "SuperPowerUser",
                    Email = "taiseer.joudeh@mymail.com",
                    EmailConfirmed = true,
                    FirstName = "Taiseer",
                    LastName = "Joudeh",
                    Age = 5
                };

                manager.Create(user, "MySuperP@ssword!");
            }*/
         
                //  This method will be called after migrating to the latest version.

                var manager = new UserManager<EmployeeData>(new UserStore<EmployeeData>(new EmployeeDBContext()));

                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new EmployeeDBContext()));

                var user = new EmployeeData()
                {
                    UserName = "SuperPowerUser",
                    Email = "taiseer.joudeh@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Taiseer",
                    LastName = "Joudeh",
                };

                manager.Create(user, "MySuperP@ss!");

                if (roleManager.Roles.Count() == 0)
                {
                    roleManager.Create(new IdentityRole { Name = "SuperAdmin" });
                    roleManager.Create(new IdentityRole { Name = "Admin" });
                    roleManager.Create(new IdentityRole { Name = "User" });
                }

                var adminUser = manager.FindByName("SuperPowerUser");

                manager.AddToRoles(adminUser.Id, new string[] { "SuperAdmin", "Admin" });
            
        }

    }
}
