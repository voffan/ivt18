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
    //обычно делают в отдельной базе (txt)
    class Log
    {
        [Key]
        public int LogId { get; set; }

        public int ProcedureId { get; set; }
        [ForeignKey("ProcedureId")]
        public Procedure Procedure { get; set; }

        public int EmplyeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public int FixId { get; set; }
        [ForeignKey("FixId")]
        public Fix Fix { get; set; }

        public DateTime Date { get; set; }

    }
}
