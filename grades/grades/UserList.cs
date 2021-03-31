using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            //test();
        }

        public void test()
        {
            //@"S:\MOCK_DATA.csv"
            using (var reader = new StreamReader(@"S:\MOCK_DATA.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new Person
                    {
                        FirstName = csv.GetField<String>("FirstName"),
                        SurName = csv.GetField<String>("SurName"),
                        MiddleName = csv.GetField<String>("MidleName"),
                        PhoneNumber = csv.GetField<String>("PhoneNumber"),
                        HomeAddress = csv.GetField<String>("HomeAddress"),
                        Login = csv.GetField<String>("Login"),
                        Password = csv.GetField<String>("Password"),
                        PositionId = csv.GetField<int>("PositionId"),
                    };
                    record.Position = Context.Positions.Where(x => x.PositionId == record.PositionId).Select(x => x).Single();

                    Context.Persons.Add(record);
                }
            }
            Context.SaveChanges();
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

            editUserForm.SetEditState(personToEdit);
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

        private void viewUser_Click(object sender, EventArgs e)
        {
            int personId = getSelectedRowPersonId();
            Person personToDisplay = _logic.getPersonById(Context, personId);

            AddUser ViewUserForm = new AddUser(Context);
            ViewUserForm.SetViewState(personToDisplay);
            ViewUserForm.ShowDialog();
        }
    }
}
