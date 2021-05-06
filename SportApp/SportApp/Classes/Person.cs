using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    public enum Sex { Male, Female }
    public enum personType { Admin, Organizator, Judge, Athlete, Normal}
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
        [StringLength(250)]
        public string Photo { get; set; }
        [StringLength(250)]
        public string Phone { get; set; }
        public string CityName { get; set; }
        public DateTime Birthday { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Sex Sex { get; set; }
        public personType Type { get; set; }

    }
}
