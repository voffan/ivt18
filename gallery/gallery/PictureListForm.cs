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

        public PictureListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
            addPictureForm.C = C;
            addPictureForm.Show();
        }

    }
}
