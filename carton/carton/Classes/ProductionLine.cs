﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Data.Entity.Spatial;

namespace carton
{
    public class ProductionLine
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public int FactoryId { get; set; }
        [ForeignKey("FactoryId")]
        public Factory Factory { get; set; }

        public virtual List<Shift> Shifts { get; set; }
        public virtual List<ProductPL> ProductOperations { get; set; }
        public virtual List<Plan> Plans { get; set; }
    }
}
