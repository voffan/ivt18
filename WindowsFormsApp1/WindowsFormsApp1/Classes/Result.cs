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
    public class Result
    {
        public string sporttype { get; set; }
        public string category { get; set; } 
		public string points { get; set; } 
		public string place { get; set; } 
		
    }
}
