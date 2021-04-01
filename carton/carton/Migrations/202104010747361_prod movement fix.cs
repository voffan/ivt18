namespace carton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prodmovementfix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductMovement", "Amount", c => c.Int(nullable: false));
            DropColumn("dbo.ProductOperation", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductOperation", "Amount", c => c.Int(nullable: false));
            DropColumn("dbo.ProductMovement", "Amount");
        }
    }
}
