namespace carton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Surname", c => c.String());
            AddColumn("dbo.Employee", "Name", c => c.String());
            AddColumn("dbo.Employee", "Fathername", c => c.String());
            AddColumn("dbo.Employee", "Login", c => c.String());
            AddColumn("dbo.Employee", "Password", c => c.String());
            DropColumn("dbo.Employee", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "FullName", c => c.String());
            DropColumn("dbo.Employee", "Password");
            DropColumn("dbo.Employee", "Login");
            DropColumn("dbo.Employee", "Fathername");
            DropColumn("dbo.Employee", "Name");
            DropColumn("dbo.Employee", "Surname");
        }
    }
}
