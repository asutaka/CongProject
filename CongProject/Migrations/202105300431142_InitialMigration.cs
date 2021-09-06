namespace CongProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KeHoachSo = c.String(maxLength: 20),
                        PlanDate = c.DateTime(nullable: false),
                        PlanContent = c.String(maxLength: 1000),
                        RequireContent = c.String(maxLength: 1000),
                        SolutionKey = c.String(maxLength: 100),
                        SolutionValue = c.String(maxLength: 1000),
                        RiskKey = c.String(maxLength: 100),
                        RiskValue = c.String(maxLength: 1000),
                        ResourceKey = c.String(maxLength: 100),
                        ResourceValue = c.String(maxLength: 1000),
                        UserKey = c.String(maxLength: 100),
                        UserValue = c.String(maxLength: 1000),
                        Group = c.String(maxLength: 50),
                        ImpDate = c.DateTime(nullable: false),
                        District = c.String(maxLength: 500),
                        Status = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlanId = c.Int(nullable: false),
                        KeHoachSo = c.String(maxLength: 20),
                        PlanDate = c.DateTime(nullable: false),
                        District = c.String(maxLength: 500),
                        UserKey = c.String(maxLength: 100),
                        UserValue = c.String(maxLength: 1000),
                        SolutionKey = c.String(maxLength: 100),
                        SolutionValue = c.String(maxLength: 1000),
                        Result = c.String(maxLength: 1000),
                        ReportDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblResources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRisks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblSolutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblUsers");
            DropTable("dbo.tblSolutions");
            DropTable("dbo.tblRisks");
            DropTable("dbo.tblResources");
            DropTable("dbo.tblReports");
            DropTable("dbo.tblPlans");
        }
    }
}
