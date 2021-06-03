using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportApp
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Context connect = new Context();
            //load img
            string photoName = (from customer in connect.Persons
                           where customer.Login == Program.logining
                           select customer.Photo)
               .FirstOrDefault();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation=("https://manchkin-test.000webhostapp.com/user_img/"+photoName);
            //fio
            string name = (from customer in connect.Persons
                           where customer.Login == Program.logining
                           select customer.Name)
               .FirstOrDefault();
            string[] words = name.Split(' ');
            label7.Text = words[0];
            label8.Text = words[1];
            label9.Text = words[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (!MainMainForm.Instance.PnlContainer.Controls.ContainsKey("UCNext"))
            //{
            //    //MainMainForm.Instance.Con
            //    UCNext un = new UCNext();
            //    un.Dock = DockStyle.Fill;
            //    Form1.Instance.PnlContainer.Controls.Add(un);
            //}
            //MainMainForm.Instance.PnlContainer.Controls["UCNext"].BringToFront();
        }
    }
}
