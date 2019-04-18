namespace EmployeeManagementSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tableisadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        employee_EmployeeID = c.Int(),
                        role_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registration", t => t.employee_EmployeeID)
                .ForeignKey("dbo.Role", t => t.role_RoleID)
                .Index(t => t.employee_EmployeeID)
                .Index(t => t.role_RoleID);
            
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmailID = c.String(),
                        UserName = c.String(),
                        Age = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        Role = c.String(),
                        Studio = c.String(),
                        Password = c.String(),
                        StudioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Studio", t => t.StudioID, cascadeDelete: true)
                .Index(t => t.StudioID);
            
            CreateTable(
                "dbo.Studio",
                c => new
                    {
                        StudioID = c.Int(nullable: false, identity: true),
                        StudioName = c.String(),
                        StudioDescription = c.String(),
                        TechDirector = c.String(),
                        isDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudioID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeRole", "role_RoleID", "dbo.Role");
            DropForeignKey("dbo.EmployeeRole", "employee_EmployeeID", "dbo.Registration");
            DropForeignKey("dbo.Registration", "StudioID", "dbo.Studio");
            DropIndex("dbo.Registration", new[] { "StudioID" });
            DropIndex("dbo.EmployeeRole", new[] { "role_RoleID" });
            DropIndex("dbo.EmployeeRole", new[] { "employee_EmployeeID" });
            DropTable("dbo.Role");
            DropTable("dbo.Studio");
            DropTable("dbo.Registration");
            DropTable("dbo.EmployeeRole");
        }
    }
}
