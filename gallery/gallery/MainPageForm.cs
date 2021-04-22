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
    public partial class MainPageForm : Form
    {
        private Context c = new Context();

        public MainPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureListForm pictureListForm = new PictureListForm();
            pictureListForm.C = c;
            pictureListForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.C = c;
            employeeListForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComissionList comissionList = new ComissionList();
            comissionList.C = c;
            comissionList.Show();
        }
    }
}
