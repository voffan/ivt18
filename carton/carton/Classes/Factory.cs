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
    public class Factory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string ContactPhone { get; set; }

        public virtual List<Storage> Storages { get; set; }

        public virtual List<Employee> Employees { get; set; }
#nullable enable
        public Nullable<int> DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Employee Director { get; set; } = null!;
#nullable disable
    }
}
