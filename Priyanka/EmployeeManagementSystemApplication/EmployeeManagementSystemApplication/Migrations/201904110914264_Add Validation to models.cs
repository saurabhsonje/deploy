namespace EmployeeManagementSystemApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationtomodels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registration", "EmailID", c => c.String(nullable: false));
            AlterColumn("dbo.Registration", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Registration", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Studio", "StudioName", c => c.String(nullable: false));
            AlterColumn("dbo.Studio", "StudioDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Studio", "StudioDescription", c => c.String());
            AlterColumn("dbo.Studio", "StudioName", c => c.String());
            AlterColumn("dbo.Registration", "Password", c => c.String());
            AlterColumn("dbo.Registration", "UserName", c => c.String());
            AlterColumn("dbo.Registration", "EmailID", c => c.String());
        }
    }
}
