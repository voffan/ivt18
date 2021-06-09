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
            eId = C.Employees.Select(c => c.EmployeeId).FirstOrDefault();

            ToolTip t = new ToolTip();
            t.SetToolTip(addExpoButton, "Добавить выставку");

            ToolTip t1 = new ToolTip();
            t1.SetToolTip(editExpoButton, "Редактировать выставку");

            ToolTip t2 = new ToolTip();
            t2.SetToolTip(deleteExpoButton, "Удалить выставку");
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
                editExpoForm.eId = eId;
                editExpoForm.Show();
            }

        }

        private void deleteExpoButton_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                ExpoLogic.deleteExpo(id, C);
            }

            ExpoListForm_Load(sender, e);
        }

        private void expoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (expoDataGrid.Rows.Count > 0)
            {
                id = Convert.ToInt32(expoDataGrid.CurrentRow.Cells["ID"].Value);
            }
            else
            {
                id = -1;
            }
        }

        private void expoDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editExpoButton_Click(sender, e);
        }

        private void expoDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
