using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    public partial class UserGeneration : Form
    {
        public UserGeneration()
        {
            InitializeComponent();
        }

        private void UserGeneration_Load(object sender, EventArgs e)
        {

     
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            int N;
            N = Convert.ToInt32(countUserGeneration.Text);

          
        }
  public virtual List<Student> Students { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }
    }
}
