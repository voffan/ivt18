using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
   public class Position
    {
        [Key]
        public string Role { get; set; }

  //      public Staff Staff { get; set; }  ?
    }
}
