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
        
        public virtual List<Product> Products { get; set; }
        public virtual List<Storage> Storages { get; set; }
    }
}
