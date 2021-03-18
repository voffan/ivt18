﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomePresenter
    {
        IHomeView View { get; set; }
        void PresentPeripherals();
    }

    class HomePresenter : IHomePresenter
    {
        public IHomeView View { get; set; }

        public void PresentPeripherals()
        {
            throw new NotImplementedException();
        }
    }
}
