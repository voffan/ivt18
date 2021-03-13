using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    class ExpoLogic
    {
        static public bool ViewExpo(Label elem, int id, Context C)
        {
            var expo = C.Expos.Where(c => c.ExpoId == id).FirstOrDefault();

            elem.Text = expo.Name + "\nМесто проведения: " + expo.Place + "\nДата: " + expo.StartDate + "-" + expo.EndDate;

            return true;
        }
    }
}
