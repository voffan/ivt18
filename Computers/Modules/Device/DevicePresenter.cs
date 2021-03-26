using Computers.Models;
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
        void PresentConfigure(List<Models.Manufacturer> manufacturers, List<Models.Status> statuses, Utils.DeviceType deviceType);
        void PresentUpdate(List<Models.Manufacturer> manufacturers, List<Models.Status> statuses);
    }

    class DevicePresenter : IDevicePresenter
    {
        public IDeviceView View { get; set; }

        public DevicePresenter(IDeviceView View)
        {
            this.View = View;
        }

        public void PresentConfigure(List<Manufacturer> manufacturers, List<Status> statuses, Utils.DeviceType deviceType)
        {
            DeviceViewModel viewModel = new DeviceViewModel();

            viewModel.deviceType = deviceType;

            foreach (var manufacturer in manufacturers)
            {
                viewModel.manufacturers.Add(manufacturer.Name, manufacturer);
            }
            foreach (var status in statuses)
            {
                viewModel.statuses.Add(status.Name, status);
            }

            View.Configure(viewModel);
        }

        public void PresentUpdate(List<Manufacturer> manufacturers, List<Status> statuses)
        {
            DeviceViewModel viewModel = new DeviceViewModel();
            foreach (var manufacturer in manufacturers)
            {
                viewModel.manufacturers.Add(manufacturer.Name, manufacturer);
            }
            foreach (var status in statuses)
            {
                viewModel.statuses.Add(status.Name, status);
            }
            View.Update(viewModel);
        }
    }
}
