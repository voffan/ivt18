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
    }

    class DeviceView : View, IDeviceView
    {
        public IDeviceInteractor Interactor { get; set; }

        private readonly Utils.DeviceType deviceType;      
        private readonly Utils.WindowMode windowMode;
        private readonly Models.Device device;

        // Создание нового девайса указанного типа
        public DeviceView(Utils.DeviceType deviceType) : base()
        {
            this.deviceType = deviceType;
            this.windowMode = Utils.WindowMode.Create;
        }

        // Редактирование девайса
        public DeviceView(Models.Device device) : base()
        {
            this.device = device;
            this.windowMode = Utils.WindowMode.Create;
        }

        private readonly Panel panel = new Panel();

        private readonly Label nameLabel = new Label();
        private readonly Label manufacturerLabel = new Label();
        private readonly Label priceLabel = new Label();
        private readonly Label statusLabel = new Label();

        private readonly TextBox nameTextBox = new TextBox();
        private readonly ComboBox manufacturerComboBox = new ComboBox();
        private readonly NumericUpDown priceNumericBox = new NumericUpDown();
        private readonly ComboBox statusComboBox = new ComboBox();

        private readonly Label uniqueFieldLabel = new Label();
        
        // Hard drive, memory, power supply
        private readonly NumericUpDown uniqueNumericField = new NumericUpDown();
        // Graphic card, Processor
        private readonly TextBox uniqueTextField = new TextBox();

        public override void SetupView()
        {
            base.SetupView();
            SetupViewText();
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);

            nameLabel.Text = "Название";
            manufacturerLabel.Text = "Производитель";
            priceLabel.Text = "Ценность";
            statusLabel.Text = "Статус";

            panel.BorderStyle = BorderStyle.FixedSingle;
            priceNumericBox.Maximum = 3000000;
            priceNumericBox.Minimum = 0;

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(manufacturerLabel);
            panel.Controls.Add(manufacturerComboBox);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(priceNumericBox);
            panel.Controls.Add(statusLabel);
            panel.Controls.Add(statusComboBox);

            Controls.Add(panel);

            SetupUniqueFields();
            SetupLayout(null, null);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(300, 300);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            Size labelSize = new Size(280, 20);

            nameLabel.Size = labelSize;
            nameLabel.Location = new Point(10, 10);

            nameTextBox.Size = labelSize;
            nameTextBox.Location = new Point(10, 30);

            manufacturerLabel.Size = labelSize;
            manufacturerLabel.Location = new Point(10, 60);

            manufacturerComboBox.Size = labelSize;
            manufacturerComboBox.Location = new Point(10, 80);

            priceLabel.Size = labelSize;
            priceLabel.Location = new Point(10, 110);

            priceNumericBox.Size = labelSize;
            priceNumericBox.Location = new Point(10, 130);

            statusLabel.Size = labelSize;
            statusLabel.Location = new Point(10, 160);

            statusComboBox.Size = labelSize;
            statusComboBox.Location = new Point(10, 180);

            SetupUniqueFieldsLayout(labelSize);
        }

        private void SetupUniqueFields()
        {
            switch (deviceType)
            {
                case Utils.DeviceType.HardDrive:
                    uniqueFieldLabel.Text = "Объем (ГБ)";
                    uniqueNumericField.Minimum = 0;
                    uniqueNumericField.Maximum = 10000;
                    panel.Controls.Add(uniqueFieldLabel);
                    panel.Controls.Add(uniqueNumericField);
                    break;
                case Utils.DeviceType.Memory:
                    uniqueFieldLabel.Text = "Объем (ГБ)";
                    uniqueNumericField.Minimum = 0;
                    uniqueNumericField.Maximum = 10000;
                    panel.Controls.Add(uniqueFieldLabel);
                    panel.Controls.Add(uniqueNumericField);
                    break;
                case Utils.DeviceType.PowerSupply:
                    uniqueFieldLabel.Text = "Мощность (Вт)";
                    uniqueNumericField.Minimum = 0;
                    uniqueNumericField.Maximum = 5000;
                    panel.Controls.Add(uniqueFieldLabel);
                    panel.Controls.Add(uniqueNumericField);
                    break;
                case Utils.DeviceType.Processor:
                    uniqueFieldLabel.Text = "Частота (ГГц)";
                    panel.Controls.Add(uniqueFieldLabel);
                    panel.Controls.Add(uniqueTextField);
                    break;
                case Utils.DeviceType.GraphicCard:
                    uniqueFieldLabel.Text = "Value (неизвестно)";
                    panel.Controls.Add(uniqueFieldLabel);
                    panel.Controls.Add(uniqueTextField);
                    break;
                default:
                    break;
            }
        }

        private void SetupUniqueFieldsLayout(Size labelSize)
        {
            switch (deviceType)
            {
                case Utils.DeviceType.HardDrive:
                    uniqueFieldLabel.Size = labelSize;
                    uniqueFieldLabel.Location = new Point(10, 210);
                    uniqueNumericField.Size = labelSize;
                    uniqueNumericField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.Memory:
                    uniqueFieldLabel.Size = labelSize;
                    uniqueFieldLabel.Location = new Point(10, 210);
                    uniqueNumericField.Size = labelSize;
                    uniqueNumericField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.PowerSupply:
                    uniqueFieldLabel.Size = labelSize;
                    uniqueFieldLabel.Location = new Point(10, 210);
                    uniqueNumericField.Size = labelSize;
                    uniqueNumericField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.Processor:
                    uniqueFieldLabel.Size = labelSize;
                    uniqueFieldLabel.Location = new Point(10, 210);
                    uniqueTextField.Size = labelSize;
                    uniqueTextField.Location = new Point(10, 230);
                    break;
                case Utils.DeviceType.GraphicCard:
                    uniqueFieldLabel.Size = labelSize;
                    uniqueFieldLabel.Location = new Point(10, 210);
                    uniqueTextField.Size = labelSize;
                    uniqueTextField.Location = new Point(10, 230);
                    break;
                default:
                    break;
            }
        }

        private void SetupViewText()
        {
            if (windowMode == Utils.WindowMode.Create)
            {
                switch (deviceType)
                {
                    case Utils.DeviceType.Processor:
                        Text = "Добавление процессора";
                        break;
                    case Utils.DeviceType.PowerSupply:
                        Text = "Добавление элемента питания";
                        break;
                    case Utils.DeviceType.Motherboard:
                        Text = "Добавление мат. платы";
                        break;
                    case Utils.DeviceType.Memory:
                        Text = "Добавление оперативной памяти";
                        break;
                    case Utils.DeviceType.HardDrive:
                        Text = "Добавление накопителя данных";
                        break;
                    case Utils.DeviceType.GraphicCard:
                        Text = "Добавление видеокарты";
                        break;
                    case Utils.DeviceType.None:
                        Text = "Добавление девайса";
                        break;
                    default: break;
                }
            }
            if (windowMode == Utils.WindowMode.Edit)
            {
                switch (deviceType)
                {
                    case Utils.DeviceType.Processor:
                        Text = "Изменение процессора";
                        break;
                    case Utils.DeviceType.PowerSupply:
                        Text = "Изменение элемента питания";
                        break;
                    case Utils.DeviceType.Motherboard:
                        Text = "Изменение мат. платы";
                        break;
                    case Utils.DeviceType.Memory:
                        Text = "Изменение оперативной памяти";
                        break;
                    case Utils.DeviceType.HardDrive:
                        Text = "Изменение накопителя данных";
                        break;
                    case Utils.DeviceType.GraphicCard:
                        Text = "Изменение видеокарты";
                        break;
                    case Utils.DeviceType.None:
                        Text = "Изменение девайса";
                        break;
                    default: break;
                }
            }
        }
    }
}
