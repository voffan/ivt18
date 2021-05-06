using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("Participant")]
    public class Participant
    {
    	[Key]
        public int Id { get; set; }
        
        public int CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public Competition Competition { get; set; }

        public int AthleteId { get; set; }
        [ForeignKey("AthleteId")]
        public Person Name { get; set; }

        public int? SportTypeId { get; set; }
        [ForeignKey("SportTypeId")]
        public SportType SportType { get; set; }

    	public int? SportCategoryId { get; set; }
        [ForeignKey("SportCategoryId")]
		public SportCategory Category { get; set; }
		
    }
}
