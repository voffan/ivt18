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

        public List<Planned> Planneds { get; set; }
        public List<ProductRemain> ProductRemains { get; set; }

        public int? ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public DailyProd DailyProd { get; set; }
    }
}
