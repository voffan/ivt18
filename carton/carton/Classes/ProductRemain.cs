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
        public int remainings { get; set; }
        
        public string productName { get; set; }
        [ForeignKey("productName")]
        public Product product { get; set; }
    }
}
