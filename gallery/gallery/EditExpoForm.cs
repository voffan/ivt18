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
        public int eId;

        public EditExpoForm()
        {
            InitializeComponent();
            
        }

        void picturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToExpo(picturesBox.SelectedItem.ToString(), C);
            updateExpoPicturesList(ExpoLogic.getExpoPicturesList(C));
        }
        void expoPicturesBox_DoubleClick(object sender, EventArgs e)
        {
            ExpoLogic.sendToStorage(expoPicturesBox.SelectedItem.ToString(), C);
            updateExpoPicturesList(ExpoLogic.getExpoPicturesList(C));
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ExpoLogic.apply(nameBox.Text, placeBox.Text, startDatePicker.Value, endDatePicker.Value, id, eId, C);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var info = ExpoLogic.oldData(id, C);

            nameBox.Text = info[0];
            placeBox.Text = info[1];
            startDatePicker.Value = Convert.ToDateTime(info[2]);
            endDatePicker.Value = Convert.ToDateTime(info[3]);

            updatePicturesList(ExpoLogic.updatePicturesList(C));
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
