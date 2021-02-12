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
    public class Competition
    {
        public string name { get; set; }
        public string openDate { get; set; } 
		public string closeDate { get; set; } 
		public string place { get; set; }
		public string city { get; set; }
		
    }
}
