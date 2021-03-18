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
        void ShowPeripherals(List<Peripheral> peripherals);
    }

    class HomeView : View, IHomeView
    {
        public IHomeInteractor Interactor { get; set; }

        private readonly TabControl tabControl = new TabControl();
        private readonly TabPage computersTab = new TabPage();
        private readonly TabPage peripheralsTab = new TabPage();
        private readonly TabPage employeesTab = new TabPage();
        private readonly TabPage cataloguesTab = new TabPage();

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

            tabControl.TabPages.Add(computersTab);
            tabControl.TabPages.Add(peripheralsTab);
            tabControl.TabPages.Add(employeesTab);
            tabControl.TabPages.Add(cataloguesTab);

            Controls.Add(tabControl);
        }

        public override void ViewDidShow(object sender, EventArgs e)
        {
            base.ViewDidShow(sender, e);
            _ = Interactor.LoadPeripherals();
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            tabControl.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        public void ShowPeripherals(List<Peripheral> peripherals)
        {
            Console.WriteLine($"Peripherals count: {peripherals.Count}");
            // TODO: Сделать общий метод и вывести
        }
    }
}
