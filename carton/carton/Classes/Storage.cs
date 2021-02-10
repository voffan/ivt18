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
    public class Storage
    {
        public string name { get; set; }

        public string departmentName { get; set; }
        [ForeignKey("departmentName")]
        public Department department { get; set; }

        public int productRemaining { get; set; }
        [ForeignKey("productRemaining")]
        public ProductRemain product_remain { get; set; }

        public string[] employeeNames { get; set; }
        [ForeignKey("employeeNames")]
        public Employee[] employees { get; set; }
    }
}
