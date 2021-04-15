namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dep : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Picture", name: "PlaceId", newName: "DepartmentId");
            RenameIndex(table: "dbo.Picture", name: "IX_PlaceId", newName: "IX_DepartmentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Picture", name: "IX_DepartmentId", newName: "IX_PlaceId");
            RenameColumn(table: "dbo.Picture", name: "DepartmentId", newName: "PlaceId");
        }
    }
}
