using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
    public class GradingSystem
    {
        [Key]
        public int GradingSystemId { get; set; }
        public int MaxGrade { get; set; }
        public int MinGrade { get; set; }

        public School School { get; set; }
    }
}
