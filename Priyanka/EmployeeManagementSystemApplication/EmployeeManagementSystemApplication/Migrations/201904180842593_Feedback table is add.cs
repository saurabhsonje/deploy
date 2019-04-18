namespace EmployeeManagementSystemApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Feedbacktableisadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedbackModel",
                c => new
                    {
                        FeedbackID = c.Int(nullable: false, identity: true),
                        TechKnowledge = c.String(nullable: false, maxLength: 50, unicode: false),
                        Teamwork = c.String(nullable: false, maxLength: 50, unicode: false),
                        Flexibility = c.String(nullable: false, maxLength: 50, unicode: false),
                        Comment = c.String(),
                        HasEmployeeSubmitted = c.Boolean(nullable: false),
                        HasTdSubmitted = c.Boolean(nullable: false),
                        EmployeeId = c.String(),
                        SubmittedBy = c.String(),
                        registrationModel_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.FeedbackID)
                .ForeignKey("dbo.Registration", t => t.registrationModel_EmployeeID)
                .Index(t => t.registrationModel_EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FeedbackModel", "registrationModel_EmployeeID", "dbo.Registration");
            DropIndex("dbo.FeedbackModel", new[] { "registrationModel_EmployeeID" });
            DropTable("dbo.FeedbackModel");
        }
    }
}
