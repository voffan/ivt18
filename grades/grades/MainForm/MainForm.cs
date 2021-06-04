using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    public partial class MainForm : Form
    {

        private Person _user;
        private int Id;
        private Context _context;

        private UserList _userListForm;
        private SubjectList _subjectListForm;
        private GroupAndCourseGrades _gradingForm;
        private StudentInfo _studentInfo;
        private AddRole _addRole;

        private Color _defauldBackColor;
        private Color _selectedBtnTxtColor;

        public MainForm(Context _context, int _id)
        {
            InitializeComponent();
            this._context = _context;
            Id = _id;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _context = new Context();

            _user = (from usr in _context.Persons
                     where usr.PersonId == Id
                     select usr).Single();


            //_userListForm = new UserList(_context, _user);
            //_subjectListForm = new SubjectList(_context, _user);
            //_gradingForm = new GroupAndCourseGrades(_context, _user);
            _studentInfo = new StudentInfo(_context, _user);
            _addRole = new AddRole(_context, _user);


            SetupUserInfo();
            SetupColors();
            Enter();
        }

        private void Enter()
        {
            if (lblUserPosition.Text == "Директор")
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }
        }

        private void SetupColors()
        {
            _defauldBackColor = System.Drawing.ColorTranslator.FromHtml("#535353");
            _selectedBtnTxtColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");

            panelNavigation.BackColor = System.Drawing.ColorTranslator.FromHtml("#121212");
            panelMainContent.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            lblUserName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#535353");
            lblUserPosition.BackColor = System.Drawing.ColorTranslator.FromHtml("#121212");
            lblUserPosition.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");


            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                foreach (Panel pp in p.Controls.OfType<Panel>())
                {
                    foreach (Button b in pp.Controls.OfType<Button>())
                    {
                        b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#535353");
                    }
                }
                foreach (Button b in p.Controls.OfType<Button>())
                {
                    b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#535353");
                }
                
            }
        }

        private void SetupUserInfo()
        {
            lblUserName.Text = _user.FirstName + " " + _user.SurName;
            lblUserPosition.Text = _context.Positions.Where(p => p.PositionId == _user.PositionId).Select(p => p.Name).Single();
            lblUserName.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            lblUserName.AutoSize = false;
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            lblUserPosition.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            lblUserPosition.AutoSize = false;
            lblUserPosition.TextAlign = ContentAlignment.MiddleCenter;

            int xCenter = (panelUserInfo.Width - lblUserName.Width) / 2;
            lblUserName.Location = new Point(xCenter, lblUserName.Location.Y);
            xCenter = (panelUserInfo.Width - lblUserPosition.Width) / 2;
            lblUserPosition.Location = new Point(xCenter, lblUserPosition.Location.Y);
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            hideAllForm();
            clearButtonsColor();

            btnUserList.ForeColor = _selectedBtnTxtColor;

            _userListForm.FormBorderStyle = FormBorderStyle.None;
            this.IsMdiContainer = true;
            _userListForm.MdiParent = this;
            this.panelMainContent.Controls.Add(_userListForm);
            _userListForm.Dock = DockStyle.Fill;
            _userListForm.Show();
        }

        private void btnSubjectList_Click(object sender, EventArgs e)
        {
            hideAllForm();
            clearButtonsColor();

            btnSubjectList.ForeColor = _selectedBtnTxtColor;

            _subjectListForm.FormBorderStyle = FormBorderStyle.None;
            this.IsMdiContainer = true;
            _subjectListForm.MdiParent = this;
            this.panelMainContent.Controls.Add(_subjectListForm);
            _subjectListForm.Dock = DockStyle.Fill;
            _subjectListForm.Show();
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            hideAllForm();
            clearButtonsColor();

            btnGrading.ForeColor = _selectedBtnTxtColor;

            _gradingForm.FormBorderStyle = FormBorderStyle.None;
            this.IsMdiContainer = true;
            _gradingForm.MdiParent = this;
            this.panelMainContent.Controls.Add(_gradingForm);
            _gradingForm.Dock = DockStyle.Fill;
            _gradingForm.Show();
        }

        private void hideAllForm()
        {
            //_subjectListForm.Hide();
            //_userListForm.Hide();
            //_gradingForm.Hide();
            _studentInfo.Hide();
            _addRole.Hide();
        }

        private void clearButtonsColor()
        {
            btnGrading.ForeColor = _defauldBackColor;
            btnSubjectList.ForeColor = _defauldBackColor;
            btnUserList.ForeColor = _defauldBackColor;
            button1.ForeColor = _defauldBackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideAllForm();
            clearButtonsColor();
            

            btnGrading.ForeColor = _selectedBtnTxtColor;

            _studentInfo.FormBorderStyle = FormBorderStyle.None;
            this.IsMdiContainer = true;
            _studentInfo.MdiParent = this;
            this.panelMainContent.Controls.Add(_studentInfo);
            _studentInfo.Dock = DockStyle.Fill;
            _studentInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            hideAllForm();
            clearButtonsColor();


            btnGrading.ForeColor = _selectedBtnTxtColor;

            _addRole.FormBorderStyle = FormBorderStyle.None;
            this.IsMdiContainer = true;
            _addRole.MdiParent = this;
            this.panelMainContent.Controls.Add(_addRole);
            _addRole.Dock = DockStyle.Fill;
            _addRole.Show();
        }

        private void lblUserPosition_Click(object sender, EventArgs e)
        {

        }
    }
}
