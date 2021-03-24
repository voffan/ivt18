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
  

        
        public ClassGeneretion()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(CountBox);

            _logic = new ClassGeneretionLogic ();

            _logic.AddClass(n);

        }
    }
}
