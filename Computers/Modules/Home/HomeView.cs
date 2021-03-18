using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomeView
    {
        IHomeInteractor Interactor { get; set; }
        void ShowPeripherals();
    }

    class HomeView : View, IHomeView
    {
        public IHomeInteractor Interactor { get; set; }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
        }

        public void ShowPeripherals()
        {
            throw new NotImplementedException();
        }
    }
}
