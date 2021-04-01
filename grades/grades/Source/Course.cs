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
        public int CourseId { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        public int? SubGroupId { get; set; }
        [ForeignKey("SubGroupId")]
        public SubGroup SubGroup { get; set; }

       
        public int StaffId { get; set; }
        [ForeignKey("StaffId")]
        public Staff Teacher { get; set; }
    }
}
