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
    public partial class SubjectList : Form
    {
        Context _context;
        Person _user;
        SubjectListLogic _logic;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public SubjectList(Context context, Person user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _logic = new SubjectListLogic();

            SetUpForm();
            SetUpColors();
            SetUpComponentAnchors();

            subjectDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetUpColors()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            searchBox.BackColor = Color.White;

            subjectDGV.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
            subjectDGV.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            subjectDGV.EnableHeadersVisualStyles = false;
            subjectDGV.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            subjectDGV.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            subjectDGV.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            subjectDGV.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            subjectDGV.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            subjectDGV.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentSelectedColor);
            subjectDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;
            subjectDGV.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            subjectDGV.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            subjectDGV.RowHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);

            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.FlatAppearance.BorderSize = 1;
                b.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");
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

        private void SubjectList_Load(object sender, EventArgs e)
        {
            updateList();
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
            clearButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            subjectDGV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            addButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            editButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            deleteButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddSubjectcs addSubjectcsForm = new AddSubjectcs(_context);
            addSubjectcsForm.ShowDialog();
            updateList();
        }

        private void updateList()
        {
            subjectDGV.DataSource = _logic.GetSubjectList(_context, searchBox.Text);

            if (subjectDGV.Columns["SubjectId"] != null)
                subjectDGV.Columns["SubjectId"].Visible = false;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private List<int> getSelectedRowSubjectId()
        {
            List<int> selectedSubjectsId = new List<int>();

            if (subjectDGV.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = subjectDGV.SelectedRows[0];

                selectedSubjectsId.Add(Convert.ToInt32(selectedRow.Cells["SubjectId"].Value.ToString()));

                return selectedSubjectsId;
            }
            else if (subjectDGV.SelectedRows.Count > 1)
            {
                for (int i = 0; i < subjectDGV.SelectedRows.Count; i++)
                {
                    DataGridViewRow selectedRow = subjectDGV.SelectedRows[i];

                    selectedSubjectsId.Add(Convert.ToInt32(selectedRow.Cells["SubjectId"].Value.ToString()));
                }

                return selectedSubjectsId.Distinct().ToList();
            }

            return null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            List<int> subjectsId = getSelectedRowSubjectId();

            for (int i = 0; i < subjectsId.Count; i++)
            {
                _logic.DeleteSubject(_context, subjectsId[i]);
                updateList();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddSubjectcs editSubjectcsForm = new AddSubjectcs(_context);

            int subjectId = getSelectedRowSubjectId().Last();
            Subject subjectToEdit = _logic.GetSubjectById(_context, subjectId);

            editSubjectcsForm.SetEditState(subjectToEdit);
            editSubjectcsForm.ShowDialog();

            updateList();
        }
    }
}
