using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace grades
{
    public partial class GroupAndCourseGrades : Form
    {
        private Context _context;
        private GroupAndCourseGradesLogic _logic;
        private Person _user;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        private int _currentCourseId;

        public GroupAndCourseGrades(Context context, Person user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _logic = new GroupAndCourseGradesLogic();
            
            LoadCoursesList();
            LoadGroupList();

            SetupColor();
            SetUpComponentAnchors();
        }

        private void SetUpComponentAnchors()
        {
            courseLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            groupLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            courseComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            groupComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

            gradesDGV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            cancelButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            saveButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void SetupColor()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);

            gradesDGV.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
            gradesDGV.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            gradesDGV.EnableHeadersVisualStyles = false;
            gradesDGV.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            gradesDGV.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            gradesDGV.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            gradesDGV.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            gradesDGV.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            gradesDGV.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentSelectedColor);
            gradesDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;
            gradesDGV.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            gradesDGV.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            gradesDGV.RowHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);

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

        private void LoadCoursesList()
        {
            courseComboBox.DataSource = _logic.GetCoursesList(_context, _user);
            courseComboBox.DisplayMember = "CourseName";
            courseComboBox.ValueMember = "Id";
            courseComboBox.SelectedIndex = -1;
        }

        private void LoadGroupList()
        {
            groupComboBox.DataSource = _logic.GetGroupList(_context, _user);
            groupComboBox.DisplayMember = "ClassName";
            groupComboBox.ValueMember = "Id";
            groupComboBox.SelectedIndex = -1;
        }

        private void GroupAndCourseGrades_Load(object sender, EventArgs e)
        {

            updateGradingList();
        }

        private void updateGradingList()
        {
            if (courseComboBox.SelectedIndex != -1 && groupComboBox.SelectedIndex != -1)
            {
                string subjectName = courseComboBox.Text;
                var group = groupComboBox.Text.Split(' ');

                _currentCourseId = Convert.ToInt32(courseComboBox.SelectedValue);

                try
                {
                    var groupCards = (_logic.GetGroup(_context, subjectName, Convert.ToInt32(group[0]), group[1], _user));

                    List<string> cellNames = new List<string>{
                        "id",
                        "ФИО",
                        "1 четверть",
                        "2 четверть",
                        "1 полугодие",
                        "3 четверть",
                        "4 четверть",
                        "2 полугодие",
                        "Год",};

                    for (int i = 0; i < groupCards[0].Count; i++)
                    {
                        DataGridViewColumn col = new DataGridViewColumn();
                        col.Name = cellNames[i];
                        col.CellTemplate = new DataGridViewTextBoxCell();

                        if (i > 1)
                        {
                            col.ReadOnly = false;
                        }
                        else
                        {
                            col.ReadOnly = true;
                        }

                        gradesDGV.Columns.Add(col);
                    }

                    for (int i = 0; i < groupCards.Count; i++)
                    {
                        gradesDGV.Rows.Add();
                        for (int j = 0; j < groupCards[i].Count; j++)
                        {
                            gradesDGV.Rows[i].Cells[j].Value = groupCards[i][j];
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void gradesDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int studentId = Convert.ToInt32(gradesDGV.Rows[e.RowIndex].Cells["id"].Value);
            CheckPoint checkPoint = (CheckPoint)Convert.ToInt32(gradesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            MessageBox.Show(groupComboBox.SelectedValue.ToString());
        }
    }
}
