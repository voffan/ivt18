using Computers.Modules.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Welcome
{
    public interface IWelcomeView
    {
        Form Self { get; }
        IWelcomeInteractor Interactor { get; set; }
    }
    public partial class WelcomeView : Form, IWelcomeView
    {
        private readonly Label loadingLabel = new Label();
        private readonly Button loginButton = new Button();
        private readonly Button registerButton = new Button();
        private readonly Panel panel = new Panel();

        public WelcomeView()
        {
            InitializeComponent();
        }

        private void WelcomeView_Load(object sender, EventArgs e)
        {
            loadingLabel.Text = "Computers App";
            loadingLabel.Font = new Font("Arial", 14, FontStyle.Bold);

            loginButton.Text = "Войти";
            loginButton.Click += LoginButtonPressed;

            registerButton.Text = "Зарегистрироваться";
            registerButton.Click += RegisterButtonPressed;

            panel.Controls.Add(loadingLabel);
            panel.Controls.Add(loginButton);
            panel.Controls.Add(registerButton);
            Controls.Add(panel);

            SetupLayout(this, null);
            SizeChanged += SetupLayout;
        }

        private void SetupLayout(object sender, EventArgs e)
        {
            panel.Size = new Size(200, 130);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            loadingLabel.Size = new Size(180, 30);
            loadingLabel.Location = new Point(10, 10);

            loginButton.Size = new Size(180, 30);
            loginButton.Location = new Point(10, 50);

            registerButton.Size = new Size(180, 30);
            registerButton.Location = new Point(10, 85);
        }

        private void LoginButtonPressed(object sender, EventArgs e)
        {
            Interactor.NavigateToLoginView();
        }

        private void RegisterButtonPressed(object sender, EventArgs e)
        {
            Interactor.NavigateToRegisterView();
        }

        Form IWelcomeView.Self => this;

        public IWelcomeInteractor Interactor { get; set; }
    }
}
