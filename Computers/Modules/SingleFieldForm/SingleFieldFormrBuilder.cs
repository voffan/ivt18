using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.SingleFieldForm
{
    class SingleFieldFormrBuilder
    {
        public Form Build(Utils.IFormOwner FormOwner, Utils.SingleFieldFormType FormType)
        {
            var View = new SingleFieldFormView();
            var Presenter = new SingleFieldFormPresenter(View);
            var Interactor = new SingleFieldFormInteractor(Presenter, FormOwner, FormType);
            
            View.Interactor = Interactor;
            return View;
        }
    }
}
