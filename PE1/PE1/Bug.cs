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
    public enum BugStatus {New, Closed}
    class Bug
    {
        [Key]
        public int BugId { get; set; }
        public BugType BugType { get; set; }
        public string Description { get; set; }
        public DateTime LastFixedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public StatusBug Status { get; set; }

        public virtual ICollection<Fix> Fixes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public int EmplyeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        

    }
}
