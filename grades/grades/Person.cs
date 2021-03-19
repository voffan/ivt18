using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public String FirstName { get; set; }
        public String SurName { get; set; }
        public String MiddleName { get; set; }
        public String PhoneNumber { get; set; }
        public String HomeAddress { get; set; }

        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
    }
}
