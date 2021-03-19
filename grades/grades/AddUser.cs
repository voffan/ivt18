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
            // TO DO:
            // Создавать либо ученика, либо учителя
            // Вынести в класс логики все, что стоит ниже
            if (_currentPerson == null)
                _currentPerson = new Person();

            _currentPerson.FirstName = personFirstNameBox.Text.ToString().Trim();
            _currentPerson.SurName = personSurNameBox.Text.ToString().Trim();
            _currentPerson.MiddleName = personMiddleNameBox.Text.ToString().Trim();

            string posName = positionList.Items[positionList.SelectedIndex].ToString();
            if  (posName != null)
            {
                _currentPerson.PositionId = _context.Positions.Where(x => x.Name == posName).Select(x => x.PositionId).Single();
                _currentPerson.Position = _context.Positions.Where(x => x.PositionId == _currentPerson.PositionId).Select(x => x).Single();
            }

            _currentPerson.PhoneNumber = personPhoneNumberBox.Text.ToString().Trim();

            _currentPerson.HomeAddress = personHomeAddressBox.Text.ToString().Trim();
            if (!_editingState)
                _context.Persons.Add(_currentPerson);
            _context.SaveChanges();
            this.Close();
        }

        private void cancelAddingUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
