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
        private void EditExpoForm_Load(object sender, EventArgs e)
        {
            var expo = ExpoLogic.oldData(id, C);

            nameBox.Text = expo.Name;
            placeBox.Text = expo.Place;
            startDatePicker.Value = expo.StartDate;
            endDatePicker.Value = expo.EndDate;

            updatePicturesList();
            updateExpoPicturesList();
        }

        void picturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToExpo(picturesBox.SelectedItem.ToString(), id, C);
            updatePicturesList();
            updateExpoPicturesList();

        }
        void expoPicturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToStorage(expoPicturesBox.SelectedItem.ToString(), id, C);
            updateExpoPicturesList();
        }

        void updatePicturesList()
        {
            picturesBox.Items.Clear();

            var upData = ExpoLogic.updatePicturesList(C);

            picturesBox.Items.AddRange(upData);
        }

        void updateExpoPicturesList()
        {
            expoPicturesBox.Items.Clear();

            var upData = ExpoLogic.updateExpoPicturesList(id, C);

            expoPicturesBox.Items.AddRange(upData);
        }
    }
}
