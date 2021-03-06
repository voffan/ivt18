using Computers.Modules.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules
{
    interface ILoginPresenter
    {
        ILoginView View { get; set; }
    }
    sealed class LoginPresenter : ILoginPresenter
    {
        public ILoginView View { get; set; }
    }
}
