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
        // Форма создания девайса для компьютера
        public Form Build(Utils.DeviceType deviceType, Utils.IFormOwner FormOwner)
        {
            var View = new DeviceView();
            var Presenter = new DevicePresenter(View);
            var Interactor = new DeviceInteractor(Presenter, FormOwner, deviceType);
            
            View.Interactor = Interactor;
            return View;
        }
    }
}
