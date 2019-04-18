namespace EmployeeManagementSystemApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Columnnameischange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registration", "StudioName", c => c.String());
            DropColumn("dbo.Registration", "Studio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registration", "Studio", c => c.String());
            DropColumn("dbo.Registration", "StudioName");
        }
    }
}
