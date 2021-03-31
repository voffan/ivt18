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
    public partial class ChooseAddUserMethodForm : Form
    {
        private Context _context;

        public ChooseAddUserMethodForm(Context context)
        {
            InitializeComponent();

            _context = context;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ChooseAddUserMethodForm_Load(object sender, EventArgs e)
        {

        }

        private void addSingleButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addUserForm = new AddUser(_context);
            addUserForm.ShowDialog();
        }

        private void addMultipleButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddMultipleUsers addMultipleUsersForm = new AddMultipleUsers(_context);
            addMultipleUsersForm.ShowDialog();
        }
    }
}
