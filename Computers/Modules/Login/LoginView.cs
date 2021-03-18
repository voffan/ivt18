using System;
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
        void ShowValidationError(string message);
        void ShowAuthError(string message);
    }
    public class LoginView : View, ILoginView
    {
        public ILoginInteractor Interactor { get; set; }

        private readonly Panel panel = new Panel();
        private readonly TextBox emailTextField = new TextBox();
        private readonly TextBox passwordTextField = new TextBox();
        private readonly Label emailLabel = new Label();
        private readonly Label passwordLabel = new Label();
        private readonly Label errorLabel = new Label();
        private readonly Button submitButton = new Button();
        private readonly Button backButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            this.Text = "Авторизация";
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            emailLabel.Text = "E-mail";
            emailTextField.TextChanged += EmailPasswordChanged;
            
            passwordLabel.Text = "Пароль";
            passwordTextField.PasswordChar = '*';
            passwordTextField.KeyDown += new KeyEventHandler(EnterClicked);
            passwordTextField.TextChanged += EmailPasswordChanged;

            submitButton.Text = "Войти";
            submitButton.Click += SubmitButtonPressed;
            submitButton.Enabled = false;

            errorLabel.ForeColor = Color.Red;

            backButton.Text = "Назад";
            backButton.Click += BackButtonPressed;

            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(emailLabel);
            panel.Controls.Add(emailTextField);         
            panel.Controls.Add(passwordLabel);
            panel.Controls.Add(passwordTextField);
            panel.Controls.Add(errorLabel);
            panel.Controls.Add(submitButton);
            panel.Controls.Add(backButton);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(200, 165);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            emailLabel.Size = new Size(180, 15);
            emailLabel.Location = new Point(10, 10);

            emailTextField.Size = new Size(180, 30);
            emailTextField.Location = new Point(10, 30);

            passwordLabel.Size = new Size(180, 15);
            passwordLabel.Location = new Point(10, 60);

            passwordTextField.Size = new Size(180, 15);
            passwordTextField.Location = new Point(10, 80);

            errorLabel.Size = new Size(180, 15);
            errorLabel.Location = new Point(10, 110);

            submitButton.Size = new Size(80, 25);
            submitButton.Location = new Point(110, 130);

            backButton.Size = new Size(80, 25);
            backButton.Location = new Point(10, 130);
        }

        private void EmailPasswordChanged(object sender, EventArgs e)
        {
            Interactor.Validate(emailTextField.Text, passwordTextField.Text);
        }
        private void SubmitButtonPressed(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
            backButton.Enabled = false;
            Interactor.Login(emailTextField.Text, passwordTextField.Text);
        }

        public void ShowAuthError(string message)
        {
            errorLabel.Text = message;
            submitButton.Enabled = true;
            backButton.Enabled = true;
        }

        public void ShowValidationError(string message)
        {
            errorLabel.Text = message;
            submitButton.Enabled = message == null;
            backButton.Enabled = true;
        }

        private void BackButtonPressed(object sender, EventArgs e)
        {
            Interactor.NavigateBack();
        }

        private void EnterClicked(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && submitButton.Enabled)
            {
                e.Handled = true;
                SubmitButtonPressed(null, null);
            }
        }
    }
}
