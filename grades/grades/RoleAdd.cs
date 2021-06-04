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
    public partial class RoleAdd : Form
    {
        private Context _context;
        private Position _curentPosition;
        private RoleAddLogic _logic;
        private List<TextBox> textBoxes;
        private bool _editingState;

        private string _contentBackgroundColor;
        private string _contentSelectedColor;

        public RoleAdd(Context context)
        {
            InitializeComponent();
            _context = context;
            _logic = new RoleAddLogic();
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

        public void SetEditState(Position position)
        {
            _curentPosition = position;
            _editingState = true;

            nameBox.Text = _curentPosition.Name;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (!_editingState)
            {
                _logic.createPosition();
            }
            else
            {
                _logic.setPosition(_curentPosition);
            }

            _logic.setPositionName(_context, nameBox.Text);

            if (!_editingState)
            {
                _context.Positions.Add(_logic.GetPosition());
            }
            _context.SaveChanges();

            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
