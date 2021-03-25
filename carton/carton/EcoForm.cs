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

        private void button1_Click(object sender, EventArgs e)
        {
            CEPlan cePlan = new CEPlan(context, 0);
            cePlan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CEPlan cePlan = new CEPlan(context, 1);
            cePlan.Show();
        }
    }
}
