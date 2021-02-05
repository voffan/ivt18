using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class HardDrive : Device
    {
        public HardDrive()
        {
            this.Computers = new HashSet<Computer>();
        }
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
    }
}
