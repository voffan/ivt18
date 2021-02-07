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
    public class Plan
    {
        [Key]
        public string name { get; set; }
        public string date { get; set; }
        public string prodLineName { get; set; }
        [ForeignKey("name")]
        public Planned planned { get; set; }
        [ForeignKey("prodLineName")]
        public ProductionLine Production_line { get; set; }
    }
}
