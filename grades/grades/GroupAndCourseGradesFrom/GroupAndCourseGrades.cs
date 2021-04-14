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
        private Staff _user;

        //public GroupAndCourseGrades(Context context)
        public GroupAndCourseGrades()
        {
            InitializeComponent();

            _context = new Context();
            _logic = new GroupAndCourseGradesLogic();
            _user = (from usr in _context.Staff
                     where usr.PersonId == 17
                     select usr).Single();

            LoadCoursesList();
            LoadGroupList();
        }

        private void LoadCoursesList()
        {
            courseComboBox.DataSource = _logic.GetCoursesList(_context, _user);
        }

        private void LoadGroupList()
        {
            groupComboBox.DataSource = _logic.GetGroupList(_context, _user);
        }
    }
}
