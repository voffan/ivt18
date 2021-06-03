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
            var query = from c in C.Journals
                        select new { ID = c.JournalId, Дата = c.Date, Откуда = c.From.Name, Куда = c.To.Name, Картина = c.Picture.Name, Сотрудник = c.Employee.FullName }
                        ;
            dataGridView1.DataSource = query.ToList();
            if (dataGridView1.RowCount > 0)
            {
                int selectedrowid = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRoww = dataGridView1.Rows[selectedrowid];
                selectedItemId = Convert.ToInt32(selectedRoww.Cells["ID"].Value);
            }
            else
            {
                selectedItemId = -1;
            }
        }

        private void deletePictureFromResto(object sender, EventArgs e)
        {
            if (selectedItemId > -1)
            {
                try
                {
                    PictureLogic.deleteFromResto(C, selectedItemId);
                    ComissionList_Activated(sender, e);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            else
            {
                MessageBox.Show("Пусто...");
            }
        }

        private void ComissionList_Activated(object sender, EventArgs e)
        {
            ComissionList_Load(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowid = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRoww = dataGridView1.Rows[selectedrowid];
                selectedItemId = Convert.ToInt32(selectedRoww.Cells["ID"].Value);
            }
        }
    }
}
