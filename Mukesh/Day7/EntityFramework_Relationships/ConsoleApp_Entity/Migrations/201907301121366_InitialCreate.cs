namespace ConsoleApp_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Order_ID = c.Int(nullable: false, identity: true),
                        Order_Date = c.String(),
                        Order_Supplier = c.String(),
                    })
                .PrimaryKey(t => t.Order_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Cust_ID = c.Int(nullable: false, identity: true),
                        Cust_Name = c.String(),
                        Cust_Adress = c.String(),
                        Cust_Code = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cust_ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .Index(t => t.Order_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suppliers", "Order_ID", "dbo.Orders");
            DropIndex("dbo.Suppliers", new[] { "Order_ID" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Orders");
        }
    }
}
