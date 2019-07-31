namespace Assign07_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student_Dept : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Department_Id = c.Int(nullable: false, identity: true),
                        Department_Name = c.String(),
                    })
                .PrimaryKey(t => t.Department_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
            CreateStoredProcedure(
                "dbo.Student_Insert",
                p => new
                    {
                        Name = p.String(),
                        Department_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Students]([Name], [Department_Id])
                      VALUES (@Name, @Department_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Students]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Students] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Student_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Department_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Students]
                      SET [Name] = @Name, [Department_Id] = @Department_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Student_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Students]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Student_Delete");
            DropStoredProcedure("dbo.Student_Update");
            DropStoredProcedure("dbo.Student_Insert");
            DropForeignKey("dbo.Students", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
