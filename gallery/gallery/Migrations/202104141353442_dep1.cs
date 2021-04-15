namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dep1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Picture", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Journal", "PlaceFromId", "dbo.Department");
            DropForeignKey("dbo.Journal", "PlaceToId", "dbo.Department");
            DropPrimaryKey("dbo.Department");
            DropColumn("dbo.Department", "PlaceId");
            AddColumn("dbo.Department", "DepartmentId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Department", "DepartmentId");
            AddForeignKey("dbo.Picture", "DepartmentId", "dbo.Department", "DepartmentId", cascadeDelete: true);
            AddForeignKey("dbo.Journal", "PlaceFromId", "dbo.Department", "DepartmentId");
            AddForeignKey("dbo.Journal", "PlaceToId", "dbo.Department", "DepartmentId");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Department", "PlaceId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Journal", "PlaceToId", "dbo.Department");
            DropForeignKey("dbo.Journal", "PlaceFromId", "dbo.Department");
            DropForeignKey("dbo.Picture", "DepartmentId", "dbo.Department");
            DropPrimaryKey("dbo.Department");
            DropColumn("dbo.Department", "DepartmentId");
            AddPrimaryKey("dbo.Department", "PlaceId");
            AddForeignKey("dbo.Journal", "PlaceToId", "dbo.Department", "PlaceId");
            AddForeignKey("dbo.Journal", "PlaceFromId", "dbo.Department", "PlaceId");
            AddForeignKey("dbo.Picture", "DepartmentId", "dbo.Department", "PlaceId", cascadeDelete: true);
        }
    }
}
