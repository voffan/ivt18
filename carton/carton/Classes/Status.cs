using System;
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
    public enum StatusType { Working, Absent}

    public class Status
    {
        [Key]
        public int Id { get; set; }
        public StatusType Attendance { get; set; }
    }
}
