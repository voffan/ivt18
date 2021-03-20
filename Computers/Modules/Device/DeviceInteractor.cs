using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Device
{
    public interface IDeviceInteractor
    {
        IDevicePresenter Presenter { get; set; }
    }

    class DeviceInteractor : IDeviceInteractor
    {
        public IDevicePresenter Presenter { get; set; }
    }
}
