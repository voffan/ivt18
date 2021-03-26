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

            updatePicturesList(ExpoLogic.updatePicturesList(C));
            updateExpoPicturesList(ExpoLogic.returnExpoPicturesList(id, C));
        }

        void picturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToExpo(picturesBox.SelectedItem.ToString(), id, C);
            updateExpoPicturesList(ExpoLogic.getExpoPicturesList(id, C));
        }
        void expoPicturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToStorage(expoPicturesBox.SelectedItem.ToString(), id, C);
            updateExpoPicturesList(ExpoLogic.getExpoPicturesList(id, C));
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ExpoLogic.apply(id, C);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            updateExpoPicturesList(ExpoLogic.returnExpoPicturesList(id, C));
        }

        private void updatePicturesList(string[] upData)
        {
            picturesBox.Items.Clear();

            picturesBox.Items.AddRange(upData);
        }

        private void updateExpoPicturesList(string[] upData)
        {
            expoPicturesBox.Items.Clear();
            expoPicturesBox.Items.AddRange(upData);
        }
    }
}
