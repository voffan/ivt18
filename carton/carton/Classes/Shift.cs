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
        public string begin_date; //TO-DO string
        public int end_date;
        public string explaining;

        public DailyProd daily_prod;
        public Employee foreman;
    }
}
