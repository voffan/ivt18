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

        public int DailyProdId { get; set; }
        [ForeignKey("DailyProdId")]
        public DailyProd DailyProd { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Foreman { get; set; }
    }
}
