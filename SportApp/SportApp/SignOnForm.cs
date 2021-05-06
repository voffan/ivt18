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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Фамилия";
                textBox1.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Фамилия")
            {
                textBox1.Text = null;
            }
            textBox1.ForeColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Имя")
            {
                textBox2.Text = null;
            }
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Имя";
                textBox2.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Отчество")
            {
                textBox3.Text = null;
            }
            textBox3.ForeColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Отчество";
                textBox3.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox3.ForeColor = Color.White;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Логин")
            {
                textBox7.Text = null;
            }
            textBox7.ForeColor = Color.White;
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Логин";
                textBox7.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox7.ForeColor = Color.White;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Пароль")
            {
                textBox9.Text = null;
                textBox9.PasswordChar = Convert.ToChar("о");
            }
            textBox9.ForeColor = Color.White;
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Пароль";
                textBox9.PasswordChar = '\0';
                textBox9.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox9.ForeColor = Color.White;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Подтвержение пароля")
            {
                textBox6.Text = null;
                textBox6.PasswordChar = Convert.ToChar("о");
            }
            textBox6.ForeColor = Color.White;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Подтвержение пароля";
                textBox6.PasswordChar = '\0';
                textBox6.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox6.ForeColor = Color.White;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void SignOnForm_Load(object sender, EventArgs e)
        {
            Context connect = new Context();
            List<string> names = connect.Cities
                .Select(c => c.Name).ToList();
            foreach (string name in names)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Телефон")
            {
                textBox8.Text = null;
            }
            textBox8.ForeColor = Color.White;
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Телефон";
                textBox8.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox8.ForeColor = Color.White;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Почта")
            {
                textBox4.Text = null;
            }
            textBox4.ForeColor = Color.White;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Почта";
                textBox4.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox4.ForeColor = Color.White;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Дата рождения")
            {
                textBox5.Text = null;
                monthCalendar1.Visible = true;
            }
            else {
                monthCalendar1.Visible = true;
            }
            textBox5.ForeColor = Color.White;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Дата рождения";
                textBox5.ForeColor = Color.DarkGray;
            }
            else
            {
                monthCalendar1.Visible = false;
                textBox5.ForeColor = Color.White;
            }
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = e.Start.ToLongDateString();
            monthCalendar1.Visible = false;
            textBox5.ForeColor = Color.White;
        }
    }
}
