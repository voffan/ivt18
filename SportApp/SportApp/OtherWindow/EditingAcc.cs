using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportApp.OtherWindow
{
    public partial class EditingAcc : UserControl
    {
        public EditingAcc()
        {
            InitializeComponent();
        }
        static EditingAcc _obj;
        public static EditingAcc Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new EditingAcc();
                }
                return _obj;
            }
        }

        public System.Windows.Forms.Panel PnlContainer
        {
            get { return PnelCntrlEdit; }
            set { PnelCntrlEdit = value; }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("Photo"))
            {
                OtherWindow.EditingPanel.Photo un = new OtherWindow.EditingPanel.Photo();
                un.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(un);
            }
            PnlContainer.Controls["Photo"].BringToFront();

        }

        private void EditingAcc_Load(object sender, EventArgs e)
        {
            _obj = this;
        }
    }
}
