using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Computers.Modules.SingleFieldForm
{
    public interface ISingleFieldFormInteractor
    {
        ISingleFieldFormPresenter Presenter { get; set; }
        void SetText(string name);
        void Submit();
        void Cancel();
    }

    class SingleFieldFormInteractor : ISingleFieldFormInteractor, Utils.IFormDelegate
    {
        public ISingleFieldFormPresenter Presenter { get; set; }
        public Utils.IFormOwner FormOwner { get; set; }
        private Utils.SingleFieldFormType FormType;
        private string textFieldValue;

        public SingleFieldFormInteractor(ISingleFieldFormPresenter Presenter, Utils.IFormOwner FormOwner, Utils.SingleFieldFormType FormType)
        {
            this.Presenter = Presenter;
            this.FormType = FormType;
            this.FormOwner = FormOwner;            
            Presenter.PresentConfigure(FormType);
        }

        // Create and pass object to owner form, close this
        public async void Submit()
        {
            if (FormOwner != null)
            {
                switch (FormType)
                {
                    case Utils.SingleFieldFormType.Manufacturer:
                        var manufacturer = new Models.Manufacturer { Name = textFieldValue };
                        await DatabaseContext.Shared.AddManufacturer(manufacturer);
                        break;
                    case Utils.SingleFieldFormType.Status:
                        var status = new Models.Status { Name = textFieldValue };
                        await DatabaseContext.Shared.AddStatus(status);
                        break;
                    default:
                        break;
                }
                FormOwner.Update();
            }
            Presenter.PresentClose();
        }

        public void SetText(string name)
        {
            textFieldValue = name;
        }

        public void Cancel()
        {
            Presenter.PresentClose();
        }
    }
}
