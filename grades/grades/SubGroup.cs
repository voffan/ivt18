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
        [ForeignKey("studentId")]
        public int studentId { get; set; }
        public String name { get; set; }
        public int groupId { get; set; }
        [ForeignKey("groupId")]
        public Group group { get; set; }
        public int subjectId { get; set; }
        [ForeignKey("subjectId")]
        public Subject subject { get; set; }

        public System.Collections.ArrayList student;

        /// <summary>
        /// Property for collection of Student
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Student
        {
            get
            {
                if (student == null)
                    student = new System.Collections.ArrayList();
                return student;
            }
            set
            {
                RemoveAllStudent();
                if (value != null)
                {
                    foreach (Student oStudent in value)
                        AddStudent(oStudent);
                }
            }
        }

        /// <summary>
        /// Add a new Student in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddStudent(Student newStudent)
        {
            if (newStudent == null)
                return;
            if (this.student == null)
                this.student = new System.Collections.ArrayList();
            if (!this.student.Contains(newStudent))
                this.student.Add(newStudent);
        }

        /// <summary>
        /// Remove an existing Student from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveStudent(Student oldStudent)
        {
            if (oldStudent == null)
                return;
            if (this.student != null)
                if (this.student.Contains(oldStudent))
                    this.student.Remove(oldStudent);
        }

        /// <summary>
        /// Remove all instances of Student from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllStudent()
        {
            if (student != null)
                student.Clear();
        }
    }
}
