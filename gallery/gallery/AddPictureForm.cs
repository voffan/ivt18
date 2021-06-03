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
        public int FormId = 0;//1-add new picture 2-update 3-picture view
        public int UpdatingItemId = -1;

        public AddPictureForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormId == 1)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1)
                {
                    try
                    {
                        Convert.ToInt32(textBox3.Text);
                        if (Convert.ToInt32(textBox3.Text) > 1000 && Convert.ToInt32(textBox3.Text) < 2022)
                        {
                            if (Convert.ToSingle(textBox2.Text) > 0 && Convert.ToInt32(textBox3.Text) > 0)
                            {
                                try
                                {
                                    PictureLogic.AddPicture(C, textBox1.Text, Convert.ToSingle(textBox2.Text), Convert.ToInt32(textBox3.Text), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
                                    this.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка в добавлении картины!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неправильно указаны данные...");
                        }
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Введите все данные");
                }
            }
            else
            {
                if (FormId == 2)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex>-1 && comboBox2.SelectedIndex>-1 && comboBox3.SelectedIndex>-1 && comboBox4.SelectedIndex>-1)
                    {
                        try
                        {
                            PictureLogic.UpdatePicture(C, UpdatingItemId, textBox1.Text, Convert.ToSingle(textBox2.Text), Convert.ToInt32(textBox3.Text), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка при редактировании картины");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите все данные");
                    }
                }
                else
                {
                    if (FormId==3)
                    {
                        this.Close();
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
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox1.Items.AddRange(C.Artists.Select(c => c.FullName).ToArray());
                comboBox2.Items.AddRange(C.Genres.Select(c => c.Name).ToArray());
                comboBox3.Items.AddRange(C.Departments.Select(c => c.Name).ToArray());
                comboBox4.Items.AddRange(C.Galleries.Select(c => c.Name).ToArray());
                label1.Text = "Добавление картины";
            }
            else
            {
                if (FormId==2)
                {
                    comboBox1.Visible = true;
                    comboBox2.Visible = true;
                    comboBox3.Visible = true;
                    comboBox4.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox1.Text=C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.Name).FirstOrDefault();
                    textBox2.Text = Convert.ToString(C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.Price).FirstOrDefault());
                    textBox3.Text = Convert.ToString(C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.Year).FirstOrDefault());
                    int artistId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.ArtistId).FirstOrDefault();
                    comboBox1.Items.AddRange(C.Artists.Select(c => c.FullName).ToArray());
                    comboBox1.SelectedItem = C.Artists.Where(c => c.ArtistId == artistId).Select(c => c.FullName).FirstOrDefault();
                    int genreId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.GenreId).FirstOrDefault();
                    comboBox2.Items.AddRange(C.Genres.Select(c => c.Name).ToArray());
                    comboBox2.SelectedItem = C.Genres.Where(c => c.GenreId == genreId).Select(c => c.Name).FirstOrDefault();
                    int depId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.DepartmentId).FirstOrDefault();
                    comboBox3.Items.AddRange(C.Departments.Select(c => c.Name).ToArray());
                    comboBox3.SelectedItem = C.Departments.Where(c => c.DepartmentId == depId).Select(c => c.Name).FirstOrDefault();
                    int galleryId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.GalleryId).FirstOrDefault().Value;
                    comboBox4.Items.AddRange(C.Galleries.Select(c => c.Name).ToArray());
                    comboBox4.SelectedItem = C.Galleries.Where(c => c.GalleryId == galleryId).Select(c => c.Name).FirstOrDefault();
                    label1.Text = "Редактирование картины";
                }
                else
                {
                    if (FormId==3)
                    {
                        comboBox1.Visible = false;
                        comboBox2.Visible = false;
                        comboBox3.Visible = false;
                        comboBox4.Visible = false;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        textBox6.Visible = true;
                        textBox7.Visible = true;
                        textBox1.ReadOnly = true;
                        textBox2.ReadOnly = true;
                        textBox3.ReadOnly = true;
                        textBox4.ReadOnly = true;
                        textBox5.ReadOnly = true;
                        textBox6.ReadOnly = true;
                        textBox7.ReadOnly = true;
                        textBox1.Text = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.Name).FirstOrDefault();
                        textBox2.Text = Convert.ToString(C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.Price).FirstOrDefault());
                        textBox3.Text = Convert.ToString(C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.Year).FirstOrDefault());
                        int artistId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.ArtistId).FirstOrDefault();
                        textBox4.Text = C.Artists.Where(c => c.ArtistId == artistId).Select(c => c.FullName).FirstOrDefault();
                        int genreId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.GenreId).FirstOrDefault();
                        textBox5.Text = C.Genres.Where(c => c.GenreId == genreId).Select(c => c.Name).FirstOrDefault();
                        int placeId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.DepartmentId).FirstOrDefault();
                        textBox6.Text = C.Departments.Where(c => c.DepartmentId == placeId).Select(c => c.Name).FirstOrDefault();
                        int galleryId = C.Pictures.Where(c => c.PictureId == UpdatingItemId).Select(c => c.GalleryId).FirstOrDefault().Value;
                        textBox7.Text = C.Galleries.Where(c => c.GalleryId == galleryId).Select(c => c.Name).FirstOrDefault();
                        label1.Text = "Просмотр картины";
                        button1.Text = "Ok";
                    }
                }
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

        private void button6_Click(object sender, EventArgs e)
        {
            GalleryListForm galleryListForm = new GalleryListForm();
            galleryListForm.C = C;
            galleryListForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
