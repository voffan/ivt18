namespace carton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reboot : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
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
                .ForeignKey("dbo.Department", t => t.ProdLineId, cascadeDelete: true)
                .Index(t => t.ProdLineId);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        FactoryId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factory", t => t.FactoryId)
                .Index(t => t.FactoryId);
            
            CreateTable(
                "dbo.ProductOperation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SourceId = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .ForeignKey("dbo.Department", t => t.DestinationId)
                .ForeignKey("dbo.Department", t => t.SourceId)
                .Index(t => t.SourceId)
                .Index(t => t.DestinationId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employee",
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
                        FactoryDirectorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factory", t => t.FactoryDirectorId)
                .ForeignKey("dbo.Factory", t => t.FactoryId)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Department", t => t.StorageId)
                .Index(t => t.PositionId)
                .Index(t => t.StatusId)
                .Index(t => t.StorageId)
                .Index(t => t.FactoryId)
                .Index(t => t.FactoryDirectorId);
            
            CreateTable(
                "dbo.Factory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        INN = c.String(),
                        ContactPhone = c.String(),
                        DirectorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.DirectorId)
                .Index(t => t.DirectorId);
            
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
                        ProductionLineId = c.Int(nullable: false),
                        ForemanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.ForemanId, cascadeDelete: true)
                .ForeignKey("dbo.Department", t => t.ProductionLineId)
                .Index(t => t.ProductionLineId)
                .Index(t => t.ForemanId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Attendance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .ForeignKey("dbo.Department", t => t.StorageId, cascadeDelete: true)
                .Index(t => t.StorageId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductMovement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductOperationId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.ProductOperation", t => t.ProductOperationId, cascadeDelete: true)
                .Index(t => t.ProductOperationId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planned", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Plan", "ProdLineId", "dbo.Department");
            DropForeignKey("dbo.ProductOperation", "SourceId", "dbo.Department");
            DropForeignKey("dbo.ProductMovement", "ProductOperationId", "dbo.ProductOperation");
            DropForeignKey("dbo.ProductMovement", "ProductId", "dbo.Product");
            DropForeignKey("dbo.ProductOperation", "DestinationId", "dbo.Department");
            DropForeignKey("dbo.ProductRemain", "StorageId", "dbo.Department");
            DropForeignKey("dbo.ProductRemain", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Employee", "StorageId", "dbo.Department");
            DropForeignKey("dbo.Employee", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Shift", "ProductionLineId", "dbo.Department");
            DropForeignKey("dbo.Shift", "ForemanId", "dbo.Employee");
            DropForeignKey("dbo.DailyProd", "ShiftId", "dbo.Shift");
            DropForeignKey("dbo.ProductOperation", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Employee", "FactoryId", "dbo.Factory");
            DropForeignKey("dbo.Employee", "FactoryDirectorId", "dbo.Factory");
            DropForeignKey("dbo.Department", "FactoryId", "dbo.Factory");
            DropForeignKey("dbo.Factory", "DirectorId", "dbo.Employee");
            DropForeignKey("dbo.Planned", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.DailyProd", "ProductId", "dbo.Product");
            DropIndex("dbo.ProductMovement", new[] { "ProductId" });
            DropIndex("dbo.ProductMovement", new[] { "ProductOperationId" });
            DropIndex("dbo.ProductRemain", new[] { "ProductId" });
            DropIndex("dbo.ProductRemain", new[] { "StorageId" });
            DropIndex("dbo.Shift", new[] { "ForemanId" });
            DropIndex("dbo.Shift", new[] { "ProductionLineId" });
            DropIndex("dbo.Factory", new[] { "DirectorId" });
            DropIndex("dbo.Employee", new[] { "FactoryDirectorId" });
            DropIndex("dbo.Employee", new[] { "FactoryId" });
            DropIndex("dbo.Employee", new[] { "StorageId" });
            DropIndex("dbo.Employee", new[] { "StatusId" });
            DropIndex("dbo.Employee", new[] { "PositionId" });
            DropIndex("dbo.ProductOperation", new[] { "EmployeeId" });
            DropIndex("dbo.ProductOperation", new[] { "DestinationId" });
            DropIndex("dbo.ProductOperation", new[] { "SourceId" });
            DropIndex("dbo.Department", new[] { "FactoryId" });
            DropIndex("dbo.Plan", new[] { "ProdLineId" });
            DropIndex("dbo.Planned", new[] { "ProductId" });
            DropIndex("dbo.Planned", new[] { "PlanId" });
            DropIndex("dbo.DailyProd", new[] { "ShiftId" });
            DropIndex("dbo.DailyProd", new[] { "ProductId" });
            DropTable("dbo.ProductMovement");
            DropTable("dbo.ProductRemain");
            DropTable("dbo.Status");
            DropTable("dbo.Shift");
            DropTable("dbo.Position");
            DropTable("dbo.Factory");
            DropTable("dbo.Employee");
            DropTable("dbo.ProductOperation");
            DropTable("dbo.Department");
            DropTable("dbo.Plan");
            DropTable("dbo.Planned");
            DropTable("dbo.Product");
            DropTable("dbo.DailyProd");
        }
    }
}
