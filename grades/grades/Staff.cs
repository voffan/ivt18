using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades
{
    public class Staff
    {
        [Key]
        public int staffId { get; set; }
        public String fullname { get; set; }
        public String role { get; set; }
        public String phonenumber { get; set; }
        public String homeadress { get; set; }

        public Student student { get; set; }
    }
}
