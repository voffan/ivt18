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
    public partial class AddRole : Form
    {
        Context _context;
        Person _user;
        AddRoleLogic _logic;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public AddRole(Context context, Person user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _logic = new AddRoleLogic();

            SetUpForm();
            SetupColors();
            SetUpComponentAnchors();
            updateList();
            RoleDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetUpForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetupColors()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);

            RoleDGV.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
            RoleDGV.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            RoleDGV.EnableHeadersVisualStyles = false;
            RoleDGV.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            RoleDGV.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            RoleDGV.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            RoleDGV.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            RoleDGV.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            RoleDGV.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentSelectedColor);
            RoleDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentBackgroundColor); ;
            RoleDGV.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            RoleDGV.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            RoleDGV.RowHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);

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
            searchBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            RoleDGV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            addButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            editButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            deleteButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void updateList()
        {
            RoleDGV.DataSource = _logic.GetRoleList(_context, searchBox.Text);

            if (RoleDGV.Columns["PositionId"] != null)
                RoleDGV.Columns["PositionId"].Visible = false;
        }

        private List<int> getSelectedRowRole()
        {
            List<int> selectedPositionId = new List<int>();

            if (RoleDGV.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = RoleDGV.SelectedRows[0];

                selectedPositionId.Add(Convert.ToInt32(selectedRow.Cells["PositionId"].Value.ToString()));

                return selectedPositionId;
            }
            else if (RoleDGV.SelectedRows.Count > 1)
            {
                for (int i = 0; i < RoleDGV.SelectedRows.Count; i++)
                {
                    DataGridViewRow selectedRow = RoleDGV.SelectedRows[i];

                    selectedPositionId.Add(Convert.ToInt32(selectedRow.Cells["PositionId"].Value.ToString()));
                }

                return selectedPositionId.Distinct().ToList();
            }

            return null;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoleDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RoleAdd addRoleForm = new RoleAdd(_context);
            addRoleForm.ShowDialog();
            updateList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            RoleAdd editRoleForm = new RoleAdd(_context);

            int positionId = getSelectedRowRole().Last();
            Position positionToEdit = _logic.GetPositionById(_context, positionId);

            editRoleForm.SetEditState(positionToEdit);
            editRoleForm.ShowDialog();

            updateList();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            List<int> positionId = getSelectedRowRole();

            for (int i = 0; i < positionId.Count; i++)
            {
                _logic.DeleteRole(_context, positionId[i]);
                updateList();
            }
        }
    }
}
