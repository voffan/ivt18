using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Manufacturer
{
    public interface IManufacturerInteractor
    {
        IManufacturerPresenter Presenter { get; set; }
        Models.Manufacturer Manufacturer { get; set; }
        void SetName(string name);
        void AddManufacturer();
        void Cancel();
    }

    class ManufacturerInteractor : IManufacturerInteractor, Utils.IFormDelegate
    {
        public IManufacturerPresenter Presenter { get; set; }
        public Utils.IFormOwner FormOwner { get; set; }
        public Models.Manufacturer Manufacturer { get; set; }

        public ManufacturerInteractor(IManufacturerPresenter Presenter)
        {
            this.Presenter = Presenter;
            this.Manufacturer = new Models.Manufacturer();
        }

        public ManufacturerInteractor(IManufacturerPresenter Presenter, Utils.IFormOwner FormOwner)
        {
            this.Presenter = Presenter;
            this.Manufacturer = new Models.Manufacturer();
            this.FormOwner = FormOwner;
        }

        public ManufacturerInteractor(IManufacturerPresenter Presenter, Models.Manufacturer Manufacturer)
        {
            this.Presenter = Presenter;
            this.Manufacturer = Manufacturer;
        }

        public void AddManufacturer()
        {
            if (FormOwner != null)
            {
                FormOwner.DelegateProperty = Manufacturer;
            }
            Presenter.PresentClose();
        }

        public void SetName(string name)
        {
            Manufacturer.Name = name;
        }

        public void Cancel()
        {
            Presenter.PresentClose();
        }
    }
}
