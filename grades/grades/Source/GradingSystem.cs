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
        [ForeignKey("School")]
        public int GradingSystemId { get; set; }
        [StringLength(1)]
        public String MaxGrade { get; set; }
        [StringLength(1)]
        public String MinGrade { get; set; }

        public virtual School School { get; set; }
    }
}
