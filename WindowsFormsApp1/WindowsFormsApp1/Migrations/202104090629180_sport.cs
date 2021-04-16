namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Email = c.String(maxLength: 250),
                        Login = c.String(maxLength: 250),
                        Password = c.String(maxLength: 250),
                        SportTypeId = c.Int(),
                        Birthday = c.DateTime(),
                        Height = c.Double(),
                        Weight = c.Double(),
                        Sex = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SportTypes", t => t.SportTypeId)
                .Index(t => t.SportTypeId);
            
            CreateTable(
                "dbo.SportTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OpenDate = c.DateTime(nullable: false),
                        CloseDate = c.DateTime(nullable: false),
                        PositionId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TheStreet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Heading = c.String(maxLength: 250),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompetitionId = c.Int(nullable: false),
                        AthleteId = c.Int(nullable: false),
                        SportTypeId = c.Int(),
                        SportCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.AthleteId, cascadeDelete: true)
                .ForeignKey("dbo.SportCategories", t => t.SportCategoryId)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.SportTypes", t => t.SportTypeId)
                .Index(t => t.CompetitionId)
                .Index(t => t.AthleteId)
                .Index(t => t.SportTypeId)
                .Index(t => t.SportCategoryId);
            
            CreateTable(
                "dbo.SportCategories",
                c => new
                    {
                        SportCategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Regulation = c.String(),
                        SportTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SportCategoryID)
                .ForeignKey("dbo.SportTypes", t => t.SportTypeId, cascadeDelete: true)
                .Index(t => t.SportTypeId);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParticipantId = c.Int(nullable: false),
                        Points = c.Double(nullable: false),
                        Place = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.ParticipantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.Participants", "SportTypeId", "dbo.SportTypes");
            DropForeignKey("dbo.Participants", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Participants", "SportCategoryId", "dbo.SportCategories");
            DropForeignKey("dbo.SportCategories", "SportTypeId", "dbo.SportTypes");
            DropForeignKey("dbo.Participants", "AthleteId", "dbo.People");
            DropForeignKey("dbo.Competitions", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Competitions", "CityId", "dbo.Cities");
            DropForeignKey("dbo.People", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.Results", new[] { "ParticipantId" });
            DropIndex("dbo.SportCategories", new[] { "SportTypeId" });
            DropIndex("dbo.Participants", new[] { "SportCategoryId" });
            DropIndex("dbo.Participants", new[] { "SportTypeId" });
            DropIndex("dbo.Participants", new[] { "AthleteId" });
            DropIndex("dbo.Participants", new[] { "CompetitionId" });
            DropIndex("dbo.Competitions", new[] { "CityId" });
            DropIndex("dbo.Competitions", new[] { "PositionId" });
            DropIndex("dbo.People", new[] { "SportTypeId" });
            DropTable("dbo.Results");
            DropTable("dbo.SportCategories");
            DropTable("dbo.Participants");
            DropTable("dbo.News");
            DropTable("dbo.Employees");
            DropTable("dbo.Positions");
            DropTable("dbo.Competitions");
            DropTable("dbo.Cities");
            DropTable("dbo.SportTypes");
            DropTable("dbo.People");
        }
    }
}
