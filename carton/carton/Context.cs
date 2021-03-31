using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace carton
{
    public class Context : DbContext
    {
        public Context() : base("CartonConnStr") { }

        public DbSet<DailyProd> DailyProds { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Planned> Planneds { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductionLine> ProductionLines { get; set; }
        public DbSet<ProductOperation> ProductOperations { get; set; }
        public DbSet<ProductRemain> ProductRemains { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<ProductMovement> ProductMovements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<ProductOperation>()
                .HasRequired<Department>(p => p.Source)
                .WithMany(d => d.Sources)
                .HasForeignKey(p => p.SourceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductOperation>()
                .HasRequired<Department>(p => p.Destination)
                .WithMany(d => d.Destinations)
                .HasForeignKey(p => p.DestinationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shift>()
                .HasRequired<ProductionLine>(p => p.ProductionLine)
                .WithMany(d => d.Shifts)
                .HasForeignKey(p => p.ProductionLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shift>()
                .HasRequired<Employee>(s => s.Foreman)
                .WithMany(e => e.Shifts)
                .HasForeignKey(s => s.ForemanId);

            modelBuilder.Entity<Factory>()
                .HasOptional(f => f.Director)
                .WithMany()
                .HasForeignKey(f => f.DirectorId);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Factory)
                .WithMany(f => f.Employees)
                .HasForeignKey(e => e.FactoryId);

            //modelBuilder.Entity<Employee>()
            //    .HasOptional<Factory>(e => e.Factory)
            //    .WithMany(f => f.Employees)
            //    .HasForeignKey(e => e.FactoryId);

            //modelBuilder.Entity<ProductOperation>()
            //.HasOptional<Department>(s => s.Source)
            //.WithMany()
            //.HasForeignKey(s => s.SourceId)
            //.WillCascadeOnDelete(false);

            //modelBuilder.Entity<ProductOperation>()
            //.HasOptional<Department>(s => s.Destination)
            //.WithMany()
            //.HasForeignKey(s => s.DestinationId)
            //.WillCascadeOnDelete(false);
        }
    }
}
