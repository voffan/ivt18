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
    public enum PosType { Director, Economist, SysAdmin, StorageEmployee, Foreman }

    public class Position
    {
        [Key]
        public int Id { get; set; }
        public PosType Role { get; set; }
    }
}
