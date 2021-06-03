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
        int empId = 6;

        public PictureListForm()
        {
            InitializeComponent();
        }

        private void PictureListForm_Load(object sender, EventArgs e)
        {
            var query = from c in C.Pictures
                        select new { ID = c.PictureId, Название = c.Name, Цена = c.Price, Год = c.Year, Художник = c.Artist.FullName, Жанр = c.Genre.Name, Местонахождение = c.CurrentLocation.Name, Галерея = c.Gallery.Name }
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                selectedItemId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
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
            if (selectedItemId > -1)
            {
                AddPictureForm addPictureForm = new AddPictureForm();
                addPictureForm.UpdatingItemId = selectedItemId;
                addPictureForm.FormId = 3;
                addPictureForm.C = C;
                addPictureForm.Show();
            }
            else
            {
                MessageBox.Show("Пусто...");
            }
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            if (selectedItemId > -1)
            {
                AddPictureForm addPictureForm = new AddPictureForm();
                addPictureForm.UpdatingItemId = selectedItemId;
                addPictureForm.FormId = 2;
                addPictureForm.C = C;
                addPictureForm.Show();
            }
            else
            {
                MessageBox.Show("Пусто...");
            }
        }

        private void expoListView(object sender, EventArgs e)
        {
            ExpoListForm expoListForm = new ExpoListForm();
            expoListForm.C = C;
            expoListForm.Show();
        }

        private void pictureDelete_Click(object sender, EventArgs e)
        {
            if (selectedItemId > -1)
            {
                try
                {
                    PictureLogic.DeletePicture(C, selectedItemId);
                    PictureListForm_Activated(sender, e);
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении картины");
                }
            }
            else
            {
                MessageBox.Show("Пусто...");
            }
        }

        private void pictureSendToResto_Click(object sender, EventArgs e)
        {
            if (selectedItemId > -1)
            {
                try
                {
                    PictureLogic.sendToResto(C, selectedItemId, empId);
                    PictureListForm_Activated(sender, e);
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
    }
}
