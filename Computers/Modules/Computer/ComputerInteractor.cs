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
        Models.Computer Computer { get; set; }
        void AddPowerSupply();
        void AddHardDrive();
        void AddMemory();
        void AddGraphicCard();
    }

    class ComputerInteractor : IComputerInteractor
    {
        public IComputerPresenter Presenter { get; set; }
        public Models.Computer Computer { get; set; }

        public void AddGraphicCard()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.GraphicCard, Computer)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddHardDrive()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.HardDrive, Computer)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddMemory()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.Memory, Computer)
                .ShowDialog(Presenter.View as Form);
        }

        public void AddPowerSupply()
        {
            new DeviceBuilder()
                .Build(Utils.DeviceType.PowerSupply, Computer)
                .ShowDialog(Presenter.View as Form);
        }
    }
}
