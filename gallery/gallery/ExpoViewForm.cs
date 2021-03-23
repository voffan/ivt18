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
    public partial class ExpoViewForm : Form
    {
        public Context C { get; set; }
        public int id;
        public ExpoViewForm()
        {
            InitializeComponent();
        }

        private void ExpoViewForm_Load(object sender, EventArgs e)
        {
            expoPicturesBox.Items.Clear();
            var expo = ExpoLogic.oldData(id, C);
            expoInfoLabel1.Text += "\n" + expo.Name;
            expoInfoLabel2.Text += "\n" + expo.Place;
            expoInfoLabel3.Text += "\n" + expo.StartDate + "  -  " + expo.EndDate;

            expoPicturesBox.Items.AddRange(ExpoLogic.getExpoPicturesList(id, C));
        }
    }
}
