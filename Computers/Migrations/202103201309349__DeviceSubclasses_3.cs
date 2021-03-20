namespace Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _DeviceSubclasses_3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PeripheralEmployees", "Peripheral_Id", "dbo.Peripherals");
            DropForeignKey("dbo.PeripheralEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.GraphicCardComputers", "GraphicCard_Id", "dbo.GraphicCards");
            DropForeignKey("dbo.GraphicCardComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.HardDriveComputers", "HardDrive_Id", "dbo.HardDrives");
            DropForeignKey("dbo.HardDriveComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.MemoryComputers", "Memory_Id", "dbo.Memories");
            DropForeignKey("dbo.MemoryComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.PowerSupplyComputers", "PowerSupply_Id", "dbo.PowerSupplies");
            DropForeignKey("dbo.PowerSupplyComputers", "Computer_Id", "dbo.Computers");
            DropIndex("dbo.PeripheralEmployees", new[] { "Peripheral_Id" });
            DropIndex("dbo.PeripheralEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.GraphicCardComputers", new[] { "GraphicCard_Id" });
            DropIndex("dbo.GraphicCardComputers", new[] { "Computer_Id" });
            DropIndex("dbo.HardDriveComputers", new[] { "HardDrive_Id" });
            DropIndex("dbo.HardDriveComputers", new[] { "Computer_Id" });
            DropIndex("dbo.MemoryComputers", new[] { "Memory_Id" });
            DropIndex("dbo.MemoryComputers", new[] { "Computer_Id" });
            DropIndex("dbo.PowerSupplyComputers", new[] { "PowerSupply_Id" });
            DropIndex("dbo.PowerSupplyComputers", new[] { "Computer_Id" });
            AddColumn("dbo.Peripherals", "Employee_Id", c => c.Int());
            AddColumn("dbo.GraphicCards", "Computer_Id", c => c.Int());
            AddColumn("dbo.HardDrives", "Computer_Id", c => c.Int());
            AddColumn("dbo.Memories", "Computer_Id", c => c.Int());
            AddColumn("dbo.PowerSupplies", "Computer_Id", c => c.Int());
            CreateIndex("dbo.Peripherals", "Employee_Id");
            CreateIndex("dbo.GraphicCards", "Computer_Id");
            CreateIndex("dbo.HardDrives", "Computer_Id");
            CreateIndex("dbo.Memories", "Computer_Id");
            CreateIndex("dbo.PowerSupplies", "Computer_Id");
            AddForeignKey("dbo.Peripherals", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.GraphicCards", "Computer_Id", "dbo.Computers", "Id");
            AddForeignKey("dbo.HardDrives", "Computer_Id", "dbo.Computers", "Id");
            AddForeignKey("dbo.Memories", "Computer_Id", "dbo.Computers", "Id");
            AddForeignKey("dbo.PowerSupplies", "Computer_Id", "dbo.Computers", "Id");
            DropTable("dbo.PeripheralEmployees");
            DropTable("dbo.GraphicCardComputers");
            DropTable("dbo.HardDriveComputers");
            DropTable("dbo.MemoryComputers");
            DropTable("dbo.PowerSupplyComputers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PowerSupplyComputers",
                c => new
                    {
                        PowerSupply_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PowerSupply_Id, t.Computer_Id });
            
            CreateTable(
                "dbo.MemoryComputers",
                c => new
                    {
                        Memory_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Memory_Id, t.Computer_Id });
            
            CreateTable(
                "dbo.HardDriveComputers",
                c => new
                    {
                        HardDrive_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HardDrive_Id, t.Computer_Id });
            
            CreateTable(
                "dbo.GraphicCardComputers",
                c => new
                    {
                        GraphicCard_Id = c.Int(nullable: false),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GraphicCard_Id, t.Computer_Id });
            
            CreateTable(
                "dbo.PeripheralEmployees",
                c => new
                    {
                        Peripheral_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Peripheral_Id, t.Employee_Id });
            
            DropForeignKey("dbo.PowerSupplies", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.Memories", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.HardDrives", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.GraphicCards", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.Peripherals", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.PowerSupplies", new[] { "Computer_Id" });
            DropIndex("dbo.Memories", new[] { "Computer_Id" });
            DropIndex("dbo.HardDrives", new[] { "Computer_Id" });
            DropIndex("dbo.GraphicCards", new[] { "Computer_Id" });
            DropIndex("dbo.Peripherals", new[] { "Employee_Id" });
            DropColumn("dbo.PowerSupplies", "Computer_Id");
            DropColumn("dbo.Memories", "Computer_Id");
            DropColumn("dbo.HardDrives", "Computer_Id");
            DropColumn("dbo.GraphicCards", "Computer_Id");
            DropColumn("dbo.Peripherals", "Employee_Id");
            CreateIndex("dbo.PowerSupplyComputers", "Computer_Id");
            CreateIndex("dbo.PowerSupplyComputers", "PowerSupply_Id");
            CreateIndex("dbo.MemoryComputers", "Computer_Id");
            CreateIndex("dbo.MemoryComputers", "Memory_Id");
            CreateIndex("dbo.HardDriveComputers", "Computer_Id");
            CreateIndex("dbo.HardDriveComputers", "HardDrive_Id");
            CreateIndex("dbo.GraphicCardComputers", "Computer_Id");
            CreateIndex("dbo.GraphicCardComputers", "GraphicCard_Id");
            CreateIndex("dbo.PeripheralEmployees", "Employee_Id");
            CreateIndex("dbo.PeripheralEmployees", "Peripheral_Id");
            AddForeignKey("dbo.PowerSupplyComputers", "Computer_Id", "dbo.Computers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PowerSupplyComputers", "PowerSupply_Id", "dbo.PowerSupplies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MemoryComputers", "Computer_Id", "dbo.Computers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MemoryComputers", "Memory_Id", "dbo.Memories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HardDriveComputers", "Computer_Id", "dbo.Computers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HardDriveComputers", "HardDrive_Id", "dbo.HardDrives", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GraphicCardComputers", "Computer_Id", "dbo.Computers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GraphicCardComputers", "GraphicCard_Id", "dbo.GraphicCards", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PeripheralEmployees", "Employee_Id", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PeripheralEmployees", "Peripheral_Id", "dbo.Peripherals", "Id", cascadeDelete: true);
        }
    }
}
