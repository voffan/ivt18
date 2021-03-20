using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Device
{
    class DeviceBuilder
    {
        // Форма создания девайса
        public Form Build(Utils.DeviceType deviceType)
        {
            var Presenter = new DevicePresenter();
            var Interactor = new DeviceInteractor();
            var View = new DeviceView(deviceType);

            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;

            return View;
        }

        // Форма создания девайса для компьютера
        public Form Build(Utils.DeviceType deviceType, Models.Computer computer)
        {
            var Presenter = new DevicePresenter();
            var Interactor = new DeviceInteractor();
            var View = new DeviceView(deviceType, computer);

            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;

            return View;
        }

        // Форма редактирования девайса
        public Form Build(Models.Device device)
        {
            var Presenter = new DevicePresenter();
            var Interactor = new DeviceInteractor();
            var View = new DeviceView(device);

            Presenter.View = View;
            Interactor.Presenter = Presenter;
            View.Interactor = Interactor;

            return View;
        }
    }
}
