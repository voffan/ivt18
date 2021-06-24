using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    public partial class ArtistListForm : Form
    {
        public Context C { get; set; }
        public ArtistListForm()
        {
            InitializeComponent();
        }

        private void ArtistListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C.Artists.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ConStr = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
                {
                    if (ConStr.State == ConnectionState.Closed)
                        ConStr.Open();
                    using (DataTable dt = new DataTable("Artists"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from artist where artistid=@artistid or fullname like @fullname", ConStr))
                        {
                            cmd.Parameters.AddWithValue("artistid", txtSearch.Text);
                            cmd.Parameters.AddWithValue("fullname", string.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            lblTotal.Text = $"Всего совпадений: {dataGridView1.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick(); 
        }
    }
}
