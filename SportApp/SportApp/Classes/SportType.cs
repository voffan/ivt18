using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("SportType")]
    public class SportType
    {	
        [Key]
		public int Id { get; set; }
		[StringLength(250)]
        public string Name { get; set; }		
    }
}
