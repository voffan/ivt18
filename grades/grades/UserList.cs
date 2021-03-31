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

            usersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SetUpForm();
            SetUpComponentAnchors();
        }

        private void SetUpForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetUpComponentAnchors()
        {
            searchLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            searchBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            usersDGV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            displayLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            showStaff.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            showStudents.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

            viewUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            addUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            editUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            deleteUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
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
                    string firstName = csv.GetField<String>("FirstName");
                    string surName = csv.GetField<String>("SurName");
                    string middleName = csv.GetField<String>("MidleName");
                    string phoneNumber = csv.GetField<String>("PhoneNumber");
                    string homeAddress = csv.GetField<String>("HomeAddress");
                    string login = csv.GetField<String>("Login");
                    string password = csv.GetField<String>("Password");
                    int positionId = csv.GetField<int>("PositionId");
                    string positionName = Context.Positions.Where(x => x.PositionId == positionId).Select(x => x.Name).Single();

                    if (positionName == "Ученик")
                    {
                        Student record = new Student
                        {
                            FirstName = firstName,
                            SurName = surName,
                            MiddleName = middleName,
                            PhoneNumber = phoneNumber,
                            HomeAddress = homeAddress,
                            Login = login,
                            Password = password,
                            PositionId = positionId
                        };

                        record.Position = Context.Positions.Where(x => x.PositionId == record.PositionId).Select(x => x).Single();
                        Context.Persons.Add(record);
                    }
                    else
                    {
                        Staff record = new Staff
                        {
                            FirstName = firstName,
                            SurName = surName,
                            MiddleName = middleName,
                            PhoneNumber = phoneNumber,
                            HomeAddress = homeAddress,
                            Login = login,
                            Password = password,
                            PositionId = positionId
                        };

                        record.Position = Context.Positions.Where(x => x.PositionId == record.PositionId).Select(x => x).Single();
                        Context.Persons.Add(record);
                    }

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

            if (usersDGV.Columns["Должность"] != null)
            {
                usersDGV.Columns["Должность"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                usersDGV.Columns["Должность"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            int personId = getSelectedRowPersonId().Last();
            Person personToEdit = _logic.getPersonById(Context, personId);

            AddUser editUserForm = new AddUser(Context);

            editUserForm.SetEditState(personToEdit);
            editUserForm.ShowDialog();
            UpdateList();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            List<int> personsId = getSelectedRowPersonId();

            for (int i = 0; i < personsId.Count; i++)
            {
                _logic.DeleteUser(Context, personsId[i]);
                UpdateList();
            }
        }

        private void showStaff_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void showStudents_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private List<int> getSelectedRowPersonId()
        {
            List<int> selectedPersonsId = new List<int>();
            if (usersDGV.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = usersDGV.SelectedRows[0];

                selectedPersonsId.Add(Convert.ToInt32(selectedRow.Cells["PersonId"].Value.ToString()));
                
                return selectedPersonsId;
            }
            else if (usersDGV.SelectedRows.Count > 1)
            {
                for (int i = 0; i < usersDGV.SelectedRows.Count; i++)
                {
                    DataGridViewRow selectedRow = usersDGV.SelectedRows[i];

                    selectedPersonsId.Add(Convert.ToInt32(selectedRow.Cells["PersonId"].Value.ToString()));
                }

                return selectedPersonsId.Distinct().ToList();
            }

            return null;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void viewUser_Click(object sender, EventArgs e)
        {
            int personId = getSelectedRowPersonId().Last();
            Person personToDisplay = _logic.getPersonById(Context, personId);

            AddUser ViewUserForm = new AddUser(Context);
            ViewUserForm.SetViewState(personToDisplay);
            ViewUserForm.ShowDialog();
        }
    }
}
