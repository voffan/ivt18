using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core;


namespace bugtracking
{
    class Fix
    {
        [Foreign Key("Description")]
        public string Description { get; set; }
        public int Rank { get; set; }
        DateTime Date = DateTime.Now;
    }
}
