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
    class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual List<Picture> Pictures { get; set; }
    }
}
