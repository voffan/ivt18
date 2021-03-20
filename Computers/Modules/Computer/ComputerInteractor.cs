using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Computer
{
    public interface IComputerInteractor
    {
        IComputerPresenter Presenter { get; set; }
    }

    class ComputerInteractor : IComputerInteractor
    {
        public IComputerPresenter Presenter { get; set; }
    }
}
