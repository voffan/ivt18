using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Peripheral : Device
    {
        public Peripheral()
        {
            this.Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }
        public PeripheralType PeripheralType { get; set; }
        public int Price { get; set; }
        public string ItemNo { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
