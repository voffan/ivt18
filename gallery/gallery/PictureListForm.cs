using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        int empId = 3;

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
            //Search search = new Search();
            //search.C = C;
            //search.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ConStr = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
                {
                    if (ConStr.State == ConnectionState.Closed)
                        ConStr.Open();
                    using(DataTable dt = new DataTable("Pictures"))
                    {
                        using(SqlCommand cmd = new SqlCommand("select *from picture where pictureid=@pictureid or name like @name", ConStr))
                        {
                            cmd.Parameters.AddWithValue("pictureid", txtSearch.Text);
                            cmd.Parameters.AddWithValue("genreid", txtSearch.Text);
                            cmd.Parameters.AddWithValue("name", string.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            lblTotal.Text = $"Всего совпадений: {dataGridView1.RowCount}";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            btnSearch.PerformClick();

        }
    }
}
