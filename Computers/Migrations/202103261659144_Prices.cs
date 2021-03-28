namespace Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computers", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Computers", "TotalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Computers", "TotalPrice", c => c.Int(nullable: false));
            DropColumn("dbo.Computers", "Price");
        }
    }
}
