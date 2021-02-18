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
    public class ReportCard
    {
        [Key]
        public int ReportCardId { get; set; }
        public int Grade { get; set; }
        [ForeignKey("GradeID")]
        

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 0c051af2a8fb2e4da65ea215dc7917a685a80e6b


        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
      
        public Course Course { get; set; }

<<<<<<< HEAD
=======
       
>>>>>>> 0c051af2a8fb2e4da65ea215dc7917a685a80e6b

        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public CheckPoint CheckPoint { get; set; }

<<<<<<< HEAD
=======
       
>>>>>>> 0c051af2a8fb2e4da65ea215dc7917a685a80e6b

        public int StudyYearId { get; set; }
        [ForeignKey("StudyYearId")]
        public StudyYear StudyYear { get; set; }

<<<<<<< HEAD
=======
       
>>>>>>> 0c051af2a8fb2e4da65ea215dc7917a685a80e6b
        public virtual List<StudentSubGroup> Students { get; set; }
    }
}
