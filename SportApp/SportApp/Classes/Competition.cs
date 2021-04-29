using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
	[Table("Competition")]
	public class Competition
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime OpenDate { get; set; }
		public DateTime CloseDate { get; set; }
		public int PositionId { get; set; }
		[ForeignKey("PositionId")]
		public Position Place { get; set; }
		public int CityId { get; set; }
		[ForeignKey("CityId")]
		public City City { get; set; }

	}
}
