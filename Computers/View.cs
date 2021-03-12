using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    public class View : Form
    {
        public Form Self => this;

        public View()
        {
            SuspendLayout();
            SetupView();
            SetupLayout(this, null);
            ResumeLayout(true);
        }

        public virtual void SetupView()
        {
            this.Name = "View";
            this.Text = "View";
            this.Size = new Size(600, 400);
            
            this.Load += new EventHandler(this.ViewDidLoad);
            this.Shown += new EventHandler(this.ViewDidShow);
            this.FormClosing += new FormClosingEventHandler(this.ViewWillClose);
            this.FormClosed += new FormClosedEventHandler(this.ViewDidClose);
            this.Activated += new EventHandler(this.ViewDidActivate);
            this.Deactivate += new EventHandler(this.ViewDidDeactivate);
            
            this.SizeChanged += SetupLayout;
            this.StartPosition = FormStartPosition.CenterScreen;
            GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
        }

        public virtual void SetupLayout(object sender, EventArgs e) { }

        public virtual void ViewDidLoad(object sender, EventArgs e) {}

        public virtual void ViewDidShow(object sender, EventArgs e) {}

        public virtual void ViewWillClose(object sender, FormClosingEventArgs e) {}

        public virtual void ViewDidClose(object sender, FormClosedEventArgs e) {}

        public virtual void ViewDidActivate(object sender, EventArgs e) { }

        public virtual void ViewDidDeactivate(object sender, EventArgs e) { }

        public static string GeometryToString(Form mainForm)
        {
            return mainForm.Location.X.ToString() + "|" +
                mainForm.Location.Y.ToString() + "|" +
                mainForm.Size.Width.ToString() + "|" +
                mainForm.Size.Height.ToString() + "|" +
                mainForm.WindowState.ToString();
        }

        public static void GeometryFromString(string thisWindowGeometry, Form formIn)
        {
            if (string.IsNullOrEmpty(thisWindowGeometry) == true)
            {
                return;
            }
            string[] numbers = thisWindowGeometry.Split('|');
            string windowString = numbers[4];
            if (windowString == "Normal")
            {
                Point windowPoint = new Point(int.Parse(numbers[0]),
                    int.Parse(numbers[1]));
                Size windowSize = new Size(int.Parse(numbers[2]),
                    int.Parse(numbers[3]));

                bool locOkay = GeometryIsBizarreLocation(windowPoint, windowSize);
                bool sizeOkay = GeometryIsBizarreSize(windowSize);

                if (locOkay == true && sizeOkay == true)
                {
                    formIn.Location = windowPoint;
                    formIn.Size = windowSize;
                    formIn.StartPosition = FormStartPosition.Manual;
                    formIn.WindowState = FormWindowState.Normal;
                }
                else if (sizeOkay == true)
                {
                    formIn.Size = windowSize;
                }
            }
            else if (windowString == "Maximized")
            {
                formIn.Location = new Point(100, 100);
                formIn.StartPosition = FormStartPosition.Manual;
                formIn.WindowState = FormWindowState.Maximized;
            }
        }

        void TextWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowGeometry = GeometryToString(this);
            Properties.Settings.Default.Save();
        }

        private static bool GeometryIsBizarreLocation(Point loc, Size size)
        {
            bool locOkay;
            if (loc.X < 0 || loc.Y < 0)
            {
                locOkay = false;
            }
            else if (loc.X + size.Width > Screen.PrimaryScreen.WorkingArea.Width)
            {
                locOkay = false;
            }
            else if (loc.Y + size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                locOkay = false;
            }
            else
            {
                locOkay = true;
            }
            return locOkay;
        }

        private static bool GeometryIsBizarreSize(Size size)
        {
            return (size.Height <= Screen.PrimaryScreen.WorkingArea.Height &&
                size.Width <= Screen.PrimaryScreen.WorkingArea.Width);
        }
    }
}