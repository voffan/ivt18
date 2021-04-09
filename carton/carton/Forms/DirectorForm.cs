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
        Context context;

        int planId;

        public DirectorForm(Context context)
        {
            planId = 0;
            InitializeComponent();
            this.context = context;
            planLogic = new PlanLogic();
            header.Text = "Список планов";
            planGridView.DataSource = context.Plans.ToList();
            planGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ApplyPlanButton_Click(object sender, EventArgs e)
        {
            //selected plan from the list
            Plan plan = context.Plans.Find(planId);
            
            planLogic.ApplyPlan(plan, context);
            planGridView.DataSource = context.Plans.ToList();
        }

        private void ApproveCompletionButton_Click(object sender, EventArgs e)
        {
            //selected plan from the list
            Plan plan = context.Plans.Find(planId);

            planLogic.ApproveCompletion(plan, context);
            planGridView.DataSource = context.Plans.ToList();
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
        /*
            get planId 
        */
        private void planGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = planGridView.CurrentCell.RowIndex;
            int columnindex = 0;

            planId = (int)planGridView.Rows[rowindex].Cells[columnindex].Value;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Plan plan = context.Plans.Find(planId);

            planLogic.resetToNew(plan, context);
            planGridView.DataSource = context.Plans.ToList();
        }
    }
}
