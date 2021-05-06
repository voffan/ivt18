using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SportApp
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ваш логин")
            {
                textBox1.Text = null;
            }
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ваш логин";
                textBox1.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox1.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ваш логин")
            {
                MessageBox.Show("Для того, чтобы восстановить пароль вам нужно ввести логин");
            }
            else
            {
                Context connect = new Context();
            }
        }
    }
}
