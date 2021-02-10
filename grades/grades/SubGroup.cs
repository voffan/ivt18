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
        public int subgroupId{get;set;}

        public int studentId { get; set;} 
        [ForeignKey("studentId")]

        public String name { get; set; }
        public int groupId { get; set; }
        [ForeignKey("groupId")]
        public Group group { get; set; }
        public int subjectId { get; set; }
        [ForeignKey("subjectId")]
        public Subject subject { get; set; }

        public List<StudentSubGroup> Student { get; set; }

        StudentSubGroup studentsubgroup = new StudentSubGroup();

    

        
       
    }
}
