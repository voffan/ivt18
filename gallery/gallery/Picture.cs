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
    class Picture
    {
        [Key]
        public int PictureId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Year { get; set; }

        [ForeignKey("ArtistId")]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        [ForeignKey("GenreId")]
        public int GenreId { get; set; }
        public Genre Genre{ get; set; }

        [ForeignKey("PlaceId")]
        public int PlaceId { get; set; }
        public Place Place { get; set; }
    }
}
