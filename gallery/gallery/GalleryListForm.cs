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
    public partial class GalleryListForm : Form
    {
        public Context C { get; set; }
        public GalleryListForm()
        {
            InitializeComponent();
        }

        private void GalleryListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Galleries.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
