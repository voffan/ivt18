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
    
    public partial class ClassGeneretion : Form
    {

        private ClassGeneretionLogic _logic;
        private Context _context;

        
        public ClassGeneretion()
        {
            InitializeComponent();
          //  _context = context;
            for (int i = 1; i <= Properties.Settings.Default.HighestClass; i++)
            {
                ClassList.Items.Add(i);
            }

            ClassList.Text = "1";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // Ошибка 
            int n = Convert.ToInt16(CountBox);

            _logic = new ClassGeneretionLogic ();

            _logic.AddClass(_context, n);

        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
