using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Models
{
    public class GraphicCard : Device
    {
        public GraphicCard() {}
        public int Id { get; set; }
        public string Value { get; set; }
        public int Price { get; set; }
        public Computer Computer { get; set; }
    }
}
