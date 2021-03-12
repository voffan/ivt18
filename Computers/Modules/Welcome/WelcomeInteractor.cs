using Computers.Modules.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Welcome
{
    public interface IWelcomeInteractor
    {
        IWelcomePresenter Presenter { get; set; }
        void NavigateToLoginView();
        void NavigateToRegisterView();
    }

    public class WelcomeInteractor : IWelcomeInteractor
    {
        public IWelcomePresenter Presenter { get; set; }

        void IWelcomeInteractor.NavigateToLoginView()
        {
            Router.Shared.CurrentForm = new LoginBuilder().Build();
        }

        void IWelcomeInteractor.NavigateToRegisterView()
        {
            // TODO: Переход к регистрации
        }
    }
}
