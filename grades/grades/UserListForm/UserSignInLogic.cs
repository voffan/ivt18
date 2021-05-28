using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    class UserSignInLogic
    {

        internal List<dynamic> GetPersonList(Context context, string searchTerm)
        {
            String[] searchTerms = searchTerm.Trim().Split(' ');

            var personsList = (from usr in context.Persons
                               select new
                               {
                                   usr.Login,
                                   usr.Password,
                                   usr.Position,
                                   Логин = usr.Login,
                                   Пароль = usr.Password,
                                   Должность = usr.Position.Name
                               });

            foreach (string term in searchTerms)
            {
                var persons = (from usr in personsList
                               where usr.Логин.Contains(term) ||
                                     usr.Пароль.Contains(term) ||
                                     usr.Должность.Contains(term)
                               select new
                               {
                                   usr.Login,
                                   usr.Password,
                                   usr.Position,
                                   Логин = usr.Логин,
                                   Пароль = usr.Пароль,
                                   Должность = usr.Должность
                               });

                personsList = persons;
            }


            return personsList.ToList<dynamic>();
        }
    }
}
