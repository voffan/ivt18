using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    class AddUserLogic
    {
        Person _person;

        internal void CreatePerson(string positionName)
        {
            if (positionName == "Student")
            {
                _person = new Student();
            }
            else
            {
                _person = new Staff();
            }
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

        internal void SetPersonPostition(Context context, string positionName)
        {
            if (_person != null)
            {
                _person.PositionId = context.Positions.Where(x => x.Name == positionName).Select(x => x.PositionId).Single();
                _person.Position = context.Positions.Where(x => x.PositionId == _person.PositionId).Select(x => x).Single();
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
