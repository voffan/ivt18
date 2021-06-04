using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class StudentInfoLogic
    {
        Person _person;

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
                               });

                personsList = persons;
            }


            return personsList.ToList<dynamic>();
        }


        internal void SetPerson(Person person)
        {
            if (_person == null)
            {
                _person = person;
            }
        }

        internal void SetPersonFullName(string firstName, string surName, string middleName)
        {
            if (_person != null)
            {
                firstName = firstName.Replace(" ", string.Empty);
                surName = surName.Replace(" ", string.Empty);
                middleName = middleName.Replace(" ", string.Empty);

                _person.FirstName = firstName;
                _person.SurName = surName;
                _person.MiddleName = middleName;
            }
        }

        internal void SetPersonPhoneNumber(string phoneNumber)
        {
            if (_person != null)
            {
                phoneNumber = phoneNumber.Replace(" ", string.Empty);

                _person.PhoneNumber = phoneNumber;
            }
        }

        internal void SetPersonHomeAddress(string homeAddress)
        {
            if (_person != null)
            {
                homeAddress = homeAddress.Replace(" ", string.Empty);

                _person.HomeAddress = homeAddress;
            }
        }

        internal Person GetAddedPerson()
        {
            if (_person != null)
            {
                return _person;
            }
            else
            {
                return null;
            }
        }

    }
}
