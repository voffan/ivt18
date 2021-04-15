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
        public int FormId = 0;//1-add new pic 2-update

        public AddPictureForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormId == 1)
            {
                try
                {
                    PictureLogic.AddPicture(C, textBox1.Text, Convert.ToSingle(textBox2.Text), Convert.ToInt32(textBox3.Text), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
                    MessageBox.Show("Добавление...");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка в добавлении картины!");
                }
            }
            else
            {
                if (FormId == 2)
                {
                    try
                    {
                        PictureLogic.UpdatePicture(C, textBox1.Text, Convert.ToSingle(textBox2.Text), Convert.ToInt32(textBox3.Text), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
                        MessageBox.Show("Редактируется...");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при редактировании картины");
                    }
                }
            }
            
        }

        private void AddPictureForm_Load(object sender, EventArgs e)
        {
            if (FormId == 1)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Items.AddRange(C.Artists.Select(c => c.FullName).ToArray());
                comboBox2.Items.AddRange(C.Genres.Select(c => c.Name).ToArray());
                comboBox3.Items.AddRange(C.Departments.Select(c => c.Name).ToArray());
                comboBox4.Items.AddRange(C.Galleries.Select(c => c.Name).ToArray());
            }
            else
            {
                /*if (FormId==2)
                {
                    textBox1.Text=C.Pictures.Select()
                }*/
            }
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
