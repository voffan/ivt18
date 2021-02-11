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
    public class DailyProd
    {
        public int daily_prod { get; set; }

        public string name { get; set; }
        [ForeignKey("name")]
        public Product product { get; set; }
    }
}
