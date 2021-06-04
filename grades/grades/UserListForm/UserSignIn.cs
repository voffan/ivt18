﻿using System;
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
        private string _login;
        private string _password;
        private int _role;
        private Person _user;
        private int Id;
        private string _contentBackgroundColor;
        private string _contentSelectedColor;


        public UserSignIn(Context _context)
        {
            InitializeComponent();
            _logic = new UserSignInLogic();
            this._context = _context;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _login = Login.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _password = Password.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_logic.GetPeopleList(_context, _login, _password).Count != 0)
            {
                Id = _logic.GetPeopleList(_context, _login, _password)[0].Id;
                MainForm f = new MainForm(_context, Id);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                UserError f = new UserError();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
