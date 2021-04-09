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
    class Comment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Annotations { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int BugId { get; set; }
        public Bug Bug { get; set; }
    }
}
