using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE1
{
    public partial class BugForm : Form
    {
        public BugForm()
        {
            InitializeComponent();
        }

        private void BugForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("id", typeof(int));
            table.Columns.Add("BugType", typeof(BugType));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("LastFixedDate", typeof(DateTime));
            table.Columns.Add("AddedDate", typeof(DateTime));
            table.Columns.Add("Status", typeof(StatusBug));
            table.Columns.Add("Fixes", typeof(Fix));
            table.Columns.Add("Comments", typeof(Comment));
            table.Columns.Add("EmplyeeId", typeof(int));
            table.Columns.Add("Employee", typeof(Employee));


            table.Rows.Add(1);
            table.Rows.Add(2);
            table.Rows.Add(3);
            table.Rows.Add(4);
            table.Rows.Add(5);
            table.Rows.Add(6);
            table.Rows.Add(7);
            table.Rows.Add(8);

            dataGridView1.DataSource = table;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


    }
}