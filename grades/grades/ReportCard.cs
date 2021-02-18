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
        public int estimate { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]

        public Student student { get; set; }

        /// <summary>
        /// Property for Student
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
       

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
      
        public Course course { get; set; }

       

        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public CheckPoint checkPoint { get; set; }

       

        public int StudyYearId { get; set; }
        [ForeignKey("StudyYearId")]
        public StudyYear studyYear { get; set; }

       

    }
}
