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
    public partial class EditEmployeeForm : Form
    {
        public Context C { get; set; }
        public int deleteId;
        public int eId;
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] emparr = new String[6];

            emparr[0] = textBox1.Text;
            emparr[1] = textBox2.Text;
            emparr[2] = textBox3.Text;
            emparr[3] = textBox4.Text;
            emparr[4] = textBox6.Text;
            emparr[5] = textBox5.Text;


            EmployeeLogic.editEmployee(C, emparr);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";


            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
