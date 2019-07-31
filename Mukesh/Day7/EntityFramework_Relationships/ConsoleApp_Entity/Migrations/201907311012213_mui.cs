namespace ConsoleApp_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mui : DbMigration
    {
        public override void Up()
        {
            DropStoredProcedure("dbo.Supplier_Insert");
            DropStoredProcedure("dbo.Supplier_Update");
            DropStoredProcedure("dbo.Supplier_Delete");
        }
        
        public override void Down()
        {
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
