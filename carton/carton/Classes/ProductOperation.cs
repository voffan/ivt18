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
    public class ProductOperation
    {
        [Key]
        public int Id { get; set; }

        public virtual List<Product> Products { get; set; }
        public int Amount { get; set; }
        public int SourceId { get; set; }
        [ForeignKey("SourceId")]
        public Department Source { get; set; }

        public int DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public Department Destination { get; set; }

        public DateTime Date { get; set; }

        public virtual List<ProductPL> ProductionLine { get; set; }

        public virtual List<StoragePO> Storages { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
