namespace ConsoleApp_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mytu : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Supplier_Insert",
                p => new
                    {
                        Cust_Name = p.String(),
                        Cust_Adress = p.String(),
                        Cust_Code = p.Int(),
                        Order_ID = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Suppliers]([Cust_Name], [Cust_Adress], [Cust_Code], [Order_ID])
                      VALUES (@Cust_Name, @Cust_Adress, @Cust_Code, @Order_ID)
                      
                      DECLARE @Cust_ID int
                      SELECT @Cust_ID = [Cust_ID]
                      FROM [dbo].[Suppliers]
                      WHERE @@ROWCOUNT > 0 AND [Cust_ID] = scope_identity()
                      
                      SELECT t0.[Cust_ID]
                      FROM [dbo].[Suppliers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Cust_ID] = @Cust_ID"
            );
            
            CreateStoredProcedure(
                "dbo.Supplier_Update",
                p => new
                    {
                        Cust_ID = p.Int(),
                        Cust_Name = p.String(),
                        Cust_Adress = p.String(),
                        Cust_Code = p.Int(),
                        Order_ID = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Suppliers]
                      SET [Cust_Name] = @Cust_Name, [Cust_Adress] = @Cust_Adress, [Cust_Code] = @Cust_Code, [Order_ID] = @Order_ID
                      WHERE ([Cust_ID] = @Cust_ID)"
            );
            
            CreateStoredProcedure(
                "dbo.Supplier_Delete",
                p => new
                    {
                        Cust_ID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Suppliers]
                      WHERE ([Cust_ID] = @Cust_ID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Supplier_Delete");
            DropStoredProcedure("dbo.Supplier_Update");
            DropStoredProcedure("dbo.Supplier_Insert");
        }
    }
}
