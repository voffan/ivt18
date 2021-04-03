using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Computer
{
    public interface IComputerView
    {
        IComputerInteractor Interactor { get; set; }
        void Configure(ComputerViewModel viewModel);
        void Update(ComputerViewModel viewModel);
        void Close();
    }

    class ComputerView : View, IComputerView
    {
        public IComputerInteractor Interactor { get; set; }
        private Utils.WindowMode windowMode;

        public ComputerView() : base()
        {
            windowMode = Utils.WindowMode.Create;
        }

        private readonly Panel panel = new Panel();

        private readonly Label nameLabel = new Label();
        private readonly Label itemNoLabel = new Label();
        private readonly Label ipAddressLabel = new Label();
        private readonly Label totalPriceLabel = new Label();
        private readonly Label totalPriceValueLabel = new Label();
        private readonly Label employeeLabel = new Label();
        private readonly Label diskDriveLabel = new Label();
        private readonly Label processorLabel = new Label();
        private readonly Label motherboardLabel = new Label();
        private readonly Label powerSuppliesLabel = new Label();
        private readonly Label memoriesLabel = new Label();
        private readonly Label hardDrivesLabel = new Label();
        private readonly Label graphicCardsLabel = new Label();

        private readonly TextBox nameTextBox = new TextBox();
        private readonly TextBox itemNoTextField = new TextBox();
        private readonly TextBox ipAddressTextField = new TextBox();
        private readonly ListBox employeeListBox = new ListBox();
        private readonly ListBox diskDriveListBox = new ListBox();
        private readonly ListBox processorListBox = new ListBox();
        private readonly ListBox motherboardListBox = new ListBox();
        private readonly ListBox powerSuppliesListBox = new ListBox();
        private readonly ListBox memoriesListBox = new ListBox();
        private readonly ListBox hardDrivesListBox = new ListBox();
        private readonly ListBox graphicCardsListBox = new ListBox();

        private readonly Button addEmployeeButton = new Button();
        private readonly Button addProcessorButton = new Button();
        private readonly Button addMotherboardButton = new Button();
        private readonly Button addDiskDriveButton = new Button();
        private readonly Button addPowerSupplyButton = new Button();
        private readonly Button addMemoryButton = new Button();
        private readonly Button addHardDriveButton = new Button();
        private readonly Button addGraphicCardButton = new Button();
        private readonly Button submitButton = new Button();
        private readonly Button cancelButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            Text = "Добавление компьютера";
            Size = new Size(920, 440);
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);

            nameLabel.Text = "Название компьютера";
            itemNoLabel.Text = "Инвентарный номер";
            ipAddressLabel.Text = "IP адрес";
            totalPriceLabel.Text = "Общая ценность";
            employeeLabel.Text = "Работник";
            diskDriveLabel.Text = "Дисковод";
            processorLabel.Text = "Процессор";
            motherboardLabel.Text = "Мат. плата";
            powerSuppliesLabel.Text = "Элементы питания";
            memoriesLabel.Text = "Оперативная память";
            hardDrivesLabel.Text = "Накопители данных";
            graphicCardsLabel.Text = "Видеокарты";

            addPowerSupplyButton.Text = "Добавить";
            addMemoryButton.Text = "Добавить";
            addHardDriveButton.Text = "Добавить";
            addGraphicCardButton.Text = "Добавить";
            addEmployeeButton.Text = "Добавить";
            addProcessorButton.Text = "Добавить";
            addMotherboardButton.Text = "Добавить";
            addDiskDriveButton.Text = "Добавить";
            submitButton.Text = "Добавить компьютер";
            cancelButton.Text = "Отмена";

            nameTextBox.TextChanged += NameTextBoxChanged;
            ipAddressTextField.TextChanged += IpAddressTextBoxChanged;
            totalPriceValueLabel.Text = "0";

            panel.BorderStyle = BorderStyle.FixedSingle;
            addPowerSupplyButton.Click += AddPowerSupplyButtonClicked;
            addMemoryButton.Click += AddMemoryButtonClicked;
            addHardDriveButton.Click += AddHardDriveButtonClicked;
            addGraphicCardButton.Click += AddGraphicCardButtonClicked;
            addEmployeeButton.Click += AddEmployeeButtonClicked;
            addProcessorButton.Click += AddProcessorButtonClicked;
            addMotherboardButton.Click += AddMotherboardButtonClicked;
            addDiskDriveButton.Click += AddDiskDriveButtonClicked;

            employeeListBox.DisplayMember = "Key";
            employeeListBox.ValueMember = "Value";
            employeeListBox.SelectionMode = SelectionMode.One;
            processorListBox.DisplayMember = "Key";
            processorListBox.ValueMember = "Value";
            processorListBox.SelectionMode = SelectionMode.One;
            motherboardListBox.DisplayMember = "Key";
            motherboardListBox.ValueMember = "Value";
            motherboardListBox.SelectionMode = SelectionMode.One;
            diskDriveListBox.DisplayMember = "Key";
            diskDriveListBox.ValueMember = "Value";
            diskDriveListBox.SelectionMode = SelectionMode.One;
            powerSuppliesListBox.DisplayMember = "Key";
            powerSuppliesListBox.ValueMember = "Value";
            powerSuppliesListBox.SelectionMode = SelectionMode.MultiSimple;
            memoriesListBox.DisplayMember = "Key";
            memoriesListBox.ValueMember = "Value";
            memoriesListBox.SelectionMode = SelectionMode.MultiSimple;
            hardDrivesListBox.DisplayMember = "Key";
            hardDrivesListBox.ValueMember = "Value";
            hardDrivesListBox.SelectionMode = SelectionMode.MultiSimple;
            graphicCardsListBox.DisplayMember = "Key";
            graphicCardsListBox.ValueMember = "Value";
            graphicCardsListBox.SelectionMode = SelectionMode.MultiSimple;

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(itemNoLabel);
            panel.Controls.Add(itemNoTextField);
            panel.Controls.Add(ipAddressLabel);
            panel.Controls.Add(ipAddressTextField);
            panel.Controls.Add(totalPriceLabel);
            panel.Controls.Add(totalPriceValueLabel);
            panel.Controls.Add(employeeLabel);
            panel.Controls.Add(addEmployeeButton);
            panel.Controls.Add(employeeListBox);
            panel.Controls.Add(diskDriveLabel);
            panel.Controls.Add(addDiskDriveButton);
            panel.Controls.Add(diskDriveListBox);
            panel.Controls.Add(processorLabel);
            panel.Controls.Add(addProcessorButton);
            panel.Controls.Add(processorListBox);
            panel.Controls.Add(motherboardLabel);
            panel.Controls.Add(addMotherboardButton);
            panel.Controls.Add(motherboardListBox);
            panel.Controls.Add(powerSuppliesLabel);
            panel.Controls.Add(addPowerSupplyButton);
            panel.Controls.Add(powerSuppliesListBox);
            panel.Controls.Add(memoriesLabel);
            panel.Controls.Add(addMemoryButton);
            panel.Controls.Add(memoriesListBox);
            panel.Controls.Add(hardDrivesLabel);
            panel.Controls.Add(addHardDriveButton);
            panel.Controls.Add(hardDrivesListBox);
            panel.Controls.Add(graphicCardsLabel);
            panel.Controls.Add(addGraphicCardButton);
            panel.Controls.Add(graphicCardsListBox);
            panel.Controls.Add(submitButton);
            panel.Controls.Add(cancelButton);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(900, 400);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            Size labelSize = new Size(280, 20);
            Size listBoxSize = new Size(280, 60);
            Size rowLabelSize = new Size(200, 20);
            Size rowButtonSize = new Size(70, 20);

            nameLabel.Size = labelSize;
            nameLabel.Location = new Point(10, 10);

            nameTextBox.Size = labelSize;
            nameTextBox.Location = new Point(10, 30);

            itemNoLabel.Size = labelSize;
            itemNoLabel.Location = new Point(10, 60);

            itemNoTextField.Size = labelSize;
            itemNoTextField.Location = new Point(10, 80);

            ipAddressLabel.Size = labelSize;
            ipAddressLabel.Location = new Point(10, 110);

            ipAddressTextField.Size = labelSize;
            ipAddressTextField.Location = new Point(10, 130);

            totalPriceLabel.Size = labelSize;
            totalPriceLabel.Location = new Point(10, 160);

            totalPriceValueLabel.Size = labelSize;
            totalPriceValueLabel.Location = new Point(10, 180);

            employeeLabel.Size = rowLabelSize;
            employeeLabel.Location = new Point(310, 10);

            addEmployeeButton.Size = rowButtonSize;
            addEmployeeButton.Location = new Point(520, 5);

            employeeListBox.Size = listBoxSize;
            employeeListBox.Location = new Point(310, 30);

            diskDriveLabel.Size = rowLabelSize;
            diskDriveLabel.Location = new Point(310, 100);

            addDiskDriveButton.Size = rowButtonSize;
            addDiskDriveButton.Location = new Point(520, 95);

            diskDriveListBox.Size = listBoxSize;
            diskDriveListBox.Location = new Point(310, 120);

            processorLabel.Size = rowLabelSize;
            processorLabel.Location = new Point(310, 190);

            addProcessorButton.Size = rowButtonSize;
            addProcessorButton.Location = new Point(520, 185);

            processorListBox.Size = listBoxSize;
            processorListBox.Location = new Point(310, 210);

            motherboardLabel.Size = rowLabelSize;
            motherboardLabel.Location = new Point(310, 280);

            addMotherboardButton.Size = rowButtonSize;
            addMotherboardButton.Location = new Point(520, 275);

            motherboardListBox.Size = listBoxSize;
            motherboardListBox.Location = new Point(310, 300);

            powerSuppliesLabel.Size = rowLabelSize;
            powerSuppliesLabel.Location = new Point(610, 10);

            addPowerSupplyButton.Size = rowButtonSize;
            addPowerSupplyButton.Location = new Point(820, 5);

            powerSuppliesListBox.Size = listBoxSize;
            powerSuppliesListBox.Location = new Point(610, 30);

            memoriesLabel.Size = rowLabelSize;
            memoriesLabel.Location = new Point(610, 100);

            addMemoryButton.Size = rowButtonSize;
            addMemoryButton.Location = new Point(820, 95);

            memoriesListBox.Size = listBoxSize;
            memoriesListBox.Location = new Point(610, 120);

            hardDrivesLabel.Size = rowLabelSize;
            hardDrivesLabel.Location = new Point(610, 190);

            addHardDriveButton.Size = rowButtonSize;
            addHardDriveButton.Location = new Point(820, 185);

            hardDrivesListBox.Size = listBoxSize;
            hardDrivesListBox.Location = new Point(610, 210);

            graphicCardsLabel.Size = rowLabelSize;
            graphicCardsLabel.Location = new Point(610, 280);

            addGraphicCardButton.Size = rowButtonSize;
            addGraphicCardButton.Location = new Point(820, 275);

            graphicCardsListBox.Size = listBoxSize;
            graphicCardsListBox.Location = new Point(610, 300);

            submitButton.Size = new Size(140, 25);
            submitButton.Location = new Point(675, 365);

            cancelButton.Size = new Size(70, 25);
            cancelButton.Location = new Point(820, 365);
        }

        public void Configure(ComputerViewModel viewModel)
        {
            if (viewModel.Employees.Count > 0) 
                employeeListBox.DataSource = new BindingSource(viewModel.Employees, null);
            if (viewModel.Processors.Count > 0) 
                processorListBox.DataSource = new BindingSource(viewModel.Processors, null);
            if (viewModel.Motherboards.Count > 0) 
                motherboardListBox.DataSource = new BindingSource(viewModel.Motherboards, null);
            if (viewModel.DiskDrives.Count > 0) 
                diskDriveListBox.DataSource = new BindingSource(viewModel.DiskDrives, null);
            if (viewModel.PowerSupplies.Count > 0) 
                powerSuppliesListBox.DataSource = new BindingSource(viewModel.PowerSupplies, null);
            if (viewModel.Memories.Count > 0) 
                memoriesListBox.DataSource = new BindingSource(viewModel.Memories, null);
            if (viewModel.HardDrives.Count > 0) 
                hardDrivesListBox.DataSource = new BindingSource(viewModel.HardDrives, null);
            if (viewModel.GraphicCards.Count > 0) 
                graphicCardsListBox.DataSource = new BindingSource(viewModel.GraphicCards, null);
        }

        public void Update(ComputerViewModel viewModel)
        {
            if (viewModel.Employees.Count > 0)
                employeeListBox.DataSource = new BindingSource(viewModel.Employees, null);
            if (viewModel.Processors.Count > 0)
                processorListBox.DataSource = new BindingSource(viewModel.Processors, null);
            if (viewModel.Motherboards.Count > 0)
                motherboardListBox.DataSource = new BindingSource(viewModel.Motherboards, null);
            if (viewModel.DiskDrives.Count > 0)
                diskDriveListBox.DataSource = new BindingSource(viewModel.DiskDrives, null);
            if (viewModel.PowerSupplies.Count > 0)
                powerSuppliesListBox.DataSource = new BindingSource(viewModel.PowerSupplies, null);
            if (viewModel.Memories.Count > 0)
                memoriesListBox.DataSource = new BindingSource(viewModel.Memories, null);
            if (viewModel.HardDrives.Count > 0)
                hardDrivesListBox.DataSource = new BindingSource(viewModel.HardDrives, null);
            if (viewModel.GraphicCards.Count > 0)
                graphicCardsListBox.DataSource = new BindingSource(viewModel.GraphicCards, null);
        }
        private void NameTextBoxChanged(object sender, EventArgs e) { Interactor.SetName(nameTextBox.Text); }
        private void IpAddressTextBoxChanged(object sender, EventArgs e) { Interactor.SetIpAddress(ipAddressTextField.Text); }
        private void AddPowerSupplyButtonClicked(object sender, EventArgs e) { Interactor.AddPowerSupply(); }
        private void AddHardDriveButtonClicked(object sender, EventArgs e) { Interactor.AddHardDrive(); }
        private void AddMemoryButtonClicked(object sender, EventArgs e) { Interactor.AddMemory(); }
        private void AddGraphicCardButtonClicked(object sender, EventArgs e) { Interactor.AddGraphicCard(); }
        private void AddEmployeeButtonClicked(object sender, EventArgs e) { Interactor.AddEmployee(); }
        private void AddProcessorButtonClicked(object sender, EventArgs e) { Interactor.AddProcessor(); }
        private void AddMotherboardButtonClicked(object sender, EventArgs e) { Interactor.AddMotherboard(); }
        private void AddDiskDriveButtonClicked(object sender, EventArgs e) { Interactor.AddDiskDrive(); }
        private void SubmitButtonClicked(object sender, EventArgs e) { Interactor.Submit(); }
        private void CancelButtonClicked(object sender, EventArgs e) { Interactor.Cancel(); }
    }
}
