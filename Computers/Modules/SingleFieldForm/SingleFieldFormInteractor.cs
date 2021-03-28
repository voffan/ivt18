using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Submit()
        {
            if (FormOwner != null)
            {
                using (var context = new DatabaseContext())
                {
                    switch (FormType)
                    {
                        case Utils.SingleFieldFormType.Manufacturer:
                            Models.Manufacturer manufacturer = new Models.Manufacturer { Name = textFieldValue };
                            context.Manufacturers.Add(manufacturer);
                            break;
                        case Utils.SingleFieldFormType.PeripheralType:
                            Models.PeripheralType peripheralType = new Models.PeripheralType { Name = textFieldValue };
                            context.PeripheralTypes.Add(peripheralType);
                            break;
                        case Utils.SingleFieldFormType.Status:
                            Models.Status status = new Models.Status { Name = textFieldValue };
                            context.Statuses.Add(status);
                            break;
                        default:
                            break;
                    }
                    context.SaveChanges();
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
