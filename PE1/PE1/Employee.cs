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

        public Position Position { get; set; }

        public StatusEmployee Status { get; set; }

        public int LogId { get; set; }
        [ForeignKey("LogId")]
        public ICollection<Log> Logs { get; set; }

        public int BugId { get; set; }
        [ForeignKey("BugId")]
        public ICollection<Bug> Bugs { get; set; }

        public int FixId { get; set; }
        [ForeignKey("FixId")]
        public Fix Fix { get; set; }
    }
}
