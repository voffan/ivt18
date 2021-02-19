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
    public class News
    {
        public string Heading { get; set; }
        public string Description { get; set; } 
		public DateTime Date { get; set; } 
		
    }
}
