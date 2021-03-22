using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.SingleFieldForm
{
    public interface ISingleFieldFormView
    {
        ISingleFieldFormInteractor Interactor { get; set; }
        void Close();
        void Configure(Utils.SingleFieldFormType FormType);
    }

    class SingleFieldFormView : View, ISingleFieldFormView
    {
        public ISingleFieldFormInteractor Interactor { get; set; }

        private readonly Panel panel = new Panel();
        private readonly Label label = new Label();
        private readonly TextBox textBox = new TextBox();
        private readonly Button addButton = new Button();
        private readonly Button cancelButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            Size = new Size(320, 150);
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            
            panel.BorderStyle = BorderStyle.FixedSingle;
            addButton.Text = "Добавить";
            cancelButton.Text = "Отмена";

            textBox.TextChanged += textBoxChanged;
            addButton.Click += AddButtonClicked;
            cancelButton.Click += CancelButtonClicked;

            panel.Controls.Add(label);
            panel.Controls.Add(textBox);
            panel.Controls.Add(addButton);
            panel.Controls.Add(cancelButton);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(300, 105);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            label.Size = new Size(280, 20);
            label.Location = new Point(10, 10);

            textBox.Size = new Size(280, 20);
            textBox.Location = new Point(10, 30);

            addButton.Size = new Size(70, 25);
            addButton.Location = new Point(140, 70);

            cancelButton.Size = new Size(70, 25);
            cancelButton.Location = new Point(220, 70);
        }

        private void textBoxChanged(object sender, EventArgs e)
        {
            Interactor.SetText(textBox.Text);
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            Interactor.Submit();
        }

        private void CancelButtonClicked(object sender, EventArgs e)
        {
            Interactor.Cancel();
        }

        public void Configure(Utils.SingleFieldFormType FormType)
        {
            switch (FormType)
            {
                case Utils.SingleFieldFormType.Status:
                    Text = "Новый статус";
                    label.Text = "Название статуса";
                    break;
                case Utils.SingleFieldFormType.PeripheralType:
                    Text = "Новый тип периферии";
                    label.Text = "Название типа периферии";
                    break;
                case Utils.SingleFieldFormType.Manufacturer:
                    Text = "Новый производитель";
                    label.Text = "Название производителя";
                    break;
                default:
                    break;
            }
        }
    }
}
