﻿using System;
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
    public partial class AddEmployeeForm : Form
    {
        readonly EmployeeLogic employeeLogic;
       
        public Context C { get; set; }
        Context context;
        public int FormId = 0;
        public AddEmployeeForm(Context context)
        {
            this.context = context;
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {


            string[] emparr = new String[6];

            emparr[0] = textBox1.Text;
            emparr[1] = textBox2.Text;
            emparr[2] = textBox3.Text;
            emparr[3] = textBox4.Text;
            emparr[4] = textBox7.Text;
            emparr[5] = textBox6.Text;
            

            EmployeeLogic.addEmoployee(context, emparr);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
           

            this.Close();
          




        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
          
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
