namespace Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeviceSubclasses_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiskDrives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.GraphicCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.HardDrives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Memories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.PowerSupplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Power = c.Int(nullable: false),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Processors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Frequency = c.String(),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processors", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Processors", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Processors", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.PowerSupplies", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.PowerSupplies", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.PowerSupplies", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.Motherboards", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Motherboards", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Motherboards", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.Memories", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Memories", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Memories", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.HardDrives", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.HardDrives", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.HardDrives", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.GraphicCards", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.GraphicCards", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.GraphicCards", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.DiskDrives", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.DiskDrives", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.DiskDrives", "DeviceType_Id", "dbo.DeviceTypes");
            DropIndex("dbo.Processors", new[] { "Status_Id" });
            DropIndex("dbo.Processors", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Processors", new[] { "DeviceType_Id" });
            DropIndex("dbo.PowerSupplies", new[] { "Status_Id" });
            DropIndex("dbo.PowerSupplies", new[] { "Manufacturer_Id" });
            DropIndex("dbo.PowerSupplies", new[] { "DeviceType_Id" });
            DropIndex("dbo.Motherboards", new[] { "Status_Id" });
            DropIndex("dbo.Motherboards", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Motherboards", new[] { "DeviceType_Id" });
            DropIndex("dbo.Memories", new[] { "Status_Id" });
            DropIndex("dbo.Memories", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Memories", new[] { "DeviceType_Id" });
            DropIndex("dbo.HardDrives", new[] { "Status_Id" });
            DropIndex("dbo.HardDrives", new[] { "Manufacturer_Id" });
            DropIndex("dbo.HardDrives", new[] { "DeviceType_Id" });
            DropIndex("dbo.GraphicCards", new[] { "Status_Id" });
            DropIndex("dbo.GraphicCards", new[] { "Manufacturer_Id" });
            DropIndex("dbo.GraphicCards", new[] { "DeviceType_Id" });
            DropIndex("dbo.DiskDrives", new[] { "Status_Id" });
            DropIndex("dbo.DiskDrives", new[] { "Manufacturer_Id" });
            DropIndex("dbo.DiskDrives", new[] { "DeviceType_Id" });
            DropTable("dbo.Processors");
            DropTable("dbo.PowerSupplies");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Memories");
            DropTable("dbo.HardDrives");
            DropTable("dbo.GraphicCards");
            DropTable("dbo.DiskDrives");
        }
    }
}
