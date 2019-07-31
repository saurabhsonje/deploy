namespace EntityFramworkAssignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Company_Id = c.Int(nullable: false, identity: true),
                        Company_Name = c.String(),
                        Company_city = c.String(),
                    })
                .PrimaryKey(t => t.Company_Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Item_Id = c.Int(nullable: false, identity: true),
                        Item_Name = c.String(),
                        Item_Unit = c.String(),
                        Company_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Item_Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id, cascadeDelete: true)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Mapping_Customer",
                c => new
                    {
                        Item_Name = c.String(nullable: false, maxLength: 128),
                        Company_Name = c.String(),
                        Company_city = c.String(),
                        company_Company_Id = c.Int(),
                        foods_Item_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Item_Name)
                .ForeignKey("dbo.Companies", t => t.company_Company_Id)
                .ForeignKey("dbo.Foods", t => t.foods_Item_Id)
                .Index(t => t.company_Company_Id)
                .Index(t => t.foods_Item_Id);
            
            CreateStoredProcedure(
                "dbo.Company_Insert",
                p => new
                    {
                        Company_Name = p.String(),
                        Company_city = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Companies]([Company_Name], [Company_city])
                      VALUES (@Company_Name, @Company_city)
                      
                      DECLARE @Company_Id int
                      SELECT @Company_Id = [Company_Id]
                      FROM [dbo].[Companies]
                      WHERE @@ROWCOUNT > 0 AND [Company_Id] = scope_identity()
                      
                      SELECT t0.[Company_Id]
                      FROM [dbo].[Companies] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Company_Id] = @Company_Id"
            );
            
            CreateStoredProcedure(
                "dbo.Company_Update",
                p => new
                    {
                        Company_Id = p.Int(),
                        Company_Name = p.String(),
                        Company_city = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Companies]
                      SET [Company_Name] = @Company_Name, [Company_city] = @Company_city
                      WHERE ([Company_Id] = @Company_Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Company_Delete",
                p => new
                    {
                        Company_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Companies]
                      WHERE ([Company_Id] = @Company_Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Foods_Insert",
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
                "dbo.Foods_Update",
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
                "dbo.Foods_Delete",
                p => new
                    {
                        Item_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Foods]
                      WHERE ([Item_Id] = @Item_Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Foods_Delete");
            DropStoredProcedure("dbo.Foods_Update");
            DropStoredProcedure("dbo.Foods_Insert");
            DropStoredProcedure("dbo.Company_Delete");
            DropStoredProcedure("dbo.Company_Update");
            DropStoredProcedure("dbo.Company_Insert");
            DropForeignKey("dbo.Mapping_Customer", "foods_Item_Id", "dbo.Foods");
            DropForeignKey("dbo.Mapping_Customer", "company_Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Foods", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Mapping_Customer", new[] { "foods_Item_Id" });
            DropIndex("dbo.Mapping_Customer", new[] { "company_Company_Id" });
            DropIndex("dbo.Foods", new[] { "Company_Id" });
            DropTable("dbo.Mapping_Customer");
            DropTable("dbo.Foods");
            DropTable("dbo.Companies");
        }
    }
}
