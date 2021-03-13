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
    public partial class AddPictureForm : Form
    {
        public Context C { get; set; }

        public AddPictureForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Добавить картину в бд
            try
            {
                //PictureLogic.AddPicture(C, textBox1.Text);
                this.Close();
            }
            catch(Exception ex)
            {
                //ShowMessage("...");
            }
            
        }
    }
}
