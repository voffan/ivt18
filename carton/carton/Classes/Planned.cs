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
        public int plan_production { get; set; }
        public bool complete { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        Product product { get; set; }
    }
}
