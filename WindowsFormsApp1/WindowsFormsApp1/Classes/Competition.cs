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
<<<<<<< HEAD
		[ForeignKey("idCompetition")]
		public int idCompetition { get; set; }
=======
    	[Key]
    	public int Id { get; set; }
>>>>>>> c9302230136d6299da7c5f2bd9062090c11873eb
        public string Name { get; set; }
        public DateTime OpenDate { get; set; } 
		public DateTime CloseDate { get; set; } 
		[ForeignKey("TheStreet")]
		public Position Place { get; set; }
		public int CityId { get; set; }
		[ForeignKey("CityId")]
		public City City { get; set; }
		
    }
}
