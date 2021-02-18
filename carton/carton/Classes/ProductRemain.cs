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
    public class ProductRemain
    {
        [Key]
        public int Id { get; set; }

        public int Remainings { get; set; }
        
        public string ProductName { get; set; }
        [ForeignKey("ProductName")]
        public Product Product { get; set; }
    }
}
