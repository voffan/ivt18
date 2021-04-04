using Computers.Models;
using Computers.Modules.Computer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Home
{
    public interface IHomeInteractor
    {
        IHomePresenter Presenter { get; set; }
        void LoadPeripherals();
        void AddComputer();
    }

    class HomeInteractor : IHomeInteractor, Utils.IFormOwner
    {
        public IHomePresenter Presenter { get; set; }
        private List<Models.Computer> Computers;

        public HomeInteractor(IHomePresenter Presenter)
        {
            this.Presenter = Presenter;
            Configure();
        }

        public void LoadPeripherals()
        {
            /*using (var context = new DatabaseContext())
            {
                List<Peripheral> peripherals = context.Peripherals.ToList();
                Console.WriteLine("Context end");
                Presenter.PresentPeripherals(peripherals);
            }*/
        }

        public void AddComputer()
        {
            new ComputerBuilder()
                .Build(this)
                .ShowDialog(Presenter.View as Form);
        }
        private async void Configure()
        {
            Computers = await DatabaseContext.Shared.GetComputers();
            Presenter.PresentConfigure(Computers);
        }
        public async void Update()
        {
            Computers = await DatabaseContext.Shared.GetComputers();
            Presenter.PresentUpdate(Computers);
        }
    }
}
