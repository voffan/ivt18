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
        void SetName(string name);
        void SelectManufacturer(int index);
        void SelectStatus(int index);
        void SetPrice(int price);
        void SetOptionalNumber(int number);
        void SetOptionalText(string text);
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
            switch (DeviceType)
            {
                case DeviceType.None:
                    Device = new Models.Device();
                    break;
                case DeviceType.Processor:
                    Device = new Models.Processor();
                    break;
                case DeviceType.GraphicCard:
                    Device = new Models.GraphicCard();
                    break;
                case DeviceType.HardDrive:
                    Device = new Models.HardDrive();
                    break;
                case DeviceType.Motherboard:
                    Device = new Models.Motherboard();
                    break;
                case DeviceType.Memory:
                    Device = new Models.Memory();
                    break;
                case DeviceType.PowerSupply:
                    Device = new Models.PowerSupply();
                    break;
            }
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
            Presenter.PresentClose();
        }

        public async void Submit()
        {
            if (FormOwner != null)
            {
                await DatabaseContext.Shared.AddDevice(Device, DeviceType);
                FormOwner.Update();
            }
            Presenter.PresentClose();
        }

        public async void Configure()
        {
            Manufacturers = await DatabaseContext.Shared.GetManufacturers();
            Statuses = await DatabaseContext.Shared.GetStatuses();
            Presenter.PresentConfigure(Manufacturers, Statuses, DeviceType);
        }

        public async void Update()
        {
            Manufacturers = await DatabaseContext.Shared.GetManufacturers();
            Statuses = await DatabaseContext.Shared.GetStatuses();
            Presenter.PresentUpdate(Manufacturers, Statuses);
        }

        public void SelectManufacturer(int index)
        {
            Device.ManufacturerId = Manufacturers.ElementAt(index).Id;
        }

        public void SelectStatus(int index)
        {
            Device.StatusId = Statuses.ElementAt(index).Id;
        }

        public void SetName(string name)
        {
            // TODO: Валидация имени
            Device.Name = name;
        }

        public void SetPrice(int price)
        {
            Device.Price = price;
        }

        public void SetOptionalNumber(int number)
        {
            // TODO: Валидация дополнительных полей
            switch (DeviceType)
            {
                case DeviceType.HardDrive:
                    (Device as Models.HardDrive).Capacity = number;
                    break;
                case DeviceType.Memory:
                    (Device as Models.Memory).Capacity = number;
                    break;
                case DeviceType.PowerSupply:
                    (Device as Models.PowerSupply).Power = number;
                    break;
                case DeviceType.GraphicCard:
                    (Device as Models.GraphicCard).Capacity = number;
                    break;
                default:
                    break;
            }
        }

        public void SetOptionalText(string text)
        {
            // TODO: Валидация дополнительных полей
            switch (DeviceType)
            {
                case DeviceType.Processor:
                    (Device as Models.Processor).Frequency = text;
                    break;
                default: 
                    break;
            }
        }
    }
}
