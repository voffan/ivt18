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
    public partial class GroupAndCourseGrades : Form
    {
        private Context _context;
        private GroupAndCourseGradesLogic _logic;
        private Person _user;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

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
        }

        private void LoadGroupList()
        {
            groupComboBox.DataSource = _logic.GetGroupList(_context, _user);
        }

        private void GroupAndCourseGrades_Load(object sender, EventArgs e)
        {
            gradesDGV.DataSource = _context.Groups.ToList();
            gradesDGV.Columns[1].ReadOnly = true;
        }
    }
}
