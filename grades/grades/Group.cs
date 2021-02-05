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

        public List<Student> Students {get;set;}

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

        public int staffId { get; set; }
        [ForeignKey("staffId")]
        public Staff curator { get; set; }
    }
}