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
    public partial class ChooseAddUserMethodForm : Form
    {
        private Context _context;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public ChooseAddUserMethodForm(Context context)
        {
            InitializeComponent();

            _context = context;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            SetupColors();
        }

        private void SetupColors()
        {
            _contentBackgroundColor = "#212121";
            _contentSelectedColor = "#535353";

            this.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);

            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.FlatAppearance.BorderSize = 1;
                b.BackColor = System.Drawing.ColorTranslator.FromHtml(_contentBackgroundColor);
                b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }

            foreach (Label b in this.Controls.OfType<Label>())
            {
                b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }
        }

        private void ChooseAddUserMethodForm_Load(object sender, EventArgs e)
        {

        }

        private void addSingleButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addUserForm = new AddUser(_context);
            addUserForm.ShowDialog();
        }

        private void addMultipleButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddMultipleUsers addMultipleUsersForm = new AddMultipleUsers(_context);
            addMultipleUsersForm.ShowDialog();
        }
    }
}
