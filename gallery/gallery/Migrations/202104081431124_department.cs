namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class department : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Place", newName: "Department");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Department", newName: "Place");
        }
    }
}
