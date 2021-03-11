using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    class Router : ApplicationContext
    {
        protected bool exitAppOnClose;
        public Form CurrentForm
        {
            get { return MainForm; }
            set
            {
                if (MainForm != null)
                {
                    exitAppOnClose = false;
                    MainForm.Close();
                    exitAppOnClose = true;
                }
                MainForm = value;
                MainForm.Show();
            }
        }
        private Router()
        {
            exitAppOnClose = true;
        }
        private static Router instance;
        public static Router Shared
        {
            get
            {
                if (instance == null)
                {
                    instance = new Router();
                }
                return instance;
            }
        }

        public void Show(Form form)
        {
            CurrentForm = form;
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (exitAppOnClose)
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
