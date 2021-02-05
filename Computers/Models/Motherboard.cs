using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class Motherboard : Device
    {
        public Motherboard()
        {
            this.Computers = new HashSet<Computer>();
        }

        public int Id { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
    }
}
