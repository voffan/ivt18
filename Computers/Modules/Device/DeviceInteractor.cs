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

        public void Submit()
        {
            if (FormOwner != null)
            {
                using (var context = new DatabaseContext())
                {
                    context.Manufacturers.Attach(Device.Manufacturer);
                    context.Statuses.Attach(Device.Status);
                    switch (DeviceType)
                    {
                        case DeviceType.None:
                            break;
                        case DeviceType.Processor:
                            context.Processors.Add(Device as Models.Processor);
                            break;
                        case DeviceType.GraphicCard:
                            context.GraphicCards.Add(Device as Models.GraphicCard);
                            break;
                        case DeviceType.HardDrive:
                            context.HardDrives.Add(Device as Models.HardDrive);
                            break;
                        case DeviceType.Motherboard:
                            context.Motherboards.Add(Device as Models.Motherboard);
                            break;
                        case DeviceType.Memory:
                            context.Memories.Add(Device as Models.Memory);
                            break;
                        case DeviceType.PowerSupply:
                            context.PowerSupplies.Add(Device as Models.PowerSupply);
                            break;
                    }
                    context.SaveChanges();
                }
                FormOwner.Update();
            }
            Presenter.PresentClose();
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
                    (Device as Models.Memory).Amount = number;
                    break;
                case DeviceType.PowerSupply:
                    (Device as Models.PowerSupply).Power = number;
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
                case DeviceType.GraphicCard:
                    (Device as Models.GraphicCard).Value = text;
                    break;
                default: 
                    break;
            }
        }
    }
}
