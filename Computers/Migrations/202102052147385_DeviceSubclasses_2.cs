namespace Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeviceSubclasses_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IpAddress = c.String(),
                        ItemNo = c.String(),
                        TotalPrice = c.Int(nullable: false),
                        MotherboardId = c.Int(),
                        ProcessorId = c.Int(),
                        DiskDriveId = c.Int(),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.DiskDrives", t => t.DiskDriveId)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Motherboards", t => t.MotherboardId)
                .ForeignKey("dbo.Processors", t => t.ProcessorId)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.MotherboardId)
                .Index(t => t.ProcessorId)
                .Index(t => t.DiskDriveId)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Room = c.String(),
                        ComputerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Computers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Peripherals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        ItemNo = c.String(),
                        Name = c.String(),
                        DeviceType_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        PeripheralType_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceTypes", t => t.DeviceType_Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.PeripheralTypes", t => t.PeripheralType_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.DeviceType_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.PeripheralType_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.PeripheralEmployees",
                c => new
                    {
                        Peripheral_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Peripheral_Id, t.Employee_Id })
                .ForeignKey("dbo.Peripherals", t => t.Peripheral_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Peripheral_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.GraphicCardComputers",
                c => new
                    {
                        GraphicCard_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GraphicCard_Id, t.Computer_Id })
                .ForeignKey("dbo.GraphicCards", t => t.GraphicCard_Id, cascadeDelete: true)
                .ForeignKey("dbo.Computers", t => t.Computer_Id, cascadeDelete: true)
                .Index(t => t.GraphicCard_Id)
                .Index(t => t.Computer_Id);
            
            CreateTable(
                "dbo.HardDriveComputers",
                c => new
                    {
                        HardDrive_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HardDrive_Id, t.Computer_Id })
                .ForeignKey("dbo.HardDrives", t => t.HardDrive_Id, cascadeDelete: true)
                .ForeignKey("dbo.Computers", t => t.Computer_Id, cascadeDelete: true)
                .Index(t => t.HardDrive_Id)
                .Index(t => t.Computer_Id);
            
            CreateTable(
                "dbo.MemoryComputers",
                c => new
                    {
                        Memory_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Memory_Id, t.Computer_Id })
                .ForeignKey("dbo.Memories", t => t.Memory_Id, cascadeDelete: true)
                .ForeignKey("dbo.Computers", t => t.Computer_Id, cascadeDelete: true)
                .Index(t => t.Memory_Id)
                .Index(t => t.Computer_Id);
            
            CreateTable(
                "dbo.PowerSupplyComputers",
                c => new
                    {
                        PowerSupply_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PowerSupply_Id, t.Computer_Id })
                .ForeignKey("dbo.PowerSupplies", t => t.PowerSupply_Id, cascadeDelete: true)
                .ForeignKey("dbo.Computers", t => t.Computer_Id, cascadeDelete: true)
                .Index(t => t.PowerSupply_Id)
                .Index(t => t.Computer_Id);
            
            AddColumn("dbo.DiskDrives", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.GraphicCards", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.HardDrives", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Memories", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Motherboards", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.PowerSupplies", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Processors", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computers", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Computers", "ProcessorId", "dbo.Processors");
            DropForeignKey("dbo.PowerSupplyComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.PowerSupplyComputers", "PowerSupply_Id", "dbo.PowerSupplies");
            DropForeignKey("dbo.Computers", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.MemoryComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.MemoryComputers", "Memory_Id", "dbo.Memories");
            DropForeignKey("dbo.Computers", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.HardDriveComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.HardDriveComputers", "HardDrive_Id", "dbo.HardDrives");
            DropForeignKey("dbo.GraphicCardComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.GraphicCardComputers", "GraphicCard_Id", "dbo.GraphicCards");
            DropForeignKey("dbo.Peripherals", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Peripherals", "PeripheralType_Id", "dbo.PeripheralTypes");
            DropForeignKey("dbo.Peripherals", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.PeripheralEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.PeripheralEmployees", "Peripheral_Id", "dbo.Peripherals");
            DropForeignKey("dbo.Peripherals", "DeviceType_Id", "dbo.DeviceTypes");
            DropForeignKey("dbo.Employees", "Id", "dbo.Computers");
            DropForeignKey("dbo.Computers", "DiskDriveId", "dbo.DiskDrives");
            DropForeignKey("dbo.Computers", "DeviceType_Id", "dbo.DeviceTypes");
            DropIndex("dbo.PowerSupplyComputers", new[] { "Computer_Id" });
            DropIndex("dbo.PowerSupplyComputers", new[] { "PowerSupply_Id" });
            DropIndex("dbo.MemoryComputers", new[] { "Computer_Id" });
            DropIndex("dbo.MemoryComputers", new[] { "Memory_Id" });
            DropIndex("dbo.HardDriveComputers", new[] { "Computer_Id" });
            DropIndex("dbo.HardDriveComputers", new[] { "HardDrive_Id" });
            DropIndex("dbo.GraphicCardComputers", new[] { "Computer_Id" });
            DropIndex("dbo.GraphicCardComputers", new[] { "GraphicCard_Id" });
            DropIndex("dbo.PeripheralEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.PeripheralEmployees", new[] { "Peripheral_Id" });
            DropIndex("dbo.Peripherals", new[] { "Status_Id" });
            DropIndex("dbo.Peripherals", new[] { "PeripheralType_Id" });
            DropIndex("dbo.Peripherals", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Peripherals", new[] { "DeviceType_Id" });
            DropIndex("dbo.Employees", new[] { "Id" });
            DropIndex("dbo.Computers", new[] { "Status_Id" });
            DropIndex("dbo.Computers", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Computers", new[] { "DeviceType_Id" });
            DropIndex("dbo.Computers", new[] { "DiskDriveId" });
            DropIndex("dbo.Computers", new[] { "ProcessorId" });
            DropIndex("dbo.Computers", new[] { "MotherboardId" });
            DropColumn("dbo.Processors", "Price");
            DropColumn("dbo.PowerSupplies", "Price");
            DropColumn("dbo.Motherboards", "Price");
            DropColumn("dbo.Memories", "Price");
            DropColumn("dbo.HardDrives", "Price");
            DropColumn("dbo.GraphicCards", "Price");
            DropColumn("dbo.DiskDrives", "Price");
            DropTable("dbo.PowerSupplyComputers");
            DropTable("dbo.MemoryComputers");
            DropTable("dbo.HardDriveComputers");
            DropTable("dbo.GraphicCardComputers");
            DropTable("dbo.PeripheralEmployees");
            DropTable("dbo.Peripherals");
            DropTable("dbo.Employees");
            DropTable("dbo.Computers");
        }
    }
}
