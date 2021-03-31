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
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        public DateTime BeginDate { get; set; }
        public int EndDate { get; set; }
        public string Explaining { get; set; }

        public virtual List<DailyProd> DailyProds { get; set; }

        public int ProductionLineId { get; set; }
        [ForeignKey("ProductionLineId")]
        public ProductionLine ProductionLine { get; set; }

        public int ForemanId { get; set; }
        [ForeignKey("ForemanId")]
        public Employee Foreman { get; set; }
    }
}
