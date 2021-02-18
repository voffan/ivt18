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
    public class SubGroup
    {
        [Key ]
        public int SubGroupId{get;set;}

        public int StudentId { get; set;} 
        [ForeignKey("StudentId")]

        public String Name { get; set; }
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public virtual List<StudentSubGroup> Students { get; set; }

    }
}
