using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            setLocale(Convert.ToString(Properties.Settings.Default["local"]));
            InitializeComponent();
            checkRemember();

        }

        // Корректный ввод логина
        private void checkTextBoxSymbols(KeyPressEventArgs e)
        {
            // Проверяет, корректный ввод данных в textBox
            // Еркен 05.03.21

            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                    (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                    (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' ||
                    e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
        private void textBoxLogin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checkTextBoxSymbols(e);
        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkTextBoxSymbols(e);
        }

        // Локализация
        private void setLocale(string lang)
        {
            // Устанавливает язык lang
            // Перед инициализацией каждой формы нужны писать:
            // setLocale(Convert.ToString(Properties.Settings.Default["local"]));
            // Еркен 18.03.21

            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(lang);
            Properties.Settings.Default["local"] = lang;
            Properties.Settings.Default.Save();
        }
        private void radioButtonRussian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRussian.Checked)
            {
                setLocale("ru-RU");
                Application.Restart();
            }
        }
        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEnglish.Checked)
            {
                setLocale("en-US");
                Application.Restart();
            }
        }


        private void checkRemember()
        {
            // Автовставка пароля и логина
            // Еркен 18.03.21

            if (Properties.Settings.Default["remember"].ToString() == "True")
            {
                try
                {
                    switch (Properties.Settings.Default["local"])
                    {

                    }
                    if (Convert.ToString(Properties.Settings.Default["login"]) != "")
                        checkBoxRemember.Checked = true;
                    textBoxLogin.Text = Convert.ToString(Properties.Settings.Default["login"]);
                    textBoxPassword.Text = Convert.ToString(Properties.Settings.Default["password"]);
                }
                catch(Exception)
                {
                    
                }

            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (checkBoxRemember.Checked)
            {
                Properties.Settings.Default["login"] = textBoxLogin.Text;
                Properties.Settings.Default["password"] = textBoxPassword.Text;
                Properties.Settings.Default["remember"] = "True";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default["login"] = "";
                Properties.Settings.Default["password"] = "";
                Properties.Settings.Default["remember"] = "False";
                Properties.Settings.Default.Save();
            }
        }
    }
}
