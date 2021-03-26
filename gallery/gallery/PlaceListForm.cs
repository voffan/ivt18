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
    public partial class PlaceListForm : Form
    {
        public Context C { get; set; }
        public PlaceListForm()
        {
            InitializeComponent();
        }

        private void PlaceListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Places.ToList();
        }
    }
}
