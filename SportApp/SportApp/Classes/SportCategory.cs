using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("SportCategory")]
    public class SportCategory
    {
		[Key]
		public int SportCategoryID { get; set; }
        public string Name { get; set; }
        //???public string Position { get; set; } 
		public string Regulation { get; set; }
		
		public int SportTypeId { get; set; }
        [ForeignKey("SportTypeId")]
        public SportType SportType { get; set; }
    }
}
