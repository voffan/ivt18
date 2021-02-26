using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PE1
{
    class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }

        public int PositionEmployeeId { get; set; }
        [ForeignKey("PositionEmployeeId")]
        public PositionEmployee PositionEmployee { get; set; }

        public int StatusEmployeeId { get; set; }
        [ForeignKey("StatusEmployeeId")]
        public StatusEmployee StatusEmployee { get; set; }

        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Bug> Bugs { get; set; }
        public virtual ICollection<Fix> Fixes { get; set; }
    }
}
