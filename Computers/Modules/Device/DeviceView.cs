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
    }

    class DeviceView : View, IDeviceView
    {
        public IDeviceInteractor Interactor { get; set; }

        // Создание нового девайса указанного типа с присвоением компьютеру

        private readonly Panel panel = new Panel();

        private readonly Label nameLabel = new Label();
        private readonly Label manufacturerLabel = new Label();
        private readonly Label priceLabel = new Label();
        private readonly Label statusLabel = new Label();
        private readonly Label optionalLabel = new Label();

        private readonly TextBox nameTextBox = new TextBox();
        private readonly ComboBox manufacturerComboBox = new ComboBox();
        private readonly Button addManufacturerButton = new Button();
        private readonly NumericUpDown priceNumericBox = new NumericUpDown();
        private readonly ComboBox statusComboBox = new ComboBox();
        private readonly Button addStatusButton = new Button();
        private readonly NumericUpDown optionalNumericField = new NumericUpDown();
        private readonly TextBox optionalTextField = new TextBox();

        private readonly Button submitButton = new Button();
        private readonly Button cancelButton = new Button();

        private readonly Size panelSize = new Size(300, 300);
        private readonly Size labelSize = new Size(280, 20);
        private readonly Size rowLabelSize = new Size(200, 20);
        private readonly Size rowButtonSize = new Size(70, 20);

        public override void SetupView()
        {
            base.SetupView();
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

            panel.BorderStyle = BorderStyle.FixedSingle;
            addManufacturerButton.Text = "Добавить";
            addManufacturerButton.Click += AddManufacturerButtonClicked;
            addStatusButton.Text = "Добавить";
            addStatusButton.Click += AddStatusButtonClicked;
            priceNumericBox.Maximum = 3000000;
            priceNumericBox.Minimum = 0;

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(manufacturerLabel);
            panel.Controls.Add(addManufacturerButton);
            panel.Controls.Add(manufacturerComboBox);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(priceNumericBox);
            panel.Controls.Add(statusLabel);
            panel.Controls.Add(addStatusButton);
            panel.Controls.Add(statusComboBox);
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

            manufacturerLabel.Size = rowLabelSize;
            manufacturerLabel.Location = new Point(10, 60);

            addManufacturerButton.Size = rowButtonSize;
            addManufacturerButton.Location = new Point(220, 55);

            manufacturerComboBox.Size = labelSize;
            manufacturerComboBox.Location = new Point(10, 80);

            priceLabel.Size = labelSize;
            priceLabel.Location = new Point(10, 110);

            priceNumericBox.Size = labelSize;
            priceNumericBox.Location = new Point(10, 130);

            statusLabel.Size = rowLabelSize;
            statusLabel.Location = new Point(10, 160);

            addStatusButton.Size = rowButtonSize;
            addStatusButton.Location = new Point(220, 155);

            statusComboBox.Size = labelSize;
            statusComboBox.Location = new Point(10, 180);

            submitButton.Size = new Size(70, 25);
            submitButton.Location = new Point(140, 265);

            cancelButton.Size = new Size(70, 25);
            cancelButton.Location = new Point(220, 265);
        }

        private void AddManufacturerButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddManufacturer();
        }

        private void AddStatusButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddStatus();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            Interactor.SubmitDevice();
        }

        private void CancelButtonClicked(object sender, EventArgs e)
        {
            Interactor.Cancel();
        }

        public void Configure(DeviceViewModel viewModel)
        {
            manufacturerComboBox.DataSource = new BindingSource(viewModel.manufacturers, null);
            manufacturerComboBox.DisplayMember = "Key";
            manufacturerComboBox.ValueMember = "Value";
            statusComboBox.DataSource = new BindingSource(viewModel.statuses, null);
            statusComboBox.DisplayMember = "Key";
            statusComboBox.ValueMember = "Value";

            switch (viewModel.deviceType)
            {
                case Utils.DeviceType.HardDrive:
                    Text = "Добавление носителя данных";
                    optionalLabel.Text = "Объем (ГБ)";
                    optionalNumericField.Minimum = 0;
                    optionalNumericField.Maximum = 10000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericField);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 210);
                    optionalNumericField.Size = labelSize;
                    optionalNumericField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.Memory:
                    Text = "Добавление оперативной памяти";
                    optionalLabel.Text = "Объем (ГБ)";
                    optionalNumericField.Minimum = 0;
                    optionalNumericField.Maximum = 10000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericField);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 210);
                    optionalNumericField.Size = labelSize;
                    optionalNumericField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.PowerSupply:
                    Text = "Добавление источника питания";
                    optionalLabel.Text = "Мощность (Вт)";
                    optionalNumericField.Minimum = 0;
                    optionalNumericField.Maximum = 5000;
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalNumericField);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 210);
                    optionalNumericField.Size = labelSize;
                    optionalNumericField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.Processor:
                    Text = "Добавление процессора";
                    optionalLabel.Text = "Частота (ГГц)";
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalTextField);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 210);
                    optionalTextField.Size = labelSize;
                    optionalTextField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.GraphicCard:
                    Text = "Добавление видеокарты";
                    optionalLabel.Text = "Value (неизвестно)";
                    panel.Controls.Add(optionalLabel);
                    panel.Controls.Add(optionalTextField);
                    optionalLabel.Size = labelSize;
                    optionalLabel.Location = new Point(10, 210);
                    optionalTextField.Size = labelSize;
                    optionalTextField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.Motherboard:
                    Text = "Добавление мат. платы";
                    break;
                default:
                    break;
            }
        }
    }
}
