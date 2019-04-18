namespace RegistrationWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tableisadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        empId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Contact = c.Long(nullable: false),
                        City = c.String(nullable: false),
                        EmailID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.empId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registration");
        }
    }
}
