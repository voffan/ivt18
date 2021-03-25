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
    public enum PlanStatus { New, InProgress, Completed, Approved }

    public class Plan
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public PlanStatus Status { get; set; }
        
        public List<Planned> Planneds { get; set; }
        public int ProdLineId { get; set; }
        [ForeignKey("ProdLineId")]
        public ProductionLine ProductionLine { get; set; }

    }
}
