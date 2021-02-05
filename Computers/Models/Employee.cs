using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Peripherals = new HashSet<Peripheral>();
        }

        [ForeignKey("Computer")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public int? ComputerId { get; set; }
        public Computer Computer { get; set; }
        public virtual ICollection<Peripheral> Peripherals { get; set; }
    }
}
