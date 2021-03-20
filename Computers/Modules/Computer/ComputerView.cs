﻿using System;
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
    }

    class ComputerView : View, IComputerView
    {
        public IComputerInteractor Interactor { get; set; }

        private Models.Computer computer;
        private Utils.WindowMode windowMode;

        public ComputerView(IComputerInteractor Interactor) : base()
        {
            this.Interactor = Interactor;
            Interactor.Computer = new Models.Computer();
            windowMode = Utils.WindowMode.Create;
        }
        public ComputerView(IComputerInteractor Interactor, Models.Computer computer) : base()
        {
            this.Interactor = Interactor;
            this.computer = computer;
            Interactor.Computer = computer;
            windowMode = Utils.WindowMode.Edit;
        }

        private readonly Panel panel = new Panel();

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

        private readonly TextBox itemNoTextField = new TextBox();
        private readonly TextBox ipAddressTextField = new TextBox();
        private readonly ComboBox employeeComboBox = new ComboBox();
        private readonly ComboBox diskDriveComboBox = new ComboBox();
        private readonly ComboBox processorComboBox = new ComboBox();
        private readonly ComboBox motherboardComboBox = new ComboBox();
        private readonly ListBox powerSuppliesListBox = new ListBox();
        private readonly ListBox memoriesListBox = new ListBox();
        private readonly ListBox hardDrivesListBox = new ListBox();
        private readonly ListBox graphicCardsListBox = new ListBox();

        private readonly Button addPowerSupplyButton = new Button();
        private readonly Button addMemoryButton = new Button();
        private readonly Button addHardDriveButton = new Button();
        private readonly Button addGraphicCardButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            Text = "Добавление компьютера";
            Size = new Size(620, 440);
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);

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

            totalPriceValueLabel.Text = "242394";

            panel.BorderStyle = BorderStyle.FixedSingle;
            addPowerSupplyButton.Click += AddPowerSupplyButtonClicked;
            addMemoryButton.Click += AddMemoryButtonClicked;
            addHardDriveButton.Click += AddHardDriveButtonClicked;
            addGraphicCardButton.Click += AddGraphicCardButtonClicked;

            panel.Controls.Add(itemNoLabel);
            panel.Controls.Add(itemNoTextField);
            panel.Controls.Add(ipAddressLabel);
            panel.Controls.Add(ipAddressTextField);
            panel.Controls.Add(totalPriceLabel);
            panel.Controls.Add(totalPriceValueLabel);
            panel.Controls.Add(employeeLabel);
            panel.Controls.Add(employeeComboBox);
            panel.Controls.Add(diskDriveLabel);
            panel.Controls.Add(diskDriveComboBox);
            panel.Controls.Add(processorLabel);
            panel.Controls.Add(processorComboBox);
            panel.Controls.Add(motherboardLabel);
            panel.Controls.Add(motherboardComboBox);
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

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = new Size(600, 400);
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            Size labelSize = new Size(280, 20);
            Size listBoxSize = new Size(280, 60);
            Size rowLabelSize = new Size(200, 20);
            Size rowButtonSize = new Size(70, 20);

            itemNoLabel.Size = labelSize;
            itemNoLabel.Location = new Point(10, 10);

            itemNoTextField.Size = labelSize;
            itemNoTextField.Location = new Point(10, 30);

            ipAddressLabel.Size = labelSize;
            ipAddressLabel.Location = new Point(10, 60);

            ipAddressTextField.Size = labelSize;
            ipAddressTextField.Location = new Point(10, 80);

            totalPriceLabel.Size = labelSize;
            totalPriceLabel.Location = new Point(10, 115);

            totalPriceValueLabel.Size = labelSize;
            totalPriceValueLabel.Location = new Point(10, 135);

            employeeLabel.Size = labelSize;
            employeeLabel.Location = new Point(10, 165);

            employeeComboBox.Size = labelSize;
            employeeComboBox.Location = new Point(10, 185);

            diskDriveLabel.Size = labelSize;
            diskDriveLabel.Location = new Point(10, 215);

            diskDriveComboBox.Size = labelSize;
            diskDriveComboBox.Location = new Point(10, 235);

            processorLabel.Size = labelSize;
            processorLabel.Location = new Point(10, 265);

            processorComboBox.Size = labelSize;
            processorComboBox.Location = new Point(10, 285);

            motherboardLabel.Size = labelSize;
            motherboardLabel.Location = new Point(10, 315);

            motherboardComboBox.Size = labelSize;
            motherboardComboBox.Location = new Point(10, 335);

            powerSuppliesLabel.Size = rowLabelSize;
            powerSuppliesLabel.Location = new Point(310, 10);

            addPowerSupplyButton.Size = rowButtonSize;
            addPowerSupplyButton.Location = new Point(520, 5);

            powerSuppliesListBox.Size = listBoxSize;
            powerSuppliesListBox.Location = new Point(310, 30);

            memoriesLabel.Size = rowLabelSize;
            memoriesLabel.Location = new Point(310, 100);

            addMemoryButton.Size = rowButtonSize;
            addMemoryButton.Location = new Point(520, 95);

            memoriesListBox.Size = listBoxSize;
            memoriesListBox.Location = new Point(310, 120);

            hardDrivesLabel.Size = rowLabelSize;
            hardDrivesLabel.Location = new Point(310, 190);

            addHardDriveButton.Size = rowButtonSize;
            addHardDriveButton.Location = new Point(520, 185);

            hardDrivesListBox.Size = listBoxSize;
            hardDrivesListBox.Location = new Point(310, 210);

            graphicCardsLabel.Size = rowLabelSize;
            graphicCardsLabel.Location = new Point(310, 280);

            addGraphicCardButton.Size = rowButtonSize;
            addGraphicCardButton.Location = new Point(520, 275);

            graphicCardsListBox.Size = listBoxSize;
            graphicCardsListBox.Location = new Point(310, 300);
        }

        private void AddPowerSupplyButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddPowerSupply();
        }

        private void AddHardDriveButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddHardDrive();
        }

        private void AddMemoryButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddMemory();
        }

        private void AddGraphicCardButtonClicked(object sender, EventArgs e)
        {
            Interactor.AddGraphicCard();
        }
    }
}
