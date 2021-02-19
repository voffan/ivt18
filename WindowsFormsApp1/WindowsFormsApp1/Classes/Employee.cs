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
        public string Name { get; set; }
		[ForeignKey("Name")]
        public string Position { get; set; }
		public string E-mail { get; set; }
		public int Phone { get; set; }
    }
}
