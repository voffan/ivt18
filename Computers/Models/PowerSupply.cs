using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class PowerSupply : Device
    {
        public PowerSupply()
        {
            this.Computers = new HashSet<Computer>();
        }
        public int Id { get; set; }
        public int Power { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
    }
}
