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
        int planId;
        public CEPlanForm(Context context, int type, int planId)
        {
            InitializeComponent();
            this.context = context;
            this.planId = planId;

            List<Product> products = context.Products.ToList();
            List<Planned> planneds = context.Planneds.ToList();

            List<String> productNames = new List<string>();
            List<int> productAmount = new List<int>();


            foreach (Product p in products)
            {
                productNames.Add(p.Name);
            }

        }

        private int selectedProduct(string productName)
        {
            int temp = 0;

            foreach (Product p in context.Products)
            {
                if (p.Name == productName)
                {
                    temp = p.Id;
                }
            }

            return temp;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PlanLogic planLogic = new PlanLogic();
            string name = planNameTextBox.Text;
            string data = planDateTextBox.Text;
            int status = Int32.Parse(statusTextBox.Text);
            int prodLineId = Int32.Parse(prodLineIdTextBox.Text);

            planLogic.CreatePlan(context, name, data, status, prodLineId);
            planNameTextBox.Text = "";
            planDateTextBox.Text = "";
            statusTextBox.Text = "";
            prodLineIdTextBox.Text = "";


        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CEPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartonDBDataSet.Plan' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void planNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
