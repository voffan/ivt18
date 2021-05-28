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
    public partial class ShiftRepForm : Form
    {
        readonly ShiftLogic shiftLogic;
        Context context;
        CurrencyManager currencyManager;

        int shiftId;

        public ShiftRepForm(Context context)
        {
            shiftId = 5;
            InitializeComponent();
            this.context = context;
            shiftLogic = new ShiftLogic();
            //planGridView
            planGridView.DataSource = context.DailyProds.ToList();
            planGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            planGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Visible = false;
            planGridView.RowHeadersVisible = false;
            planGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //plannedGridView
        }
      
        private void ShiftRepForm_Load(object sender, EventArgs e)
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

            //shiftId = (int)planGridView.Rows[rowindex].Cells[columnindex].Value;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            string BoxA = textBoxA.Text;
            string BoxB = textBoxB.Text;
            string BoxC = textBoxC.Text;

            Shift shift = context.Shifts.Find(shiftId);
            shiftLogic.Add(context, shift, BoxA, BoxB, BoxC);

            planGridView.DataSource = context.DailyProds.ToList();

        }

        private void editReportButton_Click(object sender, EventArgs e)
        {
            int rowindex = planGridView.CurrentCell.RowIndex;
            int columnindex = 0;
            int dailyProdId = (int)planGridView.Rows[rowindex].Cells[columnindex].Value;

            string BoxA = textBoxA.Text;
            DailyProd dailyprod = context.DailyProds.Find(dailyProdId);
            shiftLogic.Change(context, dailyprod, BoxA);
            planGridView.DataSource = context.DailyProds.ToList();
        }
    }
}
