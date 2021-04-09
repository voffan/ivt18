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
    public class Result
    {
    	[Key]
        public int Id { get; set; }

        public int ParticipantId { get; set; }
		[ForeignKey("ParticipantId")]
		public Participant Participant { get; set; }

		public double Points { get; set; } 
		public int Place { get; set; } 

		//??????? подумать нужен ли????????
		//public int CompetitionId { get; set; }
		//[ForeignKey("CompetitionId")]
		//public Competition Competition { get; set; }
    }
}
