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
    public class Product
    {
        [Key]
        public int Id { get; set; }
        private string Name { get; set; }

        public List<Planned> planneds { get; set; }
        public List<ProductRemain> productRemains { get; set; }

        public int shiftId { get; set; }
        [ForeignKey("shiftId")]
        public DailyProd? dailyProd { get; set; } //nullable error
    }
}
