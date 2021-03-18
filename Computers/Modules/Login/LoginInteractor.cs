using Computers.Modules.Home;
using Computers.Modules.Welcome;
using Computers.Utils;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Login
{
    public interface ILoginInteractor
    {
        ILoginPresenter Presenter { get; set; }
        void Validate(string email, string password);
        Task Login(string email, string password);
        void NavigateBack();
    }

    public class LoginInteractor : ILoginInteractor
    {
        public ILoginPresenter Presenter { get; set; }

        void ILoginInteractor.Validate(string email, string password)
        {
            Presenter.PresentValidationError(email.IsValidEmail(), password.IsValidPassword());
        }
        async Task ILoginInteractor.Login(string email, string password)
        {
            var exception = await Auth.Shared.SignInAsync(email, password);
            if (exception == null)
            {
                if (Auth.Shared.SignedIn)
                {
                    Router.Shared.CurrentForm = new HomeBuilder().Build();
                }
                else
                {
                    var systemException = new FirebaseAuthException("", AuthErrorReason.SystemError);
                    Presenter.PresentAuthError(systemException);
                }
            }
            else
            {
                Presenter.PresentAuthError(exception);
            }
        }

        public void NavigateBack()
        {
            Router.Shared.CurrentForm = new WelcomeBuilder().Build();
        }
    }
}
