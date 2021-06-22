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
        int selectedItemId = -1 ;
        public int id2=-1;
        public int eId = -1;
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
            eId = C.Employees.Select(c => c.EmployeeId).FirstOrDefault();

            //dataGridView1.DataSource = C.Employees.ToList();
           // if (dataGridView1.RowCount > 0)
            //{
                //int selectedrowid = dataGridView1.SelectedCells[0].RowIndex;
               // DataGridViewRow selectedRoww = dataGridView1.Rows[selectedrowid];
               // selectedItemId = Convert.ToInt32(selectedRoww.Cells["EmployeeId"].Value);
          //  }
           // else
            //{
                //electedItemId = -1;
           // }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(C);
            addEmployeeForm.Show();
            EmployeeListForm_Load(sender, e);
        }
        public void EmployeeListForm_Activated(object sender, EventArgs e)
        {
            EmployeeListForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int deleteId = Int32.Parse(textBox1.Text);


            EmployeeLogic.deleteEmployee(C, deleteId);
                //EmployeeListForm_Activated(sender, e);
            
                EmployeeListForm_Load(sender, e);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmployeeId"].Value);
            }
            else
            {
                id = -1;
            }
            EmployeeListForm_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeListForm_Activated(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int deleteId = Int32.Parse(textBox1.Text);
           
              
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm();
                editEmployeeForm.C = C;
                editEmployeeForm.deleteId = deleteId;
                editEmployeeForm.eId = eId;
                editEmployeeForm.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int deleteId = Int32.Parse(textBox1.Text);
        }
    }
}
