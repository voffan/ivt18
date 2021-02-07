using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    public class Factory
    {
        public string name;
        public string address;
        public string INN;
        public string contact_phone;

        public ProductionLine[] productionLines;
        public Storage[] storages;
        public Employee[] employees;
        public Employee director; //TO-DO delete?
    }
}
