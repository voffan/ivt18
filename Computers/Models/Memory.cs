using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Memory : Device
    {
        public Memory() {}
        public int Id { get; set; }
        public int Amount { get; set; }
        public Computer Computer { get; set; }
    }
}
