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
        
        internal List<dynamic> GetCoursesList(Context context, Person user)
        {
            var courses = context.Courses
                .Where(c => c.StaffId == user.PersonId)
                .Select(c => new { Id = c.CourseId, CourseName = c.Subject.Name })
                .OrderBy(g => g.Id).ToList<dynamic>();
            return courses;
        }

        internal List<dynamic> GetGroupList(Context context, Person user)
        {
            var groups = context.Groups
                .Where(g => g.StaffId == user.PersonId)
                .Select(g => new { Id = g.GroupId, ClassName = g.Year + " " + g.Letter })
                .OrderBy(g => g.Id).ToList<dynamic>();
            return groups;
        }

        internal List<List<string>> GetGroup(Context context, string subjectName, int year, string letter, Person user)
        {
            int groupId = context.Groups
                .Where(g => g.Year == year && g.Letter == letter)
                .Select(g => g.GroupId).Single();

            int courseId = 0;
            try
            {
                courseId = context.Courses
                    .Where(c => c.StaffId == user.PersonId && c.Subject.Name == subjectName && c.GroupId == groupId)
                    .Select(c => c.CourseId).Single();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

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
    }
}
