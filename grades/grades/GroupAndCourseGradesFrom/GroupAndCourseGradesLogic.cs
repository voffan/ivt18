using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    class GroupAndCourseGradesLogic
    {
        private int checkPointsNum = 7;
        
        internal List<dynamic> GetSubjectsList(Context context, Person user)
        {
            var courses = context.Courses
                .Where(c => c.StaffId == user.PersonId)
                .Select(c => new { Id = c.Subject.SubjectId, SubjectName = c.Subject.Name })
                .Distinct().ToList<dynamic>();
            return courses;
        }

        internal List<dynamic> GetGroupList(Context context, int subjectId, Person user)
        {
            var groups = context.Groups
                .Where(g => (context.Courses.Where(c => c.SubjectId == subjectId && c.StaffId == user.PersonId).Select(c => c.GroupId)).Contains(g.GroupId))
                .Select(g => new { Id = g.GroupId, ClassName = g.Year + " " + g.Letter })
                .OrderBy(g => g.Id).ToList<dynamic>();
            return groups;
        }

        internal List<List<string>> GetGroup(Context context, int courseId, int groupId, Person user)
        {
            var students = context.Students
                .Where(s => s.GroupId == groupId)
                .Select(s => s)
                .ToList<Student>();

            List<List<ReportCard>> groupCards = new List<List<ReportCard>>();
            List<List<string>> groupCard = new List<List<string>>();
            foreach (var student in students)
            {
                List<string> line = new List<string>();
                line.Add(student.PersonId.ToString());
                line.Add(student.FirstName + " " + student.MiddleName + " " + student.SurName);
                for (var i = 0; i < checkPointsNum; i++)
                {
                    ReportCard studentCard = context.ReportCards
                    .Where(c => c.StudentId == student.PersonId && c.CourseId == courseId && c.CheckPoint == (CheckPoint)i)
                    .Select(c => c).SingleOrDefault();
                    if (studentCard != null)
                    {
                        line.Add(studentCard.Grade.Value);
                    }
                    else
                    {
                        line.Add("");
                    }
                }
                groupCard.Add(line);
            }

            return groupCard;
        }

        internal int GetCourseId(Context context, int subjectId, int groupId, Person user)
        {
            var courseId = context.Courses
                    .Where(
                            c => c.StaffId == user.PersonId &&
                            c.Subject.SubjectId == subjectId &&
                            c.GroupId == groupId)
                    .Select(c => c.CourseId).Single();
            return courseId;
        }

        internal void SaveGrade(Context context, int studentId, int courseId, CheckPoint checkPoint, string grade)
        {
            var reportCard = context.ReportCards
                    .Where(
                            rp => rp.StudentId == studentId &&
                            rp.CourseId == courseId &&
                            rp.CheckPoint == checkPoint)
                    .Select(rp => rp).Single();

            var gradeId = context.Grades
                    .Where(gr => gr.Value == grade)
                    .Select(gr => gr.GradeId).Single();

            reportCard.GradeId = gradeId;
        }
    }
}
