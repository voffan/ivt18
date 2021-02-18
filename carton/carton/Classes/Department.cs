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
    public enum DepType { Storage, ProductionLine }

    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DepType Type { get; set; }
    }
}
