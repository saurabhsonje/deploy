namespace EntityFramworkAssignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class food : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Food_Insert",
                p => new
                    {
                        Item_Name = p.String(),
                        Item_Unit = p.String(),
                        Company_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Foods]([Item_Name], [Item_Unit], [Company_Id])
                      VALUES (@Item_Name, @Item_Unit, @Company_Id)
                      
                      DECLARE @Item_Id int
                      SELECT @Item_Id = [Item_Id]
                      FROM [dbo].[Foods]
                      WHERE @@ROWCOUNT > 0 AND [Item_Id] = scope_identity()
                      
                      SELECT t0.[Item_Id]
                      FROM [dbo].[Foods] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Item_Id] = @Item_Id"
            );
            
            CreateStoredProcedure(
                "dbo.Food_Update",
                p => new
                    {
                        Item_Id = p.Int(),
                        Item_Name = p.String(),
                        Item_Unit = p.String(),
                        Company_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Foods]
                      SET [Item_Name] = @Item_Name, [Item_Unit] = @Item_Unit, [Company_Id] = @Company_Id
                      WHERE ([Item_Id] = @Item_Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Food_Delete",
                p => new
                    {
                        Item_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Foods]
                      WHERE ([Item_Id] = @Item_Id)"
            );
            
            DropStoredProcedure("dbo.Foods_Insert");
            DropStoredProcedure("dbo.Foods_Update");
            DropStoredProcedure("dbo.Foods_Delete");
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Food_Delete");
            DropStoredProcedure("dbo.Food_Update");
            DropStoredProcedure("dbo.Food_Insert");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
