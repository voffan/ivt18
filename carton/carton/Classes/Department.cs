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
    public enum DepType { Storage, ProductionLine }

    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DepType Type { get; set; }

        public virtual List<ProductOperation> Sources { get; set; }
        public virtual List<ProductOperation> Destinations { get; set; }
    }
}
