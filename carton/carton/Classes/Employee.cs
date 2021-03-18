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
        public Storage Storage { get; set; }

        //2 links?
        public int? FactoryId { get; set; }
        [ForeignKey("FactoryId")]
        public Factory Factory { get; set; }

        //public virtual List<Factory> Factory { get; set; }

        // nullable reference type fix
        public virtual List<ProductOperation> ProductOperations { get; set; }
        public virtual List<Shift> Shifts { get; set; }


    }
}
