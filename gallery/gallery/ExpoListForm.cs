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
        public int id;
        public int eId = -1;

        public ExpoListForm()
        {
            InitializeComponent();
        }

        private void ExpoListForm_Load(object sender, EventArgs e)
        {
            var query = from c in C.Expos
                        select new { ID = c.ExpoId, Название = c.Name, Адрес = c.Address, Начало = c.StartDate, Конец = c.EndDate }
                        ;
            expoDataGrid.DataSource = query.ToList();
            if (expoDataGrid.Rows.Count > 0)
            {
                expoDataGrid.Rows[0].Selected = true;
                id = Convert.ToInt32(expoDataGrid.CurrentRow.Cells["ID"].Value);
            }
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
                ExpoListForm_Load(sender, e);
            }
        }

        private void expoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExpoListForm_Load(sender, e);
            if (expoDataGrid.Rows.Count > 0)
            {
                id = Convert.ToInt32(expoDataGrid.CurrentRow.Cells["ID"].Value);
            }
        }

        private void expoDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editExpoButton_Click(sender, e);
        }
    }
}
