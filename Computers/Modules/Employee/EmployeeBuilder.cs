using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Employee
{
    class EmployeeBuilder
    {
        // Форма создания девайса для компьютера
        public Form Build(Utils.IFormOwner FormOwner)
        {
            var View = new EmployeeView();
            var Presenter = new EmployeePresenter(View);
            var Interactor = new EmployeeInteractor(Presenter, FormOwner);
            
            View.Interactor = Interactor;
            return View;
        }
    }
}
