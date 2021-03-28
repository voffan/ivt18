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
            var View = new ComputerView();
            var Presenter = new ComputerPresenter(View);
            var Interactor = new ComputerInteractor(Presenter);

            View.Interactor = Interactor;
            return View;
        }
    }
}
