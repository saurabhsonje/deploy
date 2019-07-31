namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Leader", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Leader");
        }
    }
}
