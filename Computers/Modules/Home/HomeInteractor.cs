using Computers.Models;
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
        Task LoadPeripherals();
    }

    class HomeInteractor : IHomeInteractor
    {
        public IHomePresenter Presenter { get; set; }

        public async Task LoadPeripherals()
        {
            var context = new DatabaseContext();
            var result = await context.Peripherals.ToListAsync();
            Presenter.PresentPeripherals(result);
        }
    }
}
