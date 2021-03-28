using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Device
    {
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int Price { get; set; }
        public Status Status { get; set; }
    }
}
