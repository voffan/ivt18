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
        public ComissionList()
        {
            InitializeComponent();
        }

        private void ComissionList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Journals.ToList();//fix it, some bags
            dataGridView1.ReadOnly = true;
            if (dataGridView1.RowCount!=0)
            {
                dataGridView1.CurrentCell.Selected = true;
                dataGridView1.Rows[0].Selected = true;
            }
            dataGridView1.Columns.Remove("Picture");
            dataGridView1.Columns.Remove("From");
            dataGridView1.Columns.Remove("To");
            dataGridView1.Columns.Add("From", "Откуда");
            dataGridView1.Columns.Add("To", "Куда");
            dataGridView1.Columns.Add("Pict", "Картина");
            dataGridView1.Columns.Add("emppl", "Сотрудник");
            dataGridView1.Columns.Add("exp", "Экспозиция");
            for (int i=0; i<dataGridView1.RowCount; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                int selectedItemId = Convert.ToInt32(selectedRow.Cells["PlaceFromId"].Value);
                int PlaceTo = Convert.ToInt32(selectedRow.Cells["PlaceToId"].Value);
                int Pictue = Convert.ToInt32(selectedRow.Cells["PictureId"].Value);
                int emp = Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value);
                int expo = Convert.ToInt32(selectedRow.Cells["ExpoId"].Value);
                dataGridView1.Rows[i].Cells["From"].Value = PictureLogic.getJournalById(selectedItemId, C);
                dataGridView1.Rows[i].Cells["To"].Value = PictureLogic.getJournalById(PlaceTo, C);
                dataGridView1.Rows[i].Cells["Pict"].Value = PictureLogic.getPictureById(Pictue, C);
                dataGridView1.Rows[i].Cells["emppl"].Value = PictureLogic.getEmployeeById(emp, C);
                dataGridView1.Rows[i].Cells["exp"].Value = PictureLogic.getExpoById(expo, C);
            }
            dataGridView1.Columns.Remove("PlaceToId");
            dataGridView1.Columns.Remove("PlaceFromId");
            dataGridView1.Columns.Remove("PictureId");
            dataGridView1.Columns.Remove("Employee");
            dataGridView1.Columns.Remove("EmployeeId");
            dataGridView1.Columns.Remove("Expo");
            dataGridView1.Columns.Remove("ExpoId");
        }
    }
}
