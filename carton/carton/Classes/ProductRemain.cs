using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Data.Entity.Spatial;

namespace carton
{
    public class ProductRemain
    {
        [Key]
        public int Id { get; set; }

        public int Remainings { get; set; }

        public int StorageId { get; set; }
        [ForeignKey("StorageId")]
        public Storage Storage { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        //public virtual List<Product> Products { get; set; }
        //public virtual List<Storage> Storages { get; set; }
    }
}
