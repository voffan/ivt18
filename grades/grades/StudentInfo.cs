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
    public partial class StudentInfo : Form
    {
        Person _user;
        private StudentInfoLogic _logic;
        private Context _context;

        private Person _currentPerson;

        private bool _editingState = false;

        private List<TextBox> _textBoxes;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;
        public StudentInfo(Context context, Person user)
        {
            InitializeComponent();
            _logic = new StudentInfoLogic();
            _context = context;
            _user = user;

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

            textBox1.Text = _currentPerson.FirstName.ToString();
            textBox2.Text = _currentPerson.SurName.ToString();
            textBox3.Text = _currentPerson.MiddleName.ToString();

            personPhoneNumberBox.Text = _currentPerson.PhoneNumber.ToString();

            personHomeAddressBox.Text = _currentPerson.HomeAddress.ToString();
        }

        internal void SetViewState(Person person)
        {
            _currentPerson = person;
            SetReadOnly();

            textBox1.Text = _currentPerson.FirstName.ToString();
            textBox2.Text = _currentPerson.SurName.ToString();
            textBox3.Text = _currentPerson.MiddleName.ToString();

            personPhoneNumberBox.Text = _currentPerson.PhoneNumber.ToString();

            personHomeAddressBox.Text = _currentPerson.HomeAddress.ToString();

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

        private void personHomeAddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void personPhoneNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
