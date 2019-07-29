namespace Assignment_06_A11_2_EF_RelationShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        EmpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmpId, cascadeDelete: true)
                .Index(t => t.EmpId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "EmpId", "dbo.Employees");
            DropIndex("dbo.Addresses", new[] { "EmpId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Addresses");
        }
    }
}
