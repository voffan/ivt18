using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1
{
    class BugType
    {
        [Key]
        public int Id { get; set; }
        public string bugType { get; set; }
    }
}
