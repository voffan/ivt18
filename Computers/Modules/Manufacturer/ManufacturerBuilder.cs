using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Manufacturer
{
    class ManufacturerBuilder
    {
        public Form Build()
        {
            var Presenter = new ManufacturerPresenter();
            var Interactor = new ManufacturerInteractor(Presenter);
            var View = new ManufacturerView(Interactor);

            Presenter.View = View;

            return View;
        }

        public Form Build(Utils.IFormOwner FormOwner)
        {
            var Presenter = new ManufacturerPresenter();
            var Interactor = new ManufacturerInteractor(Presenter, FormOwner);
            var View = new ManufacturerView(Interactor);

            Presenter.View = View;

            return View;
        }
    }
}
