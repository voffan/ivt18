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
        public int PictureId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Year { get; set; }

        public Artist Artist { get; set; }
        public Genre Genre{ get; set; }
        public Place Place{ get; set; }
    }
}
