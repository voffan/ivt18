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
        private readonly ILoginPresenter LoginPresenter;
        private readonly ILoginInteractor LoginInteractor;
        private readonly ILoginView LoginView;
        public LoginBuilder()
        {
            this.LoginPresenter = new LoginPresenter();
            this.LoginInteractor = new LoginInteractor();
            this.LoginView = new LoginView();
        }

        public Form Build()
        {
            LoginView.Interactor = LoginInteractor;
            LoginInteractor.Presenter = LoginPresenter;
            LoginPresenter.View = LoginView;
            return this.LoginView.Self;
        }
    }
}
