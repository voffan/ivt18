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
    class Division
    {
        [Foreign Key("Name")]
        public string Name { get; set; }
    }
}
