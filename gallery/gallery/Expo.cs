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
    class Expo
    {           
        [Key]
        public int ExpoId { get; set; }
        
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Place { get; set; }

        [ForeignKey("PictureId")]
        public int PictureId { get; set; }
        public Picture Picture { get; set; }

    }
}
