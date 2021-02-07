using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    public class Employee
    {
        public string full_name;
        public Position position;
        public Status status;
        public string contact_phone;
        public string address;
    }
}
