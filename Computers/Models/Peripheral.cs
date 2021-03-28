using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Peripheral : Device
    {
        public Peripheral() {}
        public int Id { get; set; }
        public PeripheralType PeripheralType { get; set; }
        public string ItemNo { get; set; }
        public Employee Employee { get; set; }
    }
}
