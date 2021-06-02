using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carton
{
    public partial class UserManagement : Form
    {

        readonly EmployeeLogic employeeLogic;
        Context context;

        public UserManagement(Context context)
        {
            InitializeComponent();
            this.context = context;
            employeeLogic = new EmployeeLogic();
            //planGridView
            usersGridView.DataSource = context.Employees.ToList();
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            usersGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Visible = false;
            usersGridView.RowHeadersVisible = false;
            usersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
