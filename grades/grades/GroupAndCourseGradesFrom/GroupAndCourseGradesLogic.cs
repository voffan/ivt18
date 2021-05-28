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
            foreach (var student in students)
            {
                for (var i = 0; i < 7; i++)
                {
                    List<ReportCard> studentCard = context.ReportCards
                    .Where(c => c.StudentId == student.PersonId && c.CourseId == courseId && c.CheckPoint == (CheckPoint)i)
                    .Select(c => c)
                    .ToList<ReportCard>();

                    groupCards.Add(studentCard);
                }
            }
            List<dynamic> test = new List<dynamic>();
            for (var i = 0; i < groupCards.Count; i++)
            {
                List<ReportCard> reportCards = groupCards[i];

                List<Object> allS = (from x in students select (Object)x).ToList();
                allS.AddRange((from x in reportCards select (Object)x).ToList());

                List<object> objectList = students.Cast<object>()
                    .Concat(from rp in reportCards
                            select rp)
                    .ToList();

                test.Add(objectList);

                //for (var j = 0; j < 7; j++)
                //{
                //    test.Add((from st in students
                //            join rp in reportCards on st.PersonId equals rp.StudentId
                //            where rp.CheckPoint == (CheckPoint)j
                //            select new
                //            {
                //                Имя = st.FirstName,
                //                Фамилия = st.SurName,
                //                Отчество = st.MiddleName,
                //                CheckPoint = (from gr in context.Grades where rp.GradeId == gr.GradeId select Convert.ToInt32(gr.Value))
                //            }).ToList<dynamic>());
                //}
            }

            return test;
        }
    }
}
