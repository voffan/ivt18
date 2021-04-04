using Computers.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Home
{
    public interface IHomeView
    {
        IHomeInteractor Interactor { get; set; }
        void Configure(HomeViewModel viewModel);
        void Update(HomeViewModel viewModel);
    }

    public class HomeView : View, IHomeView
    {
        public IHomeInteractor Interactor { get; set; }

        private readonly TabControl tabControl = new TabControl();
        private readonly TabPage computersTab = new TabPage();
        private readonly TabPage peripheralsTab = new TabPage();
        private readonly TabPage employeesTab = new TabPage();
        private readonly TabPage cataloguesTab = new TabPage();

        private readonly ListView computersListView = new ListView();
        private readonly ListView peripheralsListView = new ListView();
        private readonly ListView employeesListView = new ListView();
        private readonly ListView cataloguesListView = new ListView();

        private readonly Button addComputerButton = new Button();

        public override void SetupView()
        {
            base.SetupView();
            this.Text = "Главная";
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            computersTab.Text = "Компьютеры";
            peripheralsTab.Text = "Периферия";
            employeesTab.Text = "Сотрудники";
            cataloguesTab.Text = "Каталоги";

            computersListView.Columns.Add("ItemNo", "Инвентарный номер", 120);
            computersListView.Columns.Add("IpAddress", "IP адрес", 100);
            computersListView.Columns.Add("TotalPrice", "Общая ценность", 100);
            computersListView.Columns.Add("Employee", "Работник", 150);
            computersListView.View = System.Windows.Forms.View.Details;

            peripheralsListView.Columns.Add("ItemNo", "Инвентарный номер", 120);
            peripheralsListView.Columns.Add("peripheralType", "Тип", 100);
            peripheralsListView.Columns.Add("Price", "Ценность", 100);
            peripheralsListView.View = System.Windows.Forms.View.Details;

            employeesListView.Columns.Add("Surname", "Фамилия", 100);
            employeesListView.Columns.Add("Name", "Имя", 100);
            employeesListView.Columns.Add("Patronymic", "Отчество", 100);
            employeesListView.Columns.Add("Room", "Кабинет", 100);
            employeesListView.View = System.Windows.Forms.View.Details;

            addComputerButton.Text = "Добавить";
            addComputerButton.Click += AddComputerClicked;

            computersTab.Controls.Add(computersListView);
            computersTab.Controls.Add(addComputerButton);
            peripheralsTab.Controls.Add(peripheralsListView);
            employeesTab.Controls.Add(employeesListView);
            cataloguesTab.Controls.Add(cataloguesListView);

            tabControl.TabPages.Add(computersTab);
            tabControl.TabPages.Add(peripheralsTab);
            tabControl.TabPages.Add(employeesTab);
            tabControl.TabPages.Add(cataloguesTab);

            Controls.Add(tabControl);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            tabControl.Size = new Size(ClientSize.Width, ClientSize.Height);
            
            computersTab.Size = tabControl.Size;
            computersListView.Size = new Size(ClientSize.Width, ClientSize.Height - 55);

            peripheralsTab.Size = tabControl.Size;
            peripheralsListView.Size = peripheralsTab.Size;
            
            employeesTab.Size = tabControl.Size;
            employeesListView.Size = employeesTab.Size;
            
            cataloguesTab.Size = tabControl.Size;
            cataloguesListView.Size = cataloguesTab.Size;

            addComputerButton.Size = new Size(100, 25);
            addComputerButton.Location = new Point(0, computersTab.Size.Height - 50);
        }

        public void Configure(HomeViewModel viewModel)
        {
            computersListView.Items.Clear();
            foreach (var representableComputer in viewModel.representableComputers)
            {
                var item = new ListViewItem(representableComputer);
                computersListView.Items.Add(item);
            }
        }

        public void Update(HomeViewModel viewModel)
        {
            computersListView.Items.Clear();
            foreach (var representableComputer in viewModel.representableComputers)
            {
                var item = new ListViewItem(representableComputer);
                computersListView.Items.Add(item);
            }
        }

        private void AddComputerClicked(object sender, EventArgs args) { Interactor.AddComputer(); }
    }
}
