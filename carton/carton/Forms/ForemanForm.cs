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
    public partial class ForemanForm : Form
    {
        Context context;
        public ForemanForm(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void GetPlanButton_Click(object sender, EventArgs e)
        {
            //EcoEmplForm f = new EcoEmplForm(context);
            //f.Show();
        }

        private void ShiftRepButton_Click(object sender, EventArgs e)
        {
            ShiftRepForm f = new ShiftRepForm(context);
            f.Show();
        }
    }
}
