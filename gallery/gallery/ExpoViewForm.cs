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
            var expo = ExpoLogic.ViewExpo(id, C);
            expoInfoLabel1.Text += "\n" + expo.Name;
            expoInfoLabel2.Text += "\n" + expo.Place;
            expoInfoLabel3.Text += "\n" + expo.StartDate + "  -  " + expo.EndDate;

            string[] str = new string[expo.ExpoPictures.Count()];  
            for (int i = 0; i < expo.ExpoPictures.Count(); i++)
            {
                str[i] = expo.ExpoPictures[i].Picture.Name + ", автор - ";
            }
            expoPicturesBox.Items.AddRange(str);
        }
    }
}
