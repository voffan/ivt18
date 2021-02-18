using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PE1
{
    class Division
    {
        //id вместо Name
        [ForeignKey("Name")]
        public string Name { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public ICollection<Employee> Employees { get; set; }

        public ICollection<Bug> Bugs { get; set; }

        //Если много ко многим, то должен быть объединяющий класс
    }
}
