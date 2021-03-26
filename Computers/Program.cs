using Computers.Models;
using Computers.Modules.Computer;
using Computers.Modules.Device;
using Computers.Modules.Home;
using Computers.Modules.Login;
using Computers.Modules.SingleFieldForm;
using Computers.Modules.Welcome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (Auth.Shared.SignedIn)
            {
                Router.Shared.CurrentForm = new HomeBuilder().Build();
            }
            else
            {
                Router.Shared.CurrentForm = new WelcomeBuilder().Build();
            }

#if DEBUG
            using (var context = new DatabaseContext())
            {
                var manufacturers = context.Manufacturers.FirstOrDefault();
                context.SaveChanges();
            }
            Router.Shared.CurrentForm = new ComputerBuilder().Build();
            // Router.Shared.CurrentForm = new ManufacturerBuilder().Build();
#endif
            Application.Run();
        }
    }
}
