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
        int employeeId = 1;

        public PictureListForm()
        {
            InitializeComponent();
        }

        private void PictureListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Pictures.ToList();
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.Rows[0].Selected = true;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            selectedItemId = Convert.ToInt32(selectedRow.Cells["PictureId"].Value);
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

        private void PictureListForm_Activated(object sender, EventArgs e)
        {
            PictureListForm_Load(sender, e);
        }

        private void artistListView_Click(object sender, EventArgs e)
        {
            ArtistListForm artistListForm = new ArtistListForm();
            artistListForm.C = C;
            artistListForm.Show();
        }

        private void genreListView_Click(object sender, EventArgs e)
        {
            GenreListForm genreListForm = new GenreListForm();
            genreListForm.C = C;
            genreListForm.Show();
        }

        private void galleryListView_Click(object sender, EventArgs e)
        {
            GalleryListForm galleryListForm = new GalleryListForm();
            galleryListForm.C = C;
            galleryListForm.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.C = C;
            search.Show();
        }

        private void pictureAdd_Click(object sender, EventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
            addPictureForm.FormId = 1;
            addPictureForm.C = C;
            addPictureForm.Show();
        }

        private void pictureView_Click(object sender, EventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
            addPictureForm.UpdatingItemId = selectedItemId;
            addPictureForm.FormId = 3;
            addPictureForm.C = C;
            addPictureForm.Show();
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
            addPictureForm.UpdatingItemId = selectedItemId;
            addPictureForm.FormId = 2;
            addPictureForm.C = C;
            addPictureForm.Show();
        }

        private void expoListView(object sender, EventArgs e)
        {
            ExpoListForm expoListForm = new ExpoListForm();
            expoListForm.C = C;
            expoListForm.Show();
        }

        private void pictureDelete_Click(object sender, EventArgs e)
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

        private void pictureSendToResto_Click(object sender, EventArgs e)
        {
            try
            {
                PictureLogic.sendToResto(C, selectedItemId, employeeId);
                MessageBox.Show("Добавляется...");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
