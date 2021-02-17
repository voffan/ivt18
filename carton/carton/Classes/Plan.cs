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
    public class Plan
    {
        [Key]
        public int id { get; set; }
        private string name { get; set; }
        private DateTime date { get; set; }
        public List<Plan> plans { get; set; }
        
        public List<Planned> planneds { get; set; }
        public int prodLineId { get; set; }
        [ForeignKey("prodLineId")]
        public ProductionLine productionLine { get; set; }

    }
}
