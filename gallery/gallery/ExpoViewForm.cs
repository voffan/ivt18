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
    public partial class ExpoViewForm : Form
    {
        public Context C{ get; set; }
        int id;
        public ExpoViewForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ExpoViewForm_Load(object sender, EventArgs e)
        {
            ExpoLogic.ViewExpo(expoInfoLabel, id, C);     
        }
    }
}
