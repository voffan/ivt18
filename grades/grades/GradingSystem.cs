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
    class GradingSystem
    {
        [Key]
        public int gradingSystemId { get; set; }
        public int maxGrade { get; set; }
        public int minGrade { get; set; }
    }
}
