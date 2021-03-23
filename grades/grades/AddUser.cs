using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    public partial class AddUser : Form
    {
        private AddUserLogic _logic;
        private Context _context;

        private Person _currentPerson;

        private bool _editingState = false;
        
        public AddUser(Context context)
        {
            InitializeComponent();
            _logic = new AddUserLogic();
            _context = context;

            positionList.DataSource = (from pos in context.Positions
                                       select pos.Name).ToList();
        }

        public void FillEditUserForm(Person person)
        {
            _currentPerson = person;
            _editingState = true;

            this.personFirstNameBox.Text = _currentPerson.FirstName.ToString();
            this.personSurNameBox.Text = _currentPerson.SurName.ToString();
            this.personMiddleNameBox.Text = _currentPerson.MiddleName.ToString();
            
            this.positionList.Text = _context.Positions.Where(x => x.PositionId == _currentPerson.PositionId).Select(x => x.Name).Single();

            this.personPhoneNumberBox.Text = _currentPerson.PhoneNumber.ToString();

            this.personHomeAddressBox.Text = _currentPerson.HomeAddress.ToString();
        }

        private void applyAddingUser_Click(object sender, EventArgs e)
        {
            string positionName = positionList.Items[positionList.SelectedIndex].ToString();

            if (!_editingState)
            {
                _logic.CreatePerson(positionName);
            }
            else
            {
                _logic.SetPerson(_currentPerson);
            }

            _logic.SetPersonFullName(
                personFirstNameBox.Text.ToString(),
                personSurNameBox.Text.ToString(),
                personMiddleNameBox.Text.ToString()
                );
            _logic.SetPersonPostition(_context, positionName);
            _logic.SetPersonPhoneNumber(personPhoneNumberBox.Text.ToString());
            _logic.SetPersonHomeAddress(personHomeAddressBox.Text.ToString());
            _currentPerson = _logic.GetAddedPerson();

            if (!_editingState)
            {
                _context.Persons.Add(_currentPerson);
            }

            _context.SaveChanges();
            this.Close();
        }

        private void cancelAddingUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
