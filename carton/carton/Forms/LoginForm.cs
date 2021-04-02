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
        public Context context;
        public LoginForm()
        {
            context = new Context();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.passwordEntry.PasswordChar = '*';
        }

        private void buttonLoginProceed_Click(object sender, EventArgs e)
        {
            //system administator
            if (EmployeeLogic.LoginEmployee(context,this.loginEntry.Text,this.passwordEntry.Text) == 1)
            {
                SysAdminForm f = new SysAdminForm();
                f.Show();
            }
            //storage employee
            if (EmployeeLogic.LoginEmployee(context, this.loginEntry.Text, this.passwordEntry.Text) == 2)
            {
                StorageEmpForm f = new StorageEmpForm();
                f.Show();
            }
            //director
            if (EmployeeLogic.LoginEmployee(context, this.loginEntry.Text, this.passwordEntry.Text) == 3)
            {
                DirectorForm f = new DirectorForm(context);
                f.Show();
            }
            //economist
            if (EmployeeLogic.LoginEmployee(context, this.loginEntry.Text, this.passwordEntry.Text) == 4)
            {
                EcoForm f = new EcoForm(context);
                f.Show();
            }
            if (EmployeeLogic.LoginEmployee(context, this.loginEntry.Text, this.passwordEntry.Text) == 5)
            {
                ForemanForm f = new ForemanForm();
                f.Show();
            }
            this.loginEntry.Text = "";
            this.passwordEntry.Text = "";
        }
    }
}
