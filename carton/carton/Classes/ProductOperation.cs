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

        public virtual List<ProductMovement> ProductMovements { get; set; }
        public int SourceId { get; set; }
        [ForeignKey("SourceId")]
        public Department Source { get; set; }

        public int DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public Department Destination { get; set; }

        public DateTime Date { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
