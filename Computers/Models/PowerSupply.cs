using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class PowerSupply : Device
    {
        public PowerSupply() {}
        public int Id { get; set; }
        public int Power { get; set; }
        public Computer Computer { get; set; }
    }
}
