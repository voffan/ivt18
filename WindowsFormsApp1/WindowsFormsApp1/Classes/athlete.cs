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
    public class athlete
    {
        public string name { get; set; }
        public string email { get; set; } 
		public string sport { get; set; } //SportType?
		public string birthday { get; set; }
		public double height { get; set; }
		public double weight { get; set; }
		public string sex { get; set; }
		
    }
}
