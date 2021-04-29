using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
	public enum Sex { Male, Female }
	[Table("Athlete")]
	public class Athlete : Person
	{
		public int? SportTypeId { get; set; }
		[ForeignKey("SportTypeId")]
		public SportType Sport { get; set; }
		public DateTime Birthday { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
		public Sex Sex { get; set; }

	}
}
