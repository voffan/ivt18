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
    public class Shift
    {
        public string begin_date { get; set; } //TO-DO string
        public int end_date { get; set; }
        public string explaining { get; set; }

        public string name { get; set; }
        [ForeignKey("name")]
        public DailyProd daily_prod { get; set; }

        public string employeeName { get; set; }
        [ForeignKey("employeeName")]
        public Employee foreman { get; set; }
    }
}
