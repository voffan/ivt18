using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Register
{
    public interface IRegisterView
    {
        IRegisterInteractor Interactor { get; set; }
        void ShowValidationError(string message);
        void ShowRegisterError(string message);
    }
    class RegisterView : View, IRegisterView
    {
        public IRegisterInteractor Interactor { get; set; }

        private readonly Panel panel = new Panel();
        private readonly TextBox nameTextField = new TextBox();
        private readonly TextBox emailTextField = new TextBox();
        private readonly TextBox passwordTextField = new TextBox();
        private readonly Label nameLabel = new Label();
        private readonly Label emailLabel = new Label();
        private readonly Label passwordLabel = new Label();
        private readonly Button submitButton = new Button();
        private readonly Label errorLabel = new Label();

        public override void SetupView()
        {
            base.SetupView();
            this.Text = "Регистрация";
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            nameLabel.Text = "Имя";
            // nameTextField.TextChanged += TextFieldsChanged;

            emailLabel.Text = "E-mail";
            // emailLabel.TextChanged += TextFieldsChanged;

            passwordLabel.Text = "Пароль";
            passwordTextField.PasswordChar = '*';
            // passwordLabel.TextChanged += EmailPasswordChanged;

            submitButton.Text = "Зарегистрироваться";
            submitButton.Click += SubmitButtonPressed;
            // submitButton.Enabled = false;

            errorLabel.ForeColor = Color.Red;

            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextField);
            panel.Controls.Add(emailLabel);
            panel.Controls.Add(emailTextField);
            panel.Controls.Add(passwordTextField);
            panel.Controls.Add(passwordLabel);
            panel.Controls.Add(submitButton);
            panel.Controls.Add(errorLabel);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(200, 165);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            nameLabel.Size = new Size(180, 15);
            nameLabel.Location = new Point(10, 10);

            emailLabel.Size = new Size(180, 15);
            emailLabel.Location = new Point(10, 60);

            emailTextField.Size = new Size(180, 30);
            emailTextField.Location = new Point(10, 80);

            passwordLabel.Size = new Size(180, 15);
            passwordLabel.Location = new Point(10, 110);

            passwordTextField.Size = new Size(180, 15);
            passwordTextField.Location = new Point(10, 130);

            errorLabel.Size = new Size(180, 15);
            errorLabel.Location = new Point(10, 160);

            submitButton.Size = new Size(80, 25);
            submitButton.Location = new Point(110, 180);
        }

        private void TextFieldsChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Fields changed");
            // Interactor.Validate(emailTextField.Text, passwordTextField.Text);
        }
        private void SubmitButtonPressed(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
            Interactor.Register(emailTextField.Text, passwordTextField.Text, nameTextField.Text);
        }

        public void ShowRegisterError(string message)
        {
            errorLabel.Text = message;
            submitButton.Enabled = true;
        }

        public void ShowValidationError(string message)
        {
            errorLabel.Text = message;
            submitButton.Enabled = message == null;
        }
    }
}
