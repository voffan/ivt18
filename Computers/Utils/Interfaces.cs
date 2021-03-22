using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Utils
{
    public interface IFormOwner
    {
        object Receiver { set; }
    }

    public interface IFormDelegate
    {
        IFormOwner FormOwner { get; set; }
    }
}
