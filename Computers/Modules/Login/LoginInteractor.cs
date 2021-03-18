using Computers.Utils;
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
                Console.WriteLine("LOGIN SUCCESS");
            } else
            {
                Presenter.PresentAuthError(exception);
            }
        }
    }
}
