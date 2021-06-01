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

        private int _currentSubjectId;
        private int _currentCourseId;
        private int _currentGroupId;

        private String _minGrade;
        private String _maxGrade;

        public GroupAndCourseGrades(Context context, Person user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _logic = new GroupAndCourseGradesLogic();

            InitGradesDGVColumns();

            LoadSubjectsList();

            SetupColor();
            SetUpComponentAnchors();
            SetupGradeBounds();
        }

        private void SetupGradeBounds()
        {
            _maxGrade = _context.GradingSystems.Select(g => g.MaxGrade).Single();
            _minGrade = _context.GradingSystems.Select(g => g.MinGrade).Single();

            if (!char.IsNumber(Convert.ToChar(_maxGrade)))
            {
                var temp = _maxGrade;
                _maxGrade = _minGrade;
                _minGrade = temp;
            }
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

        private void InitGradesDGVColumns()
        {
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

            for (int i = 0; i < 9; i++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name = cellNames[i];
                var template = new DataGridViewTextBoxCell();

                if (i > 1)
                {
                    col.ReadOnly = false;

                    int maxInputLenght = _context.GradingSystems.Select(g => g.MaxGrade).Single().Length;
                    template.MaxInputLength = maxInputLenght;
                    col.CellTemplate = template;
                }
                else
                {
                    col.ReadOnly = true;

                    col.CellTemplate = template;
                }

                gradesDGV.Columns.Add(col);
            }

            gradesDGV.Columns[0].Visible = false;
        }

        private void LoadSubjectsList()
        {
            courseComboBox.DataSource = _logic.GetSubjectsList(_context, _user);
            courseComboBox.DisplayMember = "SubjectName";
            courseComboBox.ValueMember = "Id";
            courseComboBox.SelectedIndex = -1;
        }

        private void LoadGroupList()
        {
            groupComboBox.DataSource = _logic.GetGroupList(_context, _currentSubjectId, _user);
            groupComboBox.DisplayMember = "ClassName";
            groupComboBox.ValueMember = "Id";
            groupComboBox.SelectedIndex = -1;
        }

        private void GroupAndCourseGrades_Load(object sender, EventArgs e)
        {

        }

        private void updateGradingList()
        {
            if (courseComboBox.SelectedIndex != -1 && groupComboBox.SelectedIndex != -1)
            {
                try
                {
                    gradesDGV.Rows.Clear();
                    gradesDGV.Refresh();

                    var groupCards = (_logic.GetGroup(_context, _currentCourseId, _currentGroupId, _user));

                    for (int i = 0; i < groupCards.Count; i++)
                    {
                        gradesDGV.Rows.Add();
                        for (int j = 0; j < groupCards[i].Count; j++)
                        {
                            gradesDGV.Rows[i].Cells[j].Value = groupCards[i][j];
                        }
                    }

                    gradesDGV.AutoResizeColumns();
                    gradesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            String grade = gradesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            CheckPoint checkPoint = (CheckPoint)(e.ColumnIndex - 2);
            _logic.SaveGrade(_context, studentId, _currentCourseId, checkPoint, grade);
        }

        private void courseComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (_currentSubjectId == Convert.ToInt32(courseComboBox.SelectedValue)) return;

            _currentSubjectId = Convert.ToInt32(courseComboBox.SelectedValue);

            LoadGroupList();
        }

        private void groupComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (_currentGroupId == Convert.ToInt32(groupComboBox.SelectedValue)) return;

            _currentGroupId = Convert.ToInt32(groupComboBox.SelectedValue);
            _currentCourseId = _logic.GetCourseId(_context, _currentSubjectId, _currentGroupId, _user);

            updateGradingList();
        }

        private void gradesDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(gradesDGV_KeyPress);
            if (gradesDGV.CurrentCell.ColumnIndex > 1 && gradesDGV.CurrentCell.ColumnIndex < 9)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(gradesDGV_KeyPress);
                }
            }
        }

        private void gradesDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(e.KeyChar >= Convert.ToChar(_minGrade) && e.KeyChar <= Convert.ToChar(_maxGrade)))
            {
                e.Handled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            updateGradingList();
        }
    }
}
