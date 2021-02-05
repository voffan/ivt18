namespace Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logs_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OperationId = c.Int(),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operations", t => t.OperationId)
                .Index(t => t.OperationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "OperationId", "dbo.Operations");
            DropIndex("dbo.Logs", new[] { "OperationId" });
            DropTable("dbo.Logs");
        }
    }
}
