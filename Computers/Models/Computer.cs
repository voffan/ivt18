using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Computer : Device
    {
        public Computer()
        {
            this.PowerSupplies = new HashSet<PowerSupply>();
            this.Memories = new HashSet<Memory>();
            this.HardDrives = new HashSet<HardDrive>();
            this.GraphicCards = new HashSet<GraphicCard>();
        }
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public string ItemNo { get; set; }
        public int TotalPrice { get; set; }

        // One-to-one
        public virtual Employee Employee { get; set; }

        // One-to-many
        public int? DiskDriveId { get; set; }
        public int? ProcessorId { get; set; }
        public int? MotherboardId { get; set; }
        public virtual DiskDrive DiskDrive { get; set; }
        public virtual Processor Processor { get; set; }
        public virtual Motherboard Motherboard { get; set; }
        

        public virtual ICollection<PowerSupply> PowerSupplies { get; set; }
        public virtual ICollection<Memory> Memories { get; set; }
        public virtual ICollection<HardDrive> HardDrives { get; set; }
        public virtual ICollection<GraphicCard> GraphicCards { get; set; }

    }
}
