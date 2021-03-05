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
		[ForeignKey("idCompetition")]
		public int idCompetition { get; set; }
        public string Name { get; set; }
		[ForeignKey("Name")]
        public DateTime OpenDate { get; set; } 
		public DateTime CloseDate { get; set; } 
		public Position Place { get; set; }
		[ForeignKey("TheStreet")]
		public City City { get; set; }
		[ForeignKey("Name")]
		
    }
}
