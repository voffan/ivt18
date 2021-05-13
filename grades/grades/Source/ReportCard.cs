﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
    public enum CheckPoint{
        firstQuarter,
        secondQuarter,
        firstHalfYear,
        thirdQuarter,
        fourthQuarter,
        secondHalfYear,
        year
    }
    public class ReportCard
    {
        [Key]
        public int ReportCardId { get; set; }

        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public CheckPoint CheckPoint { get; set; }

        public int StudyYearId { get; set; }
        [ForeignKey("StudyYearId")]
        public StudyYear StudyYear { get; set; }
    }
}
