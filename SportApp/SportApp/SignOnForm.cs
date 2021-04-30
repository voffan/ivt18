using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportApp.Classes;

namespace SportApp
{
    public partial class SignOnForm : Form
    {
        public SignOnForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Context connect = new Context();
            string newUserSurname=textBox1.Text, 
                newUserName=textBox2.Text,
                newUserFatherName=textBox3.Text,
                newUserEmail=textBox4.Text,
                newUserLogin=textBox7.Text,
                newUserPassword=textBox9.Text,
                RePassword=textBox6.Text;

            if (newUserPassword == RePassword)
            {
                Person newUser = new Person {
                    Name = newUserSurname + " " + newUserName + " " + newUserFatherName,
                    Email = newUserEmail,
                    Login = newUserLogin,
                    Password = RePassword
                };
                string databaseLogin = (from customer in connect.Persons
                               where customer.Login == newUserLogin 
                               select customer.Name).FirstOrDefault();
                string databaseEmail = (from customer in connect.Persons
                                        where customer.Email == newUserEmail
                                        select customer.Name).FirstOrDefault();
                if (databaseLogin == null || databaseEmail == null)
                {
                    connect.Persons.Add(newUser);
                    connect.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно. Спасибо за регистрацию!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Convert.ToString("Извените, но пользователь с таким логином или почтовым ящиком уже существует. Попробуйте еще раз!"));
                }
               
            }
            else {
                MessageBox.Show("Ваши пароли не совподают!");
            }


        }
    }
}
