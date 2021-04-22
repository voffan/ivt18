namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dep2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Journal", "PlaceFromId", "dbo.Department");
            DropForeignKey("dbo.Journal", "PlaceToId", "dbo.Department");
            DropIndex("dbo.Journal", new[] { "PlaceFromId" });
            DropIndex("dbo.Journal", new[] { "PlaceToId" });
            DropColumn("dbo.Journal", "PlaceFromId");
            DropColumn("dbo.Journal", "PlaceToId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Journal", "PlaceToId", c => c.Int());
            AddColumn("dbo.Journal", "PlaceFromId", c => c.Int());
            CreateIndex("dbo.Journal", "PlaceToId");
            CreateIndex("dbo.Journal", "PlaceFromId");
            AddForeignKey("dbo.Journal", "PlaceToId", "dbo.Department", "DepartmentId");
            AddForeignKey("dbo.Journal", "PlaceFromId", "dbo.Department", "DepartmentId");
        }
    }
}
