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
    public partial class ComissionList : Form
    {
        public Context C { get; set; }
        int selectedItemId = -1;
        public ComissionList()
        {
            InitializeComponent();
        }

        private void ComissionList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Journals.ToList();
            dataGridView1.ReadOnly = true;
            if (dataGridView1.RowCount!=0)
            {
                dataGridView1.CurrentCell.Selected = true;
                dataGridView1.Rows[0].Selected = true;
            }
            dataGridView1.Columns["Picture"].Visible = false;
            dataGridView1.Columns["DepartmentFromId"].Visible = false;
            dataGridView1.Columns["DepartmentToId"].Visible = false;
            dataGridView1.Columns["From"].Visible = false;
            dataGridView1.Columns["To"].Visible = false;
            //dataGridView1.Columns["Department"].Visible = false;
            dataGridView1.Columns.Add("Fromm", "Откуда");
            dataGridView1.Columns.Add("Too", "Куда");
            dataGridView1.Columns.Add("Pict", "Картина");
            dataGridView1.Columns.Add("emppl", "Сотрудник");
            dataGridView1.Columns["DepartmentToId"].Visible = false;
            dataGridView1.Columns["DepartmentFromId"].Visible = false;
            dataGridView1.Columns["PictureId"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView1.Columns["EmployeeId"].Visible = false;
            dataGridView1.Columns["Expo"].Visible = false;
            dataGridView1.Columns["ExpoId"].Visible = false;
            getPictures();
        }

        public void getPictures()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                int selectedItemId = Convert.ToInt32(selectedRow.Cells["DepartmentFromId"].Value);
                int DepartmentTo = Convert.ToInt32(selectedRow.Cells["DepartmentToId"].Value);
                int Pictue = Convert.ToInt32(selectedRow.Cells["PictureId"].Value);
                int emp = Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value);
                int expo = Convert.ToInt32(selectedRow.Cells["ExpoId"].Value);
                dataGridView1.Rows[i].Cells["Fromm"].Value = PictureLogic.getJournalById(selectedItemId, C);
                dataGridView1.Rows[i].Cells["Too"].Value = PictureLogic.getJournalById(DepartmentTo, C);
                dataGridView1.Rows[i].Cells["Pict"].Value = PictureLogic.getPictureById(Pictue, C);
                dataGridView1.Rows[i].Cells["emppl"].Value = PictureLogic.getEmployeeById(emp, C);
            }
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell.Selected = true;
                dataGridView1.Rows[0].Selected = true;
                int selectedrowid = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRoww = dataGridView1.Rows[selectedrowid];
                selectedItemId = Convert.ToInt32(selectedRoww.Cells["JournalId"].Value);
            }
        }

        private void deletePictureFromResto(object sender, EventArgs e)
        {
            try
            {
                PictureLogic.deleteFromResto(C, selectedItemId);
                MessageBox.Show("Удаление...");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void ComissionList_Activated(object sender, EventArgs e)
        {
            getPictures();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowid = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRoww = dataGridView1.Rows[selectedrowid];
                selectedItemId = Convert.ToInt32(selectedRoww.Cells["JournalId"].Value);
            }
        }
    }
}
