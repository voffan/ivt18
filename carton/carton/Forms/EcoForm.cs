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
    public partial class EcoForm : Form
    {
        Context context;
        public EcoForm(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void createPlanButton_Click(object sender, EventArgs e)
        {
            CEPlanForm cePlan = new CEPlanForm(context, 0);
            cePlan.Show();
        }

        private void editPlanButton_Click(object sender, EventArgs e)
        {
            CEPlanForm cePlan = new CEPlanForm(context, 1);
            cePlan.Show();
        }
    }
}
