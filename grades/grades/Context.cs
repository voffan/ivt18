using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace grades
{
    class Context : DbContext
    {
        public Context() : base() { }

       //public DbSet<CheckPoint> CheckPoints { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Grade> Grades { get; set; }
        public DbSet<GradingSystem> GradingSystems { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Position> Postitions { get; set; }
        public DbSet<ReportCard> ReportCards { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubGroup> StudentSubGroups { get; set; }
        public DbSet<StudyYear> StudyYears { get; set; }
        public DbSet<SubGroup> SubGroups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
