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
        public int studentId { get; set; }
        public String fullname { get; set; }
        public int phonenumber { get; set; }
        public String homeadress { get; set; }

        public int GroupId{get;set;}
        [ForeignKey("GroupId")]
        public Group Group{get;set;}
    }
}
