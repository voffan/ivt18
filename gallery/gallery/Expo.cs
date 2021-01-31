using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace gallery
{
    class Expo
    {      
        public int ExpoId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("Place")]
        public int PlaceId { get; set; }
        public Place Place { get; set; }

        public ICollection<PictureId> Pictures { get; set; }
        public Gallery gallery { get; set; }
    }
}
