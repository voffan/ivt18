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
    public class CheckPoint
    {
        [Key]
        public int CheckPointId { get; set; }
        public String name { get; set; }

    }
}
