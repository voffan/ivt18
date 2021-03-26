using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Utils
{
    public interface IFormOwner
    {
        void Update();
    }

    public interface IFormDelegate
    {
        IFormOwner FormOwner { get; set; }
    }
}
