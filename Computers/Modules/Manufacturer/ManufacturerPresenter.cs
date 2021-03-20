using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Manufacturer
{
    public interface IManufacturerPresenter
    {
        IManufacturerView View { get; set; }
        void PresentClose();
    }

    class ManufacturerPresenter : IManufacturerPresenter
    {
        public IManufacturerView View { get; set; }

        public void PresentClose()
        {
            View.Close();
        }
    }
}
