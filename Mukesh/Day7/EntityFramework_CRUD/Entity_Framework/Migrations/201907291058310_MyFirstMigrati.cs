namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigrati : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Leader");
            CreateStoredProcedure(
                "dbo.Employee_Insert",
                p => new
                    {
                        Name = p.String(),
                        Salary = p.Int(),
                        Studio = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Name], [Salary], [Studio])
                      VALUES (@Name, @Salary, @Studio)
                      
                      DECLARE @ID int
                      SELECT @ID = [ID]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [ID] = scope_identity()
                      
                      SELECT t0.[ID]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ID] = @ID"
            );
            
            CreateStoredProcedure(
                "dbo.Employee_Update",
                p => new
                    {
                        ID = p.Int(),
                        Name = p.String(),
                        Salary = p.Int(),
                        Studio = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Name] = @Name, [Salary] = @Salary, [Studio] = @Studio
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "dbo.Employee_Delete",
                p => new
                    {
                        ID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ([ID] = @ID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Employee_Delete");
            DropStoredProcedure("dbo.Employee_Update");
            DropStoredProcedure("dbo.Employee_Insert");
            AddColumn("dbo.Employees", "Leader", c => c.String());
        }
    }
}
