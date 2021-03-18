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
                    Console.WriteLine("REGISTER SUCCESS");
                } 
                else
                {
                    var systemError = new FirebaseAuthException("", AuthErrorReason.SystemError);
                    Presenter.PresentRegisterError(systemError);
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
    }
}
