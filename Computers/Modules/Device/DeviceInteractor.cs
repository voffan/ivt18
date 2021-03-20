using Computers.Modules.Manufacturer;
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
        void AddManufacturer();
    }

    class DeviceInteractor : IDeviceInteractor, Utils.IFormOwner
    {
        public IDevicePresenter Presenter { get; set; }
        public object DelegateProperty 
        {
            set 
            {
                if (value is Models.Manufacturer manufacturer)
                {
                    Console.WriteLine(manufacturer.Name);
                }
            } 
        }

        public void AddManufacturer()
        {
            new ManufacturerBuilder()
                .Build(this)
                .Show();
        }
    }
}
