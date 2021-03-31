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
            String[] searchTerms = searchTerm.Trim().Split(' ');

            var personsList = (from usr in context.Persons
                                         select new
                                         {
                                             usr.PersonId,
                                             Фамилия = usr.SurName,
                                             Имя = usr.FirstName,
                                             Отчество = usr.MiddleName,
                                             Должность = usr.Position.Name
                                         });

            foreach (string term in searchTerms)
            {
                var persons = (from usr in personsList
                                  where usr.Фамилия.Contains(term) ||
                                        usr.Имя.Contains(term) ||
                                        usr.Отчество.Contains(term)
                                  select new
                                  {
                                      usr.PersonId,
                                      Фамилия = usr.Фамилия,
                                      Имя = usr.Имя,
                                      Отчество = usr.Отчество,
                                      Должность = usr.Должность
                                  });

                personsList = persons;
            }


            return personsList.ToList<dynamic>();
        }

        internal List<dynamic> GetStaffList(Context context, string searchTerm)
        {
            searchTerm = searchTerm.Trim();
            String[] searchTerms = searchTerm.Split(' ');

            var staffList = (from usr in context.Persons
                             where usr.Position.Name != "Ученик"
                             select new
                               {
                                   usr.PersonId,
                                   Фамилия = usr.SurName,
                                   Имя = usr.FirstName,
                                   Отчество = usr.MiddleName,
                                   Должность = usr.Position.Name
                               });

            foreach (string term in searchTerms)
            {
                var staff = (from usr in staffList
                             where usr.Фамилия.Contains(term) ||
                                      usr.Имя.Contains(term) ||
                                      usr.Отчество.Contains(term)
                             select new
                             {
                                 usr.PersonId,
                                 Фамилия = usr.Фамилия,
                                 Имя = usr.Имя,
                                 Отчество = usr.Отчество,
                                 Должность = usr.Должность
                             });

                staffList = staff;
            }

            return staffList.ToList<dynamic>();
        }

        internal List<dynamic> GetStudentList(Context context, string searchTerm)
        {
            searchTerm = searchTerm.Trim();
            String[] searchTerms = searchTerm.Split(' ');

            var studentsList = (from usr in context.Persons
                                where usr.Position.Name == "Ученик"
                                select new
                                {
                                    usr.PersonId,
                                    Фамилия = usr.SurName,
                                    Имя = usr.FirstName,
                                    Отчество = usr.MiddleName,
                                    Должность = usr.Position.Name
                                });

            foreach (string term in searchTerms)
            {
                var students = (from usr in studentsList
                                where usr.Фамилия.Contains(term) ||
                                        usr.Имя.Contains(term) ||
                                        usr.Отчество.Contains(term)
                                select new
                                {
                                    usr.PersonId,
                                    Фамилия = usr.Фамилия,
                                    Имя = usr.Имя,
                                    Отчество = usr.Отчество,
                                    Должность = usr.Должность
                                });

                studentsList = students;
            }

            return studentsList.ToList<dynamic>();
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
