using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomeInteractor
    {
        IHomePresenter Presenter { get; set; }
        void LoadPeripherals();
    }

    class HomeInteractor : IHomeInteractor
    {
        public IHomePresenter Presenter { get; set; }

        public void LoadPeripherals()
        {
            throw new NotImplementedException();
        }
    }
}
