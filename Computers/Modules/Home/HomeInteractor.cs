using Computers.Models;
using Computers.Modules.Computer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomeInteractor
    {
        IHomePresenter Presenter { get; set; }
        void LoadPeripherals();
        void AddComputer();
    }

    class HomeInteractor : IHomeInteractor
    {
        public IHomePresenter Presenter { get; set; }

        public void LoadPeripherals()
        {
            using (var context = new DatabaseContext())
            {
                List<Peripheral> peripherals = context.Peripherals.ToList();
                Console.WriteLine("Context end");
                Presenter.PresentPeripherals(peripherals);
            }
        }

        public void AddComputer()
        {
            Router.Shared.CurrentForm = new ComputerBuilder().Build();
        }
    }
}
