using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Context context;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //system administator
            if (EmployeeLogic.LoginEmployee(context, this.textBox1.Text, this.textBox2.Text) == 1)
            {
                MainPageForm f = new MainPageForm(context);
                f.Show();

                this.textBox1.Text = "";
                this.textBox2.Text = "";

            }
        }
    }
}
