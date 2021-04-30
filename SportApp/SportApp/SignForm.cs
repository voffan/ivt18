using System;
using SportApp.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportApp
{
    public partial class SignForm : Form
    {

        public SignForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Ваш логин!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Введите Ваш пароль!");
            }
            else {
                Context connect = new Context();
                string name = (from customer in connect.Employees where customer.Name==textBox1.Text
                               select customer.Name)
               .FirstOrDefault();
                MessageBox.Show(Convert.ToString(name));

            }
            
        }
    }
}
