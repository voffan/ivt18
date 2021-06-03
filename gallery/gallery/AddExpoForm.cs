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
            eId = C.Employees.Select(c => c.EmployeeId).FirstOrDefault();
        }

        void picturesBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpoLogic.sendToExpo(picturesBox.SelectedItem.ToString(), C);
                updateExpoPicturesList(ExpoLogic.getExpoPicturesList(C));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        void expoPicturesBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpoLogic.sendToStorage(expoPicturesBox.SelectedItem.ToString(), C);
                updateExpoPicturesList(ExpoLogic.getExpoPicturesList(C));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void updateExpoPicturesList(string[] upData)
        {
            expoPicturesBox.Items.Clear();
            expoPicturesBox.Items.AddRange(upData);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (startDatePicker.Value > endDatePicker.Value)
            {
                MessageBox.Show("Укажите правильные даты!");
            }
            else if (nameBox.Text != "" && placeBox.Text != "")
            {
                //try
                //{
                var startDate = new DateTime(startDatePicker.Value.Year, startDatePicker.Value.Month, startDatePicker.Value.Day);
                var endDate = endDatePicker.Value.AddMilliseconds(-endDatePicker.Value.Millisecond);
                ExpoLogic.addExpo(nameBox.Text, startDate, endDate, placeBox.Text, eId, C);
                this.Close();
                //}
                //catch (Exception ex)
                //{
               //     MessageBox.Show(ex.Message.ToString());
               // }
            }           
            else
            {
                MessageBox.Show("Заполните поля!");
            }
            
        }

        private void expoPicturesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
