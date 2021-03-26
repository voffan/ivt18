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
    public partial class AddPictureForm : Form
    {
        public Context C { get; set; }

        public AddPictureForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureLogic.AddPicture(C, textBox1.Text, Convert.ToSingle(textBox2.Text), Convert.ToInt32(textBox3.Text), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
                PictureListForm pictureListForm = new PictureListForm();
                pictureListForm.C = C;
                pictureListForm.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            
        }

        private void AddPictureForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(C.Artists.Select(c => c.FullName).ToArray());
            comboBox2.Items.AddRange(C.Genres.Select(c => c.Name).ToArray());
            comboBox3.Items.AddRange(C.Places.Select(c => c.Name).ToArray());
            comboBox4.Items.AddRange(C.Galleries.Select(c => c.Name).ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArtistListForm artistListForm = new ArtistListForm();
            artistListForm.C = C;
            artistListForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenreListForm genreListForm = new GenreListForm();
            genreListForm.C = C;
            genreListForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlaceListForm placeListForm = new PlaceListForm();
            placeListForm.C = C;
            placeListForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GalleryListForm galleryListForm = new GalleryListForm();
            galleryListForm.C = C;
            galleryListForm.Show();
        }
    }
}
