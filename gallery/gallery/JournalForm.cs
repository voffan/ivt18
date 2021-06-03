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
    public partial class JournalForm : Form
    {
        public Context C { get; set; }
        public JournalForm()
        {
            InitializeComponent1();
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            var query = from c in C.Journals                       
                        select new { ID = c.EmployeeId, ФИО = c.Employee.FullName, Должность = c.Employee.Position.Name, Дата = c.Date, Картина = c.Picture.Name, Автор = c.Picture.Artist.FullName, c.DepartmentFromId, c.DepartmentToId }
                        ;
            journalDataGrid.DataSource = query.ToList();
        }

        private void InitializeComponent1()
        {
            this.SuspendLayout();
            // 
            // JournalForm
            // 
            this.ClientSize = new System.Drawing.Size(917, 469);
            this.Name = "JournalForm";
            this.ResumeLayout(false);

        }
    }
}
