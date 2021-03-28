using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class HardDrive : Device
    {
        public HardDrive() {}
        public int Id { get; set; }
        public int Capacity { get; set; }
        public Computer Computer { get; set; }
    }
}
