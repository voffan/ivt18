namespace carton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextFix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyProd",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Production = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ShiftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Shift", t => t.ShiftId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ShiftId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductOperation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductOperation", t => t.ProductOperation_Id)
                .Index(t => t.ProductOperation_Id);
            
            CreateTable(
                "dbo.Planned",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlanProduction = c.Int(nullable: false),
                        Complete = c.Boolean(nullable: false),
                        PlanId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.PlanId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        ProdLineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductionLine", t => t.ProdLineId, cascadeDelete: true)
                .Index(t => t.ProdLineId);
            
            CreateTable(
                "dbo.ProductionLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        FactoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factory", t => t.FactoryId, cascadeDelete: true)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.FactoryId);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductOperation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SourceId = c.Int(),
                        DestinationId = c.Int(),
                        Date = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Department_Id = c.Int(),
                        Department_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DestinationId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Department", t => t.SourceId)
                .ForeignKey("dbo.Department", t => t.Department_Id)
                .ForeignKey("dbo.Department", t => t.Department_Id1)
                .Index(t => t.SourceId)
                .Index(t => t.DestinationId)
                .Index(t => t.EmployeeId)
                .Index(t => t.Department_Id)
                .Index(t => t.Department_Id1);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        PositionId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        ContactPhone = c.String(),
                        Address = c.String(),
                        StorageId = c.Int(),
                        FactoryId = c.Int(),
                        Factory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factory", t => t.Factory_Id)
                .ForeignKey("dbo.Storage", t => t.StorageId)
                .ForeignKey("dbo.Factory", t => t.FactoryId)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.PositionId)
                .Index(t => t.StatusId)
                .Index(t => t.StorageId)
                .Index(t => t.FactoryId)
                .Index(t => t.Factory_Id);
            
            CreateTable(
                "dbo.Factory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        INN = c.String(),
                        ContactPhone = c.String(),
                        DirectorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.DirectorId, cascadeDelete: true)
                .Index(t => t.DirectorId);
            
            CreateTable(
                "dbo.Storage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FactoryId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Factory", t => t.FactoryId, cascadeDelete: true)
                .Index(t => t.FactoryId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.ProductRemain",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remainings = c.Int(nullable: false),
                        StorageId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Storage", t => t.StorageId, cascadeDelete: true)
                .Index(t => t.StorageId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.Int(nullable: false),
                        Explaining = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        ProductionLine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.ProductionLine", t => t.ProductionLine_Id)
                .Index(t => t.EmployeeId)
                .Index(t => t.ProductionLine_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Attendance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductPL",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductOperationId = c.Int(nullable: false),
                        ProductionLineId = c.Int(nullable: false),
                        ProductOperation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductionLine", t => t.ProductionLineId, cascadeDelete: true)
                .ForeignKey("dbo.ProductOperation", t => t.ProductOperationId)
                .ForeignKey("dbo.ProductOperation", t => t.ProductOperation_Id)
                .Index(t => t.ProductOperationId)
                .Index(t => t.ProductionLineId)
                .Index(t => t.ProductOperation_Id);
            
            CreateTable(
                "dbo.StoragePO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductOperationId = c.Int(nullable: false),
                        StorageId = c.Int(nullable: false),
                        ProductOperation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Storage", t => t.StorageId, cascadeDelete: true)
                .ForeignKey("dbo.ProductOperation", t => t.ProductOperationId)
                .ForeignKey("dbo.ProductOperation", t => t.ProductOperation_Id)
                .Index(t => t.ProductOperationId)
                .Index(t => t.StorageId)
                .Index(t => t.ProductOperation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planned", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Shift", "ProductionLine_Id", "dbo.ProductionLine");
            DropForeignKey("dbo.Plan", "ProdLineId", "dbo.ProductionLine");
            DropForeignKey("dbo.ProductionLine", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.ProductOperation", "Department_Id1", "dbo.Department");
            DropForeignKey("dbo.ProductOperation", "Department_Id", "dbo.Department");
            DropForeignKey("dbo.StoragePO", "ProductOperation_Id", "dbo.ProductOperation");
            DropForeignKey("dbo.StoragePO", "ProductOperationId", "dbo.ProductOperation");
            DropForeignKey("dbo.StoragePO", "StorageId", "dbo.Storage");
            DropForeignKey("dbo.ProductOperation", "SourceId", "dbo.Department");
            DropForeignKey("dbo.Product", "ProductOperation_Id", "dbo.ProductOperation");
            DropForeignKey("dbo.ProductPL", "ProductOperation_Id", "dbo.ProductOperation");
            DropForeignKey("dbo.ProductPL", "ProductOperationId", "dbo.ProductOperation");
            DropForeignKey("dbo.ProductPL", "ProductionLineId", "dbo.ProductionLine");
            DropForeignKey("dbo.Employee", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Shift", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.DailyProd", "ShiftId", "dbo.Shift");
            DropForeignKey("dbo.ProductOperation", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Employee", "FactoryId", "dbo.Factory");
            DropForeignKey("dbo.ProductRemain", "StorageId", "dbo.Storage");
            DropForeignKey("dbo.ProductRemain", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Storage", "FactoryId", "dbo.Factory");
            DropForeignKey("dbo.Employee", "StorageId", "dbo.Storage");
            DropForeignKey("dbo.Storage", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.ProductionLine", "FactoryId", "dbo.Factory");
            DropForeignKey("dbo.Employee", "Factory_Id", "dbo.Factory");
            DropForeignKey("dbo.Factory", "DirectorId", "dbo.Employee");
            DropForeignKey("dbo.ProductOperation", "DestinationId", "dbo.Department");
            DropForeignKey("dbo.Planned", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.DailyProd", "ProductId", "dbo.Product");
            DropIndex("dbo.StoragePO", new[] { "ProductOperation_Id" });
            DropIndex("dbo.StoragePO", new[] { "StorageId" });
            DropIndex("dbo.StoragePO", new[] { "ProductOperationId" });
            DropIndex("dbo.ProductPL", new[] { "ProductOperation_Id" });
            DropIndex("dbo.ProductPL", new[] { "ProductionLineId" });
            DropIndex("dbo.ProductPL", new[] { "ProductOperationId" });
            DropIndex("dbo.Shift", new[] { "ProductionLine_Id" });
            DropIndex("dbo.Shift", new[] { "EmployeeId" });
            DropIndex("dbo.ProductRemain", new[] { "ProductId" });
            DropIndex("dbo.ProductRemain", new[] { "StorageId" });
            DropIndex("dbo.Storage", new[] { "DepartmentId" });
            DropIndex("dbo.Storage", new[] { "FactoryId" });
            DropIndex("dbo.Factory", new[] { "DirectorId" });
            DropIndex("dbo.Employee", new[] { "Factory_Id" });
            DropIndex("dbo.Employee", new[] { "FactoryId" });
            DropIndex("dbo.Employee", new[] { "StorageId" });
            DropIndex("dbo.Employee", new[] { "StatusId" });
            DropIndex("dbo.Employee", new[] { "PositionId" });
            DropIndex("dbo.ProductOperation", new[] { "Department_Id1" });
            DropIndex("dbo.ProductOperation", new[] { "Department_Id" });
            DropIndex("dbo.ProductOperation", new[] { "EmployeeId" });
            DropIndex("dbo.ProductOperation", new[] { "DestinationId" });
            DropIndex("dbo.ProductOperation", new[] { "SourceId" });
            DropIndex("dbo.ProductionLine", new[] { "FactoryId" });
            DropIndex("dbo.ProductionLine", new[] { "DepartmentId" });
            DropIndex("dbo.Plan", new[] { "ProdLineId" });
            DropIndex("dbo.Planned", new[] { "ProductId" });
            DropIndex("dbo.Planned", new[] { "PlanId" });
            DropIndex("dbo.Product", new[] { "ProductOperation_Id" });
            DropIndex("dbo.DailyProd", new[] { "ShiftId" });
            DropIndex("dbo.DailyProd", new[] { "ProductId" });
            DropTable("dbo.StoragePO");
            DropTable("dbo.ProductPL");
            DropTable("dbo.Status");
            DropTable("dbo.Shift");
            DropTable("dbo.Position");
            DropTable("dbo.ProductRemain");
            DropTable("dbo.Storage");
            DropTable("dbo.Factory");
            DropTable("dbo.Employee");
            DropTable("dbo.ProductOperation");
            DropTable("dbo.Department");
            DropTable("dbo.ProductionLine");
            DropTable("dbo.Plan");
            DropTable("dbo.Planned");
            DropTable("dbo.Product");
            DropTable("dbo.DailyProd");
        }
    }
}
