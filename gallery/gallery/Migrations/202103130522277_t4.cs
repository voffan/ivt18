namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Picture", new[] { "ExpoId" });
            CreateTable(
                "dbo.ExpoPicture",
                c => new
                    {
                        ExpoPictureId = c.Int(nullable: false, identity: true),
                        PictureId = c.Int(nullable: false),
                        ExpoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpoPictureId)
                .ForeignKey("dbo.Picture", t => t.PictureId, cascadeDelete: true)
                .Index(t => t.PictureId)
                .Index(t => t.ExpoId);
            
            DropColumn("dbo.Picture", "ExpoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Picture", "ExpoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ExpoPicture", "PictureId", "dbo.Picture");
            DropIndex("dbo.ExpoPicture", new[] { "ExpoId" });
            DropIndex("dbo.ExpoPicture", new[] { "PictureId" });
            DropTable("dbo.ExpoPicture");
            CreateIndex("dbo.Picture", "ExpoId");
        }
    }
}
