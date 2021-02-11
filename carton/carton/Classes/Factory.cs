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
        public string name { get; set; }
        public string address { get; set; }
        public string INN { get; set; }
        public string contact_phone { get; set; }

        public string[] prod_line_name { get; set; }
        [ForeignKey("prod_line_name")]
        public ProductionLine[] productionLines { get; set; }

        public string[] stor_name { get; set; }
        [ForeignKey("stor_name")]
        public Storage[] storages { get; set; }

        public string[] employeeNames { get; set; }
        [ForeignKey("employeeNames")]
        public Employee[] employees { get; set; }

        public string directorName { get; set; }
        [ForeignKey("directorName")]
        public Employee director { get; set; } //TO-DO delete?
    }
}
