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
    public class Picture
    {
        [Key]
        public int PictureId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Year { get; set; }

        public int ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }

        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre{ get; set; }

        public int PlaceId { get; set; }
        [ForeignKey("PlaceId")]
        public Place CurrentLocation { get; set; }

        public int GalleryId { get; set; }
        [ForeignKey("GalleryId")]
        public Gallery Gallery { get; set; }

        public virtual List<ExpoPicture> ExpoPictures { get; set; }

        public virtual List<Journal> Journal { get; set; }
    }
}
