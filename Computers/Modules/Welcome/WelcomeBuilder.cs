using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Welcome
{
    public class WelcomeBuilder
    {
        private readonly IWelcomePresenter WelcomePresenter;
        private readonly IWelcomeInteractor WelcomeInteractor;
        private readonly IWelcomeView WelcomeView;
        public WelcomeBuilder()
        {
            this.WelcomePresenter = new WelcomePresenter();
            this.WelcomeInteractor = new WelcomeInteractor();
            this.WelcomeView = new WelcomeView();
        }

        public Form Build()
        {
            WelcomeView.Interactor = WelcomeInteractor;
            WelcomeInteractor.Presenter = WelcomePresenter;
            WelcomePresenter.View = WelcomeView;
            return this.WelcomeView.Self;
        }
    }
}
