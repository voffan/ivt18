using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    public partial class EmployeeListForm : Form
    {
        public int id;
        int selectedItemId = -1;
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        public Context C { get; set; }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.galleryDBDataSet1);*/
            
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
           

            dataGridView1.DataSource = C.Employees.ToList();
            int selectedrowid = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRoww = dataGridView1.Rows[selectedrowid];
            selectedItemId = Convert.ToInt32(selectedRoww.Cells["EmployeeId"].Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(C);
            addEmployeeForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            }
            else
            {
                id = -1;
            }
        }
        private void EmployeeListForm_Activated(object sender, EventArgs e)
        {
            EmployeeListForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedItemId > -1)
            {
                try
                {
                    EmployeeLogic.deleteEmployee(C, selectedItemId);
                    EmployeeListForm_Activated(sender, e);

                }

                catch
                {

                }
         }
        }
    }
}
