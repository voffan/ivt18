using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Utils
{
    public enum WindowMode
    {
        Create,
        CreateWithAssign,
        Edit
    }

    public enum DeviceType
    {
        None,
        Processor,
        GraphicCard,
        HardDrive,
        Motherboard,
        Memory,
        PowerSupply
    }
}
