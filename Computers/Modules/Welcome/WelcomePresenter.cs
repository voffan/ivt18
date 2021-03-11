using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Welcome
{
    public interface IWelcomePresenter
    {
        IWelcomeView View { get; set; }
    }
    public class WelcomePresenter : IWelcomePresenter
    {
        public IWelcomeView View { get; set; }
    }
}
