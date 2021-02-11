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
    public class ProductOperation
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public Department source { get; set; }
        public Department destination { get; set; }
        public string date { get; set; } //TO-DO string

        public string[] prod_line_names { get; set; }
        [ForeignKey("prod_line_names")]
        public ProductionLine[] production_line { get; set; }

        public string[] stor_names { get; set; }
        [ForeignKey("stor_names")]
        public Storage[] storage { get; set; }

        public string employeeName { get; set; }
        [ForeignKey("employeeName")]
        public Employee employee { get; set; }
    }
}
