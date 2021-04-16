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


        public UserSignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserList f = new UserList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
