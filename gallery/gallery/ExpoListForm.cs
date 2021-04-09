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
        public int id = -1;
        public int eId = -1;

        public ExpoListForm()
        {
            InitializeComponent();
        }

        private void ExpoListForm_Load(object sender, EventArgs e)
        {
            listExpoBox.Items.Clear();
            listExpoBox.Items.AddRange(C.Expos.Select(c => c.Name).ToArray());
        }

        private void listExpoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = listExpoBox.SelectedItem.ToString();
            id = ExpoLogic.getId(s, C);
        }

        private void addExpoButton_Click(object sender, EventArgs e)
        {
            AddExpoForm addExpoForm = new AddExpoForm();
            addExpoForm.C = C;
            addExpoForm.eId = eId;
            addExpoForm.Show();
        }

        private void editExpoButton_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                EditExpoForm editExpoForm = new EditExpoForm();
                editExpoForm.C = C;
                editExpoForm.id = id;
                editExpoForm.Show();
            }
        }

        private void deleteExpoButton_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                ExpoLogic.deleteExpo(id, C);

                listExpoBox.Items.Clear();
                listExpoBox.Items.AddRange(C.Expos.Select(c => c.Name).ToArray());
            }
        }
    }
}
