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
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public int Year { get; set; }
        public char Letter { get; set; }

        public int SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }

        public virtual List<Student> Students {get;set;}

        public int StaffId { get; set; }
        [ForeignKey("staffId")]
        public Staff Curator { get; set; }
    }
}