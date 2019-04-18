namespace EmployeeManagementSystemApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Columnnamechange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registration", "Role", c => c.String());
            DropColumn("dbo.Registration", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registration", "RoleName", c => c.String());
            DropColumn("dbo.Registration", "Role");
        }
    }
}
