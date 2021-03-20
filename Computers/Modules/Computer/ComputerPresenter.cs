using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Computer
{
    public interface IComputerPresenter
    {
        IComputerView View { get; set; }
    }

    class ComputerPresenter : IComputerPresenter
    {
        public IComputerView View { get; set; }
    }
}
