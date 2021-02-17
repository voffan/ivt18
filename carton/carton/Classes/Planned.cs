using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    public class Planned
    {
        [Key]
        public int id { get; set; }
        private int plan_production { get; set; }
        private bool complete { get; set; }
        
        public List<Product> products { get; set; }
        public List<Plan> plans { get; set; }
    }
}
