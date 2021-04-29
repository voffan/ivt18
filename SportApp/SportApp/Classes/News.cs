using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("News")]
    public class News
    {	
    	[Key]
        public int Id { get; set; }
    	[StringLength(250)]
        public string Heading { get; set; }
        public string Description { get; set; } 
		public DateTime Date { get; set; } 
		
    }
}
