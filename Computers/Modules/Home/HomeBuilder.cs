using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Home
{
    class HomeBuilder
    {
        public Form Build()
        {
            var Presenter = new HomePresenter();
            var Interactor = new HomeInteractor();
            var View = new HomeView();

            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;

            return View;
        }
    }
}
