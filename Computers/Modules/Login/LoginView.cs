﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Login
{
    public interface ILoginView
    {
        ILoginInteractor Interactor { get; set; }
    }
    public class LoginView : View, ILoginView
    {
        public ILoginInteractor Interactor { get; set; }

        private readonly Panel panel = new Panel();
        private readonly TextBox emailTextField = new TextBox();
        private readonly TextBox passwordTextField = new TextBox();
        private readonly Label emailLabel = new Label();
        private readonly Label passwordLabel = new Label();
        private readonly Button submitButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            this.Text = "Авторизация";
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            emailLabel.Text = "E-mail";
            
            passwordLabel.Text = "Пароль";
            passwordTextField.PasswordChar = '*';

            submitButton.Text = "Войти";
            submitButton.Click += SubmitButtonPressed;

            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(emailLabel);
            panel.Controls.Add(emailTextField);
            panel.Controls.Add(passwordTextField);
            panel.Controls.Add(passwordLabel);
            panel.Controls.Add(submitButton);
            
            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(200, 155);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            emailLabel.Size = new Size(180, 15);
            emailLabel.Location = new Point(10, 10);

            emailTextField.Size = new Size(180, 30);
            emailTextField.Location = new Point(10, 30);

            passwordLabel.Size = new Size(180, 15);
            passwordLabel.Location = new Point(10, 60);

            passwordTextField.Size = new Size(180, 15);
            passwordTextField.Location = new Point(10, 80);

            submitButton.Size = new Size(80, 25);
            submitButton.Location = new Point(110, 120);
        }

        private void SubmitButtonPressed(object sender, EventArgs e)
        {
            Interactor.Validate(emailTextField.Text, passwordTextField.Text); // TODO: Возможно проверять во время ввода
            Interactor.Login(emailTextField.Text, passwordTextField.Text);
        }
    }
}
