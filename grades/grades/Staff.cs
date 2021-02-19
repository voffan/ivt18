using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public String FullName { get; set; }


        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position{ get; set; }
      
        public String PhoneNumber { get; set; }
        public String HomeAddress { get; set; }

        public int? SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }
    }
}
