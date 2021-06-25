﻿using System;
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
        public int id2=-1;
        public int eId = -1;
        public EmployeeListForm()
        {
           
            InitializeComponent();
        }

        public Context C { get; set; }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            var query = from c in C.Employees
                        select new { ID = c.EmployeeId, Имя = c.FullName, Логин = c.Login, Пароль = c.Password, Телефон = c.Phone, PositionId = c.PositionId, GalleryId = c.GalleryId};
                
            dataGridView1.DataSource = query.ToList();
            eId = C.Employees.Select(c => c.EmployeeId).FirstOrDefault();
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
          
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
                EmployeeLogic.deleteEmployee(C, id);
                EmployeeListForm_Load(sender, e);
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
            EmployeeListForm_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeListForm_Activated(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm();
                editEmployeeForm.C = C;
                editEmployeeForm.deleteId = id;
                editEmployeeForm.eId = eId;
                editEmployeeForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int deleteId = Int32.Parse(textBox1.Text);
        }
    }
}
