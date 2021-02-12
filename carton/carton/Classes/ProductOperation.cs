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
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int amount { get; set; }
        public Department source { get; set; }
        public Department destination { get; set; }
        public Date Date { get; set; } //TO-DO string

        public List<ProductPL> Production_line { get; set; }

        public string[] stor_names { get; set; }
        [ForeignKey("stor_names")]
        public Storage[] storage { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
