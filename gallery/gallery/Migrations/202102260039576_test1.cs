namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artist",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        BirthYear = c.DateTime(nullable: false),
                        DeathYear = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "dbo.Picture",
                c => new
                    {
                        PictureId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Year = c.Int(nullable: false),
                        ArtistId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        PlaceId = c.Int(nullable: false),
                        GalleryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PictureId)
                .ForeignKey("dbo.Artist", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Gallery", t => t.GalleryId, cascadeDelete: false)
                .ForeignKey("dbo.Genre", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Place", t => t.PlaceId, cascadeDelete: true)
                .Index(t => t.ArtistId)
                .Index(t => t.GenreId)
                .Index(t => t.PlaceId)
                .Index(t => t.GalleryId);
            
            CreateTable(
                "dbo.ExpoPicture",
                c => new
                    {
                        ExpoPictureId = c.Int(nullable: false, identity: true),
                        PictureId = c.Int(nullable: false),
                        ExpoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpoPictureId)
                .ForeignKey("dbo.Expo", t => t.ExpoId, cascadeDelete: true)
                .ForeignKey("dbo.Picture", t => t.PictureId, cascadeDelete: true)
                .Index(t => t.PictureId)
                .Index(t => t.ExpoId);
            
            CreateTable(
                "dbo.Expo",
                c => new
                    {
                        ExpoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Place = c.String(),
                    })
                .PrimaryKey(t => t.ExpoId);
            
            CreateTable(
                "dbo.Gallery",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Phone = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        GalleryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Gallery", t => t.GalleryId, cascadeDelete: true)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId)
                .Index(t => t.GalleryId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Journal",
                c => new
                    {
                        JournalId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        PlaceFromId = c.Int(),
                        PlaceToId = c.Int(),
                        PictureId = c.Int(nullable: false),
                        ExpoId = c.Int(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JournalId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Expo", t => t.ExpoId)
                .ForeignKey("dbo.Place", t => t.PlaceFromId)
                .ForeignKey("dbo.Picture", t => t.PictureId, cascadeDelete: true)
                .ForeignKey("dbo.Place", t => t.PlaceToId)
                .Index(t => t.PlaceFromId)
                .Index(t => t.PlaceToId)
                .Index(t => t.PictureId)
                .Index(t => t.ExpoId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Place",
                c => new
                    {
                        PlaceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PlaceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journal", "PlaceToId", "dbo.Place");
            DropForeignKey("dbo.Journal", "PictureId", "dbo.Picture");
            DropForeignKey("dbo.Journal", "PlaceFromId", "dbo.Place");
            DropForeignKey("dbo.Picture", "PlaceId", "dbo.Place");
            DropForeignKey("dbo.Journal", "ExpoId", "dbo.Expo");
            DropForeignKey("dbo.Journal", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Picture", "GenreId", "dbo.Genre");
            DropForeignKey("dbo.Picture", "GalleryId", "dbo.Gallery");
            DropForeignKey("dbo.Employee", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Employee", "GalleryId", "dbo.Gallery");
            DropForeignKey("dbo.ExpoPicture", "PictureId", "dbo.Picture");
            DropForeignKey("dbo.ExpoPicture", "ExpoId", "dbo.Expo");
            DropForeignKey("dbo.Picture", "ArtistId", "dbo.Artist");
            DropIndex("dbo.Journal", new[] { "EmployeeId" });
            DropIndex("dbo.Journal", new[] { "ExpoId" });
            DropIndex("dbo.Journal", new[] { "PictureId" });
            DropIndex("dbo.Journal", new[] { "PlaceToId" });
            DropIndex("dbo.Journal", new[] { "PlaceFromId" });
            DropIndex("dbo.Employee", new[] { "GalleryId" });
            DropIndex("dbo.Employee", new[] { "PositionId" });
            DropIndex("dbo.ExpoPicture", new[] { "ExpoId" });
            DropIndex("dbo.ExpoPicture", new[] { "PictureId" });
            DropIndex("dbo.Picture", new[] { "GalleryId" });
            DropIndex("dbo.Picture", new[] { "PlaceId" });
            DropIndex("dbo.Picture", new[] { "GenreId" });
            DropIndex("dbo.Picture", new[] { "ArtistId" });
            DropTable("dbo.Place");
            DropTable("dbo.Journal");
            DropTable("dbo.Genre");
            DropTable("dbo.Position");
            DropTable("dbo.Employee");
            DropTable("dbo.Gallery");
            DropTable("dbo.Expo");
            DropTable("dbo.ExpoPicture");
            DropTable("dbo.Picture");
            DropTable("dbo.Artist");
        }
    }
}
