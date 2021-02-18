using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
    class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public int GradingSystemId { get; set; }
        [ForeignKey("StudentId")]
        public GradingSystem GradingSystem { get; set; }
    }
}
