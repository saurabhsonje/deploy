namespace JWTGenerationUsingSimpleRoleClaim.Migrations
{
    using JWTGenerationUsingSimpleRoleClaim.Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JWTGenerationUsingSimpleRoleClaim.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JWTGenerationUsingSimpleRoleClaim.Infrastructure.ApplicationDbContext context)
        {
           

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@gmail.com",
                EmailConfirmed = true,
                FirstName = "Pooja",
                Location = "Pune"
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
