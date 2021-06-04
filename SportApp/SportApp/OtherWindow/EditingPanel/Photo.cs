using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportApp.OtherWindow.EditingPanel
{
    public partial class Photo : UserControl
    {
        public Photo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Photo_Load(object sender, EventArgs e)
        {
            Context connect = new Context();
            //load img
            string photoName = (from customer in connect.Persons
                                where customer.Login == Program.logining
                                select customer.Photo)
               .FirstOrDefault();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = ("https://manchkin-test.000webhostapp.com/user_img/" + photoName);
        }
    }
}
