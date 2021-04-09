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
    class Bug
    {
        [Key]
        public int BugId { get; set; }
        public int BugTypeId { get; set; }
        public BugType BugType { get; set; }
        public string Description { get; set; }
        public DateTime LastFixedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int StatusBugId { get; set; }
        public StatusBug Status { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }

        public virtual ICollection<Fix> Fixes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        

    }
}
