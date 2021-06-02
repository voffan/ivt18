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
    public partial class EcoEmplForm : Form
    {
        readonly PlanLogic planLogic;
        Context context;
        CurrencyManager currencyManager;

        int planId;

        public EcoEmplForm(Context context)
        {
            planId = 0;
            InitializeComponent();
            this.context = context;
            planLogic = new PlanLogic();
            //planGridView
            planGridView.DataSource = context.Plans.ToList();
            planGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            planGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Visible = false;
            planGridView.RowHeadersVisible = false;
            planGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //plannedGridView
            plannedGridView.DataSource = context.Planneds.ToList();
            plannedGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            plannedGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            plannedGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Visible = false;
            plannedGridView.RowHeadersVisible = false;
            plannedGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //currency manager
            currencyManager = (CurrencyManager)BindingContext[plannedGridView.DataSource];

            foreach (DataGridViewRow row in plannedGridView.Rows)
            {
                plannedGridView.Rows[row.Index].Visible = true;
            }
        }

        
        //private void ResetButton_Click(object sender, EventArgs e)
        //{
        //    Plan plan = context.Plans.Find(planId);

        //    planLogic.resetToNew(plan, context);

        //    //update datagridviews
        //    planGridView.DataSource = context.Plans.ToList();
        //    plannedGridView.DataSource = context.Planneds.ToList();
            
        //    HideUnnecessaryPlanneds(planId);
        //}

        //private void ApplyPlanButton_Click(object sender, EventArgs e)
        //{
        //    //selected plan from the list
        //    Plan plan = context.Plans.Find(planId);
            
        //    planLogic.ApplyPlan(plan, context);

        //    //update datagridviews
        //    planGridView.DataSource = context.Plans.ToList();
        //    plannedGridView.DataSource = context.Planneds.ToList();
            
        //    HideUnnecessaryPlanneds(planId);
        //}

        //private void ApproveCompletionButton_Click(object sender, EventArgs e)
        //{
        //    //selected plan from the list
        //    Plan plan = context.Plans.Find(planId);

        //    planLogic.ApproveCompletion(plan, context);

        //    //update datagridviews
        //    planGridView.DataSource = context.Plans.ToList();
        //    plannedGridView.DataSource = context.Planneds.ToList();

        //    HideUnnecessaryPlanneds(planId);
        //}

        private void EcoEmplForm_Load(object sender, EventArgs e)
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

            HideUnnecessaryPlanneds(planId);
        }

        private void HideUnnecessaryPlanneds(int planId)
        {
            currencyManager.SuspendBinding();
            foreach (DataGridViewRow row in plannedGridView.Rows)
            {
                if ((int)plannedGridView.Rows[row.Index].Cells[3].Value != planId)
                {
                    plannedGridView.Rows[row.Index].Visible = false;
                }
                else
                {
                    plannedGridView.Rows[row.Index].Visible = true;
                }
            }
            currencyManager.ResumeBinding();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editSavePlanButton_Click(object sender, EventArgs e)
        {
            CEPlanForm editForm = new CEPlanForm(context, 1, planId);
            editForm.Show();
            HideUnnecessaryPlanneds(planId);
            
        }

        private void createPlanBbutton_Click(object sender, EventArgs e)
        {
            CEPlanForm createForm = new CEPlanForm(context, 0, planId);
            createForm.Show();
            HideUnnecessaryPlanneds(planId);
        }

        private void deletePlan_Click(object sender, EventArgs e)
        {
            //selected plan from the list
            Plan plan = context.Plans.Find(planId);

            planLogic.MarkToDelete(plan, context);

            //update datagridviews
            planGridView.DataSource = context.Plans.ToList();
            plannedGridView.DataSource = context.Planneds.ToList();
            HideUnnecessaryPlanneds(planId);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //selected plan from the list
            Plan plan = context.Plans.Find(planId);

            planLogic.ExportPlan(plan, context);

            //update datagridviews
            planGridView.DataSource = context.Plans.ToList();
            plannedGridView.DataSource = context.Planneds.ToList();
            HideUnnecessaryPlanneds(planId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            planGridView.DataSource = context.Plans.ToList();
        }
    }
}
