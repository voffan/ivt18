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
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }

        public string ContactPhone { get; set; }
        public string Address { get; set; }

        public int? StorageId { get; set; }
        [ForeignKey("StorageId")]
        public Storage Storage { get; set; } = null!;

        public int? FactoryId { get; set; }
        [ForeignKey("FactoryId")]
        public Factory Factory { get; set; } = null!;

        public int? FactoryDirectorId { get; set; }
        [ForeignKey("FactoryDirectorId")]
        public virtual Factory Director { get; set; } = null!;

        public virtual List<ProductOperation> ProductOperations { get; set; } = null!;
        public virtual List<Shift> Shifts { get; set; } = null!;
    }
}
