using Computers.Models;
using Computers.Modules.Login;
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
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new DatabaseContext())
            {
                //var status1 = new Status() { Name = "Работает" };
                //context.Statuses.Add(status1);
                context.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginBuilder().Build());
        }
    }
}
