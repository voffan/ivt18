using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Classes
{
    [Table("City")]
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
