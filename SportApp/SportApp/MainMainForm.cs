using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportApp;

namespace SportApp
{
    public partial class MainMainForm : Form
    {
        public MainMainForm()
        {
            InitializeComponent();
        }
        static MainMainForm _obj;
        public static MainMainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainMainForm();
                }
                return _obj;
            }
        }
        
        public System.Windows.Forms.Panel PnlContainer
        {
            get { return PnelContrl; }
            set { PnelContrl = value; }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("Profile"))
            {
                Profile un = new Profile();
                un.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(un);
            }
            PnlContainer.Controls["Profile"].BringToFront();
        }

        private void MainMainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
            Profile uc = new Profile();
            uc.Dock = DockStyle.Fill;
            PnelContrl.Controls.Add(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("Doings"))
            {

                Doings uEvents = new Doings();
                uEvents.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(uEvents);
            }
            PnlContainer.Controls["Doings"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("Doings"))
            {

                Doings uEvents = new Doings();
                uEvents.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(uEvents);
            }
            PnlContainer.Controls["Doings"].BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("Profile"))
            {
                Profile un = new Profile();
                un.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(un);
            }
            PnlContainer.Controls["Profile"].BringToFront();
        }

        private void PnelContrl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (!PnlContainer.Controls.ContainsKey("News"))
            //{

            //    News uEvents = new News();
            //    uEvents.Dock = DockStyle.Fill;
            //    PnlContainer.Controls.Add(uEvents);
            //}
            //PnlContainer.Controls["News"].BringToFront();
        }
    }
}
