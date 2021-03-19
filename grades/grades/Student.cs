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
    public class Student : Person
    {
        public int? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        public virtual List<StudentSubGroup> SubGroups { get; set; }

        public virtual List<ReportCard> ReportCards { get; set; }
    }
}
