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
    public class DailyProd
    {
        [Key]
        public int Id { get; set; }
        public int Production { get; set; }

        public int ProductId { get; set; }

        public DateTime Date { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public Shift Shift { get; set; }
    }
}
