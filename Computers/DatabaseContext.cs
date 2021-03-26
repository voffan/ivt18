using Computers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DbConnectionString Mikhailov") {}
        public DbSet<Status> Statuses { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<PeripheralType> PeripheralTypes { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<GraphicCard> GraphicCards { get; set; }
        public DbSet<HardDrive> HardDrives { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<DiskDrive> DiskDrives { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Peripheral> Peripherals { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
