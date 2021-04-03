using Computers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Employee
{
    public interface IEmployeePresenter
    {
        IEmployeeView View { get; set; }
        void PresentClose();
    }

    class EmployeePresenter : IEmployeePresenter
    {
        public IEmployeeView View { get; set; }

        public EmployeePresenter(IEmployeeView View)
        {
            this.View = View;
        }
        public void PresentClose()
        {
            View.Close();
        }
    }
}
