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
       
        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }

        public int GalleryId { get; set; }
        [ForeignKey("GalleryId")]
        public Gallery Gallery { get; set; }
    }

}
