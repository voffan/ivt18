using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carton.Classes
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.passwordEntry.PasswordChar = '*';
        }

        private void buttonLoginProceed_Click(object sender, EventArgs e)
        {
            if (this.loginEntry.Text.Equals("sysadmin") && this.passwordEntry.Text.Equals("1234"))
            {
                SysAdminForm f = new SysAdminForm();
                f.Show();
            }
        }
    }
}
