using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core;

namespace gallery
{
    public class Expo
    {           
        [Key]
        public int ExpoId { get; set; }
        
        public string Name { get; set; }
        [Column(TypeName="datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        public string Address { get; set; }

        public virtual List<ExpoPicture> ExpoPictures { get; set; }

    }
}
