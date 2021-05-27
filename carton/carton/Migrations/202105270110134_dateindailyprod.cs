namespace carton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateindailyprod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyProd", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DailyProd", "Date");
        }
    }
}
