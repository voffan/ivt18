using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
	[Table("Result")]
	public class Result
    {
    	[Key]
        public int Id { get; set; }

        public int ParticipantId { get; set; }
		[ForeignKey("ParticipantId")]
		public Participant Participant { get; set; }

		public double Points { get; set; } 
		public int Place { get; set; } 
    }
}
