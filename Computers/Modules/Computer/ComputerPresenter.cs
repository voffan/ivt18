using Computers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Computer
{
    public interface IComputerPresenter
    {
        IComputerView View { get; set; }
        void PresentConfigure(
            List<Models.Employee> employees,
            List<Models.Processor> processors,
            List<Models.Motherboard> motherboards,
            List<Models.DiskDrive> diskDrives,            
            List<Models.PowerSupply> powerSupplies, 
            List<Models.Memory> memories,
            List<Models.HardDrive> hardDrives,
            List<Models.GraphicCard> graphicCards
        );
        void PresentUpdate(
            List<Models.Employee> employees,
            List<Models.Processor> processors,
            List<Models.Motherboard> motherboards,
            List<Models.DiskDrive> diskDrives,
            List<Models.PowerSupply> powerSupplies,
            List<Models.Memory> memories,
            List<Models.HardDrive> hardDrives,
            List<Models.GraphicCard> graphicCards
        );
        void PresentClose();
    }

    class ComputerPresenter : IComputerPresenter
    {
        public IComputerView View { get; set; }

        public ComputerPresenter(IComputerView view) : base()
        {
            View = view;
        }

        public void PresentConfigure(
            List<Models.Employee> employees,
            List<Models.Processor> processors,
            List<Models.Motherboard> motherboards,
            List<Models.DiskDrive> diskDrives,
            List<Models.PowerSupply> powerSupplies,
            List<Models.Memory> memories,
            List<Models.HardDrive> hardDrives,
            List<Models.GraphicCard> graphicCards
        ) {
            ComputerViewModel viewModel = new ComputerViewModel();
            foreach (var employee in employees)
            {
                viewModel.Employees.Add($"{employee.Name}, {employee.Room}", employee);
            }
            foreach (var processor in processors)
            {
                viewModel.Processors.Add($"{processor.Name}, {processor.Frequency}", processor);
            }
            foreach (var motherboard in motherboards)
            {
                viewModel.Motherboards.Add($"{motherboard.Name}", motherboard);
            }
            foreach (var diskDrive in diskDrives)
            {
                viewModel.DiskDrives.Add($"{diskDrive.Name}, {diskDrive.Model}", diskDrive);
            }
            foreach (var powerSupply in powerSupplies)
            {
                viewModel.PowerSupplies.Add($"{powerSupply.Name}, {powerSupply.Power}", powerSupply);
            }
            foreach (var memory in memories)
            {
                viewModel.Memories.Add($"{memory.Name}, {memory.Amount} ГБ", memory);
            }
            foreach (var hardDrive in hardDrives)
            {
                viewModel.HardDrives.Add($"{hardDrive.Name}, {hardDrive.Capacity} ГБ", hardDrive);
            }
            foreach (var graphicCard in graphicCards)
            {
                viewModel.GraphicCards.Add($"{graphicCard.Name}, {graphicCard.Value} V", graphicCard);
            }
            View.Configure(viewModel);
        }

        public void PresentUpdate(
            List<Models.Employee> employees,
            List<Models.Processor> processors,
            List<Models.Motherboard> motherboards,
            List<Models.DiskDrive> diskDrives,
            List<Models.PowerSupply> powerSupplies,
            List<Models.Memory> memories,
            List<Models.HardDrive> hardDrives,
            List<Models.GraphicCard> graphicCards
        ) {
            ComputerViewModel viewModel = new ComputerViewModel();
            foreach (var employee in employees)
            {
                viewModel.Employees.Add($"{employee.Name}, {employee.Room}", employee);
            }
            foreach (var processor in processors)
            {
                viewModel.Processors.Add($"{processor.Name}, {processor.Frequency}", processor);
            }
            foreach (var motherboard in motherboards)
            {
                viewModel.Motherboards.Add($"{motherboard.Name}", motherboard);
            }
            foreach (var diskDrive in diskDrives)
            {
                viewModel.DiskDrives.Add($"{diskDrive.Name}, {diskDrive.Model}", diskDrive);
            }
            foreach (var powerSupply in powerSupplies)
            {
                viewModel.PowerSupplies.Add($"{powerSupply.Name}, {powerSupply.Power}", powerSupply);
            }
            foreach (var memory in memories)
            {
                viewModel.Memories.Add($"{memory.Name}, {memory.Amount} ГБ", memory);
            }
            foreach (var hardDrive in hardDrives)
            {
                viewModel.HardDrives.Add($"{hardDrive.Name}, {hardDrive.Capacity} ГБ", hardDrive);
            }
            foreach (var graphicCard in graphicCards)
            {
                viewModel.GraphicCards.Add($"{graphicCard.Name}, {graphicCard.Value} V", graphicCard);
            }
            View.Update(viewModel);
        }

        public void PresentClose()
        {
            View.Close();
        }
    }
}
