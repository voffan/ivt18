namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expoaddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expo", "Address", c => c.String());
            DropColumn("dbo.Expo", "Place");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expo", "Place", c => c.String());
            DropColumn("dbo.Expo", "Address");
        }
    }
}
