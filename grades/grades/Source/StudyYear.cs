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
    public class StudyYear
    {
        [Key]
        public int StudyYearId { get; set; }

        public DateTime FirstYear { get; set; }
        public DateTime SecondYear { get; set; }
    }
}
