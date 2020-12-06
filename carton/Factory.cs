using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carton
{
    class Factory
    {
        private string name;
        private string address;
        private string INN;
        private string contact_phone;

        private ProductionLine[] productionLines;
        private Storage[] storages;
        private Employee[] employees;
        private Employee director; //TO-DO delete?
    }
}
