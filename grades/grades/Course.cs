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
    public class Course
    {
        [Key]
        public int gradesId { get; set; }

        [ForeignKey("subjectId")]
        public Subject subject { get; set; }

        public int groupId { get; set; }
        [ForeignKey("groupId")]
        public Group group { get; set; }
        public SubGroup subGroup { get; set; }

       
        public int sraffId { get; set; }
        [ForeignKey("staffId")]
        public Staff teacher { get; set; }
    }
}
