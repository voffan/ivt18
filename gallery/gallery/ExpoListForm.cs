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
    public partial class ExpoListForm : Form
    {
        public Context C { get; set; }
        public ExpoListForm()
        {
            InitializeComponent();
        }

        private void ExpoListForm_Load(object sender, EventArgs e)
        {
            listExpoBox.Items.AddRange(C.Expos.Select(c => c.Name).ToArray());
        }

        private void listExpoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listExpoBox_DoubleClick(object sender, EventArgs e)
        {
            var s = listExpoBox.SelectedItem.ToString(); //
            var id = C.Expos.Where(C => C.Name == s)  //
                .Select(C => C.ExpoId).FirstOrDefault(); //

            ExpoViewForm expoViewForm = new ExpoViewForm(id);
            expoViewForm.C = C;
            expoViewForm.Show();
            
        }

        private void addExpoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void editExpoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteExpoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
