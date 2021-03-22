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
        void Configure(Utils.DeviceType DeviceType);
        void AddManufacturer();
        void AddStatus();
        void SubmitDevice();
        void Cancel();
    }

    class DeviceInteractor : IDeviceInteractor, Utils.IFormOwner
    {
        public IDevicePresenter Presenter { get; set; }
        private Utils.IFormOwner FormOwner;
        public object Receiver 
        {
            set 
            {
                if (value is Models.Manufacturer newManufacturer)
                {
                    // TODO: Присвоить девайсу нового производителя
                    Console.WriteLine(newManufacturer.Name);
                }
                if (value is Models.Status newStatus)
                {
                    // TODO: Присвоить девайсу новый статус
                    Console.WriteLine(newStatus.Name);
                }
            } 
        }

        public DeviceInteractor(IDevicePresenter Presenter, Utils.IFormOwner FormOwner, Utils.DeviceType DeviceType) : base()
        {
            this.Presenter = Presenter;
            this.FormOwner = FormOwner;
            Configure(DeviceType);
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

        public void SubmitDevice()
        {
            throw new NotImplementedException();
        }

        public void Configure(DeviceType deviceType)
        {
            List<Models.Manufacturer> manufacturers = new List<Models.Manufacturer>
            {
                new Models.Manufacturer { Id = 1, Name = "Производитель №1" },
                new Models.Manufacturer { Id = 2, Name = "Производитель №2" },
                new Models.Manufacturer { Id = 3, Name = "Производитель №3" },
                new Models.Manufacturer { Id = 4, Name = "Производитель №4" },
                new Models.Manufacturer { Id = 5, Name = "Производитель №5" },
                new Models.Manufacturer { Id = 6, Name = "Производитель №6" }
            };

            List<Models.Status> statuses = new List<Models.Status>
            {
                new Models.Status { Id = 1, Name = "Работает" },
                new Models.Status { Id = 2, Name = "На обслуживании" },
                new Models.Status { Id = 3, Name = "Списан" }
            };
            Presenter.PresentConfigure(manufacturers, statuses, deviceType);
        }
    }
}
