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
    public class ProductionLine
    {
        public string name { get; set; }

        public string departmentName { get; set; }
        [ForeignKey("departmentName")]
        public Department department { get; set; }

        public string beginShifts { get; set; }
        [ForeignKey("beginShifts")]
        public Shift[] shifts { get; set; }

        public List<ProductPL> ProductOperations { get; set; }
    }
}
