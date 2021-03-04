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
        public PictureListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
        }

        private void PictureListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "galleryDBDataSet1.Picture". При необходимости она может быть перемещена или удалена.
            //this.pictureTableAdapter.Fill(this.galleryDBDataSet1.Picture);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExpoListForm expoListForm = new ExpoListForm();
            expoListForm.Show();
        }
    }
}
