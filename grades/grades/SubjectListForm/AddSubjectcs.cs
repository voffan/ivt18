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
    public partial class AddSubjectcs : Form
    {
        private Context _context;

        private Subject _curentSubject;

        private AddSubjectLogic _logic;

        private List<TextBox> _textBoxes;

        private bool _editingState;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public AddSubjectcs(Context context)
        {
            InitializeComponent();

            _context = context;
            _logic = new AddSubjectLogic();
            _editingState = false;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ControlBox = false;

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

            foreach (CheckBox c in this.Controls.OfType<CheckBox>())
            {
                c.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3b3b3");
            }
        }

        public void SetEditState(Subject subject)
        {
            _curentSubject = subject;
            _editingState = true;

            nameBox.Text = _curentSubject.Name;
        }

        private void AddSubjectcs_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (!_editingState)
            {
                _logic.createSubject();
            }
            else
            {
                _logic.setSubject(_curentSubject);
            }

            _logic.setSubjectName(_context, nameBox.Text);

            if (!_editingState)
            {
                _context.Subjects.Add(_logic.GetSubject());
            }
            _context.SaveChanges();

            this.Close();
        }
    }
}
