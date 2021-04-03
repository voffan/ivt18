using Computers.Modules.SingleFieldForm;
using Computers.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Employee
{
    public interface IEmployeeInteractor
    {
        IEmployeePresenter Presenter { get; set; }
        void SetSurname(string surname);
        void SetName(string name);
        void SetPatronymicName(string patronymicName);
        void SetRoom(string room);
        void Submit();
        void Cancel();
    }

    public class EmployeeInteractor : IEmployeeInteractor, Utils.IFormDelegate
    {
        public IEmployeePresenter Presenter { get; set; }    
        public IFormOwner FormOwner { get; set; }
        private Models.Employee Employee;

        public EmployeeInteractor(IEmployeePresenter Presenter, Utils.IFormOwner FormOwner) : base()
        {
            this.Presenter = Presenter;
            this.FormOwner = FormOwner;
            this.Employee = new Models.Employee();
        }

        public void Cancel()
        {
            Presenter.PresentClose();
        }

        public async void Submit()
        {
            if (FormOwner != null)
            {
                await DatabaseContext.Shared.AddEmployee(Employee);
                FormOwner.Update();
            }
            Presenter.PresentClose();
        }

        public void SetSurname(string surname)
        {
            Employee.Surname = surname;
        }

        public void SetName(string name)
        {
            Employee.Name = name;
        }

        public void SetPatronymicName(string patronymicName)
        {
            Employee.PatronymicName = patronymicName;
        }

        public void SetRoom(string room)
        {
            Employee.Room = room;
        }
    }
}
