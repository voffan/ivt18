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
            var View = new HomeView();
            var Presenter = new HomePresenter(View);
            var Interactor = new HomeInteractor(Presenter);

            View.Interactor = Interactor;
            return View;
        }
    }
}
