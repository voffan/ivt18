using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class GroupAndCourseGradesLogic
    {
        internal List<dynamic> GetCoursesList(Context context, Staff user)
        {
            return (from courses in context.Courses
                    where courses.StaffId == user.PersonId
                    select courses.Subject.Name).Distinct().ToList<dynamic>();
        }

        internal List<dynamic> GetGroupList(Context context, Staff user)
        {
            return (from groups in context.Groups
                    where groups.StaffId == user.PersonId
                    select new
                    {
                        groups.Year
                    }
                    ).ToList<dynamic>();
        }
    }
}
