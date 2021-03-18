using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Register
{
    class RegisterBuilder
    {
        public Form Build()
        {
            var Presenter = new RegisterPresenter();
            var Interactor = new RegisterInteractor();
            var View = new RegisterView();

            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;

            return View;
        }
    }
}
