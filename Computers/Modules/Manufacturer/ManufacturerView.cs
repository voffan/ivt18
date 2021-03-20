using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Manufacturer
{
    public interface IManufacturerView
    {
        IManufacturerInteractor Interactor { get; set; }
        void Close();
    }

    class ManufacturerView : View, IManufacturerView
    {
        public IManufacturerInteractor Interactor { get; set; }

        public ManufacturerView(IManufacturerInteractor Interactor) : base()
        {
            this.Interactor = Interactor;
        }
        private readonly Panel panel = new Panel();
        private readonly Label manufacturerLabel = new Label();
        private readonly TextBox manufacturerTextBox = new TextBox();
        private readonly Button addButton = new Button();
        private readonly Button cancelButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            Size = new Size(320, 150);
            Text = "Добавление производителя";
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            
            panel.BorderStyle = BorderStyle.FixedSingle;
            manufacturerLabel.Text = "Имя";
            addButton.Text = "Добавить";
            cancelButton.Text = "Отмена";

            manufacturerTextBox.TextChanged += ManufacturerTextBoxChanged;
            addButton.Click += AddButtonClicked;
            cancelButton.Click += CancelButtonClicked;

            panel.Controls.Add(manufacturerLabel);
            panel.Controls.Add(manufacturerTextBox);
            panel.Controls.Add(addButton);
            panel.Controls.Add(cancelButton);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(300, 105);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            manufacturerLabel.Size = new Size(280, 20);
            manufacturerLabel.Location = new Point(10, 10);

            manufacturerTextBox.Size = new Size(280, 20);
            manufacturerTextBox.Location = new Point(10, 30);

            addButton.Size = new Size(70, 25);
            addButton.Location = new Point(140, 70);

            cancelButton.Size = new Size(70, 25);
            cancelButton.Location = new Point(220, 70);
        }

        private void ManufacturerTextBoxChanged(object sender, EventArgs e)
        {
            Interactor.SetName(manufacturerTextBox.Text);
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddManufacturer();
        }

        private void CancelButtonClicked(object sender, EventArgs e)
        {
            Interactor.Cancel();
        }
    }
}
