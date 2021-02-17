using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    public class Department
    {
        public string name { get; set; }
        //enum type
        public int type { get; set; } //0 - storage, 1 - production_line
    }
}
