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
        public int gradesId;
        [ForeignKey("subjectId")]
        private Subject subject;
        [ForeignKey("groupId")]
        private Group group;
        private SubGroup subGroup;
        [ForeignKey("staffId")]
        private Staff teacher;
    }
}
