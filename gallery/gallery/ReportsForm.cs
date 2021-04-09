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
    public partial class ReportsForm : Form
    {
        public Context C { get; set; }

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void reportsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // picture 
            //PictureViewForm pictureViewForm = new PictureViewForm();
            //pictureViewForm.id = id;
            //pictureViewForm.C = C;
            //pictureViewForm.Show();
        }

        private void reportsForm_Load(object sender, EventArgs e)
        {

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            //ReportLogic.DownloadReport(id, C);
        }
    }
}
