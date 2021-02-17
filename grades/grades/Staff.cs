﻿using System;
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
        public String Fullname { get; set; }


        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position{ get; set; }
      
        public String Phonenumber { get; set; }
        public String Homeadress { get; set; }

        public School School { get; set; }
    }
}
