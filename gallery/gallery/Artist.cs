using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace gallery
{
    class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string FullName{ get; set; }
        public DateTime BirthYear{ get; set; }
        public DateTime DeathYear { get; set; }
    }
}
