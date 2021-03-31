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
    public partial class CEPlanForm : Form
    {
        Context context;
        int type; //0 - create, 1 - edit
        public CEPlanForm(Context context, int type)
        {
            this.context = context;
            this.type = type;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                PlanLogic planLogic = new PlanLogic();
                planLogic.CreatePlan(context);
            }
            else if (type == 1)
            {
                PlanLogic planLogic = new PlanLogic();
                Plan plan = new Plan();
                int id = 2; //some id
                plan = context.Plans.Find(id);
                planLogic.EditPlan(context, plan);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
