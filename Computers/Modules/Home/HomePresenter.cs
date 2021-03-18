using Computers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomePresenter
    {
        IHomeView View { get; set; }
        void PresentPeripherals(List<Peripheral> peripherals);
    }

    class HomePresenter : IHomePresenter
    {
        public IHomeView View { get; set; }

        public void PresentPeripherals(List<Peripheral> peripherals)
        {
            View.ShowPeripherals(peripherals);
        }
    }
}
