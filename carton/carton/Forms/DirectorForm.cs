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
    public partial class DirectorForm : Form
    {
        readonly PlanLogic planLogic;
        readonly Context context;

        public DirectorForm(Context context)
        {
            InitializeComponent();
            this.context = context;
            planLogic = new PlanLogic();
            planGridView.DataSource = context.Plans.ToList();
            planGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ApplyPlanButton_Click(object sender, EventArgs e)
        { 
            //selected plan from the list
            Plan plan = new Plan();
            planLogic.ApplyPlan(plan, context);
        }

        private void ApproveCompletionButton_Click(object sender, EventArgs e)
        {
            //selected plan from the list
            Plan plan = new Plan();
            planLogic.ApproveCompletion(plan, context);
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartonDBDataSet.Plan' table. You can move, or remove it, as needed.
            //this.planTableAdapter.Fill(this.cartonDBDataSet.Plan);
            //this.planGridView.DataSource = context.Plans;
        }

        private void planGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int row = e.RowIndex;
            //context.Plans.
            //Control ss = planGridView.GetChildAtPoint(planGridView.GetRowDisplayRectangle(row, false).Location);
            



        }
    }

}
