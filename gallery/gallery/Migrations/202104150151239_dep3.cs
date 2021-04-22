namespace gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dep3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Journal", "DepartmentFromId", c => c.Int());
            AddColumn("dbo.Journal", "DepartmentToId", c => c.Int());
            CreateIndex("dbo.Journal", "DepartmentFromId");
            CreateIndex("dbo.Journal", "DepartmentToId");
            AddForeignKey("dbo.Journal", "DepartmentFromId", "dbo.Department", "DepartmentId");
            AddForeignKey("dbo.Journal", "DepartmentToId", "dbo.Department", "DepartmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journal", "DepartmentToId", "dbo.Department");
            DropForeignKey("dbo.Journal", "DepartmentFromId", "dbo.Department");
            DropIndex("dbo.Journal", new[] { "DepartmentToId" });
            DropIndex("dbo.Journal", new[] { "DepartmentFromId" });
            DropColumn("dbo.Journal", "DepartmentToId");
            DropColumn("dbo.Journal", "DepartmentFromId");
        }
    }
}
