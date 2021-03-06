using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Login
{
    interface ILoginInteractor
    {
        ILoginPresenter Presenter { get; set; }
    }

    sealed class LoginInteractor : ILoginInteractor
    {
        public ILoginPresenter Presenter { get; set; }
    }
}
