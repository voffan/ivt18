using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gallery
{
    public class ExpoPicture
    {
        [Key]
        public int ExpoPictureId { get; set; }

        public int PictureId { get; set; }
        [ForeignKey("PictureId")]
        public Picture Picture { get; set; }

        public int ExpoId { get; set; }
        [ForeignKey("ExpoId")]
        public Expo Expo { get; set; }
    }
}
