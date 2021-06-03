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
    public partial class SignInForm : Form
    {

        public SignInForm()
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

        private void button3_Click(object sender, EventArgs e)
        {
            SignOnForm Registration = new SignOnForm();
            Registration.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resetPassword q = new resetPassword();
            q.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Context connect = new Context();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Ваш логин!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Введите Ваш пароль!");
            }
            else {
                string name = (from customer in connect.Persons where customer.Login==textBox1.Text
                               select customer.Name)
               .FirstOrDefault();
                if (name == null)
                {
                    MessageBox.Show(Convert.ToString("Пользователь с таким логином не найден!"));
                }
                else
                {
                    string password = (from customer in connect.Persons
                                       where customer.Password == textBox2.Text
                                       select customer.Password)
                     .FirstOrDefault();
                    if (password == null)
                    {
                        MessageBox.Show("Извините, но ваш пароль не совподает");
                    }
                    else
                    {
                        MainMainForm LoginForm = new MainMainForm();
                        Program.logining = textBox1.Text;
                        LoginForm.Show();
                    }
                }

            }
        }

    }
}
