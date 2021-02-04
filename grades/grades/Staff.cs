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
        public String fullname;
        public String role;
        public int phonenumber;
        public String homeadress;
    }
}
