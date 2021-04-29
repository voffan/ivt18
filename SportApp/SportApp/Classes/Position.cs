using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("Position")]
    public class Position
    {
    	[Key]
    	public int Id { get; set; }
        public string TheStreet { get; set; }
		
    }
}
