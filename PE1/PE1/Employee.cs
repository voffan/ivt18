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

        [ForeignKey("PositionId")]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [ForeignKey("StatusId")]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        [ForeignKey("LogId")]
        public int LogId { get; set; }
        public Log Log { get; set; }

        [ForeignKey("BugId")]
        public int BugId { get; set; }
        public Bug Bug { get; set; }

        [ForeignKey("FixId")]
        public int FixId { get; set; }
        public Fix Fix { get; set; }
    }
}
