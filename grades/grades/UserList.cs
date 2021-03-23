using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Debug
using System.Diagnostics;

namespace grades
{
    public partial class UserList : Form
    {
        public Context Context { get; set; }

        private UserListLogic _logic;

        public UserList()
        {
            InitializeComponent();
            Context = new Context();
            _logic = new UserListLogic();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser(Context);
            addUserForm.ShowDialog();
            UpdateList();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            if (showStaff.Checked && showStudents.Checked)
            {
                usersDGV.DataSource = _logic.GetPersonList(Context, searchBox.Text.ToString());
            }
            else if (showStaff.Checked)
            {
                usersDGV.DataSource = _logic.GetStaffList(Context, searchBox.Text.ToString());
            }
            else if (showStudents.Checked)
            {
                usersDGV.DataSource = _logic.GetStudentList(Context, searchBox.Text.ToString());
            }
            else
            {
                usersDGV.DataSource = null;
            }

            if (usersDGV.Columns["PersonId"] != null)
                usersDGV.Columns["PersonId"].Visible = false;
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            int personId = getSelectedRowPersonId();
            Person personToEdit = _logic.getPersonById(Context, personId);

            AddUser editUserForm = new AddUser(Context);

            editUserForm.FillEditUserForm(personToEdit);
            editUserForm.ShowDialog();
            UpdateList();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int personId = getSelectedRowPersonId();
            _logic.DeleteUser(Context, personId);
            UpdateList();
        }

        private void showStaff_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void showStudents_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private int getSelectedRowPersonId()
        {
            if (usersDGV.SelectedCells.Count > 0)
            {
                int selectedRowIndex = usersDGV.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = usersDGV.Rows[selectedRowIndex];

                return Convert.ToInt32(selectedRow.Cells["PersonId"].Value.ToString());
            }
            return 0;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
