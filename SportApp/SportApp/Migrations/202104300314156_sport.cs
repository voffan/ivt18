namespace SportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, storeType: "nvarchar"),
                        Email = c.String(maxLength: 250, storeType: "nvarchar"),
                        Login = c.String(maxLength: 250, storeType: "nvarchar"),
                        Password = c.String(maxLength: 250, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SportType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        OpenDate = c.DateTime(nullable: false, precision: 0),
                        CloseDate = c.DateTime(nullable: false, precision: 0),
                        PositionId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TheStreet = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Position = c.Int(nullable: false),
                        Email = c.String(unicode: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Heading = c.String(maxLength: 250, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participant",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompetitionId = c.Int(nullable: false),
                        AthleteId = c.Int(nullable: false),
                        SportTypeId = c.Int(),
                        SportCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Athlete", t => t.AthleteId)
                .ForeignKey("dbo.SportCategory", t => t.SportCategoryId)
                .ForeignKey("dbo.Competition", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.SportType", t => t.SportTypeId)
                .Index(t => t.CompetitionId)
                .Index(t => t.AthleteId)
                .Index(t => t.SportTypeId)
                .Index(t => t.SportCategoryId);
            
            CreateTable(
                "dbo.SportCategory",
                c => new
                    {
                        SportCategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Regulation = c.String(unicode: false),
                        SportTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SportCategoryID)
                .ForeignKey("dbo.SportType", t => t.SportTypeId, cascadeDelete: true)
                .Index(t => t.SportTypeId);
            
            CreateTable(
                "dbo.Result",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParticipantId = c.Int(nullable: false),
                        Points = c.Double(nullable: false),
                        Place = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Participant", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.ParticipantId);
            
            CreateTable(
                "dbo.Athlete",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SportTypeId = c.Int(),
                        Birthday = c.DateTime(nullable: false, precision: 0),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        Sex = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .ForeignKey("dbo.SportType", t => t.SportTypeId)
                .Index(t => t.Id)
                .Index(t => t.SportTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Athlete", "SportTypeId", "dbo.SportType");
            DropForeignKey("dbo.Athlete", "Id", "dbo.Person");
            DropForeignKey("dbo.Result", "ParticipantId", "dbo.Participant");
            DropForeignKey("dbo.Participant", "SportTypeId", "dbo.SportType");
            DropForeignKey("dbo.Participant", "CompetitionId", "dbo.Competition");
            DropForeignKey("dbo.Participant", "SportCategoryId", "dbo.SportCategory");
            DropForeignKey("dbo.SportCategory", "SportTypeId", "dbo.SportType");
            DropForeignKey("dbo.Participant", "AthleteId", "dbo.Athlete");
            DropForeignKey("dbo.Competition", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Competition", "CityId", "dbo.City");
            DropIndex("dbo.Athlete", new[] { "SportTypeId" });
            DropIndex("dbo.Athlete", new[] { "Id" });
            DropIndex("dbo.Result", new[] { "ParticipantId" });
            DropIndex("dbo.SportCategory", new[] { "SportTypeId" });
            DropIndex("dbo.Participant", new[] { "SportCategoryId" });
            DropIndex("dbo.Participant", new[] { "SportTypeId" });
            DropIndex("dbo.Participant", new[] { "AthleteId" });
            DropIndex("dbo.Participant", new[] { "CompetitionId" });
            DropIndex("dbo.Competition", new[] { "CityId" });
            DropIndex("dbo.Competition", new[] { "PositionId" });
            DropTable("dbo.Athlete");
            DropTable("dbo.Result");
            DropTable("dbo.SportCategory");
            DropTable("dbo.Participant");
            DropTable("dbo.News");
            DropTable("dbo.Employee");
            DropTable("dbo.Position");
            DropTable("dbo.Competition");
            DropTable("dbo.City");
            DropTable("dbo.SportType");
            DropTable("dbo.Person");
        }
    }
}
