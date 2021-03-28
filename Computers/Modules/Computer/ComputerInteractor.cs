using Computers.Modules.Device;
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
    }

    class ComputerInteractor : IComputerInteractor, Utils.IFormOwner
    {
        public IComputerPresenter Presenter { get; set; }
        private Models.Computer Computer { get; set; }
        private List<Models.Employee> Employees;
        private List<Models.Processor> Processors;
        private List<Models.Motherboard> Motherboards;
        private List<Models.DiskDrive> DiskDrives;
        private List<Models.PowerSupply> PowerSupplies;
        private List<Models.Memory> Memories;
        private List<Models.HardDrive> HardDrives;
        private List<Models.GraphicCard> GraphicCards;

        public ComputerInteractor(IComputerPresenter presenter) : base()
        {
            Presenter = presenter;
            Computer = new Models.Computer();
            Configure();
        }

        public void Configure()
        {
            using (var context = new DatabaseContext())
            {
                Employees = context.Employees.ToList();
                Processors = context.Processors.ToList();
                Motherboards = context.Motherboards.ToList();
                DiskDrives = context.DiskDrives.ToList();
                PowerSupplies = context.PowerSupplies.ToList();
                Memories = context.Memories.ToList();
                HardDrives = context.HardDrives.ToList();
                GraphicCards = context.GraphicCards.ToList();
                Presenter.PresentConfigure(Employees, Processors, Motherboards, DiskDrives, PowerSupplies, Memories, HardDrives, GraphicCards);
            }
        }

        public void Update()
        {
            using (var context = new DatabaseContext())
            {
                Employees = context.Employees.ToList();
                Processors = context.Processors.ToList();
                Motherboards = context.Motherboards.ToList();
                DiskDrives = context.DiskDrives.ToList();
                PowerSupplies = context.PowerSupplies.ToList();
                Memories = context.Memories.ToList();
                HardDrives = context.HardDrives.ToList();
                GraphicCards = context.GraphicCards.ToList();
                Presenter.PresentUpdate(Employees, Processors, Motherboards, DiskDrives, PowerSupplies, Memories, HardDrives, GraphicCards);
            }
        }

        public void AddEmployee()
        {
            throw new NotImplementedException();
        }

        public void AddProcessor()
        {
            throw new NotImplementedException();
        }

        public void AddMotherboard()
        {
            throw new NotImplementedException();
        }

        public void AddDiskDrive()
        {
            throw new NotImplementedException();
        }

        public void AddGraphicCard()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.GraphicCard, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddHardDrive()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.HardDrive, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddMemory()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.Memory, this)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddPowerSupply()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.PowerSupply, this)
                .ShowDialog(Presenter.View as Form);
        }        
    }
}
