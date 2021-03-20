using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Computer
{
    class ComputerBuilder
    {
        public Form Build()
        {
            var Presenter = new ComputerPresenter();
            var Interactor = new ComputerInteractor();
            var View = new ComputerView(Interactor);

            Presenter.View = View;
            Interactor.Presenter = Presenter;

            return View;
        }
    }
}
