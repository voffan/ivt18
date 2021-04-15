using System;
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
    public partial class MainForm : Form
    {
        Person User { get; set; }

        public MainForm()
        {
            InitializeComponent();
            //test
            //test 2
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserList userListForm = new UserList();
            userListForm.FormBorderStyle = FormBorderStyle.None;
            this.IsMdiContainer = true;
            userListForm.MdiParent = this;
            this.panel2.Controls.Add(userListForm);
            userListForm.Show();
        }
    }
}
