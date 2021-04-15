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
    public partial class ReportForm : Form
    {
        public Context C { get; set; }
        public int id = 0;
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportDataGrid.DataSource = C.Journals.OrderBy(c => c.EmployeeId).ToList();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            // ReportLogic.downloadReport(id, C);
        }

        private void reportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = reportDataGrid.SelectedRows[0].Index;
        }
    }
}
