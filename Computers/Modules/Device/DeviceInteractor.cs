using Computers.Modules.SingleFieldForm;
using Computers.Utils;
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
        DeviceType DeviceType { get; set; }
        void Configure();
        void AddManufacturer();
        void AddStatus();
        void SelectManufacturer(int index);
        void SelectStatus(int index);
        void Submit();
        void Cancel();
    }

    public class DeviceInteractor : IDeviceInteractor, Utils.IFormOwner
    {
        public IDevicePresenter Presenter { get; set; }
        public DeviceType DeviceType { get; set; }

        private Models.Device Device;
        private List<Models.Manufacturer> Manufacturers;
        private List<Models.Status> Statuses;
        private Utils.IFormOwner FormOwner;

        public DeviceInteractor(IDevicePresenter Presenter, Utils.IFormOwner FormOwner, Utils.DeviceType DeviceType) : base()
        {
            this.Presenter = Presenter;
            this.FormOwner = FormOwner;
            this.DeviceType = DeviceType;
            this.Device = new Models.Device();
            Configure();
        }

        public void AddManufacturer()
        {
            new SingleFieldFormrBuilder()
                .Build(this, Utils.SingleFieldFormType.Manufacturer)
                .Show();
        }

        public void AddStatus()
        {
            new SingleFieldFormrBuilder()
                .Build(this, Utils.SingleFieldFormType.Status)
                .Show();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            
        }

        public void Configure()
        {
            using (var context = new DatabaseContext())
            {
                Manufacturers = context.Manufacturers.ToList();
                Statuses = context.Statuses.ToList();
                Presenter.PresentConfigure(Manufacturers, Statuses, DeviceType);
            }
        }

        public void Update()
        {
            using (var context = new DatabaseContext())
            {
                Manufacturers = context.Manufacturers.ToList();
                Statuses = context.Statuses.ToList();
                Presenter.PresentUpdate(Manufacturers, Statuses);
            }
        }

        public void SelectManufacturer(int index)
        {
            Device.Manufacturer = Manufacturers.ElementAt(index);
            Console.WriteLine("Manufacturer");
            Console.WriteLine(Device.Manufacturer.Name);
        }

        public void SelectStatus(int index)
        {
            Device.Status = Statuses.ElementAt(index);
            Console.WriteLine("Status");
            Console.WriteLine(Device.Status.Name);
        }
    }
}
