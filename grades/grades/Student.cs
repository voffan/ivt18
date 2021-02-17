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
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public String Fullname { get; set; }
        public int Phonenumber { get; set; }
        public String Homeadress { get; set; }

        public int GroupId{get;set;}
        [ForeignKey("GroupId")]
        public Group Group{get;set;}

        public List<StudentSubGroup> SubGroups { get; set; }

        public List<ReportCard> ReportCards { get; set; }
    }
}
