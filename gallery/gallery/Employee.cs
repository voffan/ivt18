using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core;

namespace gallery
{
    class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }

        [ForeignKey ("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        public Gallery gallery { get; set; }
    }

}
