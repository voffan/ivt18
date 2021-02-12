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
    public class Employee
    {
        public string name { get; set; }
	[ForeignKey("name")]
        public string position { get; set; }
		public string e-mail { get; set; }
		public int phone { get; set; }
    }
}
