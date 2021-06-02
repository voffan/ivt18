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
            string[] userArray = new String[12];

            userArray[0] = addSurnameField.Text;
            userArray[1] = addNameField.Text;
            userArray[2] = addFathernameField.Text;
            userArray[3] = addLoginField.Text;
            userArray[4] = addPasswordField.Text;
            userArray[5] = addPositionIdField.Text;
            userArray[6] = addStatusIdField.Text;
            userArray[7] = addContactPhoneField.Text;
            userArray[8] = addAddressField.Text;
            userArray[9] = addStorageIdField.Text;
            userArray[10] = addFactoryIdField.Text;
            userArray[11] = addFactoryDirectorIdField.Text;
            
            employeeLogic.addUser(context, userArray);

            addSurnameField.Text = "";
            addNameField.Text = "";
            addFathernameField.Text = "";
            addLoginField.Text = "";
            addPasswordField.Text = "";
            addPositionIdField.Text = "";
            addStatusIdField.Text = "";
            addContactPhoneField.Text = "";
            addAddressField.Text = "";
            addStorageIdField.Text = "";
            addFactoryIdField.Text = "";
            addFactoryDirectorIdField.Text = "";

            usersGridView.DataSource = context.Employees.ToList();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
