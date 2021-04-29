using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("Person")]
    public class Person
    {
    	[Key]
    	public int Id { get; set; }
    	[StringLength(250)]
        public string Name { get; set; }
		[StringLength(250)]
        public string Email { get; set; } 
		[StringLength(250)]
        public string Login { get; set; }
		[StringLength(250)]
        public string Password { get; set; }
		
    }
}
