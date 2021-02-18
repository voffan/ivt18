﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string DepartmentName { get; set; }
        [ForeignKey("DepartmentName")]
        public Department Department { get; set; }

        public int ProductRemaining { get; set; }
        [ForeignKey("ProductRemaining")]
        public ProductRemain ProductRemain { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
