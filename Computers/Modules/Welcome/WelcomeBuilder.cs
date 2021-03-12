using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Welcome
{
    public class WelcomeBuilder
    {
        public Form Build()
        {
            var Presenter = new WelcomePresenter();
            var Interactor = new WelcomeInteractor();
            var View = new WelcomeView();

            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;

            return View;
        }
    }
}
