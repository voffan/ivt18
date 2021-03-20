using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Device
{
    public interface IDevicePresenter
    {
        IDeviceView View { get; set; }
    }

    class DevicePresenter : IDevicePresenter
    {
        public IDeviceView View { get; set; }
    }
}
