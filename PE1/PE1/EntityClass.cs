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
    enum Status { ok, wrong }
    class EntityClass
    {
        public class TryClass
        {
            [Key]
            public int TryClassId { get; set; }
            public string Email { get; set; }
            //public string Address? { get; set; }
            public Status Status { get; set; }
            
            public ICollection<ChildClass> ChildClasses { get; set; }
            }

        public class ChildClass
        {
            [Key]
            public int ChildClassId { get; set; }
            public int TryClassId { get; set; }
            [ForeignKey("TryClassId")]
            public TryClass TryClass { get; set; }
        }
    }
}
