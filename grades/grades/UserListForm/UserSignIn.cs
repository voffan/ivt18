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
    public partial class UserSignIn : Form
    {
        private UserSignInLogic _logic;
        private Context _context;
        private Person _currentPerson;
        private bool Hello = false;
        private string _login;
        private string _password;
        private Person _user;


        public UserSignIn(Context _context)
        {
            InitializeComponent();
            _logic = new UserSignInLogic();
            this._context = _context;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _login = Login.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _password = Password.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_logic.GetPeopleList(_context, _login, _password) == null)
            {
                AddUser a = new AddUser(_context);
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                MainForm f = new MainForm(_context);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
