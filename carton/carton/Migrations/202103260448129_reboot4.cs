namespace carton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reboot4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyProds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Production = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ShiftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Shifts", t => t.ShiftId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ShiftId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductOperation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductOperations", t => t.ProductOperation_Id)
                .Index(t => t.ProductOperation_Id);
            
            CreateTable(
                "dbo.Planneds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlanProduction = c.Int(nullable: false),
                        Complete = c.Boolean(nullable: false),
                        PlanId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plans", t => t.PlanId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.PlanId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        ProdLineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.ProdLineId, cascadeDelete: true)
                .Index(t => t.ProdLineId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        FactoryId = c.Int(),
                        FactoryId1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factories", t => t.FactoryId, cascadeDelete: true)
                .ForeignKey("dbo.Factories", t => t.FactoryId1, cascadeDelete: true)
                .Index(t => t.FactoryId)
                .Index(t => t.FactoryId1);
            
            CreateTable(
                "dbo.ProductOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SourceId = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Department_Id = c.Int(),
                        Department_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id1)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DestinationId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.SourceId, cascadeDelete: true)
                .Index(t => t.SourceId)
                .Index(t => t.DestinationId)
                .Index(t => t.EmployeeId)
                .Index(t => t.Department_Id)
                .Index(t => t.Department_Id1);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Fathername = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        PositionId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        ContactPhone = c.String(),
                        Address = c.String(),
                        StorageId = c.Int(),
                        FactoryId = c.Int(),
                        Factory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factories", t => t.Factory_Id)
                .ForeignKey("dbo.Factories", t => t.FactoryId)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.StorageId)
                .Index(t => t.PositionId)
                .Index(t => t.StatusId)
                .Index(t => t.StorageId)
                .Index(t => t.FactoryId)
                .Index(t => t.Factory_Id);
            
            CreateTable(
                "dbo.Factories",
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
                .ForeignKey("dbo.Employees", t => t.DirectorId, cascadeDelete: true)
                .Index(t => t.DirectorId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.Int(nullable: false),
                        Explaining = c.String(),
                        ProductionLineId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.ProductionLineId, cascadeDelete: true)
                .Index(t => t.ProductionLineId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Attendance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRemains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remainings = c.Int(nullable: false),
                        StorageId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.StorageId, cascadeDelete: true)
                .Index(t => t.StorageId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planneds", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Plans", "ProdLineId", "dbo.Departments");
            DropForeignKey("dbo.ProductOperations", "SourceId", "dbo.Departments");
            DropForeignKey("dbo.Products", "ProductOperation_Id", "dbo.ProductOperations");
            DropForeignKey("dbo.ProductOperations", "DestinationId", "dbo.Departments");
            DropForeignKey("dbo.ProductRemains", "StorageId", "dbo.Departments");
            DropForeignKey("dbo.ProductRemains", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Employees", "StorageId", "dbo.Departments");
            DropForeignKey("dbo.Employees", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Shifts", "ProductionLineId", "dbo.Departments");
            DropForeignKey("dbo.Shifts", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.DailyProds", "ShiftId", "dbo.Shifts");
            DropForeignKey("dbo.ProductOperations", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Employees", "FactoryId", "dbo.Factories");
            DropForeignKey("dbo.Departments", "FactoryId1", "dbo.Factories");
            DropForeignKey("dbo.Departments", "FactoryId", "dbo.Factories");
            DropForeignKey("dbo.Employees", "Factory_Id", "dbo.Factories");
            DropForeignKey("dbo.Factories", "DirectorId", "dbo.Employees");
            DropForeignKey("dbo.ProductOperations", "Department_Id1", "dbo.Departments");
            DropForeignKey("dbo.ProductOperations", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Planneds", "PlanId", "dbo.Plans");
            DropForeignKey("dbo.DailyProds", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductRemains", new[] { "ProductId" });
            DropIndex("dbo.ProductRemains", new[] { "StorageId" });
            DropIndex("dbo.Shifts", new[] { "EmployeeId" });
            DropIndex("dbo.Shifts", new[] { "ProductionLineId" });
            DropIndex("dbo.Factories", new[] { "DirectorId" });
            DropIndex("dbo.Employees", new[] { "Factory_Id" });
            DropIndex("dbo.Employees", new[] { "FactoryId" });
            DropIndex("dbo.Employees", new[] { "StorageId" });
            DropIndex("dbo.Employees", new[] { "StatusId" });
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropIndex("dbo.ProductOperations", new[] { "Department_Id1" });
            DropIndex("dbo.ProductOperations", new[] { "Department_Id" });
            DropIndex("dbo.ProductOperations", new[] { "EmployeeId" });
            DropIndex("dbo.ProductOperations", new[] { "DestinationId" });
            DropIndex("dbo.ProductOperations", new[] { "SourceId" });
            DropIndex("dbo.Departments", new[] { "FactoryId1" });
            DropIndex("dbo.Departments", new[] { "FactoryId" });
            DropIndex("dbo.Plans", new[] { "ProdLineId" });
            DropIndex("dbo.Planneds", new[] { "ProductId" });
            DropIndex("dbo.Planneds", new[] { "PlanId" });
            DropIndex("dbo.Products", new[] { "ProductOperation_Id" });
            DropIndex("dbo.DailyProds", new[] { "ShiftId" });
            DropIndex("dbo.DailyProds", new[] { "ProductId" });
            DropTable("dbo.ProductRemains");
            DropTable("dbo.Status");
            DropTable("dbo.Shifts");
            DropTable("dbo.Positions");
            DropTable("dbo.Factories");
            DropTable("dbo.Employees");
            DropTable("dbo.ProductOperations");
            DropTable("dbo.Departments");
            DropTable("dbo.Plans");
            DropTable("dbo.Planneds");
            DropTable("dbo.Products");
            DropTable("dbo.DailyProds");
        }
    }
}
