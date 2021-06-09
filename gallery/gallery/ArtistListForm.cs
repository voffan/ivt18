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
    public partial class ArtistListForm : Form
    {
        public Context C { get; set; }
        public ArtistListForm()
        {
            InitializeComponent();
        }

        private void ArtistListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Artists.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
