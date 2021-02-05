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
        public Student Student
        {
            get
            {
                return student;
            }
            set
            {
                this.student = value;
            }
        }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
      
        public Course course { get; set; }

        /// <summary>
        /// Property for Course
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Course Course
        {
            get
            {
                return course;
            }
            set
            {
                this.course = value;
            }
        }

        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public CheckPoint checkPoint { get; set; }

        /// <summary>
        /// Property for CheckPoint
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public CheckPoint CheckPoint
        {
            get
            {
                return checkPoint;
            }
            set
            {
                this.checkPoint = value;
            }
        }

        public int StudyYearId { get; set; }
        [ForeignKey("StudyYearId")]
        public StudyYear studyYear { get; set; }

        /// <summary>
        /// Property for StudyYear
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public StudyYear StudyYear
        {
            get
            {
                return studyYear;
            }
            set
            {
                this.studyYear = value;
            }
        }

    }
}
