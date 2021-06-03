﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportApp.Classes;
namespace SportApp
{
    
    
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelresultats.Visible = true;
            this.panelusers.Visible = false;
            this.panelusers2.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelresultats.Visible = false;
            this.panelusers.Visible = false;
            this.panelusers2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelresultats.Visible = false;
            this.panelusers.Visible = false;
            this.panelusers2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelresultats.Visible = false;
            this.panelusers.Visible = false;
            this.panelusers2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            if (!Instance.PnlContainer.Controls.ContainsKey("Profile"))
            {
                Profile ProfileGUI = new Profile();
                ProfileGUI.Dock = DockStyle.Fill;
                panelusers.Controls.Add(ProfileGUI);

               
            }
            panelusers.Controls["Profile"].BringToFront();


            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }
        static MainForm _obj;
        public static MainForm Instance 
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelusers; }
            set { panelusers = value; }
        }
    }
}
