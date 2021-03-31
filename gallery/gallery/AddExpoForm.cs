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
        public AddExpoForm()
        {
            InitializeComponent();
        }

        private void AddExpoForm_Load(object sender, EventArgs e)
        {
            picturesBox.Items.AddRange(ExpoLogic.updatePicturesList(C));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try{
                ExpoLogic.addExpo(nameBox.Text, startDatePicker.Value, endDatePicker.Value, placeBox.Text, C);
            }catch(Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
