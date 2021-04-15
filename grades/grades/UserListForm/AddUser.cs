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

        private List<TextBox> _textBoxes;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public AddUser(Context context)
        {
            InitializeComponent();
            _logic = new AddUserLogic();
            _context = context;

            positionList.DataSource = (from pos in context.Positions
                                       select pos.Name).ToList();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ControlBox = false;

            SetupColors();
        }

        private void SetupColors()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);

            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.FlatAppearance.BorderSize = 1;
                b.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
                b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }

            foreach (Label b in this.Controls.OfType<Label>())
            {
                b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }

            foreach (CheckBox c in this.Controls.OfType<CheckBox>())
            {
                c.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }
        }

        internal void SetEditState(Person person)
        {
            _currentPerson = person;
            _editingState = true;

            personFirstNameBox.Text = _currentPerson.FirstName.ToString();
            personSurNameBox.Text = _currentPerson.SurName.ToString();
            personMiddleNameBox.Text = _currentPerson.MiddleName.ToString();
            
            positionList.Text = _context.Positions.Where(x => x.PositionId == _currentPerson.PositionId).Select(x => x.Name).Single();

            personPhoneNumberBox.Text = _currentPerson.PhoneNumber.ToString();

            personHomeAddressBox.Text = _currentPerson.HomeAddress.ToString();
        }

        internal void SetViewState(Person person)
        {
            _currentPerson = person;
            
            guideText.Visible = false;
            applyAddingUser.Visible = false;

            cancelAddingUser.Text = "Закрыть";
            SetReadOnly();

            personFirstNameBox.Text = _currentPerson.FirstName.ToString();
            personSurNameBox.Text = _currentPerson.SurName.ToString();
            personMiddleNameBox.Text = _currentPerson.MiddleName.ToString();

            positionList.Text = _context.Positions.Where(x => x.PositionId == _currentPerson.PositionId).Select(x => x.Name).Single();
            positionList.Enabled = false;

            personPhoneNumberBox.Text = _currentPerson.PhoneNumber.ToString();

            personHomeAddressBox.Text = _currentPerson.HomeAddress.ToString();

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

        private void SetReadOnly()
        {
            if (_textBoxes == null)
            {
                _textBoxes = new List<TextBox>();

                foreach (var control in Controls)
                {
                    TextBox textEdit = control as TextBox;
                    if (textEdit != null)
                    {
                        textEdit.ReadOnly = true;
                        _textBoxes.Add(textEdit);
                    }
                }
            }
            else
            {
                foreach (var control in _textBoxes)
                {
                    control.ReadOnly = true;
                }
            }
        }
    }
}
