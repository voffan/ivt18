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
    public class StoragePO
    {
        [Key]
        public int Id { get; set; }
        public int ProductOperationId { get; set; }
        [ForeignKey("ProductOperationId")]
        public virtual ProductOperation ProductOperation { get; set; }

        public int StorageId { get; set; }
        [ForeignKey("StorageId")]
        public virtual Storage ProductionLine { get; set; }
    }
}
