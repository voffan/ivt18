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
    public class StudentSubGroup
    {
        [Key]
        public int StudentSubGroupId { get; set; }

        public int SubGroupId { get; set; }
        [ForeignKey("SubGroupId")]
        public Group SubGroup { get; set; }


        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

    }
}
