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
        private Context _context;
        private Person _user;
        private UserListLogic _logic;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public UserList(Context context, Person user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _logic = new UserListLogic();

            usersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SetUpForm();
            SetUpColors();
            SetUpComponentAnchors();
        }

        private void SetUpForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetUpColors()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);

            searchBox.BackColor = Color.White;

            usersDGV.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
            usersDGV.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            usersDGV.EnableHeadersVisualStyles = false;
            usersDGV.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            usersDGV.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            usersDGV.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            usersDGV.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            usersDGV.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            usersDGV.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentSelectedColor);
            usersDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentBackgroundColor); ;
            usersDGV.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            usersDGV.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            usersDGV.RowHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);

            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.FlatAppearance.BorderSize = 1;
                b.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
                b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }

            foreach (Label b in this.Controls.OfType<Label>())
            {
                b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }

            foreach (CheckBox c in this.Controls.OfType<CheckBox>())
            {
                c.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }
        }

        private void SetUpComponentAnchors()
        {
            searchLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            searchBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            clearButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            usersDGV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            displayLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            showStaff.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            showStudents.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

            viewUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            addUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            editUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            deleteUser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            ChooseAddUserMethodForm chooseMethodForm = new ChooseAddUserMethodForm(_context);
            chooseMethodForm.ShowDialog();
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
                usersDGV.DataSource = _logic.GetPersonList(_context, searchBox.Text.ToString());
            }
            else if (showStaff.Checked)
            {
                usersDGV.DataSource = _logic.GetStaffList(_context, searchBox.Text.ToString());
            }
            else if (showStudents.Checked)
            {
                usersDGV.DataSource = _logic.GetStudentList(_context, searchBox.Text.ToString());
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
            Person personToEdit = _logic.getPersonById(_context, personId);

            AddUser editUserForm = new AddUser(_context);

            editUserForm.SetEditState(personToEdit);
            editUserForm.ShowDialog();
            UpdateList();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            List<int> personsId = getSelectedRowPersonId();

            for (int i = 0; i < personsId.Count; i++)
            {
                _logic.DeleteUser(_context, personsId[i]);
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
            Person personToDisplay = _logic.getPersonById(_context, personId);

            AddUser ViewUserForm = new AddUser(_context);
            ViewUserForm.SetViewState(personToDisplay);
            ViewUserForm.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void UserList_Resize(object sender, EventArgs e)
        {
            this.Update();
            
        }

        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
