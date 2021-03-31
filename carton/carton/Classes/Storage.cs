using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Data.Entity.Spatial;

namespace carton
{
    public class Storage : Department
    {
        public int? FactoryId { get; set; }
        [ForeignKey("FactoryId")]
        public Factory Factory { get; set; }

        public virtual List<ProductRemain> ProductRemain { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
