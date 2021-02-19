using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace carton
{
    class Context : DbContext
    {
        public Context() : base("CartonConnStr") { }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Planned> Planneds { get; set; }
        public DbSet<ProductionLine> ProductionLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
