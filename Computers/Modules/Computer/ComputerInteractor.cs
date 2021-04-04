using Computers.Modules.Device;
using Computers.Modules.Employee;
using Computers.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Computer
{
    public interface IComputerInteractor
    {
        IComputerPresenter Presenter { get; set; }
        void SetName(string name);
        void SetIpAddress(string ipAddress);
        void AddEmployee();
        void AddProcessor();
        void AddMotherboard();
        void AddDiskDrive();
        void AddPowerSupply();
        void AddHardDrive();
        void AddMemory();
        void AddGraphicCard();
        void Configure();
        void Update();
        void Submit();
        void Cancel();
    }

    class ComputerInteractor : IComputerInteractor, Utils.IFormOwner, Utils.IFormDelegate
    {
        public IComputerPresenter Presenter { get; set; }        
        public IFormOwner FormOwner { get; set; }
        private Models.Computer Computer;

        private List<Models.Employee> Employees;
        private List<Models.Processor> Processors;
        private List<Models.Motherboard> Motherboards;
        private List<Models.DiskDrive> DiskDrives;
        private List<Models.PowerSupply> PowerSupplies;
        private List<Models.Memory> Memories;
        private List<Models.HardDrive> HardDrives;
        private List<Models.GraphicCard> GraphicCards;

        public ComputerInteractor(IComputerPresenter Presenter, IFormOwner FormOwner) : base()
        {
            this.Presenter = Presenter;
            this.FormOwner = FormOwner;
            this.Computer = new Models.Computer();
            Configure();
        }

        public async void Configure()
        {
            Employees = await DatabaseContext.Shared.GetEmployees();
            Processors = await DatabaseContext.Shared.GetProcessors();
            Motherboards = await DatabaseContext.Shared.GetMotherboards();
            DiskDrives = await DatabaseContext.Shared.GetDiskDrives();
            PowerSupplies = await DatabaseContext.Shared.GetPowerSupplies();
            Memories = await DatabaseContext.Shared.GetMemories();
            HardDrives = await DatabaseContext.Shared.GetHardDrives();
            GraphicCards = await DatabaseContext.Shared.GetGraphicCards();
            Presenter.PresentConfigure(Employees, Processors, Motherboards, DiskDrives, PowerSupplies, Memories, HardDrives, GraphicCards);
        }

        public async void Update()
        {
            Employees = await DatabaseContext.Shared.GetEmployees();
            Processors = await DatabaseContext.Shared.GetProcessors();
            Motherboards = await DatabaseContext.Shared.GetMotherboards();
            DiskDrives = await DatabaseContext.Shared.GetDiskDrives();
            PowerSupplies = await DatabaseContext.Shared.GetPowerSupplies();
            Memories = await DatabaseContext.Shared.GetMemories();
            HardDrives = await DatabaseContext.Shared.GetHardDrives();
            GraphicCards = await DatabaseContext.Shared.GetGraphicCards();
            Presenter.PresentUpdate(Employees, Processors, Motherboards, DiskDrives, PowerSupplies, Memories, HardDrives, GraphicCards);
        }

        public void SetName(string name)
        {
            Computer.Name = name;
        }

        public void SetIpAddress(string ipAddress)
        {
            Computer.Ip = ipAddress;
        }

        public void AddEmployee()
        {
            new EmployeeBuilder()
                .Build(this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddProcessor()
        {
            new DeviceBuilder()
                .Build(DeviceType.Processor, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddMotherboard()
        {
            new DeviceBuilder()
                .Build(DeviceType.Motherboard, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddDiskDrive()
        {
            new DeviceBuilder()
                .Build(DeviceType.DiskDrive, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddGraphicCard()
        {
            new DeviceBuilder()
                .Build(DeviceType.GraphicCard, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddHardDrive()
        {
            new DeviceBuilder()
                .Build(DeviceType.HardDrive, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddMemory()
        {
            new DeviceBuilder()
                .Build(DeviceType.Memory, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddPowerSupply()
        {
            new DeviceBuilder()
                .Build(DeviceType.PowerSupply, this)
                .ShowDialog(Presenter.View as Form);
        }

        public async void Submit()
        {
            if (FormOwner != null)
            {
                await DatabaseContext.Shared.AddComputer(Computer);
                FormOwner.Update();
            }
            Presenter.PresentClose();
        }

        public void Cancel()
        {
            Presenter.PresentClose();
        }
    }
}
