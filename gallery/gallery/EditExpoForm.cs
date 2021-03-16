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
    public partial class EditExpoForm : Form
    {
        public Context C { get; set; }
        public int id;
        public EditExpoForm()
        {
            InitializeComponent();
            
        }

        void picturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToExpo(picturesBox.SelectedItem.ToString(), id, C);
            ExpoLogic.updatePicturesList(picturesBox, expoPicturesBox, id, C);
        }
        void expoPicturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.updatePicturesList(picturesBox, expoPicturesBox, id, C);
        }

        private void EditExpoForm_Load(object sender, EventArgs e)
        {
            ExpoLogic.updatePicturesList(picturesBox, expoPicturesBox, id, C);
            var expo = ExpoLogic.oldData(id, C);
            nameBox.Text = expo.Name;
            placeBox.Text = expo.Place;
            startDatePicker.Value = expo.StartDate;
            endDatePicker.Value = expo.EndDate;

        }
    }
}
