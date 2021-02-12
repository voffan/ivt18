using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public class SportCategory
    {
        public string name { get; set; }
        public string position { get; set; } 
		public string regulation { get; set; }
		
    }
}
