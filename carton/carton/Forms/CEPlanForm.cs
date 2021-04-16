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
            InitializeComponent();
            this.context = context;
            this.type = type;

            if (type == 1)
            {
                header.Text = "Изменение плана";
                planNameTextBox.ReadOnly = false;
                planDateTimePicker.Enabled = true;
            }
            else if (type == 0)
            {
                header.Text = "Создание плана";
                planNameTextBox.ReadOnly = true;
                planDateTimePicker.Enabled = false;
            }
            statusTextBox.ReadOnly = true;

            List<Product> products = context.Products.ToList();
            List<String> productNames = new List<string>();
            foreach (Product p in products)
            {
                productNames.Add(p.Name); 
            }
            productListBox.DataSource = productNames;
            productListBox.SelectionMode = SelectionMode.One;
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
            if (type == 0)
            {
                PlanLogic planLogic = new PlanLogic();
                //<productId, productAmount>
                Dictionary<int, int> data = new Dictionary<int, int>();
                //List<string> ss;
                //ss[0] = textBox1.Text;
                string selectedName = productListBox.SelectedItem.ToString();
                int productId = selectedProduct(selectedName);
                int productAmount = 0;
                foreach (char c in productAmountTextBox.Text)
                {
                    if (c >= '0' && c <= '9')
                    {
                        productAmount = productAmount * 10 + (c - '0');
                    }
                    else
                    {
                        productAmount = -1;
                        break;
                    }
                }

                header.Text = productAmount.ToString();
                data.Add(productId, productAmount);
                planLogic.CreatePlan(context, data);
            }
            else if (type == 1)
            {
                PlanLogic planLogic = new PlanLogic();
                Dictionary<int, int> data = new Dictionary<int, int>();
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

        private void CEPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartonDBDataSet.Plan' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
