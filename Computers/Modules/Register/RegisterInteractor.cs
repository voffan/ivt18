using Computers.Modules.Home;
using Computers.Modules.Welcome;
using Computers.Utils;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Register
{
    public interface IRegisterInteractor
    {
        IRegisterPresenter Presenter { get; set; }
        void Validate(string email, string password);
        Task Register(string email, string password, string username);
        void NavigateBack();
    }
    class RegisterInteractor : IRegisterInteractor
    {
        public IRegisterPresenter Presenter { get; set; }

        public async Task Register(string email, string password, string username)
        {
            var exception = await Auth.Shared.RegisterAsync(email, password, username);
            if (exception == null)
            {
                if (Auth.Shared.SignedIn)
                {
                    Router.Shared.CurrentForm = new HomeBuilder().Build();
                } 
                else
                {
                    var systemException = new FirebaseAuthException("", AuthErrorReason.SystemError);
                    Presenter.PresentRegisterError(systemException);
                }
            } 
            else
            {
                Presenter.PresentRegisterError(exception);
            }
        }

        public void Validate(string email, string password)
        {
            Presenter.PresentValidationError(email.IsValidEmail(), password.IsValidPassword());
        }

        public void NavigateBack()
        {
            Router.Shared.CurrentForm = new WelcomeBuilder().Build();
        }
    }
}
