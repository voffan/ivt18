﻿using Computers.Models;
using Computers.Modules.Computer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Home
{
    public interface IHomeInteractor
    {
        IHomePresenter Presenter { get; set; }
        Task LoadPeripherals();
        void AddComputer();
    }

    class HomeInteractor : IHomeInteractor
    {
        public IHomePresenter Presenter { get; set; }        

        public async Task LoadPeripherals()
        {
            Console.WriteLine("Context start");
            using (var context = new DatabaseContext())
            {
                List<Peripheral> peripherals = context.Peripherals.ToList();
                context.SaveChanges();
                Console.WriteLine("Context end");
                Presenter.PresentPeripherals(peripherals);
            }
        }

        public void AddComputer()
        {
            Router.Shared.CurrentForm = new ComputerBuilder().Build();
        }
    }
}
