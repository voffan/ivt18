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
    public partial class PictureListForm : Form
    {
        public Context C { get; set; }
        int selectedItemId = -1;

        public PictureListForm()
        {
            InitializeComponent();
        }

        private void PictureListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Pictures.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExpoListForm expoListForm = new ExpoListForm();
            expoListForm.C = C;
            expoListForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
            addPictureForm.FormId = 1;
            addPictureForm.C = C;
            addPictureForm.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                selectedItemId = Convert.ToInt32(selectedRow.Cells["PictureId"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PictureLogic.DeletePicture(C, selectedItemId);
                MessageBox.Show("Удаление...");
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении картины");
            }
        }

        private void PictureListForm_Activated(object sender, EventArgs e)
        {
            PictureListForm_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
