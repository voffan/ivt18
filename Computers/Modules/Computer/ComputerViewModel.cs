using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Computer
{
    public class ComputerViewModel
    {
        public Dictionary<string, Models.Employee> Employees = new Dictionary<string, Models.Employee> { };
        public Dictionary<string, Models.Processor> Processors = new Dictionary<string, Models.Processor> { };
        public Dictionary<string, Models.Motherboard> Motherboards = new Dictionary<string, Models.Motherboard> { };
        public Dictionary<string, Models.DiskDrive> DiskDrives = new Dictionary<string, Models.DiskDrive> { };

        public Dictionary<string, Models.PowerSupply> PowerSupplies = new Dictionary<string, Models.PowerSupply> { };
        public Dictionary<string, Models.Memory> Memories = new Dictionary<string, Models.Memory> { };        
        public Dictionary<string, Models.HardDrive> HardDrives = new Dictionary<string, Models.HardDrive> { };
        public Dictionary<string, Models.GraphicCard> GraphicCards = new Dictionary<string, Models.GraphicCard> { };
    }
}
