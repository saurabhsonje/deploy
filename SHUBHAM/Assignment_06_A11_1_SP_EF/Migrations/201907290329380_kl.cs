namespace Assignment_06_A11_1_SP_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
