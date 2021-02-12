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
	public enum Sex { Male, Female }
    public class Athlete: Person
    {
        public int SportTypeId { get; set; }
		[ForeignKey("SportTypeId")]
		public SportType Sport { get; set; } //SportType?
		public DateTime Birthday { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
		public Sex Sex { get; set; }
		
    }
}
