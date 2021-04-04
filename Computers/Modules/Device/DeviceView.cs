using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Device
{
    public interface IDeviceView
    {
        IDeviceInteractor Interactor { get; set; }
        void Configure(DeviceViewModel viewModel);
        void Update(DeviceViewModel viewModel);
        void Close();
    }

    class DeviceView : View, IDeviceView
    {
        public IDeviceInteractor Interactor { get; set; }

        private readonly Panel panel = new Panel();

        private readonly Label nameLabel = new Label();
        private readonly Label manufacturerLabel = new Label();
        private readonly Label priceLabel = new Label();
        private readonly Label statusLabel = new Label();
        private readonly Label optionalLabel = new Label();

        private readonly TextBox nameTextBox = new TextBox();
        private readonly ListBox manufacturerListBox = new ListBox();
        private readonly Button addManufacturerButton = new Button();
        private readonly NumericUpDown priceNumericBox = new NumericUpDown();
        private readonly ListBox statusListBox = new ListBox();
        private readonly Button addStatusButton = new Button();
        private readonly NumericUpDown optionalNumericBox = new NumericUpDown();
        private readonly TextBox optionalTextBox = new TextBox();

        private readonly Button submitButton = new Button();
        private readonly Button cancelButton = new Button();

        private readonly Size panelSize = new Size(600, 300);
        private readonly Size labelSize = new Size(280, 20);
        private readonly Size listBoxSize = new Size(280, 60);
        private readonly Size rowLabelSize = new Size(200, 20);
        private readonly Size rowButtonSize = new Size(70, 20);

        public override void SetupView()
        {
            base.SetupView();
            Size = new Size(620, 345);
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);

            nameLabel.Text = "Название";
            manufacturerLabel.Text = "Производитель";
            priceLabel.Text = "Ценность";
            statusLabel.Text = "Статус";
            submitButton.Text = "Добавить";
            cancelButton.Text = "Отмена";
            addManufacturerButton.Text = "Добавить";
            addStatusButton.Text = "Добавить";
            panel.BorderStyle = BorderStyle.FixedSingle;
            submitButton.Click += SubmitButtonClicked;
            addStatusButton.Click += AddStatusButtonClicked;
            cancelButton.Click += CancelButtonClicked;
            priceNumericBox.Maximum = 3000000;
            priceNumericBox.Minimum = 0;

            manufacturerListBox.SelectionMode = SelectionMode.One;
            statusListBox.SelectionMode = SelectionMode.One;

            nameTextBox.TextChanged += NameTextBoxChanged;
            addManufacturerButton.Click += AddManufacturerButtonClicked;
            manufacturerListBox.SelectedIndexChanged += ManufacturerListBoxSelected;
            priceNumericBox.ValueChanged += PriceNumericBoxChanged;
            statusListBox.SelectedIndexChanged += StatusListBoxSelected;
            optionalNumericBox.ValueChanged += OptionalNumericBoxChanged;
            optionalTextBox.TextChanged += OptionalTextBoxChanged;

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(manufacturerLabel);
            panel.Controls.Add(addManufacturerButton);
            panel.Controls.Add(manufacturerListBox);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(priceNumericBox);
            panel.Controls.Add(statusLabel);
            panel.Controls.Add(addStatusButton);
            panel.Controls.Add(statusListBox);
            panel.Controls.Add(submitButton);
            panel.Controls.Add(cancelButton);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = panelSize;
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            nameLabel.Size = labelSize;
            nameLabel.Location = new Point(10, 10);

            nameTextBox.Size = labelSize;
            nameTextBox.Location = new Point(10, 30);

            priceLabel.Size = labelSize;
            priceLabel.Location = new Point(10, 60);

            priceNumericBox.Size = labelSize;
            priceNumericBox.Location = new Point(10, 80);

            manufacturerLabel.Size = rowLabelSize;
            manufacturerLabel.Location = new Point(310, 10);

            addManufacturerButton.Size = rowButtonSize;
            addManufacturerButton.Location = new Point(520, 5);

            manufacturerListBox.Size = listBoxSize;
            manufacturerListBox.Location = new Point(310, 30);

            statusLabel.Size = rowLabelSize;
            statusLabel.Location = new Point(310, 100);

            addStatusButton.Size = rowButtonSize;
            addStatusButton.Location = new Point(520, 95);

            statusListBox.Size = listBoxSize;
            statusListBox.Location = new Point(310, 120);

            submitButton.Size = new Size(70, 25);
            submitButton.Location = new Point(440, 265);

            cancelButton.Size = new Size(70, 25);
            cancelButton.Location = new Point(520, 265);
        }

        public void Configure(DeviceViewModel viewModel)
        {
            Update(viewModel);

            switch (viewModel.deviceType)
            {
                case Utils.DeviceType.HardDrive:
                    Text = "Добавление носителя данных";
                    optionalLabel.Text = "Объем (ГБ)";
                    optionalNumericBox.Minimum = 0;
                    optionalNumericBox.Maximum = 10000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericBox);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 115);
                    optionalNumericBox.Size = labelSize;
                    optionalNumericBox.Location = new Point(10, 135);
                    break;
                case Utils.DeviceType.Memory:
                    Text = "Добавление оперативной памяти";
                    optionalLabel.Text = "Объем (ГБ)";
                    optionalNumericBox.Minimum = 0;
                    optionalNumericBox.Maximum = 10000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericBox);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 115);
                    optionalNumericBox.Size = labelSize;
                    optionalNumericBox.Location = new Point(10, 135);
                    break;
                case Utils.DeviceType.PowerSupply:
                    Text = "Добавление источника питания";
                    optionalLabel.Text = "Мощность (Вт)";
                    optionalNumericBox.Minimum = 0;
                    optionalNumericBox.Maximum = 5000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericBox);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 115);
                    optionalNumericBox.Size = labelSize;
                    optionalNumericBox.Location = new Point(10, 135);
                    break;
                case Utils.DeviceType.Processor:
                    Text = "Добавление процессора";
                    optionalLabel.Text = "Частота (ГГц)";
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalTextBox);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 115);
                    optionalTextBox.Size = labelSize;
                    optionalTextBox.Location = new Point(10, 135);
                    break;
                case Utils.DeviceType.GraphicCard:
                    Text = "Добавление видеокарты";
                    optionalLabel.Text = "Объем памяти (Мб)";
                    optionalNumericBox.Minimum = 0;
                    optionalNumericBox.Maximum = 5000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericBox);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 115);
                    optionalNumericBox.Size = labelSize;
                    optionalNumericBox.Location = new Point(10, 135);
                    break;
                case Utils.DeviceType.Motherboard:
                    Text = "Добавление мат. платы";
                    break;
                case Utils.DeviceType.DiskDrive:
                    Text = "Добавление дисковода";
                    break;
                default:
                    break;
            }
        }

        public void Update(DeviceViewModel viewModel)
        {
            if (viewModel.manufacturers.Count > 0)
            {
                manufacturerListBox.DisplayMember = "Value";
                manufacturerListBox.ValueMember = "Key";
                manufacturerListBox.DataSource = new BindingSource(viewModel.manufacturers, null);
            }
            if (viewModel.statuses.Count > 0)
            {
                statusListBox.DisplayMember = "Value";
                statusListBox.ValueMember = "Key";
                statusListBox.DataSource = new BindingSource(viewModel.statuses, null);
            }
        }

        private void AddManufacturerButtonClicked(object sender, EventArgs e) { Interactor.AddManufacturer(); }

        private void AddStatusButtonClicked(object sender, EventArgs e) { Interactor.AddStatus(); }

        private void SubmitButtonClicked(object sender, EventArgs e) { Interactor.Submit(); }

        private void CancelButtonClicked(object sender, EventArgs e) { Interactor.Cancel(); }

        private void NameTextBoxChanged(object sender, EventArgs e) { Interactor.SetName(nameTextBox.Text); }

        private void ManufacturerListBoxSelected(object sender, EventArgs e) { Interactor.SelectManufacturer(manufacturerListBox.SelectedIndex); }

        private void StatusListBoxSelected(object sender, EventArgs e) { Interactor.SelectStatus(statusListBox.SelectedIndex); }

        private void PriceNumericBoxChanged(object sender, EventArgs e) { Interactor.SetPrice((int)priceNumericBox.Value); }

        private void OptionalNumericBoxChanged(object sender, EventArgs e) { Interactor.SetOptionalNumber((int)optionalNumericBox.Value); }

        private void OptionalTextBoxChanged(object sender, EventArgs e) { Interactor.SetOptionalText(optionalTextBox.Text); }
    }
}
