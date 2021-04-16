using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class GroupAndCourseGradesLogic
    {
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
    }
}
