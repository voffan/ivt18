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
        void Login(string email, string password);
    }

    public class LoginInteractor : ILoginInteractor
    {
        public ILoginPresenter Presenter { get; set; }

        void ILoginInteractor.Validate(string email, string password)
        {
            // TODO: Проверка
        }
        void ILoginInteractor.Login(string email, string password)
        {
            // TODO: Авторизовать
        }
    }
}
