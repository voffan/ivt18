using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class GroupAndCourseGradesLogic
    {
        private int checkPointsNum = 4;

        internal List<dynamic> GetCoursesList(Context context, Person user)
        {
            return (from courses in context.Courses
                    where courses.StaffId == user.PersonId
                    select courses.Subject.Name).Distinct().ToList<dynamic>();
        }

        internal List<dynamic> GetGroupList(Context context, Person user)
        {
            var groups = context.Groups
                .Where(g => g.StaffId == user.PersonId)
                .Select(g => g.Year.ToString() + " " + g.Letter)
                .ToList<dynamic>();
            return groups;
        }

        internal List<dynamic> GetGroup(Context context, string subjectName, int year, string letter, Person user)
        {
            int groupId = context.Groups
                .Where(g => g.Year == year && g.Letter == letter)
                .Select(g => g.GroupId).Single();

            int courseId = context.Courses
                .Where(c => c.StaffId == user.PersonId && c.Subject.Name == subjectName && c.GroupId == groupId)
                .Select(c => c.CourseId).Single();

            var students = context.Students
                .Where(s => s.GroupId == groupId)
                .Select(s => s.FirstName + " " + s.SurName + " " + s.MiddleName)
                .ToList<dynamic>();

            return students;
        }
    }
}
