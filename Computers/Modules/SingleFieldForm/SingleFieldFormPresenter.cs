using Computers.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.SingleFieldForm
{
    public interface ISingleFieldFormPresenter
    {
        ISingleFieldFormView View { get; set; }
        void PresentConfigure(Utils.SingleFieldFormType FormType);
        void PresentClose();
    }

    class SingleFieldFormPresenter : ISingleFieldFormPresenter
    {
        public ISingleFieldFormView View { get; set; }

        public SingleFieldFormPresenter(ISingleFieldFormView View) : base()
        {
            this.View = View;
        }

        public void PresentClose()
        {
            View.Close();
        }

        public void PresentConfigure(SingleFieldFormType FormType)
        {
            View.Configure(FormType);
        }
    }
}
