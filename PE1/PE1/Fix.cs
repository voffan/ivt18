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
    class Fix
    {
        [Key]
        public int FixId { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public DateTime Date { get; set; }

        public int BugId { get; set; }
        [ForeignKey("BugId")]
        public Bug Bug { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
