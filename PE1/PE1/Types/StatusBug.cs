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
    //enum

    //idшки у types
    class StatusBug
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
