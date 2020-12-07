using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    public class ReportCard
    {
        private int estimate;

        public Student student;

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
        public Course course;

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
        public CheckPoint checkPoint;

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
        public StudyYear studyYear;

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
