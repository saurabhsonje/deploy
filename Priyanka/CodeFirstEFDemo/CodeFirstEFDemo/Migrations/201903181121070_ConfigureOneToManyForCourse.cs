namespace CodeFirstEFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigureOneToManyForCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CourseID", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseID" });
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
