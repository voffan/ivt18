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
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //public int? ProductOperationId { get; set; }
        //[ForeignKey("ProductOperationId")]
        //public ProductOperation ProductOperation { get; set; }

        public virtual List<Planned> Planneds { get; set; }
        public virtual List<ProductRemain> ProductRemains { get; set; }

        public virtual List<ProductMovement> ProductMovements { get; set; }
        public virtual List<DailyProd> DailyProds { get; set; }

    }
}
