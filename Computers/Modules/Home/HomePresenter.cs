using Computers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomePresenter
    {
        IHomeView View { get; set; }
        void PresentConfigure(List<Models.Computer> computers);
        void PresentUpdate(List<Models.Computer> computers);
    }

    class HomePresenter : IHomePresenter
    {
        public IHomeView View { get; set; }
        public HomePresenter(IHomeView View)
        {
            this.View = View;
        }

        public void PresentConfigure(List<Models.Computer> computers)
        {
            var viewModel = new HomeViewModel();
            foreach (var computer in computers)
            {
                string[] representableItems = {
                    computer.ItemNo,
                    computer.Ip,
                    computer.Price.ToString(),
                    "Тут работник"
                };
                viewModel.representableComputers.Add(representableItems);
            }
            View.Configure(viewModel);
        }

        public void PresentUpdate(List<Models.Computer> computers)
        {
            var viewModel = new HomeViewModel();
            foreach (var computer in computers)
            {
                string[] representableItems = {
                    computer.ItemNo,
                    computer.Ip,
                    computer.Price.ToString(),
                    "Тут работник"
                };
                viewModel.representableComputers.Add(representableItems);
            }
            View.Update(viewModel);
        }
    }
}
