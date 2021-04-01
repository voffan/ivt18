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
    
    public partial class AddExpoForm : Form
    {
        public Context C { get; set; }
        public int eId;

        public AddExpoForm()
        {
            InitializeComponent();
        }

        private void AddExpoForm_Load(object sender, EventArgs e)
        {
            picturesBox.Items.AddRange(ExpoLogic.updatePicturesList(C));
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

        private void updateExpoPicturesList(string[] upData)
        {
            expoPicturesBox.Items.Clear();
            expoPicturesBox.Items.AddRange(upData);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try{
                ExpoLogic.addExpo(nameBox.Text, startDatePicker.Value, endDatePicker.Value, placeBox.Text, eId, C);
                this.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void expoPicturesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
