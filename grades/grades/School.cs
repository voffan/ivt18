using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades {

    public class School {
        [Key]
        public int SchoolId { get; set; }
        public String Name { get; set; }
        public String Adress { get; set; }
        public String Email { get; set; }
        public String Phonenumber { get; set; }

        public virtual List<Group> Group { get; set; }

        public virtual List<Staff> Staff { get; set; }

        public Staff Headteacher { get; set; }

        public int GradingSystemId { get; set; }
        [ForeignKey("GradingSystemId")]
        public GradingSystem GradingSystem { get; set; }
    }
}