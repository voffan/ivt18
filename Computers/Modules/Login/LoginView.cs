using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Login
{
    interface ILoginView
    {
        Form Self { get; }
        ILoginInteractor Interactor { get; set; }
    }
    public partial class LoginView : Form, ILoginView
    {
        private TextBox textBox = new TextBox();
        public LoginView()
        {
            InitializeComponent();
        }

        public Form Self => this;

        ILoginInteractor ILoginView.Interactor { get; set; }

        private void LoginView_Load(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello, world!";
            this.textBox.Location = new Point(10, 25);
            this.textBox.Size = new Size(80, 20);
            this.Controls.Add(textBox);
        }
    }
}
