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
    class Log
    {
        [Key]
        public int LogId { get; set; }
        public String Procedure { get; set; }
        public String User { get; set; }
        public String Fixes { get; set; }
        public String DescriptionOfFix { get; set; }
        public DateTime Date { get; set; }
    }
