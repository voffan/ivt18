using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carton
{
    public partial class ShiftExpForm : Form
    {
        readonly ShiftLogic shiftLogic;
        Context context;
        int shiftId;
        public ShiftExpForm(Context context, int shiftId)
        {
            this.shiftId = shiftId;
            InitializeComponent();
            this.context = context;
            shiftLogic = new ShiftLogic();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Shift exp = context.Shifts.Find(shiftId);
            string BoxA = textBox1.Text;
            shiftLogic.Save(context, exp, BoxA);
        }
    }
}
