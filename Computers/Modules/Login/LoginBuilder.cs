using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Login
{
    public class LoginBuilder
    {
        public Form Build()
        {
            var Presenter = new LoginPresenter();
            var Interactor = new LoginInteractor();
            var View = new LoginView();
           
            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;
            
            return View;
        }
    }
}
