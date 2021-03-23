using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    class UserListLogic
    {
        internal List<dynamic> GetPersonList(Context context, string searchTerm)
        {
            searchTerm = searchTerm.Trim();

            var personList = (from usr in context.Persons
                              where usr.SurName.Contains(searchTerm) ||
                                    usr.FirstName.Contains(searchTerm) ||
                                    usr.MiddleName.Contains(searchTerm)
                              select new
                               {
                                   usr.PersonId,
                                   usr.SurName,
                                   usr.FirstName,
                                   usr.MiddleName,
                                   usr.Position.Name
                               }).ToList<dynamic>();

            return personList;
        }

        internal List<dynamic> GetStaffList(Context context, string searchTerm)
        {
            searchTerm = searchTerm.Trim();

            var staffList = (from usr in context.Persons
                               where usr.Position.Name != "Student" &&
                                    (usr.SurName.Contains(searchTerm) ||
                                    usr.FirstName.Contains(searchTerm) ||
                                    usr.MiddleName.Contains(searchTerm))
                             select new
                               {
                                   usr.PersonId,
                                   usr.SurName,
                                   usr.FirstName,
                                   usr.MiddleName,
                                   usr.Position.Name
                               }).ToList<dynamic>();

            return staffList;
        }

        internal List<dynamic> GetStudentList(Context context, string searchTerm)
        {
            searchTerm = searchTerm.Trim();

            var studentList = (from usr in context.Persons
                             where usr.Position.Name == "Student" &&
                                    (usr.SurName.Contains(searchTerm) ||
                                    usr.FirstName.Contains(searchTerm) ||
                                    usr.MiddleName.Contains(searchTerm))
                               select new
                             {
                                 usr.PersonId,
                                 usr.SurName,
                                 usr.FirstName,
                                 usr.MiddleName,
                                 usr.Position.Name
                             }).ToList<dynamic>();

            return studentList;
        }

        internal Person getPersonById(Context context, int personId)
        {
            Person selectedPerson = context.Persons.Where(x => x.PersonId == personId).Select(x => x).Single();

            return selectedPerson;
        }

        internal void DeleteUser(Context context, int userId)
        {
            Person personToDelete = context.Persons.Where(x => x.PersonId == userId).Select(x => x).Single();
            context.Persons.Remove(personToDelete);
            context.SaveChanges();
        }
    }
}
