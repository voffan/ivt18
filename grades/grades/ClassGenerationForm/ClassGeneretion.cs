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
    
    public partial class ClassGeneretion : Form
    {

        private ClassGeneretionLogic _logic;
        private Context _context;
        List<string> words;
        string word;
        
        public ClassGeneretion()
        {
            InitializeComponent();
            _context = new Context();
            for (int i = 1; i <= Properties.Settings.Default.HighestClass; i++)
            {
                ClassList.Items.Add(i);
            }

            ClassList.Text = "1";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // Ошибка 
            int n = Convert.ToInt16(CountBox.Text);

            _logic = new ClassGeneretionLogic ();

            words = ClassGeneretionLogic.GetLetters(_context,Convert.ToInt32(ClassList.Text));
            if(words.Count > 0)
            word = words.Last();

            _logic.AddClass(_context, n,word, Convert.ToInt32(ClassList.Text));


        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CountBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
