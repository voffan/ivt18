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
    public class Planned
    {
        [Key]
        public int Id { get; set; }
        public int PlanProduction { get; set; }
        public bool Complete { get; set; }
        
        public int PlanId { get; set; }
        [ForeignKey("PlanId")]
        public Plan Plan { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        //public List<Product> Products { get; set; }
        //public List<Plan> Plans { get; set; }
    }
}
