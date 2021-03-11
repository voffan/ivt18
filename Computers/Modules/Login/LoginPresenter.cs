using Computers.Modules.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules
{
    public interface ILoginPresenter
    {
        ILoginView View { get; set; }
    }
    public class LoginPresenter : ILoginPresenter
    {
        public ILoginView View { get; set; }
    }
}
