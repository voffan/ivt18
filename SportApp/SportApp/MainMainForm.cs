using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportApp
{
    public partial class MainMainForm : Form
    {
        public MainMainForm()
        {
            InitializeComponent();
        }
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
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
            Profile uc = new Profile();
            uc.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(uc);
        }
    }
}
