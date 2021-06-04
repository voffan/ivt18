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
    public partial class TransitionManagement : Form
    {
        private Context _context;
        private TransitionManagementLogic _logic;
        private Person _user;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        private int _currentGroupId;

        public TransitionManagement(Context context, Person user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _logic = new TransitionManagementLogic();

            SetupComponentAnchors();
            SetupForm();
            SetupColors();

            LoadGroupList();
        }

        private void SetupComponentAnchors()
        {
            groupLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            groupComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

            studentsDGV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            reportCardButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetupColors()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);

            studentsDGV.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
            studentsDGV.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            studentsDGV.EnableHeadersVisualStyles = false;
            studentsDGV.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            studentsDGV.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            studentsDGV.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            studentsDGV.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);
            studentsDGV.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            studentsDGV.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentSelectedColor);
            studentsDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentBackgroundColor); ;
            studentsDGV.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            studentsDGV.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(_contentBackgroundColor);
            studentsDGV.RowHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(_contentSelectedColor);

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

        private void LoadGroupList()
        {
            groupComboBox.DataSource = _logic.GetGroupList(_context);
            groupComboBox.DisplayMember = "ClassName";
            groupComboBox.ValueMember = "Id";
            groupComboBox.SelectedIndex = -1;
        }

        private void groupComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(groupComboBox.SelectedValue.ToString());
        }
    }
}
